using FAMOS.HELPER.SECS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMOS.HELPER.SECS.SF
{
    class S10F4 : BasicSF, IConversable
    {
        public S10F4()
        {
            this.CodeName = "S10F4";
        }

        public List<string> Convert(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
