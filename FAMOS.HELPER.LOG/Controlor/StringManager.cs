using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FAMOS.HELPER.LOG.Controlor
{
    class StringManager
    {
        public static string GetApoLessWord(string str)
        {
            return str.Substring(str.IndexOf(@"'") + 1, str.LastIndexOf(@"'") - str.IndexOf(@"'") - 1);
        }

    }
}