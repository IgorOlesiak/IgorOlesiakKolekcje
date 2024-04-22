using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Maui.Controls;
using System.IO;
using System.Threading.Tasks;

namespace IgorOlesiakKolekcje
{
    public partial class AddItemPage : ContentPage
    {
        private Collection selectedCollection;

        public AddItemPage(Collection collection)
        {
            InitializeComponent();
            selectedCollection = collection;
        }

        private async Task SaveItemAsync(string itemName)
        {
            if (!string.IsNullOrWhiteSpace(itemName))
            {
                selectedCollection.Items.Add(itemName);
                await Navigation.PopModalAsync(); // Zapisuje tylko po zakończeniu dodawania
            }
        }

        private async void AddItemButton_Clicked(object sender, EventArgs e)
        {
            string itemName = ItemNameEntry.Text;
            await SaveItemAsync(itemName);
        }
    }
}
