using FAMOS.HELPER.LOG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMOS.HELPER.LOG.SF
{
    class S10F3 : BasicSF, IConversable
    {
        public S10F3()
        {
            this.CodeName = "S10F3";
        }

        public List<string> Convert(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
