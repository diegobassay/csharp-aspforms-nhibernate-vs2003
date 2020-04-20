using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using MapeamentoOR;
using NHibernate;

public class AtividadeDAO
{
    public AtividadeDAO()
    {
    }

    public static IList RetornaAtividades(string column,
                               int maximumRows,
                               int startRowIndex)
    {
        ISession session = NHibernateHelper.GetSession();

        string sql = "FROM Atividade AS atividade";

        // Sorting
        if (!String.IsNullOrEmpty(column))
        {
            sql += " ORDER BY atividade." + column;
        }

        IQuery query = session.CreateQuery(sql);

        // Paging
        query.SetFirstResult(startRowIndex);
        query.SetMaxResults(maximumRows);

        IList list = null;

        try
        {
            list = query.List();
        }
        catch (Exception e) {
            Console.Write("Teste");
        
        
        }


        return list;
    }

    public static void SalvaAtividade(Atividade atividade)
    {
        ISession session = NHibernateHelper.GetSession();
        session.Save(atividade);
        session.Flush();
        session.Close();
    }

    public static Atividade RetornaAtividade(int id)
    {
        ISession session = NHibernateHelper.GetSession();
        return (Atividade)session.Get(typeof(Atividade), id);
    }

    public static void ExcluiAtividade(Atividade atividade)
    {
        ISession session = NHibernateHelper.GetSession();
        session.Delete(atividade);
        session.Flush();
        session.Close();
    }

    public static void AtualizaAtividade(Atividade atividade)
    {
        ISession session = NHibernateHelper.GetSession();
        session.Update(atividade);
        session.Flush();
        session.Close();
    }
}
