using System;
using WebForLink.Domain.Entities;

namespace WebForLink.Domain.Builders
{
    public class FornecedorBuilder
    {
        public string Documento { get; private set; }
        public string Nome { get; private set; }
        public Categoria Categoria { get; private set; }
        public Contato Contato { get; private set; }
        public DateTime Criacao { get; private set; }

        public Fornecedor Constroi()
        {
            return new Fornecedor(Documento, Nome, Categoria, Contato, Criacao);
        }

        public FornecedorBuilder ComDocumento(string documento)
        {
            Documento = documento;
            return this;
        }

        public FornecedorBuilder ComNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public FornecedorBuilder NaCategoria(Categoria categoria)
        {
            Categoria = categoria;
            return this;
        }

        public FornecedorBuilder ComContato(Contato contato)
        {
            Contato = contato;
            return this;
        }

        public FornecedorBuilder NaDataAtual()
        {
            Criacao = DateTime.Now;
            return this;
        }
    }
}