using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Converte
    {
        public static Filme ToFilme(FilmeVO filmeVO)
        {
            return new Filme()
            {
                Id = filmeVO.Id,
                Nome = filmeVO.Nome,
                Genero = filmeVO.Genero,
                AnoLancamento = filmeVO.AnoLancamento
            };
        }

        public static FilmeVO ToFilmeVO(Filme filme)
        {
            return new FilmeVO()
            {
                Id = filme.Id,
                Nome = filme.Nome,
                Genero = filme.Genero,
                AnoLancamento = (DateTime)filme.AnoLancamento
            };
        }

    }
}
