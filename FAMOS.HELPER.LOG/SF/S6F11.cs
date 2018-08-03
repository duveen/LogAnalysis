using FAMOS.HELPER.LOG.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMOS.HELPER.LOG.SF
{
    class S6F11 : BasicSF, IConversable
    {
        static public readonly string LogFormat =
        @"           <LIST, 3>
                             <U2, 1, '0'>
                             <U2, 1, '8020'>
                             <LIST, 1>
                                <LIST, 2>
                                   <U2, 1, '200'>
                                   <LIST, 37>
                                      <ASCII, 16, '2018061608161300'>
                                      <U1, 1, '1'>
                                      <ASCII, 8, 'DR04100E'>
                                      <U1, 1, '0'>
                                      <U1, 1, '2'>
                                      <BOOLEAN, 1, 'False'>
                                      <I2, 1, '0'>
                                      <U2, 1, '1'>
                                      <U2, 1, '6'>
                                      <U4, 1, '6331'>
                                      <U4, 1, '342'>
                                      <U2, 1, '1'>
                                      <U2, 1, '1'>
                                      <U2, 1, '1'>
                                      <U2, 1, '1'>
                                      <I4, 1, '0'>
                                      <U4, 1, '0'>
                                      <F4, 1, '23.53111'>
                                      <F4, 1, '234.5519'>
                                      <F4, 1, '993.3066'>
                                      <F4, 1, '0'>
                                      <F4, 1, '2.277203'>
                                      <F4, 1, '0'>
                                      <F4, 1, '0'>
                                      <U4, 1, '0'>
                                      <F4, 1, '0'>
                                      <U4, 1, '418531'>
                                      <F4, 1, '1565.749'>
                                      <U4, 1, '0'>
                                      <U4, 1, '0'>
                                      <U4, 1, '0'>
                                      <U4, 1, '0'>
                                      <U4, 1, '0'>
                                      <U4, 1, '0'>
                                      <U4, 1, '0'>
                                      <U4, 1, '0'>
                                      <BINARY, 1, '5'>";
        public S6F11()
        {
            this.CodeName = "S6F11";
        }
        public void Convert(Log log)
        {
            Console.WriteLine("Convert S6F11");
        }

        List<string> IConversable.Convert(Log log)
        {
            throw new NotImplementedException();
        }
    }
}
