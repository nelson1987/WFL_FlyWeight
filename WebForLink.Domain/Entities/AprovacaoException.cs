using System;

namespace WebForLink.Domain.Entities
{
    public class AprovacaoException : Exception
    {
        public AprovacaoException(string mensagem)
            : base(mensagem)
        {
            MensagemErro = mensagem;
        }

        public string MensagemErro { get; private set; }
    }
}