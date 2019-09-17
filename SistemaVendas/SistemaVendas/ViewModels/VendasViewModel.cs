using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using SistemaVendas.Models;
using Xamarin.Forms;

namespace SistemaVendas.ViewModels
{
    public class VendasViewModel : BaseViewModel
    {
        public ObservableCollection<Vendas> Vendas { get; set; }
        public Command LoadItemsCommand { get; set; }

        public VendasViewModel()
        {
            Title = "Vendas";
            Vendas = new ObservableCollection<Vendas>();
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
                Vendas.Clear();
                var vendas = await Api.Vendas.GetAsync();
                foreach (var venda in vendas)
                {
                    Vendas.Add(venda);
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
