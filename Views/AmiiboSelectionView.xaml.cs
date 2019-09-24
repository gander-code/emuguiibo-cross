using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace emuGUIibo_Cross.Views
{
    public class AmiiboSelectionView : UserControl
    {
        public AmiiboSelectionView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}