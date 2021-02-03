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
    public partial class Ank2 : ContentPage
    {
        public IList<Pitanja> ListaPitanja3 { get; set; }
        public IList<Pitanja> ListaPitanja4 { get; set; }
        public Ank2()
        {
            InitializeComponent();
            ListaPitanja3 = new List<Pitanja>(); 
            ListaPitanja3.Add(new Pitanja
            {
                Odgovor = "Da"
            });

            ListaPitanja3.Add(new Pitanja
            {
                Odgovor = "Ne"
            });

            ListaPitanja4 = new List<Pitanja>();

            ListaPitanja4.Add(new Pitanja
            {
                Abcd = "Do jedan sat"
            });

            ListaPitanja4.Add(new Pitanja
            {
                Abcd = "Dva sata"
            });

            ListaPitanja4.Add(new Pitanja
            {
                Abcd = "Više od dva sata"
            });

            ListaPitanja4.Add(new Pitanja
            {
                Abcd = "Ne učim"
            });

            BindingContext = this;
        }
        private void OcijeniSlider2_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double StepValue = 1.0;
            var newStep = Math.Round(e.NewValue / StepValue);

            OcijeniSlider2.Value = newStep * StepValue;
        }

        private void d1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (d1.IsChecked == true)
            {
                d2.IsChecked = false;
                d3.IsChecked = false;
                d4.IsChecked = false;
                d5.IsChecked = false;
            }
        }

        private void d2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (d2.IsChecked == true)
            {
                d1.IsChecked = false;
                d3.IsChecked = false;
                d4.IsChecked = false;
                d5.IsChecked = false;
            }
        }

        private void d3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (d3.IsChecked == true)
            {
                d1.IsChecked = false;
                d2.IsChecked = false;
                d4.IsChecked = false;
                d5.IsChecked = false;
            }
        }

        private void d4_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (d4.IsChecked == true)
            {
                d1.IsChecked = false;
                d2.IsChecked = false;
                d3.IsChecked = false;
                d5.IsChecked = false;
            }
        }

        private void d5_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (d5.IsChecked == true)
            {
                d1.IsChecked = false;
                d2.IsChecked = false;
                d3.IsChecked = false;
                d4.IsChecked = false;
            }
        }
        private async void Button2_Clicked(object sender, EventArgs e)
        {
            /*  String PrintAnketa = "";
              Pitanja odg = new Pitanja();
              Pitanja odg2 = new Pitanja();
              if (DaNePicker2.SelectedIndex != -1)
              {
                  odg = (Pitanja)DaNePicker2.SelectedItem;
              }
              if (AbcdPicker2.SelectedIndex != -1)
              {
                  odg2 = (Pitanja)AbcdPicker2.SelectedItem;
              }
              PrintAnketa = PrintAnketa + $"1. Da li ste zadovoljni našom aplikacijom? {odg.Odgovor}\n";
              PrintAnketa = PrintAnketa + $"2. Koliko često koristite našu aplikaciju? {odg2.Abcd}\n";
              PrintAnketa = PrintAnketa + $"3. Ocijenite našu aplikaciju od 1 do 10: {OcijeniSlider2.Value}\n";
              PrintAnketa = PrintAnketa + $"4. Ocijenite izgled aplikacije od 1 do 5: ";
              String check = "";
              if (d1.IsChecked == true)
              {
                  check = "1";
              }
              if (d2.IsChecked == true)
              {
                  check = "2";
              }
              if (d3.IsChecked == true)
              {
                  check = "3";
              }
              if (d4.IsChecked == true)
              {
                  check = "4";
              }
              if (d5.IsChecked == true)
              {
                  check = "5";
              }

              PrintAnketa = PrintAnketa + check;

              String odgov = "\n5. Kako ste pronašli našu aplikaciju? " + EntryOdgovor2.Text;
              PrintAnketa = PrintAnketa + odgov;
              String odgov2 = "\n6. Komentar: " + EditorKomentar2.Text;
              PrintAnketa = PrintAnketa + odgov2;
              await DisplayAlert("Anketa", PrintAnketa, "POTVRDI");*/
            
            if (String.IsNullOrWhiteSpace(EntryOdgovor2.Text) || DaNePicker2.SelectedIndex == -1 || AbcdPicker2.SelectedIndex == -1 || d1.IsChecked == false && d2.IsChecked == false && d3.IsChecked == false && d4.IsChecked == false && d5.IsChecked == false)
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
