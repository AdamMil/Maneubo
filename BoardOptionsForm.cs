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
using System.Drawing;

namespace Maneubo
{
  partial class BoardOptionsForm : Form
  {
    public BoardOptionsForm()
    {
      InitializeComponent();
    }

    public BoardOptionsForm(ManeuveringBoard board) : this()
    {
      chkShowAllObservations.Checked = board.ShowAllObservations;
      cmbUnitSystem.SelectedIndex = (int)board.UnitSystem;
      btnBackground.BackColor   = board.BackColor;
      btnObservations.BackColor = board.ObservationColor;
      btnReference.BackColor    = board.ReferenceColor;
      btnScale1.BackColor       = board.ScaleColor1;
      btnScale2.BackColor       = board.ScaleColor2;
      btnSelected.BackColor     = board.SelectedColor;
      btnTMA.BackColor          = board.TMAColor;
      btnUnselected.BackColor   = board.UnselectedColor;
    }

    public Color BoardBackgroundColor
    {
      get { return btnBackground.BackColor; }
    }

    public Color ObservationColor
    {
      get { return btnObservations.BackColor; }
    }

    public Color ReferenceColor
    {
      get { return btnReference.BackColor; }
    }

    public Color ScaleColor1
    {
      get { return btnScale1.BackColor; }
    }

    public Color ScaleColor2
    {
      get { return btnScale2.BackColor; }
    }

    public Color SelectedColor
    {
      get { return btnSelected.BackColor; }
    }

    public Color TMAColor
    {
      get { return btnTMA.BackColor; }
    }

    public Color UnselectedColor
    {
      get { return btnUnselected.BackColor; }
    }

    public bool ShowAllObservations
    {
      get { return chkShowAllObservations.Checked; }
    }

    public UnitSystem UnitSystem
    {
      get { return (UnitSystem)cmbUnitSystem.SelectedIndex; }
    }

    void btnColor_Click(object sender, System.EventArgs e)
    {
      Button button = (Button)sender;
      colorDialog.Color = button.BackColor;
      if(colorDialog.ShowDialog() == DialogResult.OK) button.BackColor = colorDialog.Color;
    }
  }
}
