/*
 *  UpdateChecker
 *  A simple update checker, written in Visual C#
 *  Copyright (C) 2021  0J3.
 *  
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *  
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *  
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 *  
 */

// The UI requires Bunifu UI and Siticone, which can both be found in any release zip.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace TestAutoUpdater
{
  public partial class Updater : Form
  {

    const string BaseUrl = "https://raw.githubusercontent.com";
    const string Username = "0J3";
    const string Repo = "UpdateChecker";
    const string Branch = "main";
    const string VersionFileName = "Version.txt";

    const string UpdateDownload = "https://github.com/0J3/UpdateChecker/releases/latest/download/Release.zip";

    string ThisVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

    public Updater()
    {
      InitializeComponent();

      string url = $"{BaseUrl}/{Username}/{Repo}/{Branch}/{VersionFileName}?raw=true";

      WebClient updateCheck = new WebClient();
      string vers = updateCheck.DownloadString(url);
      if (!vers.Contains(ThisVersion))
      {
        Title.Text = "Version Mismatch";
        Description.Text = $"Version {ThisVersion} does not match ${vers}".Replace("$", "");

        UpdateBtn.Visible = true;
        Close.Visible = true;
      }
      else
      {
        // Specify custom code here
        // Remember, this code is licensed under the GPL, meaning you will need to attribute 0J3, and additionally state all modifications.
        // See the "LICENSE" file or https://www.gnu.org/licenses/gpl-3.0.html for more information, aswell as the whole license.
        Title.Text = "Version Matches";
        Description.Text = $"No custom code has been specified.\n Please click \"Close\".";
        CloseAlt.Visible = true;
      }
    }

    private void Close_Click(object sender, EventArgs e) // Close button Click
    {
      Application.ExitThread(); // Exit the Thread
    }

    private void SiticoneButton1_Click_1(object sender, EventArgs e) // Alternative Close Button Click
    {
      Application.ExitThread(); // Exit the Thread
    }

    private void SiticoneButton1_Click(object sender, EventArgs e) // Update Btn click
    {
      System.Diagnostics.Process.Start(UpdateDownload);
      Application.ExitThread(); // Exit the Thread
    }
  }
}