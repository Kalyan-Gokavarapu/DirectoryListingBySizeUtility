using System.Windows.Forms;

namespace DirectoryListing
{
  partial class FolderExplorer
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.dgFolderContents = new System.Windows.Forms.DataGridView();
      this.btnPopulate = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtPath = new System.Windows.Forms.TextBox();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnMinimize = new System.Windows.Forms.Button();
      this.lblHeader = new System.Windows.Forms.Label();
      this.pnlHeader = new System.Windows.Forms.Panel();
      this.pbProgress = new System.Windows.Forms.ProgressBar();
      this.lblProgress = new System.Windows.Forms.Label();
      this.pbFileProgress = new System.Windows.Forms.ProgressBar();
      ((System.ComponentModel.ISupportInitialize)(this.dgFolderContents)).BeginInit();
      this.pnlHeader.SuspendLayout();
      this.SuspendLayout();
      // 
      // dgFolderContents
      // 
      this.dgFolderContents.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.dgFolderContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgFolderContents.Location = new System.Drawing.Point(13, 70);
      this.dgFolderContents.Name = "dgFolderContents";
      this.dgFolderContents.RowTemplate.Height = 24;
      this.dgFolderContents.Size = new System.Drawing.Size(759, 503);
      this.dgFolderContents.TabIndex = 0;
      this.dgFolderContents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFolderContents_CellContentClick);
      // 
      // btnPopulate
      // 
      this.btnPopulate.Enabled = false;
      this.btnPopulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPopulate.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.btnPopulate.Location = new System.Drawing.Point(698, 31);
      this.btnPopulate.Name = "btnPopulate";
      this.btnPopulate.Size = new System.Drawing.Size(74, 33);
      this.btnPopulate.TabIndex = 1;
      this.btnPopulate.Text = "Populate";
      this.btnPopulate.UseVisualStyleBackColor = true;
      this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.SystemColors.Control;
      this.label1.Location = new System.Drawing.Point(10, 39);
      this.label1.Name = "label1";
      this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.label1.Size = new System.Drawing.Size(71, 17);
      this.label1.TabIndex = 2;
      this.label1.Text = "Root Path";
      // 
      // txtPath
      // 
      this.txtPath.Location = new System.Drawing.Point(87, 36);
      this.txtPath.Name = "txtPath";
      this.txtPath.Size = new System.Drawing.Size(525, 22);
      this.txtPath.TabIndex = 3;
      this.txtPath.Click += new System.EventHandler(this.txtPath_Click);
      this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
      // 
      // folderBrowserDialog1
      // 
      this.folderBrowserDialog1.ShowNewFolderButton = false;
      // 
      // btnBrowse
      // 
      this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBrowse.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.btnBrowse.Location = new System.Drawing.Point(618, 31);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(74, 33);
      this.btnBrowse.TabIndex = 4;
      this.btnBrowse.Text = "Browse";
      this.btnBrowse.UseVisualStyleBackColor = true;
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Red;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnClose.Location = new System.Drawing.Point(753, 7);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(19, 17);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnMinimize
      // 
      this.btnMinimize.BackColor = System.Drawing.Color.Silver;
      this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMinimize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnMinimize.Location = new System.Drawing.Point(732, 7);
      this.btnMinimize.Name = "btnMinimize";
      this.btnMinimize.Size = new System.Drawing.Size(19, 17);
      this.btnMinimize.TabIndex = 6;
      this.btnMinimize.Text = "-";
      this.btnMinimize.UseVisualStyleBackColor = false;
      this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
      // 
      // lblHeader
      // 
      this.lblHeader.AutoSize = true;
      this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
      this.lblHeader.Location = new System.Drawing.Point(286, 9);
      this.lblHeader.Name = "lblHeader";
      this.lblHeader.Size = new System.Drawing.Size(194, 17);
      this.lblHeader.TabIndex = 7;
      this.lblHeader.Text = "Advanced Directory Inspector";
      this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
      this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerArea_MouseDown);
      this.lblHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerArea_MouseMove);
      this.lblHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerArea_MouseUp);
      // 
      // pnlHeader
      // 
      this.pnlHeader.Controls.Add(this.lblHeader);
      this.pnlHeader.Location = new System.Drawing.Point(0, 0);
      this.pnlHeader.Name = "pnlHeader";
      this.pnlHeader.Size = new System.Drawing.Size(785, 27);
      this.pnlHeader.TabIndex = 8;
      this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerArea_MouseDown);
      this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerArea_MouseMove);
      this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerArea_MouseUp);
      // 
      // pbProgress
      // 
      this.pbProgress.Location = new System.Drawing.Point(13, 575);
      this.pbProgress.Name = "pbProgress";
      this.pbProgress.Size = new System.Drawing.Size(756, 5);
      this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.pbProgress.TabIndex = 9;
      this.pbProgress.Visible = false;
      // 
      // lblProgress
      // 
      this.lblProgress.AutoSize = true;
      this.lblProgress.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.lblProgress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblProgress.Location = new System.Drawing.Point(15, 506);
      this.lblProgress.MaximumSize = new System.Drawing.Size(745, 0);
      this.lblProgress.Name = "lblProgress";
      this.lblProgress.Size = new System.Drawing.Size(65, 17);
      this.lblProgress.TabIndex = 10;
      this.lblProgress.Text = "Progress";
      this.lblProgress.Visible = false;
      this.lblProgress.Click += new System.EventHandler(this.lblProgress_Click);
      // 
      // pbFileProgress
      // 
      this.pbFileProgress.Location = new System.Drawing.Point(13, 583);
      this.pbFileProgress.Name = "pbFileProgress";
      this.pbFileProgress.Size = new System.Drawing.Size(756, 5);
      this.pbFileProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.pbFileProgress.TabIndex = 11;
      this.pbFileProgress.Visible = false;
      // 
      // FolderExplorer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
      this.ClientSize = new System.Drawing.Size(785, 592);
      this.Controls.Add(this.pbFileProgress);
      this.Controls.Add(this.lblProgress);
      this.Controls.Add(this.pbProgress);
      this.Controls.Add(this.btnMinimize);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnBrowse);
      this.Controls.Add(this.txtPath);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnPopulate);
      this.Controls.Add(this.dgFolderContents);
      this.Controls.Add(this.pnlHeader);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "FolderExplorer";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FolderExplorer";
      ((System.ComponentModel.ISupportInitialize)(this.dgFolderContents)).EndInit();
      this.pnlHeader.ResumeLayout(false);
      this.pnlHeader.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgFolderContents;
    private System.Windows.Forms.Button btnPopulate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtPath;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.Button btnClose;
    private Button btnMinimize;
    private Label lblHeader;
    private Panel pnlHeader;
    private ProgressBar pbProgress;
    private Label lblProgress;
    private ProgressBar pbFileProgress;
  }
}

