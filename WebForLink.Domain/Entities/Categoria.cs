namespace WebForLink.Domain.Entities
{
    public class Categoria
    {
        public Categoria(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
    }
}