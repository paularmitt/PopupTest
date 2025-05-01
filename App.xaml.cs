namespace PopupTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var nav=new NavigationPage(new MainPage());
            //nav.Background=new SolidColorBrush(Colors.Black.WithAlpha(0.7f));
            nav.BackgroundColor = Colors.Transparent;
            return new Window(nav);
            //return new Window(new AppShell());
        }
    }
}