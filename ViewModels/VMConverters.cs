using MVVMBasic.Model;
using MVVMBasic.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBasic.ViewModels
{
    public class VMConverters : VMBase
    {
        public MovieItem Movie { get; set; }

        public VMConverters()
        {
            Movie = MovieItem.GetMock();
        }
    }
}
