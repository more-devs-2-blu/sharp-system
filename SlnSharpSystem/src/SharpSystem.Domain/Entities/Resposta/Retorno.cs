using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.Entities.Resposta
{
    public class Retorno
    {
        public int id { get; set; }
        public Mensagem Mensagem { get; set; }
        public string Numero { get; set; }
        public string Serie { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string SituacaoCodigo { get; set; }
        public string SituacaoDescricao { get; set; }
        public string Link { get; set; }
        public string CodVerificador { get; set; }

    }
}
