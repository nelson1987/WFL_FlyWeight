using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Builders;
using WebForLink.Domain.Entities;

namespace WebForLink.Domain.Tests
{
    [TestClass]
    public class FornecedorBuilderTests
    {
        [TestMethod]
        public void CriarBuilder()
        {
            var fornecedor = new FornecedorBuilder();
            fornecedor
                .ComContato(new Contato("José Augusto", "21934567890"))
                .ComNome("AutoViação Fast")
                .ComDocumento("012.345.678/0001-90")
                .NaCategoria(new Categoria("Transporte"))
                .NaDataAtual();

            var autoViacaoFast = fornecedor.Constroi();

            Assert.AreEqual(autoViacaoFast.Categoria.Nome, "Transporte");
        }
    }
}