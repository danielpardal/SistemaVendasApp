using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace SistemaVendas.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Sobre";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("http://35.199.88.198:8080/SistemaVendas")));
        }

        public ICommand OpenWebCommand { get; }
    }
}