namespace WebForLink.Domain.Entities
{
    public class Solicitante
    {
        public Solicitante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
    }
}