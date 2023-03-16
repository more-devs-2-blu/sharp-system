namespace SharpSystem.Domain.Entities.NFS
{
    public class NFSE
    {
        public int Id { get; set; }
        public NotaFiscal NotaFiscal { get; set; }
        public Prestador Prestador { get; set; }
        public Tomador Tomador { get; set; }
        public Itens Itens { get; set; }
    }
}
