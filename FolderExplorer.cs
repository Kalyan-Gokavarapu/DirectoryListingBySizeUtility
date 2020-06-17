using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryListing
{
  public partial class FolderExplorer : Form
  {
    bool flgMove = false;
    int intPositionX = 0;
    int intPositionY = 0;
    public FolderExplorer()
    {
      InitializeComponent();
      
    }

    //private void FolderExplorer_Load(object sender, EventArgs e)
    //{
    //  this.Location = Screen.AllScreens[1].WorkingArea.Location;
    //}

    private void btnPopulate_Click(object sender, EventArgs e)
    {
      dgFolderContents.DataSource = null;
      DirectoryInspector oDirectoryInspector = new DirectoryInspector(txtPath.Text,
        pbProgress,pbFileProgress,lblProgress);
      this.lblProgress.Visible = true;
      this.pbProgress.Visible = true;
      this.pbFileProgress.Visible = true;
      DataTable dtDirectory = oDirectoryInspector.InspectDirecory();
      this.lblProgress.Visible = false;
      this.pbProgress.Visible = false;
      this.pbFileProgress.Visible = false;
      dgFolderContents.DataSource = dtDirectory;
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
      showDirectoryExplorer();
    }

    private void btnMinimize_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void txtPath_TextChanged(object sender, EventArgs e)
    {
      DirectoryInfo rootDirectory = new DirectoryInfo(txtPath.Text);
      if (rootDirectory.Exists)
      {
        btnPopulate.Enabled = true;
      }
      else
      {
        btnPopulate.Enabled = false;
      }

    }

    private void txtPath_Click(object sender, EventArgs e)
    {
      showDirectoryExplorer();
    }

    private void showDirectoryExplorer()
    {
      folderBrowserDialog1.Description = "Please select a root folder";
      DialogResult result = this.folderBrowserDialog1.ShowDialog();
      if (result == DialogResult.OK)
      {
        txtPath.Text = this.folderBrowserDialog1.SelectedPath;
        dgFolderContents.DataSource = null;
      }
    }

    private void dgFolderContents_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void headerArea_MouseDown(object sender, MouseEventArgs e)
    {
      flgMove = true;     

      if(sender.GetType().Name == "Panel")
      {
        intPositionX = e.X;
        intPositionY = e.Y;
      }
      else if (sender.GetType().Name == "Label")
      {
        intPositionX = e.X + 286;
        intPositionY = e.Y + 10;
      }
      
    }

    private void headerArea_MouseMove(object sender, MouseEventArgs e)
    {
      if (flgMove)
      {       
        this.SetDesktopLocation(MousePosition.X - intPositionX, MousePosition.Y - intPositionY);
      }
      
    }

    private void headerArea_MouseUp(object sender, MouseEventArgs e)
    {
      flgMove = false;
    }

    private void lblProgress_Click(object sender, EventArgs e)
    {

    }

    private void lblHeader_Click(object sender, EventArgs e)
    {

    }
  }
}
