using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryListing
{
  partial class DirectoryInspector
  {
    private string rootPath;
    ProgressBar pbProgress;
    ProgressBar pbFileProgress;
    Label lblProgress;

    StringBuilder skipList;

    public DirectoryInspector(string rootPath, ProgressBar pbProgress, ProgressBar pbFileProgress, Label lblProgress)
    {
      this.rootPath = rootPath;
      this.lblProgress = lblProgress;
      this.pbProgress = pbProgress;
      this.pbFileProgress = pbFileProgress;
    }
    internal DataTable InspectDirecory()
    {
      this.lblProgress.Visible = true;
      DataTable dtDirectoryMap = new DataTable();

      dtDirectoryMap.Columns.Add("No", typeof(string));
      dtDirectoryMap.Columns.Add("Folder", typeof(string));
      dtDirectoryMap.Columns.Add("Space", typeof(string));

      DirectoryInfo oRootDirectory = new DirectoryInfo(rootPath);

      var directoryList = oRootDirectory.GetDirectories();
      skipList = new StringBuilder();
      for (var iCount=0; iCount<directoryList.Length; iCount++ )
      {
        pbProgress.Value = iCount + 1;
        pbProgress.Update();
        var dr = directoryList[iCount];
        pbProgress.Maximum = directoryList.Length;
        pbProgress.Step = 1;
        this.lblProgress.Text = "Processing: " + dr.Name;
        this.lblProgress.Update();
        //if (!(dr.Attributes.HasFlag(FileAttributes.Hidden) || dr.Attributes.HasFlag(FileAttributes.Archive)))
        //{
          try
          {
            dtDirectoryMap.Rows.Add((iCount + 1).ToString(),
            dr.Name,
            FormatBytes(
              ComputeFolderSpace(Delimon.Win32.IO.Directory.GetFiles(
                dr.FullName, "*.*", Delimon.Win32.IO.SearchOption.AllDirectories))));
          }
          catch (Exception ex)
          {
            this.lblProgress.Text = "Skipped: " + dr.Name;
            this.lblProgress.Update();
            skipList.Append(dr.Name + " : " + ex.Message + Environment.NewLine);
          }
          
        //}
        //else
        //{
        //  this.lblProgress.Text = "Skipped: " + dr.Name;
        //  this.lblProgress.Update();
        //  skipList.Append(dr.Name + Environment.NewLine);
        //}        
      }
      if (skipList.Length > 0)
      {
        MessageBox.Show(skipList.ToString());
      }
      
      return dtDirectoryMap;
    }

    private long ComputeFolderSpace(string[] files)
    {
      pbFileProgress.Maximum = files.Length;
      pbFileProgress.Step = 1;
      long lngSpace = 0;
      Delimon.Win32.IO.FileInfo oFileInfo;
      int i = 1;
      foreach (var file in files) {
        this.lblProgress.Text = "Calculation file size: " + file;
        this.lblProgress.Update();
        oFileInfo = new Delimon.Win32.IO.FileInfo(file);
        lngSpace += oFileInfo.Length;
        pbFileProgress.Value = i++;
        pbFileProgress.Update();
      }
      return lngSpace;
    }

    private string FormatBytes(long bytes)
    {
      string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
      int i;
      double dblSByte = bytes;
      for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
      {
        dblSByte = bytes / 1024.0;
      }

      return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
    }

    private void UpdateStatus()
    {

    }
  }
}
