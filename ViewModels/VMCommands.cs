
using MVVMBasic.ViewModels.Base;
using System;
using System.Windows.Input;
using Windows.UI.Popups;
namespace MVVMBasic.ViewModels
{
    public class VMCommands : VMBase
    {
        private Lazy<DelegateCommand> _sayHelloCommand;
        private string _userInput;

        public ICommand SayHelloCommand
        {
            get { return _sayHelloCommand.Value; }
        }

        public string UserInput
        {
            get { return _userInput; }
            set
            {
                _userInput = value;
                RaisePropertyChanged("UserInput");
                _sayHelloCommand.Value.RaiseCanExecuteChanged();
            }
        }

        public VMCommands()
        {
            _sayHelloCommand = new Lazy<DelegateCommand>(
                () => new DelegateCommand(SayHelloCommandExecute, SayHelloCommandCanExecute)
            );
            _userInput = String.Empty;
        }

        public async void SayHelloCommandExecute()
        {
            var message = String.Format("Hello {0}", UserInput);
            MessageDialog dialog = new MessageDialog(message);
            await dialog.ShowAsync();
        }

        public bool SayHelloCommandCanExecute()
        {
            if (UserInput.ToLowerInvariant() == "jesus")
                return true;

            return false;
        }
    }
}
