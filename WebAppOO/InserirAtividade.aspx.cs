using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using MapeamentoOR;

public partial class InserirAtividade : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            
    }

    protected void _btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            Atividade atividade = new Atividade();
            atividade.Id = Convert.ToInt32(_txtCodigo.Text);
            atividade.Nome = _txtNome.Text;
            atividade.Descricao = _txtDescricao.Text;

            AtividadeDAO.SalvaAtividade(atividade);

            Response.Redirect("Default.aspx");
        }
        catch (Exception ex)
        {
            Response.Write("Erro: " + ex.Message);
        }
    }

    protected void _btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
