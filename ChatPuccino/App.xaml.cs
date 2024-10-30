using ChatPuccino.Views;

namespace ChatPuccino
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LandingPage();
        }
    }
}
