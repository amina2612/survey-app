using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB2.Models;
using Xamarin.Forms;

namespace LAB2
{
    public partial class MainPage : ContentPage
    {
        public IList<Anketa> ListaAnketa { get; set; }
        public int vrijednost = 0;
        public MainPage()
        {
            InitializeComponent();
            ListaAnketa = new List<Anketa>();
            
            ListaAnketa.Add(new Anketa
            {
                Naziv = "Prva anketa",
                Status = "Neispunjena"
            });

            ListaAnketa.Add(new Anketa
            {
                Naziv = "Druga anketa",
                Status = "Neispunjena"
            });

            ListaAnketa.Add(new Anketa
            {
                Naziv = "Treća anketa",
                Status = "Neispunjena"
            });

            ListaAnketa.Add(new Anketa
            {
                Naziv = "Četvrta anketa",
                Status = "Neispunjena"
            });

            BindingContext = this;
        }


        private void Frame1Tap(object sender, EventArgs e)
        {
            LabelaDatum.IsVisible = false;
            if (Okvir1.BackgroundColor == Color.LightGray) { 
                Okvir1.BackgroundColor = Color.DarkGray;
                Okvir2.BackgroundColor = Color.LightGray;
                Okvir3.BackgroundColor = Color.LightGray;
                Okvir4.BackgroundColor = Color.LightGray;
                Dugme.IsVisible = true;
                vrijednost = 1;
                Labela.IsVisible = true;
                Labela.Text = "Status: " + ListaAnketa[0].Status;
                if (ListaAnketa[0].Status == "Ispunjena")
                {
                    LabelaDatum.IsVisible = true;
                    LabelaDatum.Text = "Datum: " + ListaAnketa[0].Datum.ToShortDateString();
                }
            }
            else
            {
                Okvir1.BackgroundColor = Color.LightGray;
                Dugme.IsVisible = false;
                Labela.IsVisible = false;
                LabelaDatum.IsVisible = false;
            }
            
        }

        private void Frame2Tap(object sender, EventArgs e)
        {
            LabelaDatum.IsVisible = false;
            if (Okvir2.BackgroundColor == Color.LightGray)
            {
                Okvir2.BackgroundColor = Color.DarkGray;
                Okvir1.BackgroundColor = Color.LightGray;
                Okvir3.BackgroundColor = Color.LightGray;
                Okvir4.BackgroundColor = Color.LightGray;
                Dugme.IsVisible = true;
                vrijednost = 2; 
                Labela.IsVisible = true;
                Labela.Text = "Status: " + ListaAnketa[1].Status;
                if (ListaAnketa[1].Status == "Ispunjena")
                {
                    LabelaDatum.IsVisible = true;
                    LabelaDatum.Text = "Datum: " + ListaAnketa[1].Datum.ToShortDateString();
                }
            }
            else
            {
                Okvir2.BackgroundColor = Color.LightGray;
                Dugme.IsVisible = false;
                Labela.IsVisible = false;
                LabelaDatum.IsVisible = false;
            }

            
        }

        private void Frame3Tap(object sender, EventArgs e)
        {
            LabelaDatum.IsVisible = false;
            if (Okvir3.BackgroundColor == Color.LightGray)
            {
                Okvir3.BackgroundColor = Color.DarkGray;
                Okvir2.BackgroundColor = Color.LightGray;
                Okvir1.BackgroundColor = Color.LightGray;
                Okvir4.BackgroundColor = Color.LightGray;
                Dugme.IsVisible = true;
                vrijednost = 3;
                Labela.IsVisible = true;
                Labela.Text = "Status: " + ListaAnketa[2].Status;
                if (ListaAnketa[2].Status == "Ispunjena")
                {
                    LabelaDatum.IsVisible = true;

                    LabelaDatum.Text = "Datum: " + ListaAnketa[2].Datum.ToShortDateString();
                }
            }
            else
            {
                Okvir3.BackgroundColor = Color.LightGray;
                Dugme.IsVisible = false;
                Labela.IsVisible = false;
                LabelaDatum.IsVisible = false;
            }

           
        }

        private void Frame4Tap(object sender, EventArgs e)
        {
            LabelaDatum.IsVisible = false;
            if (Okvir4.BackgroundColor == Color.LightGray)
            {
                Okvir4.BackgroundColor = Color.DarkGray;
                Okvir2.BackgroundColor = Color.LightGray;
                Okvir3.BackgroundColor = Color.LightGray;
                Okvir1.BackgroundColor = Color.LightGray;
                Dugme.IsVisible = true;
                vrijednost = 4;
                Labela.IsVisible = true;
                Labela.Text = "Status: " + ListaAnketa[3].Status;
                if (ListaAnketa[3].Status == "Ispunjena")
                {
                    LabelaDatum.IsVisible = true;
                    LabelaDatum.Text = "Datum: " + ListaAnketa[3].Datum.ToShortDateString();
                }
            }
            else
            {
                Okvir4.BackgroundColor = Color.LightGray;
                Dugme.IsVisible = false;
                Labela.IsVisible = false;
                LabelaDatum.IsVisible = false;

            }
           
        }

        private async void DugmeClicked(object sender, EventArgs e)
        {
            if (vrijednost == 1)
            {
                await Navigation.PushAsync(new Ank1());
                ListaAnketa[0].Status = "Ispunjena";
                ListaAnketa[0].Datum = DateTime.Now;
            }
            else if (vrijednost == 2)
            {
                await Navigation.PushAsync(new Ank2());
                ListaAnketa[1].Status = "Ispunjena";
                ListaAnketa[1].Datum = DateTime.Now;
            }
            else if (vrijednost == 3)
            {
                await Navigation.PushAsync(new Ank3());

                ListaAnketa[2].Status = "Ispunjena";
                ListaAnketa[2].Datum = DateTime.Now;
            }
            else if (vrijednost == 4)
            {
                await Navigation.PushAsync(new Ank4());
                ListaAnketa[3].Status = "Ispunjena";
                ListaAnketa[3].Datum = DateTime.Now;
            }
        }
    }
}
