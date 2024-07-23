namespace MauiWebViewSpaceBug
{
    public partial class MainPage : ContentPage
    {
        string currentUrl;
        
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void sendQuery_Clicked(object sender, EventArgs e)
        {
            bugTestWebView.Source = "https://example.com/?q=" + query.Text;
        }
    }

}
