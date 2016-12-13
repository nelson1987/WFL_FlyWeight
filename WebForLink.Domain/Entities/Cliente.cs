using WebForLink.Domain.Interfaces;

namespace WebForLink.Domain.Entities
{
    public class Cliente : ISolicitado
    {
        public Cliente(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
        public Contato Contato { get; private set; }

        public void IncluirContato(Contato contato)
        {
            Contato = contato;
        }
    }
}