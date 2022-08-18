using System;
using Xamarin.Forms;

namespace AppQuantidade
{
    public partial class MainPage : ContentPage
    {
        int Quantidade = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Aumentar(object sender, EventArgs e)
        {
            Quantidade++;
            LblQtd.Text = Quantidade.ToString();
        }

        private void Diminuir(object sender, EventArgs e)
        {
            if (Quantidade != 0)
            {
                Quantidade--;
                LblQtd.Text = Quantidade.ToString();
            }
        }
    }
}
