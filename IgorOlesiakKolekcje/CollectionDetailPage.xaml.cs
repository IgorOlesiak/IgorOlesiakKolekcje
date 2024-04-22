using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.Threading.Tasks;

namespace IgorOlesiakKolekcje;


    public partial class CollectionDetailPage : ContentPage
{
    public CollectionDetailPage(Collection collection)
    {
        InitializeComponent();
        Title = "Collection Detail";
        BindingContext = collection;
        ItemsListView.ItemsSource = collection.Items;
    }


}