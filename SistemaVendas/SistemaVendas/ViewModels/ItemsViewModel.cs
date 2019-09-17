using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using SistemaVendas.Models;
using SistemaVendas.Views;

namespace SistemaVendas.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Empresa> Empresas { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Empresa";
            Empresas = new ObservableCollection<Empresa>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            /*MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Item;
                Items.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });*/
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Empresas.Clear();
                var empresas = await Api.Empresa.GetAsync();
                foreach (var empresa in empresas)
                {
                    Empresas.Add(empresa);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}