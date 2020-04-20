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

public partial class EditarAtividade : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = Convert.ToInt32(Request["Id"]);
            CarregaAtividade(id);
        }
    }

    protected void CarregaAtividade(int id)
    {
        Atividade atividade = AtividadeDAO.RetornaAtividade(id);

        _txtCodigo.Text = atividade.Id.ToString();
        _txtNome.Text = atividade.Nome;
        _txtDescricao.Text = atividade.Descricao;
    }

    protected void _btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void _btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            Atividade atividade = new Atividade();
            atividade.Id = Convert.ToInt32(_txtCodigo.Text);
            atividade.Nome = _txtNome.Text;
            atividade.Descricao = _txtDescricao.Text;

            AtividadeDAO.AtualizaAtividade(atividade);

            Response.Redirect("Default.aspx");
        }
        catch (Exception ex)
        {
            Response.Write("Erro: " + ex.Message);
        }
    }

    protected void _btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            Atividade atividade = new Atividade();
            atividade.Id = Convert.ToInt32(_txtCodigo.Text);

            AtividadeDAO.ExcluiAtividade(atividade);

            Response.Redirect("Default.aspx");
        }
        catch (Exception ex)
        {
            Response.Write("Erro: " + ex.Message);
        }
    }
}
