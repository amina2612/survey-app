using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LAB2.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ank1 : ContentPage
    {
        public IList<Pitanja> ListaPitanja { get; set; }
        public IList<Pitanja> ListaPitanja2 { get; set; }

        public Ank1()
        {
            InitializeComponent();
            ListaPitanja = new List<Pitanja>();

            
            ListaPitanja.Add(new Pitanja
            {
                Odgovor = "Da"
            });

            ListaPitanja.Add(new Pitanja
            {
                Odgovor = "Ne"
            });

            ListaPitanja2 = new List<Pitanja>();

            ListaPitanja2.Add(new Pitanja
            {
                Abcd = "Jednom mjesečno"
            });

            ListaPitanja2.Add(new Pitanja
            {
                Abcd = "Jednom sedmično"
            });

            ListaPitanja2.Add(new Pitanja
            {
                Abcd = "Jednom dnevno"
            });

            ListaPitanja2.Add(new Pitanja
            {
                Abcd = "Više puta dnevno"
            });

            BindingContext = this;
        }

        private void OcijeniSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double StepValue = 1.0;
            var newStep = Math.Round(e.NewValue / StepValue);

            OcijeniSlider.Value = newStep * StepValue;
        }

        private void c1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (c1.IsChecked == true)
            {
                c2.IsChecked = false;
                c3.IsChecked = false;
                c4.IsChecked = false;
                c5.IsChecked = false;
            }
        }

        private void c2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (c2.IsChecked == true)
            {
                c1.IsChecked = false;
                c3.IsChecked = false;
                c4.IsChecked = false;
                c5.IsChecked = false;
            }
        }

        private void c3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (c3.IsChecked == true)
            {
                c1.IsChecked = false;
                c2.IsChecked = false;
                c4.IsChecked = false;
                c5.IsChecked = false;
            }
        }

        private void c4_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (c4.IsChecked == true)
            {
                c1.IsChecked = false;
                c2.IsChecked = false;
                c3.IsChecked = false;
                c5.IsChecked = false;
            }
        }

        private void c5_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (c5.IsChecked == true)
            {
                c1.IsChecked = false;
                c2.IsChecked = false;
                c3.IsChecked = false;
                c4.IsChecked = false;
            }
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (DaNePicker.SelectedIndex==-1 || AbcdPicker.SelectedIndex==-1 || c1.IsChecked==false && c2.IsChecked==false && c3.IsChecked==false && c4.IsChecked==false && c5.IsChecked==false)
            {
                await DisplayAlert("Anketa", "Niste ispunili sva polja!", "OK");
            }
            else {
                await Navigation.PopAsync();
            }
        }
    }
}
