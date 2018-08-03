using FAMOS.HELPER.SECS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMOS.HELPER.SECS.SF
{
    class S2F33 : BasicSF, IConversable
    {
        public S2F33()
        {
            this.CodeName = "S2F33";
        }

        public List<string> Convert(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
