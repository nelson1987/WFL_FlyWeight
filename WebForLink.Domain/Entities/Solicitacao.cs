using WebForLink.Domain.Interfaces;

namespace WebForLink.Domain.Entities
{
    public class Solicitacao
    {
        public Solicitacao(Solicitante solicitante, ISolicitado solicitado, string titulo)
        {
            Solicitante = solicitante;
            Solicitado = solicitado;
            Titulo = titulo;
        }

        public Solicitante Solicitante { get; private set; }
        public ISolicitado Solicitado { get; private set; }
        public string Titulo { get; private set; }
    }
}