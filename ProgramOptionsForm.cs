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
using System;

namespace Maneubo
{
  public partial class ProgramOptionsForm : Form
  {
    public ProgramOptionsForm()
    {
      InitializeComponent();
    }

    public int SaveTimeHotkey
    {
      get { return GetHotkey(chkSaveTime, chkTSAlt, chkTSCtrl, chkTSShift, txtTSChar); }
      set { SetHotkey(value, chkSaveTime, chkTSAlt, chkTSCtrl, chkTSShift, txtTSChar); }
    }

    public int ToggleStopwatchHotkey
    {
      get { return GetHotkey(chkToggleStopwatch, chkSTAlt, chkSTCtrl, chkSTShift, txtSTChar); }
      set { SetHotkey(value, chkToggleStopwatch, chkSTAlt, chkSTCtrl, chkSTShift, txtSTChar); }
    }

    const int HkAlt=1, HkCtrl=2, HkShift=4, HkNoRepeat=0x4000; // global hotkey flags

    void btnOK_Click(object sender, EventArgs e)
    {
      if((!chkSaveTime.Checked || ValidateHotkey(chkSaveTime.Text, txtTSChar)) &&
         (!chkToggleStopwatch.Checked || ValidateHotkey(chkToggleStopwatch.Text, txtSTChar)))
      {
        DialogResult = DialogResult.OK;
      }
    }

    static int GetHotkey(CheckBox chkEnable, CheckBox alt, CheckBox ctrl, CheckBox shift, TextBox txtChar)
    {
      if(!chkEnable.Checked) return 0;
      string text = txtChar.Text.Trim();
      if(text.Length != 1) throw new InvalidOperationException();
      return (((alt.Checked ? HkAlt : 0) | (ctrl.Checked ? HkCtrl : 0) | (shift.Checked ? HkShift : 0)) << 16) |
             char.ToUpperInvariant(text[0]);
    }

    static void SetHotkey(int value, CheckBox chkEnable, CheckBox alt, CheckBox ctrl, CheckBox shift, TextBox txtChar)
    {
      if(value == 0)
      {
        chkEnable.Checked = false;
        alt.Checked = ctrl.Checked = shift.Checked = false;
        txtChar.Clear();
      }
      else
      {
        int flags = value >> 16;
        chkEnable.Checked = true;
        alt.Checked   = (flags & HkAlt)   != 0;
        ctrl.Checked  = (flags & HkCtrl)  != 0;
        shift.Checked = (flags & HkShift) != 0;
        txtChar.Text  = new string((char)value, 1);
      }
    }

    static bool ValidateHotkey(string hotkeyName, TextBox txtChar)
    {
      string text = txtChar.Text.Trim();
      char hotkey = text.Length == 1 ? char.ToUpperInvariant(text[0]) : '\0';
      if(hotkey < 'A' || hotkey > 'Z')
      {
        MessageBox.Show(hotkeyName + ": You must specify a single English letter as the hotkey or uncheck the box at the left to " +
                        "disable it.", "Invalid hotkey", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtChar.Focus();
        return false;
      }

      return true;
    }
  }
}
