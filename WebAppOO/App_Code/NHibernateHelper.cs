using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using MapeamentoOR;

using System.Reflection;


public class NHibernateHelper
{
    private static ISessionFactory _sessionFactory;

    public static ISession GetSession()
    {

        try
        {
            if (_sessionFactory == null)
            {
                lock (typeof(NHibernateHelper))
                {
                    if (_sessionFactory == null)
                    {
                        Configuration cfg = new Configuration();

                        string connectionString = "Server=GMEPN000749\\SQLSERVER;Database=TESTE;Trusted_Connection=True;";

                        NHibernate.Cfg.Configuration nHibernateConfiguration = new NHibernate.Cfg.Configuration();

                        nHibernateConfiguration.SetProperty(NHibernate.Cfg.Environment.ProxyFactoryFactoryClass, typeof(NHibernate.ByteCode.Castle.ProxyFactoryFactory).AssemblyQualifiedName);
                        nHibernateConfiguration.SetProperty(NHibernate.Cfg.Environment.Dialect, typeof(NHibernate.Dialect.MsSql2008Dialect).AssemblyQualifiedName);
                        nHibernateConfiguration.SetProperty(NHibernate.Cfg.Environment.ConnectionString, connectionString);
                        nHibernateConfiguration.SetProperty(NHibernate.Cfg.Environment.ShowSql, "true");
                        nHibernateConfiguration.AddAssembly("MapeamentoOR");
                        //objProperties.Add("proxyfactory.factory_class", "NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle");
                        ISessionFactory oneISessionFactory = nHibernateConfiguration
                                                                .BuildSessionFactory();



                        //cfg.AddProperties("")
                        //cfg.AddAssembly("MapeamentoOR");
                        //_sessionFactory = cfg.BuildSessionFactory();
                        return oneISessionFactory.OpenSession();
                    }
                }
            }

        }
        catch (Exception e) { 
        
        
        
        
        }

        return null;
    }
    private NHibernateHelper()
    {
    }
}
