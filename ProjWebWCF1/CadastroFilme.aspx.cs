using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjWebWCF1
{
    public partial class CadastroFilme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            var servico = new MeuServicoWCF.ServicoClient();
            gvtFilme.DataSource = servico.Listar();
            gvtFilme.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            FilmeVO filme = new FilmeVO();
            filme.Nome = txtNome.Text;
            filme.Genero = txtGenero.Text;
            filme.AnoLancamento = Convert.ToDateTime(txtAnoLancamento.Text);

            MeuServicoWCF.ServicoClient servico = new MeuServicoWCF.ServicoClient();

            servico.inserir(filme);
            AtualizarGrid();
        }
    }
}