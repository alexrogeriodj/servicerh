using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;

namespace ContratosService.NHibernate
{
    public class NHibernateHelper
    {
        private static ISessionFactory sessionFactory;

        public static ISessionFactory getSessionFactory()
        {
            try
            {
                if (sessionFactory == null)
                {
                    lock(typeof (NHibernateHelper))
                    {
                        Configuration config = new Configuration();
                        config.Configure();
                        config.AddAssembly("ContratosService");
                        sessionFactory = config.BuildSessionFactory();
                    }
                }
                return sessionFactory;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
