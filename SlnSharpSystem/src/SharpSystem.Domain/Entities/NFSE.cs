using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.Entities
{
    public class NFSE
    {
        public int Id { get; set; }
        public class NotaFiscal
        {
            public int Id { get; set; }
            public string ValorTotal { get; set; }
        }
        public class Prestador
        {
            public int Id { get; set; }
            public string CpfCnpj { get; set; }
            public string Cidade { get; set; }
        }
        public class Tomador
        {
            public int Id { get; set; }
            public string Tipo { get; set; }
            public string NomeRazaoSocial { get; set; }
            public string Logradouro { get; set; }
            public string Email { get; set; }
            public string NumeroResidencia { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Cep { get; set; }
        }
        public class Itens
        {
            public class Lista
            {
                public int Id { get; set; }
                public string TribunaMunicipioPrestador { get; set; }
                public string CodigoLocalPrestacaoServico { get; set; }
                public string CodigoItemListaServico { get; set; }
                public string Descritivo { get; set; }
                public string AliquotaItemListaServico { get; set; }
                public string SituacaoTributaria { get; set; }
                public string ValorTributavel { get; set; }
            }
        }
    }
}
