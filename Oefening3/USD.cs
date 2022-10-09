using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class USD
    {
        public double bedrag { get; set; }

        public USD (double bedrag)
        {
            this.bedrag = bedrag;
        }

        public USD()
        {

        }

        public override string ToString()
        {
            return bedrag.ToString();
        }
    }
}
