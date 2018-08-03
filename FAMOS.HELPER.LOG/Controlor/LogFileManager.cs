using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMOS.HELPER.LOG.Controlor
{
    class LogFileManager
    {
        public static LogFileManager Instance { get; } = new LogFileManager();
        // 로그 문자열 구분용 인덱스
        static public readonly int YEAR_MONTH_DAY_INDEX = 1;
        static public readonly int HOUR_MINUTE_INDEX = 2;
        static public readonly int TRANSFER_TYPE_INDEX = 4;
        static public readonly int SF_INDEX = 5;
        static public readonly int SYSTEMBYTE_INDEX = 9;

        private StreamReader streamReader;

        public string FileName { get; set; } = "";
        public string FilePath { get; set; } = "";

        #region [ Constructor ] =============================================
        public LogFileManager()
        {
            streamReader = null;
        }
        public LogFileManager(string FileName, string FilePath)
        {
            SetCurrentFileInfo(FileName, FilePath);
        }
        #endregion

        public void SetCurrentFileInfo(string FileName, string FilePath)
        {
            this.FileName = FileName;
            this.FilePath = FilePath;
        }

        public bool GetLogFile(string FilePath, List<string> Logs)
        {
            try
            {
                using (streamReader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Logs.Add(line.Trim());
                    }
                }
                streamReader.Close();
            }
            catch (FileNotFoundException ffe)
            {
                Console.WriteLine(ffe.StackTrace);
                return false;
            }

            return true;
        }

        private void SFCount(string Log, Dictionary<string, int> LogFrequency)
        {
            if (LogFrequency.ContainsKey(Log))
                (LogFrequency[Log])++;
            else
                LogFrequency[Log] = 1;
        }        

        public bool CheckHighRankLog(string line)
        {
            if (line.IndexOf("[") != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Log 객체 리스트 Ver
        public Dictionary<string, int> CountLogFrequency(List<Log> Logs)
        {
            Dictionary<string, int> Logfrequency = new Dictionary<string, int>();
            foreach (Log log in Logs)
            {
                if (log.Log_Division == Log.LogDivision.SEND_REV)
                    SFCount(log.SF, Logfrequency);
            }
            return Logfrequency;
        }

        public List<Log> GetLogInstance(List<string> LogStrings)
        {
            List<Log> Logs = new List<Log>();
            Log currentLog = null;
            foreach (string log in LogStrings)
            {
                if (CheckHighRankLog(log))
                {
                    currentLog = new Log(GetHighRankLog(log));
                    Logs.Add(currentLog);
                }
                else
                    currentLog.LowRankLogs.Add(log);
            }
            return Logs;
        }

        private string[] GetHighRankLog(string log)
        {
            string[] parsedString = log.Split(' ', '=', '[', ']');
            if (parsedString[TRANSFER_TYPE_INDEX] == "WARN" || parsedString[TRANSFER_TYPE_INDEX] == "INFO")
            {
                StringBuilder AdditionINFOBuilder = new StringBuilder();
                for (int i = TRANSFER_TYPE_INDEX + 1; i < parsedString.Length; i++)
                {
                    AdditionINFOBuilder.Append($"{parsedString[i]} ");
                }
                return new string[] { $"{parsedString[YEAR_MONTH_DAY_INDEX]} {parsedString[HOUR_MINUTE_INDEX]}", parsedString[TRANSFER_TYPE_INDEX], AdditionINFOBuilder.ToString() };
            }
            else
            {
                return new string[] { $"{parsedString[YEAR_MONTH_DAY_INDEX]} {parsedString[HOUR_MINUTE_INDEX]}", parsedString[TRANSFER_TYPE_INDEX], parsedString[SF_INDEX], parsedString[SYSTEMBYTE_INDEX] };
            }
        }
    }
}
