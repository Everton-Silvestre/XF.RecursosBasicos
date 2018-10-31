using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.ControlesBasicos
{
    public partial class MainPage : ContentPage
    {
        Email emailModel;

        public MainPage()
        {
            InitializeComponent();

            if (emailModel == null) emailModel = new Email();

        }               

        private void Enviar_Clicked(object sender, EventArgs e)
        {
            if ((emailModel.Permissao) && (!string.IsNullOrEmpty(emailModel.ContaEmail)))
                DisplayAlert("Mensagem", $"Envio feito para {emailModel.ContaEmail} ","OK");
            else
                DisplayAlert("Mensagem","Envio não permitido","OK");

        }

        private void Configuracao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConfigPage() { BindingContext = emailModel } );
        }
    }
}
