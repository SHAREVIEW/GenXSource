namespace Genetibase.UI.NuGenImageWorks
{
    partial class ImageViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.mainRibbonGroup = new Genetibase.UI.NuGenImageWorks.RibbonGroup();
            this.transPanel1 = new System.Windows.Forms.Panel();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonDOWN = new Genetibase.UI.NuGenImageWorks.RibbonButton();
            this.btnLeft = new Genetibase.UI.NuGenImageWorks.RibbonButton();
            this.btnRight = new Genetibase.UI.NuGenImageWorks.RibbonButton();
            this.picBoxClone = new Genetibase.UI.NuGenImageWorks.RibbonItem();
            this.hiddenRibbenGroup = new Genetibase.UI.NuGenImageWorks.RibbonGroup();
            this.buttonUP = new Genetibase.UI.NuGenImageWorks.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.mainRibbonGroup.SuspendLayout();
            this.transPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClone)).BeginInit();
            this.hiddenRibbenGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // mainRibbonGroup
            // 
            this.mainRibbonGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.mainRibbonGroup.BackgroundImage = global::Genetibase.UI.NuGenImageWorks.Properties.Resources.bg;
            this.mainRibbonGroup.Controls.Add(this.transPanel1);
            this.mainRibbonGroup.Controls.Add(this.buttonDOWN);
            this.mainRibbonGroup.Controls.Add(this.btnLeft);
            this.mainRibbonGroup.Controls.Add(this.btnRight);
            this.mainRibbonGroup.Controls.Add(this.picBoxClone);
            this.mainRibbonGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainRibbonGroup.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonGroup.Margin = new System.Windows.Forms.Padding(1);
            this.mainRibbonGroup.Name = "mainRibbonGroup";
            this.mainRibbonGroup.Size = new System.Drawing.Size(802, 76);
            this.mainRibbonGroup.TabIndex = 12;
            this.mainRibbonGroup.TabStop = false;
            this.mainRibbonGroup.SizeChanged += new System.EventHandler(this.mainRibbonGroup_SizeChanged);
            // 
            // transPanel1
            // 
            this.transPanel1.BackColor = System.Drawing.Color.Transparent;
            this.transPanel1.Controls.Add(this.lblProgress);
            this.transPanel1.Controls.Add(this.progressBar1);
            this.transPanel1.Location = new System.Drawing.Point(276, 8);
            this.transPanel1.Name = "transPanel1";
            this.transPanel1.Size = new System.Drawing.Size(246, 42);
            this.transPanel1.TabIndex = 8;
            this.transPanel1.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Location = new System.Drawing.Point(50, 2);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(147, 13);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "Creating/Updating thumbnails";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.DarkOrange;
            this.progressBar1.Location = new System.Drawing.Point(3, 16);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(237, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 50;
            // 
            // buttonDOWN
            // 
            this.buttonDOWN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDOWN.BackColor = System.Drawing.Color.Transparent;
            this.buttonDOWN.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDOWN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDOWN.IsFlat = true;
            this.buttonDOWN.IsPressed = false;
            this.buttonDOWN.Location = new System.Drawing.Point(388, 59);
            this.buttonDOWN.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDOWN.Name = "buttonDOWN";
            this.buttonDOWN.Padding = new System.Windows.Forms.Padding(2);
            this.buttonDOWN.Size = new System.Drawing.Size(29, 16);
            this.buttonDOWN.TabIndex = 6;
            this.buttonDOWN.Text = "▲";
            this.buttonDOWN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDOWN.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLeft.IsFlat = true;
            this.btnLeft.IsPressed = false;
            this.btnLeft.Location = new System.Drawing.Point(1, 17);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(1);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Padding = new System.Windows.Forms.Padding(2);
            this.btnLeft.Size = new System.Drawing.Size(17, 25);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "«";
            this.btnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRight.IsFlat = true;
            this.btnRight.IsPressed = false;
            this.btnRight.Location = new System.Drawing.Point(784, 17);
            this.btnRight.Margin = new System.Windows.Forms.Padding(1);
            this.btnRight.Name = "btnRight";
            this.btnRight.Padding = new System.Windows.Forms.Padding(2);
            this.btnRight.Size = new System.Drawing.Size(16, 25);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "»";
            this.btnRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // picBoxClone
            // 
            this.picBoxClone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.picBoxClone.IsPressed = false;
            this.picBoxClone.Location = new System.Drawing.Point(40, 4);
            this.picBoxClone.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxClone.Name = "picBoxClone";
            this.picBoxClone.Size = new System.Drawing.Size(50, 50);
            this.picBoxClone.TabIndex = 0;
            this.picBoxClone.TabStop = false;
            // 
            // hiddenRibbenGroup
            // 
            this.hiddenRibbenGroup.Controls.Add(this.buttonUP);
            this.hiddenRibbenGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hiddenRibbenGroup.Location = new System.Drawing.Point(0, 0);
            this.hiddenRibbenGroup.Margin = new System.Windows.Forms.Padding(0);
            this.hiddenRibbenGroup.Name = "hiddenRibbenGroup";
            this.hiddenRibbenGroup.Padding = new System.Windows.Forms.Padding(0);
            this.hiddenRibbenGroup.Size = new System.Drawing.Size(802, 76);
            this.hiddenRibbenGroup.TabIndex = 8;
            this.hiddenRibbenGroup.TabStop = false;
            this.hiddenRibbenGroup.SizeChanged += new System.EventHandler(this.hiddenRibbenGroup_SizeChanged);
            // 
            // buttonUP
            // 
            this.buttonUP.BackColor = System.Drawing.Color.Transparent;
            this.buttonUP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUP.IsFlat = true;
            this.buttonUP.IsPressed = false;
            this.buttonUP.Location = new System.Drawing.Point(147, -1);
            this.buttonUP.Margin = new System.Windows.Forms.Padding(1);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Padding = new System.Windows.Forms.Padding(2);
            this.buttonUP.Size = new System.Drawing.Size(29, 16);
            this.buttonUP.TabIndex = 7;
            this.buttonUP.Text = "▼";
            this.buttonUP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUP.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.mainRibbonGroup);
            this.Controls.Add(this.hiddenRibbenGroup);
            this.Name = "ImageViewer";
            this.Size = new System.Drawing.Size(802, 76);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImageViewer_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.mainRibbonGroup.ResumeLayout(false);
            this.transPanel1.ResumeLayout(false);
            this.transPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClone)).EndInit();
            this.hiddenRibbenGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RibbonButton btnLeft;
        private RibbonButton buttonDOWN;
        private RibbonItem picBoxClone;
        private RibbonButton btnRight;
        private RibbonGroup mainRibbonGroup;
        private RibbonGroup hiddenRibbenGroup;
        private RibbonButton buttonUP;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel transPanel1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;


    }
}
