using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NCM_Utilities.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {

        

        private string caption;

        public string Caption
        {
            get => caption;
            set => this.RaiseAndSetIfChanged(ref caption, value);
        }
    }


}
