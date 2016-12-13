namespace WebForLink.Domain.Entities
{
    public class Contato
    {
        public Contato(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public Contato(string nome, string telefone, string celular, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Celular = celular;
            Email = email;
        }

        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Celular { get; private set; }
        public string Email { get; private set; }
    }
}