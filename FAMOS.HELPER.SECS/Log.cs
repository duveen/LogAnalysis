using FAMOS.HELPER.SECS.SF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMOS.HELPER.SECS
{
    [Serializable]
    public class Log
    {
        #region [ static ]        
        static public readonly string PAKAGE_PATH = "FAMOS.HELPER.SECS.SF";
        enum INDEX { TIME, TRANSFER_TYPE, ADDITIONINFO = 2, CODE_NAME = 2, SYSTEM_BYTE }

        #endregion

        private DateTime _Time { get; set; }
        public string Time { get; set; }

        public string TransferType { get; set; }
        private BasicSF _SF { get; set; }
        public string SF { get; set; }
        private int _SystemByte { get; set; }
        public string SystemByte { get; set; }
        public string AdditionINFO { get; set; } = string.Empty;
        public List<string> LowRankLogs { get; set; } = new List<string>();

        public Log(string[] HighRankLog)
        {
            //[2018/06/16 07:12:15.092]
            this._Time = DateTime.ParseExact(HighRankLog[(int)INDEX.TIME], "yyyy/MM/dd HH:mm:ss.fff", null);
            this.TransferType = HighRankLog[(int)INDEX.TRANSFER_TYPE];

            if (this.TransferType == "WARN" || this.TransferType == "INFO")
            {
                this.AdditionINFO = HighRankLog[(int)INDEX.ADDITIONINFO];
            }
            else
            {
                try
                {
                    this._SF = Activator.CreateInstance(Type.GetType($"{PAKAGE_PATH}.{HighRankLog[(int)INDEX.CODE_NAME]}")) as BasicSF;
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine(ane.StackTrace);
                    Console.WriteLine($"{HighRankLog[(int)INDEX.CODE_NAME]} 클래스가 정의되지 않았습니다.");
                }
                this._SystemByte = int.Parse(HighRankLog[(int)INDEX.SYSTEM_BYTE]);
            }
        }

        public Log(DateTime Time, string TransferType, string SFName, int SystemByte)
        {
            this._Time = Time;
            this.TransferType = TransferType;
            this._SF = Activator.CreateInstance(Type.GetType($"{PAKAGE_PATH}.{SFName}")) as BasicSF;
            this._SystemByte = SystemByte;
        }



        public string GetHighRankLogString()
        {
            if (this.TransferType == "WARN" || this.TransferType == "INFO")
            {
                return $"[{this._Time.ToString("yyyy/MM/dd HH:ss.fff")}] {this.TransferType} {AdditionINFO}";
            }
            else
            {
                return $"[{this._Time.ToString("yyyy/MM/dd HH:ss.fff")}] {this.TransferType} {_SF.CodeName} {SystemByte}";
            }
        }


        public void ConvertData()
        {
            Time = _Time.ToString();
            SF = _SF.CodeName;
            SystemByte = _SystemByte.ToString();
        }

        // 콘솔 테스트용
        public void PrintLog()
        {
            Console.WriteLine($"[{this._Time.ToString("yyyy-MM-dd-HH:ss")}] {this.TransferType} {_SF.CodeName} {SystemByte}");
            foreach (string LowRankLog in LowRankLogs)
            {
                Console.WriteLine(LowRankLog);
            }
        }

    }
}
