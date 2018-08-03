using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace FAMOS.HELPER.LOG
{
    public partial class DetailForm : Telerik.WinControls.UI.RadForm
    {
        public string Time { get; set; }
        public string SF { get; set; }
        public string TransferType { get; set; }
        public string SystemByte { get; set; }
        public Log log { get; set; }
        public DetailForm(Log log)
        {
            this.log = log;
            InitializeComponent();
            RadMessageBox.SetThemeName(OfficeTheme.ThemeName);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            toolTip.SetToolTip(lbSystemByte, "lblSysByte");

            txtTime.Text = log.Time;
            txtSF.Text = log.SF;
            txtTransferType.Text = log.TransferType;
            txtSystemByte.Text = log.SystemByte;
            if(log.Log_Division == Log.LogDivision.NOTIFY)
            {
                txtDescription.Text = log.AdditionINFO;
            }
            else if(log.Log_Division == Log.LogDivision.SEND_REV)
            {
                StringBuilder SB_LowRankLog = new StringBuilder();
                foreach(string LowRankLog in log.LowRankLogs)
                {
                    SB_LowRankLog.Append(LowRankLog).AppendLine();
                }
                txtDescription.Text = SB_LowRankLog.ToString();
            }

        }
    }
}
