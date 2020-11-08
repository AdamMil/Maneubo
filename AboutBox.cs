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
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;

namespace Maneubo
{
  partial class AboutBox : Form
  {
    public AboutBox()
    {
      InitializeComponent();
      this.Text = String.Format("About {0}", AssemblyTitle);
      this.labelProductName.Text = AssemblyTitle + ", version " + AssemblyVersion;
      this.labelCopyright.Text = AssemblyCopyright;
    }

    #region Assembly Attribute Accessors
    string AssemblyCopyright
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
        return attributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
      }
    }

    string AssemblyTitle
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
        if(attributes.Length != 0)
        {
          AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
          if(!string.IsNullOrEmpty(titleAttribute.Title)) return titleAttribute.Title;
        }
        return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
      }
    }

    string AssemblyVersion
    {
      get
      {
        Version version = Assembly.GetExecutingAssembly().GetName().Version;
        return string.Format(CultureInfo.InvariantCulture, "{0}.{1}", version.Major, version.Minor);
      }
    }
    #endregion

    void lblUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(lblUrl.Text);
    }
  }
}
