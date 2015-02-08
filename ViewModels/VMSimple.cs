using MVVMBasic.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBasic.ViewModels
{
    /*
     * ViewModel to test simple links to data with diferent modes
     * and change's notifications including a view model base
     */

    public class VMSimple : VMBase
    {
        private string _userInput;

        public string Title { get; set; }

        public string UserInput
        {
            get { return _userInput; }
            set
            {
                _userInput = value;
                RaisePropertyChanged("UserInput");
            }
        }

        public VMSimple()
        {
            Title = "Título de prueba";
        }

        private void UpdateAll()
        {
            RaisePropertyChanged(String.Empty);
        }
    }
}
