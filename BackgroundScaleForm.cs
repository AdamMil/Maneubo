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
using System.Windows.Forms;

namespace Maneubo
{
  partial class BackgroundScaleForm : DataForm
  {
    public BackgroundScaleForm()
    {
      InitializeComponent();
    }

    public BackgroundScaleForm(double pixels, double meters, UnitSystem unitSystem) : this()
    {
      lblPixels.Text = pixels.ToString("0.##") + " pixels represents...";
      txtLength.Text = ManeuveringBoard.GetDistanceString(meters, unitSystem);
      txtLength.Tag  = meters;
      txtLength.WasChanged = false;
      this.unitSystem = unitSystem;
    }

    public double Distance
    {
      get
      {
        double distance;
        if(txtLength.WasChanged) TryParseLength(txtLength.Text, unitSystem, out distance);
        else distance = (double)txtLength.Tag;
        return distance;
      }
    }

    void btnOK_Click(object sender, System.EventArgs e)
    {
      double length;
      if(txtLength.WasChanged)
      {
        if(TryParseLength(txtLength.Text, unitSystem, out length))
        {
          txtLength.Tag = length;
        }
        else
        {
          if(string.IsNullOrEmpty(txtLength.Text.Trim())) ShowRequiredMessage("Distance");
          else ShowInvalidLength(txtLength.Text);
          return;
        }
      }

      DialogResult = DialogResult.OK;
    }

    readonly UnitSystem unitSystem;
  }
}
