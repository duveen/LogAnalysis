﻿using FAMOS.HELPER.SECS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMOS.HELPER.SECS.SF
{
    class S2F42 : BasicSF, IConversable
    {
        public S2F42()
        {
            this.CodeName = "S2F42";
        }

        public List<string> Convert(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
