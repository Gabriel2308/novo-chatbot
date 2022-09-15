using Autofac;
using System;
using System.Reflection;

namespace habilitacaoCb.Infra.CrossCutting.IoC
{
    public class ModuleIoC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            DependencyInjection.Load(builder);
        }
    }
}
