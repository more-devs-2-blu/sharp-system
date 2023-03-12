﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities
{
    public class NFSE
    {
        public NotaFiscal nf { get; set; }
        public Prestador prestador { get; set; }
        public Tomador tomador { get; set; }
        public Lista<Itens> itens { get; set; }
    }
}