

namespace MauiApp1 { 

   public partial class NewPage1 : ContentPage
   {
    public NewPage1(String Name, String Image , String Description)
    {
        InitializeComponent();
           showImage.Source=Image;
           showName.Text = Name;
           showDescription.Text = Description;

    }
   }
}
