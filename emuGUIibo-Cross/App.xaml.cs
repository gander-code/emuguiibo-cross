using Avalonia;
using Avalonia.Markup.Xaml;

namespace emuGUIibo_Cross
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}