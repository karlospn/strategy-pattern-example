﻿using System;
using Autofac;
using Autofac.Integration.Wcf;
using Strategy.Example.Contracts.Application;
using Strategy.Example.Impl.Application.StrategyWithDI;
using Strategy.Example.Impl.Application.StrategyWithDI.EnumContracts;
using Strategy.Example.Impl.Application.StrategyWithDI.EnumImplementations;
using Strategy.Example.Impl.Application.StrategyWithReflection.EnumContracts;

namespace Strategy.Example.WCF.WebService
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            try
            {
                var builder = new ContainerBuilder();
                Registrations(builder);
                AutofacHostFactory.Container = builder.Build();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error on register dependencies on Global.asax " + exception.Message);
                throw;
            }

        }

        private void Registrations(ContainerBuilder builder)
        {
            builder.RegisterType<CalculateService>().As<ICalculateService>();
            //builder.RegisterType<CalculateApplicationService>().As<ICalculateApplicationService>();
            builder.RegisterType<Impl.Application.StrategyWithReflection.CalculateApplicationService>().As<ICalculateApplicationService>();
            builder.RegisterType<CalculateTypeA>().As<ICalculate>();
            builder.RegisterType<CalculateTypeB>().As<ICalculate>();
            builder.RegisterType<CalculateTypeC>().As<ICalculate>();
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