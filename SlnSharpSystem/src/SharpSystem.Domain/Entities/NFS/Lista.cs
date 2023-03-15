namespace SharpSystem.Domain.Entities.NFS
{
    public class Lista
    {
        public int Id { get; set; }
        public string TributaMunicipioPrestador { get; set; }
        public string CodigoLocalPrestacaoServico { get; set; }
        public string CodigoItemListaServico { get; set; }
        public string Descritivo { get; set; }
        public string AliquotaItemListaServico { get; set; }
        public string SituacaoTributaria { get; set; }
        public string ValorTributavel { get; set; }
    }
}
