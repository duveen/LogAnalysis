﻿namespace FAMOS.HELPER.SECS
{
    partial class LogInfo
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gvLog = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLog.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLog
            // 
            this.gvLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvLog.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gvLog.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gvLog.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvLog.Name = "gvLog";
            this.gvLog.Size = new System.Drawing.Size(469, 442);
            this.gvLog.TabIndex = 0;
            this.gvLog.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvLog_CellDoubleClick);
            // 
            // LogInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvLog);
            this.Name = "LogInfo";
            this.Size = new System.Drawing.Size(469, 442);
            ((System.ComponentModel.ISupportInitialize)(this.gvLog.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gvLog;
    }
}
