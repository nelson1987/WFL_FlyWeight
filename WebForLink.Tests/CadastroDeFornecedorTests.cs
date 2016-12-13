using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebForLink.Domain.Builders;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Factories;
using WebForLink.Domain.Interfaces;

namespace WebForLink.Domain.Tests
{
    [TestClass]
    public class CadastroDeFornecedorTests
    {
        [TestMethod]
        public void CriarCadastroFornecedor()
        {
            Solicitante usuarioSistema = new Solicitante("Bruno Alves", "bruno.alves@sistema.com.br");

            Fornecedor barracaDoZe = new FornecedorBuilder()
                .ComContato(new Contato("Zé", "ze@barracaze.com.br"))
                .ComDocumento("12.234.567-0")
                .ComNome("José Araújo de Lima")
                .NaCategoria(new Categoria("Alimentícios"))
                .NaDataAtual()
                .Constroi();

            Solicitacao solicitacaoCadastro = new Solicitacao(usuarioSistema, barracaDoZe, "Inclusão de Fornecedor");

            //fluxo Solicitação Costumizada
            var passoA = new Passo(1, "PassoA");
            var passoB = new Passo(2, "PassoB");
            var passoC = new Passo(3, "PassoC");
            var passoD = new Passo(4, "PassoD");

            passoA.AdicionarProximoPasso(new List<Passo> { passoB, passoC });
            passoB.AdicionarProximoPasso(new List<Passo> { passoD });
            passoC.AdicionarProximoPasso(new List<Passo> { passoD });

            passoB.AdicionarPassoAnterior(new List<Passo>() { passoA });
            passoC.AdicionarPassoAnterior(new List<Passo>() { passoA });
            passoD.AdicionarPassoAnterior(new List<Passo>() { passoB, passoC });

            var fluxo = new WorkFlow();
            fluxo.AdicionarPasso(new List<Passo> { passoA });
            fluxo.AdicionarPasso(new List<Passo> { passoB, passoC });
            fluxo.AdicionarPasso(new List<Passo> { passoD });

            CadastroDeFornecedor cadastro = new CadastroDeFornecedor(barracaDoZe, solicitacaoCadastro, fluxo);

            //Aprovar P1
            Assert.AreEqual(cadastro.Fluxo.PassoAtual.Descricao, passoA.Descricao);
            fluxo.AprovarPassoAtual(passoA);
            //Aprovar P2
            Assert.AreEqual(cadastro.Fluxo.PassoAtual.Descricao, passoB.Descricao);
            fluxo.AprovarPassoAtual(passoB);
            //Aprovar P3
            Assert.AreEqual(cadastro.Fluxo.PassoAtual.Descricao, passoC.Descricao);
            fluxo.AprovarPassoAtual(passoC);
            //Aprovar P4
            Assert.AreEqual(cadastro.Fluxo.PassoAtual.Descricao, passoD.Descricao);
            fluxo.AprovarPassoAtual(passoD);
        }
    }
}
