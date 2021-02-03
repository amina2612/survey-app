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
    public partial class Ank3 : ContentPage
    {
        public IList<Pitanja> ListaPitanja5 { get; set; }
        public IList<Pitanja> ListaPitanja6 { get; set; }
        public Ank3()
        {
            InitializeComponent();
            ListaPitanja5 = new List<Pitanja>();
            ListaPitanja5.Add(new Pitanja
            {
                Odgovor = "Da"
            });

            ListaPitanja5.Add(new Pitanja
            {
                Odgovor = "Ne"
            });

            ListaPitanja6 = new List<Pitanja>();

            ListaPitanja6.Add(new Pitanja
            {
                Abcd = "Svaki dan"
            });

            ListaPitanja6.Add(new Pitanja
            {
                Abcd = "Gotovo svaki dan"
            });

            ListaPitanja6.Add(new Pitanja
            {
                Abcd = "Skoro nikada"
            });

            ListaPitanja6.Add(new Pitanja
            {
                Abcd = "Nikada"
            });

            BindingContext = this;
        }
        private void OcijeniSlider3_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double StepValue = 1.0;
            var newStep = Math.Round(e.NewValue / StepValue);

            OcijeniSlider3.Value = newStep * StepValue;
        }

        private void e1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e1.IsChecked == true)
            {
                e2.IsChecked = false;
                e3.IsChecked = false;
                e4.IsChecked = false;
                e5.IsChecked = false;
            }
        }

        private void e2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e2.IsChecked == true)
            {
               e1.IsChecked = false;
                e3.IsChecked = false;
                e4.IsChecked = false;
                e5.IsChecked = false;
            }
        }

        private void e3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e3.IsChecked == true)
            {
                e1.IsChecked = false;
                e2.IsChecked = false;
                e4.IsChecked = false;
                e5.IsChecked = false;
            }
        }

        private void e4_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e4.IsChecked == true)
            {
               e1.IsChecked = false;
                e2.IsChecked = false;
                e3.IsChecked = false;
                e5.IsChecked = false;
            }
        }

        private void e5_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e5.IsChecked == true)
            {
                e1.IsChecked = false;
                e2.IsChecked = false;
                e3.IsChecked = false;
                e4.IsChecked = false;
            }
        }

        private async void Button3_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(EntryOdgovor3.Text) || DaNePicker3.SelectedIndex == -1 || AbcdPicker3.SelectedIndex == -1 || e1.IsChecked == false && e2.IsChecked == false && e3.IsChecked == false && e4.IsChecked == false && e5.IsChecked == false)
            {
                await DisplayAlert("Anketa", "Niste ispunili sva polja!", "OK");
            }
            else
            {
                await Navigation.PopAsync();
            }
        }
    }
}