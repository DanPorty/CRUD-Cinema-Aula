using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaDomain
{
    public class IngressoItem
    {
        public Ingresso Ingresso { get; set; }

        public int Assento { get; set; }

        public int Fileira { get; set; }

        public bool MeiaEntrada { get; set; }
    }
}