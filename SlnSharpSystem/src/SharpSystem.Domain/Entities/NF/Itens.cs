﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities.NF
{
    public class Itens
    {
        [XmlElement("lista")]
        public Lista Lista { get; set; }
    }
}
