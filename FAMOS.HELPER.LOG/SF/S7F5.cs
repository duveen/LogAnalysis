using FAMOS.HELPER.LOG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMOS.HELPER.LOG.SF
{
    class S7F5 : BasicSF, IConversable
    {
        public S7F5()
        {
            this.CodeName = "S7F5";
        }

        public List<string> Convert(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
