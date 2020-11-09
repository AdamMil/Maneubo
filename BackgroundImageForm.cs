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
using System.IO;
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

    void btnBrowse_Click(object sender, System.EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
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
          if(Image == null) throw new Exception("Unable to read image from clipboard.");
        }
        catch(Exception ex)
        {
          MessageBox.Show("An error occurred while reading data from the clipboard. (" + ex.GetType().Name + " - " + ex.Message +
            ") Try copying the data into the clipboard again.", "Error reading clipboard", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
          MessageBox.Show("An error occurred while reading " + file + ". (" + ex.GetType().Name + " - " + ex.Message + ")",
            "Error reading file", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
      }

      DialogResult = DialogResult.OK;
    }
  }
}
