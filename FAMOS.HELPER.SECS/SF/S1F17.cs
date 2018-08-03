using FAMOS.HELPER.SECS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMOS.HELPER.SECS.SF
{
    class S1F17 : BasicSF, IConversable
    {
        public S1F17()
        {
            this.CodeName = "S1F17";
        }

        public List<string> Convert(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
