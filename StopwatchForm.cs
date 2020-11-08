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
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace Maneubo
{
  public partial class StopwatchForm : Form
  {
    public StopwatchForm()
    {
      InitializeComponent();
    }

    public void SaveTime()
    {
      lstTimes.Items.Add(GetTimeLabel(currentClock));
      btnClear.Enabled = true;
    }

    public void Toggle()
    {
      timer.Enabled     = !timer.Enabled;
      btnStartStop.Text = timer.Enabled ? "&Stop" : "&Start";
      if(timer.Enabled)
      {
        currentClock.Start();
        if(!totalClock.IsRunning) totalClock.Start();
      }
      else
      {
        currentClock.Stop();
      }
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
      base.OnKeyDown(e);
      if(e.KeyCode == Keys.Escape && !e.Handled) Hide();
    }

    void btnClear_Click(object sender, System.EventArgs e)
    {
      lstTimes.Items.Clear();
      btnClear.Enabled = btnCopy.Enabled = false;
    }

    void btnCopy_Click(object sender, System.EventArgs e)
    {
      if(lstTimes.SelectedIndex != -1)
      {
        for(int i=0; i<2; i++)
        {
          try
          {
            Clipboard.SetText((string)lstTimes.SelectedItem);
            break;
          }
          catch
          {
            System.Threading.Thread.Sleep(10);
          }
        }
      }
    }

    void btnSave_Click(object sender, System.EventArgs e)
    {
      SaveTime();
    }

    void btnStartStop_Click(object sender, System.EventArgs e)
    {
      Toggle();
    }

    void btnReset_Click(object sender, System.EventArgs e)
    {
      currentClock.Reset();
      totalClock.Reset();
      lblCurrent.Text = lblTotal.Text = "0:00:00";
      if(timer.Enabled)
      {
        currentClock.Start();
        totalClock.Start();
      }
    }

    void lstTimes_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      btnCopy_Click(null, null);
    }

    void lstTimes_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      btnCopy.Enabled = lstTimes.SelectedIndex != -1;
    }

    void timer_Tick(object sender, System.EventArgs e)
    {
      lblCurrent.Text = GetTimeLabel(currentClock);
      lblTotal.Text   = GetTimeLabel(totalClock);
    }

    readonly Stopwatch currentClock = new Stopwatch(), totalClock = new Stopwatch();

    static string GetTimeLabel(Stopwatch stopwatch)
    {
      uint seconds = (uint)((stopwatch.ElapsedMilliseconds + 500) / 1000), minutes = seconds/60;
      return (minutes/60).ToString(CultureInfo.InvariantCulture) + ":" + (minutes%60).ToString("d2", CultureInfo.InvariantCulture) + ":" +
             (seconds%60).ToString("d2", CultureInfo.InvariantCulture);
    }
  }
}
