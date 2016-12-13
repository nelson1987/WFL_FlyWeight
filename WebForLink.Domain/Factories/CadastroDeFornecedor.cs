using System.Collections.Generic;
using WebForLink.Domain.Entities;

namespace WebForLink.Domain.Factories
{
    public class CadastroDeFornecedor
    {
        public CadastroDeFornecedor(Fornecedor fornecedor, Solicitacao solicitacao, WorkFlow fluxo)
        {
            Fornecedor = fornecedor;
            Solicitacao = solicitacao;
            //Fluxo = fluxo;
        }

        public Fornecedor Fornecedor { get; private set; }
        public Solicitacao Solicitacao { get; private set; }
        //public WorkFlow Fluxo { get; private set; }


    }
}