using WebForLink.Domain.Builders;
using WebForLink.Domain.Entities;

namespace WebForLink.Application.Services
{
    public class FornecedorApplicationService
    {
        private Fornecedor _fornecedorCadastrado;

        public FornecedorApplicationService(string nome, string documento)
        {
            Nome = nome;
            Documento = documento;
        }

        public string Nome { get; private set; }
        public string Documento { get; private set; }
        public Contato Contato { get; private set; }
        public Categoria Categoria { get; private set; }

        public Fornecedor FornecedorCadastrado { get { return _fornecedorCadastrado; } }

        public void IncluirFornecedor()
        {
            var builder = new FornecedorBuilder();
            builder
                .ComNome(Nome)
                .ComDocumento(Documento)
                .ComContato(Contato)
                .NaCategoria(Categoria)
                .NaDataAtual();
            _fornecedorCadastrado = builder.Constroi();

        }

        public FornecedorApplicationService ComContato(Contato contato)
        {
            Contato = contato;
            return this;
        }

        public FornecedorApplicationService ComCategoria(Categoria categoria)
        {
            Categoria = categoria;
            return this;
        }
    }
}