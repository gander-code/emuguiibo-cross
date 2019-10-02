using System.Collections.Generic;
using System.Collections.ObjectModel;
using emuGUIibo_Cross.Models;
using emuGUIibo_Cross.Services;

namespace emuGUIibo_Cross.ViewModels
{
    public class AmiiboViewModel : ViewModelBase
    {
        public ObservableCollection<Amiibo> Amiibos { get; } = new ObservableCollection<Amiibo>();
        public ObservableCollection<string> Series { get; } = new ObservableCollection<string>();
        private AmiiboAPI Api;
        public Amiibo SelectedAmiibo { get; private set; }
        public AmiiboViewModel(AmiiboAPI api)
        {
            Api = api;
            Api.LoadAllAmiibos();
            if (Api.AllAmiibos.Count > 0) Api.Series.ForEach((string series) => Series.Add(series));
        }

        public void LoadAmiiboInSeries(string series)
        {
            Amiibos.Clear();
            var amiibosInSeries = Api.AllAmiibos.FindAll(amiibo => amiibo.SeriesName.Equals(series));
            amiibosInSeries.ForEach(amiibo => Amiibos.Add(amiibo));
        }
    }
}