using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Autofac;
using Autofac.Integration.Wcf;
using Strategy.Example.Contracts.Application;
using Strategy.Example.Impl.Application;

namespace Strategy.Example.WCF.WebService
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            try
            {
                var builder = new ContainerBuilder();
                builder.RegisterType<CalculateService>().As<ICalculateService>();
                builder.RegisterType<CalculateApplicationService>().As<ICalculateApplicationService>();
                AutofacHostFactory.Container = builder.Build();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error on register dependencies on Global.asax " + exception.Message);
                throw;
            }

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}