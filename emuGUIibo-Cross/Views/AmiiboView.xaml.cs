using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace emuGUIibo_Cross.Views
{
    public class AmiiboView : UserControl
    {
        public AmiiboView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}