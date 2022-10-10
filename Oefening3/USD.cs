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

        public override string ToString()
        {
            return bedrag.ToString();
        }

    }

    internal class Euro : USD
    {
        public double toEuro;
        public Euro(double bedrag) : base(bedrag)
        {
            toEuro = bedrag * 1.03;
        }

        public override string? ToString()
        {
            return toEuro.ToString();
        }
    }
    internal class JapaanseYen : USD
    {
        public double toYen;
        public JapaanseYen(double bedrag) : base(bedrag)
        {
            toYen = bedrag * 145.34;
        }

        public override string? ToString()
        {
            return toYen.ToString();
        }
    }
    internal class Pounds : USD
    {
        public double toPound;
        public Pounds(double bedrag) : base(bedrag)
        {
            toPound = bedrag * 0.90;
        }

        public override string? ToString()
        {
            return toPound.ToString();
        }
    }
    internal class Rupees : USD
    {
        public double toRupees;
        public Rupees(double bedrag) : base(bedrag)
        {
            toRupees = bedrag * 82.83;
        }

        public override string? ToString()
        {
            return toRupees.ToString();
        }
    }
    internal class Frank : USD
    {
        public double toFrank;
        public Frank(double bedrag) : base(bedrag)
        {
            toFrank = bedrag * 0.99;
        }

        public override string? ToString()
        {
            return toFrank.ToString();
        }
    }
}
