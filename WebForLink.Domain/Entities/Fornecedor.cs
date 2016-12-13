using System;
using WebForLink.Domain.Interfaces;

namespace WebForLink.Domain.Entities
{
    public class Fornecedor : ISolicitado
    {
        public Fornecedor(string documento, string razaoSocial)
        {
            Documento = documento;
            RazaoSocial = razaoSocial;
        }

        public Fornecedor(string documento, string razaoSocial, Categoria categoria, Contato contato, DateTime criacao)
        {
            Documento = documento;
            RazaoSocial = razaoSocial;
            Categoria = categoria;
            Contato = contato;
            Criacao = criacao;
        }

        public DateTime Criacao { get; private set; }
        public string Documento { get; private set; }
        public string RazaoSocial { get; private set; }
        public Categoria Categoria { get; private set; }
        public Contato Contato { get; private set; }

        public void IncluirContato(Contato contato)
        {
            Contato = contato;
        }

        public void IncluirCategoria(Categoria categoria)
        {
            if (string.IsNullOrEmpty(categoria.Nome))
                if (categoria.Nome.Equals(Categoria.Nome))
                    throw new Exception("O Fornecedor já tem uma categoria cadastrada");
            Categoria = categoria;
        }
    }
}