

namespace MauiApp1 { 

   public partial class NewPage1 : ContentPage
   {
    public NewPage1(String Name, Image Image , String Description)
    {
        InitializeComponent();
           showImage.=Image;
           showName.Text = Name;
           showDescription.Text = Description;

    }
   }
}