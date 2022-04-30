using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeesPro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage1 : TabbedPage
    {
        public HomePage1()
        {
            InitializeComponent();
        }
        
        private void ToolbarItem_Cliked(object sender, EventArgs e) 
        {
            Navigation.PushAsync(new NavigationPage());
        }
    }
}