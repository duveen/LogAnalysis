using FAMOS.HELPER.SECS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMOS.HELPER.SECS.SF
{
    class S5F1 : BasicSF, IConversable
    {
        public S5F1()
        {
            this.CodeName = "S5F1";
        }

        public List<string> Convert(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
