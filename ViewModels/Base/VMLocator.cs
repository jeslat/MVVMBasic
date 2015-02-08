using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBasic.ViewModels.Base
{
    public class VMLocator
    {
        IContainer container;

        public VMLocator()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<VMMain>();
            builder.RegisterType<VMSimple>();
            builder.RegisterType<VMConverters>();
            builder.RegisterType<VMCommands>();

            container = builder.Build();
        }

        public VMMain MainViewModel
        {
            get
            {
                return container.Resolve<VMMain>();
            }
        }

        public VMSimple SimpleViewModel
        {
            get
            {
                return container.Resolve<VMSimple>();
            }
        }

        public VMConverters ConvertersViewModel
        {
            get
            {
                return container.Resolve<VMConverters>();
            }
        }

        public VMCommands CommandsViewModel
        {
            get
            {
                return container.Resolve<VMCommands>();
            }
        }
    }
}
