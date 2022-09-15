using Autofac;
using Habilitacao.Infra.Data.Repository.IRepositories;
using Habilitacao.Infra.Data.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace habilitacaoCb.Infra.CrossCutting.IoC
{
    public class DependencyInjection
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HabilitacaoRepository>().As<IHabilitacaoRepository>();
        }
    }
}
