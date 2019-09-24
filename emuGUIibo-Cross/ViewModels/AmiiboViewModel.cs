using System.Collections.Generic;
using System.Collections.ObjectModel;
using emuGUIibo_Cross.Models;

namespace emuGUIibo_Cross.ViewModels
{
    public class AmiiboViewModel : ViewModelBase
    {
        public ObservableCollection<Amiibo> Amiibos { get; }
        public ObservableCollection<string> Series { get; }
        public AmiiboViewModel(IEnumerable<Amiibo> amiibos, IEnumerable<string> series)
        {
            Amiibos = new ObservableCollection<Amiibo>(amiibos);
            Series = new ObservableCollection<string>(series);
        }
    }
}