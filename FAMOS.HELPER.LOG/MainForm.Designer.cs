namespace FAMOS.HELPER.LOG
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
            this.FileLocationPath = new Telerik.WinControls.UI.RadTextBox();
            this.btnFileSelect = new Telerik.WinControls.UI.RadButton();
            this.btnOk = new Telerik.WinControls.UI.RadButton();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.StatusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.StatusStripText = new Telerik.WinControls.UI.RadLabelElement();
            this.TelerikTheme = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.logView = new FAMOS.HELPER.LOG.LogView();
            ((System.ComponentModel.ISupportInitialize)(this.FileLocationPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // FileLocationPath
            // 
            this.FileLocationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileLocationPath.Enabled = false;
            this.FileLocationPath.Location = new System.Drawing.Point(12, 12);
            this.FileLocationPath.Name = "FileLocationPath";
            this.FileLocationPath.Size = new System.Drawing.Size(335, 24);
            this.FileLocationPath.TabIndex = 0;
            this.FileLocationPath.ThemeName = "TelerikMetroBlue";
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileSelect.Location = new System.Drawing.Point(352, 12);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(70, 24);
            this.btnFileSelect.TabIndex = 1;
            this.btnFileSelect.Text = "파일선택";
            this.btnFileSelect.ThemeName = "TelerikMetroBlue";
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(426, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 24);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "확인";
            this.btnOk.ThemeName = "TelerikMetroBlue";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.StatusStripText});
            this.StatusStrip.Location = new System.Drawing.Point(0, 446);
            this.StatusStrip.Margin = new System.Windows.Forms.Padding(0);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(507, 24);
            this.StatusStrip.TabIndex = 4;
            this.StatusStrip.ThemeName = "TelerikMetroBlue";
            // 
            // StatusStripText
            // 
            this.StatusStripText.Name = "StatusStripText";
            this.StatusStrip.SetSpring(this.StatusStripText, false);
            this.StatusStripText.Text = "";
            this.StatusStripText.TextWrap = true;
            // 
            // logView
            // 
            this.logView._Result = null;
            this.logView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logView.Location = new System.Drawing.Point(12, 43);
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(484, 400);
            this.logView.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 470);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.logView);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.FileLocationPath);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "LogAnalyor";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.FileLocationPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox FileLocationPath;
        private Telerik.WinControls.UI.RadButton btnFileSelect;
        private Telerik.WinControls.UI.RadButton btnOk;
        private System.Windows.Forms.OpenFileDialog ofd;
        private LogView logView;
        private Telerik.WinControls.UI.RadStatusStrip StatusStrip;
        private Telerik.WinControls.UI.RadLabelElement StatusStripText;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme TelerikTheme;
    }
}