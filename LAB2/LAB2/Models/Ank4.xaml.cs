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
    public partial class Ank4 : ContentPage
    {
        public IList<Pitanja> ListaPitanja7 { get; set; }
        public IList<Pitanja> ListaPitanja8 { get; set; }
        public Ank4()
        {
            InitializeComponent();
            ListaPitanja7 = new List<Pitanja>();
            ListaPitanja7.Add(new Pitanja
            {
                Odgovor = "Da"
            });

            ListaPitanja7.Add(new Pitanja
            {
                Odgovor = "Ne"
            });

            ListaPitanja8 = new List<Pitanja>();

            ListaPitanja8.Add(new Pitanja
            {
                Abcd = "U posljednjih mjesec dana"
            });

            ListaPitanja8.Add(new Pitanja
            {
                Abcd = "Prije nekoliko mjeseci"
            });

            ListaPitanja8.Add(new Pitanja
            {
                Abcd = "Prošle godine"
            });

            ListaPitanja8.Add(new Pitanja
            {
                Abcd = "Nikada"
            });

            BindingContext = this;
        }
        private void OcijeniSlider4_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double StepValue = 1.0;
            var newStep = Math.Round(e.NewValue / StepValue);

            OcijeniSlider4.Value = newStep * StepValue;
        }

        private void f1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (f1.IsChecked == true)
            {
                f2.IsChecked = false;
                f3.IsChecked = false;
                f4.IsChecked = false;
                f5.IsChecked = false;
            }
        }

        private void f2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (f2.IsChecked == true)
            {
                f1.IsChecked = false;
                f3.IsChecked = false;
                f4.IsChecked = false;
                f5.IsChecked = false;
            }
        }

        private void f3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (f3.IsChecked == true)
            {
                f1.IsChecked = false;
                f2.IsChecked = false;
                f4.IsChecked = false;
                f5.IsChecked = false;
            }
        }

        private void f4_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (f4.IsChecked == true)
            {
                f1.IsChecked = false;
                f2.IsChecked = false;
                f3.IsChecked = false;
                f5.IsChecked = false;
            }
        }

        private void f5_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (f5.IsChecked == true)
            {
                f1.IsChecked = false;
                f2.IsChecked = false;
                f3.IsChecked = false;
                f4.IsChecked = false;
            }
        }

        private async void Button4_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(EntryOdgovor4.Text) || DaNePicker4.SelectedIndex == -1 || AbcdPicker4.SelectedIndex == -1 || f1.IsChecked == false && f2.IsChecked == false && f3.IsChecked == false && f4.IsChecked == false && f5.IsChecked == false)
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