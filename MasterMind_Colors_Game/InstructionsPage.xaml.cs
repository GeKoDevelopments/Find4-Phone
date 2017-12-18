using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MasterMind_Colors_Game
{
    public sealed partial class InstructionsPage : Page
    {
        public InstructionsPage()
        {
            this.InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.GoBack();
            }
        }
    }
}
