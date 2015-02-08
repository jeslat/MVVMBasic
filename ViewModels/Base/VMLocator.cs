using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBasic.ViewModels.Base
{
    public class VMLocator
    {
        private Lazy<VMMain> _mainViewModel;
        private Lazy<VMSimple> _simpleViewModel;
        private Lazy<VMConverters> _convertersViewModel;
        private Lazy<VMCommands> _commandsViewModel;

        public VMLocator()
        {
            _mainViewModel = new Lazy<VMMain>(() => new VMMain());
            _simpleViewModel = new Lazy<VMSimple>(() => new VMSimple());
            _convertersViewModel = new Lazy<VMConverters>(() => new VMConverters());
            _commandsViewModel = new Lazy<VMCommands>(() => new VMCommands());
        }

        public VMMain MainViewModel
        {
            get
            {
                return _mainViewModel.Value;
            }
        }

        public VMSimple SimpleViewModel
        {
            get
            {
                return _simpleViewModel.Value;
            }
        }

        public VMConverters ConvertersViewModel
        {
            get
            {
                return _convertersViewModel.Value;
            }
        }

        public VMCommands CommandsViewModel
        {
            get
            {
                return _commandsViewModel.Value;
            }
        }
    }
}
