namespace FAMOS.HELPER.SECS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleBar = new Telerik.WinControls.UI.RadTitleBar();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.StatusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.StripText = new Telerik.WinControls.UI.RadLabelElement();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.BtnAnal = new Telerik.WinControls.UI.RadButton();
            this.BtnFileSelect = new Telerik.WinControls.UI.RadButton();
            this.FileLocationPath = new Telerik.WinControls.UI.RadTextBox();
            this.FileLocationLabel = new Telerik.WinControls.UI.RadLabel();
            this.OfficeTheme = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.logInfo1 = new FAMOS.HELPER.SECS.LogInfo();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBar)).BeginInit();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAnal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFileSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileLocationPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileLocationLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.Controls.Add(this.radButton1);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(600, 33);
            this.TitleBar.TabIndex = 5;
            this.TitleBar.TabStop = false;
            this.TitleBar.Text = "SECS/GEM 로그 분석";
            this.TitleBar.ThemeName = "Office2013Light";
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton1.Location = new System.Drawing.Point(431, 9);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(73, 21);
            this.radButton1.TabIndex = 10;
            this.radButton1.Text = "확인";
            this.radButton1.ThemeName = "Office2013Light";
            this.radButton1.Visible = false;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.StripText});
            this.StatusStrip.Location = new System.Drawing.Point(0, 576);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(600, 27);
            this.StatusStrip.TabIndex = 6;
            this.StatusStrip.ThemeName = "Office2013Light";
            // 
            // StripText
            // 
            this.StripText.Name = "StripText";
            this.StatusStrip.SetSpring(this.StripText, false);
            this.StripText.Text = "";
            this.StripText.TextWrap = true;
            // 
            // radPanel1
            // 
            this.radPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanel1.Controls.Add(this.BtnAnal);
            this.radPanel1.Controls.Add(this.BtnFileSelect);
            this.radPanel1.Controls.Add(this.FileLocationPath);
            this.radPanel1.Controls.Add(this.FileLocationLabel);
            this.radPanel1.Location = new System.Drawing.Point(12, 39);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(576, 34);
            this.radPanel1.TabIndex = 7;
            this.radPanel1.ThemeName = "Office2013Light";
            // 
            // BtnAnal
            // 
            this.BtnAnal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAnal.Location = new System.Drawing.Point(497, 7);
            this.BtnAnal.Name = "BtnAnal";
            this.BtnAnal.Size = new System.Drawing.Size(73, 21);
            this.BtnAnal.TabIndex = 9;
            this.BtnAnal.Text = "확인";
            this.BtnAnal.ThemeName = "Office2013Light";
            this.BtnAnal.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // BtnFileSelect
            // 
            this.BtnFileSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFileSelect.Location = new System.Drawing.Point(419, 7);
            this.BtnFileSelect.Name = "BtnFileSelect";
            this.BtnFileSelect.Size = new System.Drawing.Size(73, 21);
            this.BtnFileSelect.TabIndex = 8;
            this.BtnFileSelect.Text = "선택";
            this.BtnFileSelect.ThemeName = "Office2013Light";
            this.BtnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // FileLocationPath
            // 
            this.FileLocationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileLocationPath.Enabled = false;
            this.FileLocationPath.Location = new System.Drawing.Point(68, 7);
            this.FileLocationPath.Name = "FileLocationPath";
            this.FileLocationPath.Size = new System.Drawing.Size(345, 21);
            this.FileLocationPath.TabIndex = 8;
            this.FileLocationPath.ThemeName = "Office2013Light";
            // 
            // FileLocationLabel
            // 
            this.FileLocationLabel.Location = new System.Drawing.Point(10, 7);
            this.FileLocationLabel.Margin = new System.Windows.Forms.Padding(10);
            this.FileLocationLabel.Name = "FileLocationLabel";
            this.FileLocationLabel.Size = new System.Drawing.Size(56, 19);
            this.FileLocationLabel.TabIndex = 8;
            this.FileLocationLabel.Text = "파일위치";
            this.FileLocationLabel.ThemeName = "Office2013Light";
            // 
            // ofd
            // 
            this.ofd.Filter = ".log|*.log";
            // 
            // logInfo1
            // 
            this.logInfo1._Result = ((System.Collections.Generic.List<FAMOS.HELPER.SECS.Log>)(resources.GetObject("logInfo1._Result")));
            this.logInfo1.Location = new System.Drawing.Point(41, 105);
            this.logInfo1.Name = "logInfo1";
            this.logInfo1.Size = new System.Drawing.Size(204, 120);
            this.logInfo1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 603);
            this.ControlBox = false;
            this.Controls.Add(this.logInfo1);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SECS/GEM 로그 분석";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TitleBar)).EndInit();
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAnal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFileSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileLocationPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileLocationLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadTitleBar TitleBar;
        private Telerik.WinControls.UI.RadStatusStrip StatusStrip;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel FileLocationLabel;
        private Telerik.WinControls.UI.RadTextBox FileLocationPath;
        private Telerik.WinControls.UI.RadButton BtnAnal;
        private Telerik.WinControls.UI.RadButton BtnFileSelect;
        private Telerik.WinControls.Themes.Office2013LightTheme OfficeTheme;
        private System.Windows.Forms.OpenFileDialog ofd;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadLabelElement StripText;
        private LogInfo logInfo1;
    }
}
