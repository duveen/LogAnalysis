using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using SNS.UI.Framework.Object;

namespace FAMOS.HELPER.SECS
{
    public partial class LogInfo : SNSUserControl
    {
        public List<Log> _Result { get; set; }      

        public LogInfo()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //_Result = new List<Log>();
            InitDesign();           
                  
        }
        
        private void InitDesign()
        {
            this.gvLog.MasterTemplate.AllowAutoSizeColumns = false;
            this.gvLog.MasterTemplate.SelectionMode = GridViewSelectionMode.FullRowSelect;
            this.gvLog.MasterTemplate.AllowAddNewRow = false;

            this.gvLog.ShowNoDataText = true;
            this.gvLog.ShowRowErrors = true;

            this.gvLog.MasterTemplate.Columns.Add(new GridViewTextBoxColumn()
            {
                HeaderText = "Time",
                FieldName = "Time",
                TextAlignment = ContentAlignment.MiddleLeft,
                ReadOnly = true,
                Width = 100
            });
            this.gvLog.MasterTemplate.Columns.Add(new GridViewTextBoxColumn()
            {
                HeaderText = "TransferType",
                FieldName = "TransferType",
                TextAlignment = ContentAlignment.MiddleLeft,
                ReadOnly = true,
                Width = 100
            });
            this.gvLog.MasterTemplate.Columns.Add(new GridViewTextBoxColumn()
            {
                HeaderText = "StreamFunction",
                FieldName = "SF",
                TextAlignment = ContentAlignment.MiddleLeft,
                ReadOnly = true,
                Width = 100
            });
            this.gvLog.MasterTemplate.Columns.Add(new GridViewTextBoxColumn()
            {
                HeaderText = "SystemByte",
                FieldName = "SystemByte",
                TextAlignment = ContentAlignment.MiddleLeft,
                ReadOnly = true,
                Width = 100
            });
        }

        public bool LoadFile()
        {
            string FileLocationPath = MainForm.txtFileLocation.Text;
            List<string> strLogs = new List<string>();            

            if (LogFileManager.Instance.GetLogFile(FileLocationPath, strLogs))
            {
                _Result = LogFileManager.Instance.GetLogInstance(strLogs);                
                return true;
            }
            else
            {                
                return false;
            }
        }           

        private void GridDataBinding()
        {
            
        }        

        #region [ EVENT ]

        public override void BackWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (LoadFile())
            {
                GridDataBinding();
            }
            else
            {
                RadMessageBox.Show("로그 파일 로드 실패");
            }
        }

        public override void BackWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.gvLog.DataSource = _Result;

            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.Append("로그 파일 로드").AppendLine();

            Dictionary<string, int> LogFrequency_KeyMap = LogFileManager.Instance.CountLogFrequency(_Result);

            Progress.Visible = false;

            foreach (KeyValuePair<string, int> key in LogFrequency_KeyMap)
            {
                messageBuilder.Append($"{key.Key} : {key.Value}").AppendLine();
            }
            
            RadMessageBox.Show(messageBuilder.ToString());
        }
        private void gvLog_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {

        }
        #endregion

    }
}
