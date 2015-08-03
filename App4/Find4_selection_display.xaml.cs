using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Find4
{
    public sealed partial class Find4_selection_display : Page
    {
        Dictionary<string, Type> dict;
        public Find4_selection_display()
        {
            this.InitializeComponent();
            initialize();
        }

        private void initialize()
        {
            dict = new Dictionary<string, Type>();
            dict["Play"] = typeof(Find4Page);
            dict["Instructions"] = typeof(InstructionsPage);
            dict["Credits"] = typeof(CreditsPage);
        }
        
        private  void button_Click(object sender, RoutedEventArgs e)
        {
            But.MediaEnded += (s, en) => Navigate(sender);
            But.Play();
        }

        private void Navigate(object sender)
        {
            Button b = (Button)sender;
            string s = b.Name;
            if (Frame != null)
            {
                Frame.Navigate(dict[s]);
            }
        }
    }
}
