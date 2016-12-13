using System.Collections.Generic;
using System.Linq;

namespace WebForLink.Domain.Entities
{
    public class WorkFlow
    {
        public WorkFlow()
        {
            Passos = new List<List<Passo>>();
        }

        public List<List<Passo>> Passos { get; private set; }

        public bool Concluido
        {
            get { return PassoAtual == null; }
        }

        public Passo PassoAtual
        {
            get { return ValidarPassoAtual(); }
        }

        private Passo ValidarPassoAtual()
        {
            Passo passo = null;
            if (Passos.Any())
                foreach (var item in Passos)
                {
                    if (item.Any())
                        foreach (var steps in item)
                        {
                            if (!steps.Aprovado)
                            {
                                passo = steps;
                                return passo;
                            }
                        }
                }

            return passo;
        }

        public void AdicionarPasso(List<Passo> passo)
        {
            Passos.Add(passo);
        }

        public void AprovarPassoAtual()
        {
            PassoAtual.Aprovar();
        }

        public void AprovarPassoAtual(Passo passo)
        {
            foreach (var item in Passos)
            {
                foreach (var steps in item)
                {
                    if (steps.Id == passo.Id)
                        if (!steps.Aprovado)
                            steps.Aprovar();
                        else
                            throw new AprovacaoException("Não se pode aprovar processo já aprovado.");
                }
            }
        }
    }
}