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
using System.ComponentModel;
using System.Windows.Forms;

namespace Maneubo
{

class ChangeTrackingTextBox : TextBox
{
  [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public bool WasChanged { get; set; }

  protected override void OnTextChanged(EventArgs e)
  {
    WasChanged = true;
    base.OnTextChanged(e);
  }
}

}