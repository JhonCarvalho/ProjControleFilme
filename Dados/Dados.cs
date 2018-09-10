using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dados
{
    public class Dados
    {
        public bool Inserir(FilmeVO filmeVO)
        {
            ProjFilmeEntities context = new ProjFilmeEntities();
            context.Filme.Add(Converte.ToFilme(filmeVO));
            int retorno = context.SaveChanges();

            return retorno == 1;
        }

        public List<Filme> Listar ()
        {
           var context = new ProjFilmeEntities();
           return context.Filme.ToList();
        }
  
    }
}
