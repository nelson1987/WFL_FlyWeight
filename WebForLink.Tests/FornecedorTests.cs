using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Entities;

namespace WebForLink.Domain.Tests
{
    [TestClass]
    public class FornecedorTests
    {
        [TestMethod]
        public void CriarFornecedor()
        {
            var viacaoFast = new Fornecedor("012.345.678/0001-90", "Viação Fast S/A");
            viacaoFast.IncluirCategoria(new Categoria("Transporte"));
            viacaoFast.IncluirContato(new Contato("José Paulo", "21934567890"));
            Assert.AreEqual(viacaoFast.Categoria.Nome, "Transporte");
        }
    }
}