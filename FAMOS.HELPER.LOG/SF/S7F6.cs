using FAMOS.HELPER.LOG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMOS.HELPER.LOG.SF
{
    class S7F6 : BasicSF, IConversable
    {
        public S7F6()
        {
            this.CodeName = "S7F6";
        }

        public List<string> Convert(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
