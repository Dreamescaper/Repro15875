namespace Repro
{
    public partial class NavPage : ContentPage
    {
        public NavPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}