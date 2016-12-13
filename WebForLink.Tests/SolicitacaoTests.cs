using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Builders;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Interfaces;

namespace WebForLink.Domain.Tests
{
    [TestClass]
    public class SolicitacaoTests
    {
        [TestMethod]
        public void CriacaoSolicitacao()
        {
            var paulo = new Solicitante("Paulo", "paulo.solicitante@testemail.com.br");

            ISolicitado representanteComercial = new Cliente("Trufell Alimentação");
            representanteComercial.IncluirContato(new Contato("Representante Comercial",
                "representante.comercial@trufell.com"));

            ISolicitado novoFornecedor = new FornecedorBuilder()
                .ComNome("Fazendo Cacau Puro")
                .ComContato(new Contato("Representante Fornecedor", "administracao@cacaupuro.com"))
                .ComDocumento("123.456.789/0001-90")
                .NaDataAtual()
                .NaCategoria(new Categoria("Transporte"))
                .Constroi();

            var inclusaoCliente = new Solicitacao(paulo, representanteComercial, "Inclusao De Cliente");
            var inclusaoFornecedor = new Solicitacao(paulo, novoFornecedor, "Inclusao De Fornecedor");

            Assert.AreEqual(inclusaoCliente.Solicitante.Email, paulo.Email);
            Assert.AreEqual(inclusaoCliente.Solicitante.Email, "paulo.solicitante@testemail.com.br");
            Assert.AreEqual(inclusaoFornecedor.Solicitante.Email, "paulo.solicitante@testemail.com.br");
        }
    }
}