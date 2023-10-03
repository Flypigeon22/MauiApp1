

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
    
        public MainPage()
        {
            List<fruit> list = new List<fruit>()
            {
            new fruit(){Name="Apple",Image="apple.png",Description="This is an apple"},
            new fruit(){Name="Orange",Image="orange.png",Description="This is an orange"},
            new fruit(){Name="Banana",Image="banana.png",Description="This is a banana"},
            new fruit(){Name="Kiwi",Image="kiwi.png",Description="This is a kiwi"},
            new fruit(){Name="Strawberry",Image="strawberry.png",Description="This is a strawberry"},
            new fruit(){Name="Pineapple",Image="pineapple.png",Description="This is a pineapple"},
            new fruit(){Name="Watermelon",Image="watermelon.png",Description="This is a watermelon"},
            new fruit(){Name="Grapes",Image="grape.png",Description="This is a grapes"},
            };
            InitializeComponent();
            FruitListView.ItemsSource= list;
        }

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var selectedItem = e.SelectedItem as fruit;
            Navigation.PushAsync(new NewPage1(selectedItem.Name, selectedItem.Image, selectedItem.Description));
        }

      
    }
}