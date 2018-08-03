using FAMOS.HELPER.SECS.Controlor;
using FAMOS.HELPER.SECS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FAMOS.HELPER.SECS.SF
{
    public class S2F41 : BasicSF, IConversable
    {
        public class CP_Pair
        {
            public string Name;
            public string Value;
            public CP_Pair(string Name, string Value)
            {
                this.Name = Name;
                this.Value = Value;
            }
        }

        public List<CP_Pair> CP_PairList { get; set; } = new List<CP_Pair>();
        private static readonly int CP_INDEX = 3;


        public S2F41()
        {
            this.CodeName = "S2F41";
        }

        public List<string> Convert(Log log)
        {
            List<string> ConvertedLog = new List<string>();

            string CP_List = log.LowRankLogs[
                2];
            int CPCount = int.Parse(Regex.Replace(CP_List, @"\D", ""));

            ConvertedLog.Add($"<RCMD> : {StringManager.GetApoLessWord(log.LowRankLogs[1])}");
            ConvertedLog.Add($"<CPLIST, {CPCount}>");
            for(int i = CP_INDEX; CPCount > 0; i *= 3)
            {
                string CPNameValue = $"{StringManager.GetApoLessWord(log.LowRankLogs[i + 1])} : {StringManager.GetApoLessWord(log.LowRankLogs[i + 2])}";
                ConvertedLog.Add(CPNameValue);
                CPCount--;
            }
            return ConvertedLog;
        }
    }
}
