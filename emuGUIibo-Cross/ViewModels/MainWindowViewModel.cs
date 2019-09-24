using System;
using System.Collections.Generic;
using System.Text;
using emuGUIibo_Cross.Services;

namespace emuGUIibo_Cross.ViewModels
{

    public class MainWindowViewModel : ViewModelBase
    {
        public AmiiboViewModel AmiiboCollection { get; }
        public MainWindowViewModel()
        {
            AmiiboCollection = new AmiiboViewModel(AmiiboAPI.Amiibos, AmiiboAPI.Series);
        }
    }
}
