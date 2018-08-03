using FAMOS.HELPER.SECS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMOS.HELPER.SECS.SF
{
    class S1F3 : BasicSF, IConversable
    {
        public S1F3()
        {
            this.CodeName = "S1F3";
        }

        public List<string> Convert(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
