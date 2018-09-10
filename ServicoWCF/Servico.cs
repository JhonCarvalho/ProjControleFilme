using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dados;
using Entidade;


namespace ServicoWCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Servico" no arquivo de código e configuração ao mesmo tempo.
    public class Servico : IServico
    {

        public bool inserir(FilmeVO filmeVO)
        {
            return new Dados.Dados().Inserir(filmeVO);
        }

        public List<Filme> Listar()
        {
            return new Dados.Dados().Listar();
        }
    }
}
