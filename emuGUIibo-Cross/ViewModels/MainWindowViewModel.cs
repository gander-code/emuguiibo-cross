using System;
using System.Collections.Generic;
using System.Text;
using emuGUIibo_Cross.Services;

namespace emuGUIibo_Cross.ViewModels
{

    public class MainWindowViewModel : ViewModelBase
    {
        public AmiiboViewModel AmiiboVM { get; }
        public MainWindowViewModel(AmiiboAPI api)
        {
            AmiiboVM = new AmiiboViewModel(api);
        }
    }
}
