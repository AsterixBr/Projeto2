using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            StackLayout stk = new StackLayout()
            {
                Orientation = StackOrientation.Vertical
            };
            Label lb1 = new Label()
            {
                Text = "Curso Xamarin 2.0",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                BackgroundColor = Color.Black,
                Padding = new Thickness(10),
            }
        }
    }
}