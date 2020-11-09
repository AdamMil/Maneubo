/*
Maneubo is an application that provides a virtual maneuvering board and target
motion analysis.

http://www.adammil.net/Maneubo
Copyright (C) 2011-2020 Adam Milazzo

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.
This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
*/
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Maneubo
{
  public partial class BackgroundImageForm : Form
  {
    public BackgroundImageForm()
    {
      InitializeComponent();

      if(Clipboard.ContainsImage()) radClipboard.Checked = true;
      else radFile.Checked = true;
    }

    public Image Image { get; private set; }

    #region BITMAPV5HEADER
    [StructLayout(LayoutKind.Sequential)]
    struct BITMAPV5HEADER
    {
      public uint Size;
      public int Width, Height;
      public ushort Planes, BitCount;
      public int Compression, SizeImage, XPelsPerMeter, YPelsPerMeter;
      public ushort ClrUsed;
    }
    #endregion

    void btnBrowse_Click(object sender, System.EventArgs e)
    {
      var ofd = new OpenFileDialog();
      ofd.FileName = txtFile.Text;
      ofd.Filter   = "Image Files (*.bmp; *.gif; *.jpg; *.jpeg; *.png; *.tif; *.tiff)|*.bmp; *.gif; *.jpg; *.jpeg; *.png; *.tif; *.tiff|"+
                     "All Files (*.*)|*.*";
      ofd.Title    = "Select an image file to load.";
      if(!string.IsNullOrEmpty(txtFile.Text.Trim()))
      {
        try
        {
          string directory = Path.GetDirectoryName(txtFile.Text.Trim());
          if(Directory.Exists(directory)) ofd.InitialDirectory = directory;
        }
        catch { }
      }

      if(ofd.ShowDialog() == DialogResult.OK)
      {
        txtFile.Text = ofd.FileName;
        radFile.Checked = true;
      }
    }

    void btnOK_Click(object sender, System.EventArgs e)
    {
      if(radClipboard.Checked)
      {
        try
        {
          if(!Clipboard.ContainsImage())
          {
            MessageBox.Show("The clipboard does not contain a usable image.", "No clipboard image", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            return;
          }

          Image = Clipboard.GetImage();
          if(Image == null)
          {
            if(Clipboard.GetData("PNG") is Stream stream)
            {
              Image = Image.FromStream(stream);
            }
            else if((stream = Clipboard.GetData("Format17") as Stream ?? Clipboard.GetData("DeviceIndependentBitmap") as Stream) != null)
            {
              var ms = stream as MemoryStream;
              if(ms == null)
              {
                ms = new MemoryStream(stream.CanSeek ? (int)stream.Length : 64*1024);
                var buffer = new byte[4096];
                while(true)
                {
                  int read = stream.Read(buffer, 0, buffer.Length);
                  if(read == 0) break;
                  ms.Write(buffer, 0, buffer.Length);
                }
              }
              Image = DIBToBitmap(ms.ToArray());
            }
            else
            {
              throw new Exception("Possible unsupported image format.");
            }
          }
        }
        catch(Exception ex)
        {
          MessageBox.Show("An error occurred while reading the image. (" + ex.Message +
            ") Try copying the data into the clipboard again, or paste the image into a paint program and copy it back out.",
            "Error reading clipboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
      }
      else
      {
        string file = txtFile.Text.Trim();
        if(string.IsNullOrEmpty(file))
        {
          MessageBox.Show("You must select a file.", "No file selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
        if(!File.Exists(file))
        {
          MessageBox.Show(file + " does not exist or cannot be accessed.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        try
        {
          Image = Image.FromFile(file);
        }
        catch(Exception ex)
        {
          MessageBox.Show("An error occurred while reading " + file + ". (" + ex.Message + ")", "Error reading file",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
      }

      DialogResult = DialogResult.OK;
    }

    static Bitmap DIBToBitmap(byte[] data)
    {
      var handle = GCHandle.Alloc(data, GCHandleType.Pinned);
      try
      {
        var bmi = (BITMAPV5HEADER)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(BITMAPV5HEADER));

        if(bmi.Size < 40 || bmi.Planes != 1 || bmi.Compression != 0 && bmi.Compression != 3)
        {
          throw new NotSupportedException("Unsupported DIB format.");
        }

        PixelFormat format;
        switch(bmi.BitCount)
        {
          case 16: format = PixelFormat.Format16bppRgb555; break;
          case 24: format = PixelFormat.Format24bppRgb; break;
          case 32: format = PixelFormat.Format32bppRgb; break;
          default:  throw new NotSupportedException("Unsupported bit depth: " + bmi.BitCount.ToString());
        };

        int stride = bmi.SizeImage == 0 ? bmi.BitCount/8*bmi.Width : bmi.SizeImage/bmi.Height;
        var bitmap = new Bitmap(bmi.Width, bmi.Height, -stride, format,
          new IntPtr(handle.AddrOfPinnedObject().ToInt64() + (bmi.Size + (bmi.Height-1)*stride)));
        return bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format24bppRgb);
      }
      finally
      {
        handle.Free();
      }
    }
  }
}
