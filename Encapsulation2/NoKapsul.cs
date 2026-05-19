using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation2
{
    public class NoKapsul
    {
        private int tcNo;

        public void TcNoAta(int tcNo)
        {
            this.tcNo = tcNo;
        }

        public int TcNoGoster()
        {
            return this.tcNo;
        }
    }
}
