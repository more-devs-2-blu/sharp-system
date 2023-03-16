namespace SharpSystem.Domain.Entities.Usuario
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CFPCNPJ { get; set; }
        public string Senha { get; set; }
        public bool SenhaValida(string senha)
        {
            return Senha == senha;
        }
    }
}
