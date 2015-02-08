using MVVMBasic.ViewModels.Base;
using MVVMBasic.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMBasic.ViewModels
{
    public class VMMain : VMBase
    {
        private Lazy<DelegateCommand> _openSimpleViewCommand;
        private Lazy<DelegateCommand> _openConvertersViewCommand;
        private Lazy<DelegateCommand> _openCommandsViewCommand;

        public ICommand OpenSimpleViewCommand
        {
            get { return _openSimpleViewCommand.Value; }
        }

        public ICommand OpenConvertersViewCommand
        {
            get { return _openConvertersViewCommand.Value; }
        }

        public ICommand OpenCommandsViewCommand
        {
            get { return _openCommandsViewCommand.Value; }
        }

        public VMMain()
        {
            _openSimpleViewCommand = new Lazy<DelegateCommand>(() => new DelegateCommand(OpenSimpleView, null));
            _openConvertersViewCommand = new Lazy<DelegateCommand>(() => new DelegateCommand(OpenConvertersView, null));
            _openCommandsViewCommand = new Lazy<DelegateCommand>(() => new DelegateCommand(OpenCommandsView, null));
        }

        public void OpenSimpleView()
        {
            App.RootFrame.Navigate(typeof(VSimple));
        }

        public void OpenConvertersView()
        {
            App.RootFrame.Navigate(typeof(VConverters));
        }

        public void OpenCommandsView()
        {
            App.RootFrame.Navigate(typeof(VCommands));
        }
    }
}
