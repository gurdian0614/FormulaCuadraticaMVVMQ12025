using FormulaCuadraticaMVVMQ12025.Views;

namespace FormulaCuadraticaMVVMQ12025
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FormulaCuadraticaView();
        }
    }
}
