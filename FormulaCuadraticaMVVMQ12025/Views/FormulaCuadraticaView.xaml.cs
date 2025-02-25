using FormulaCuadraticaMVVMQ12025.ViewModels;

namespace FormulaCuadraticaMVVMQ12025.Views;

public partial class FormulaCuadraticaView : ContentPage
{
	FormulaCuadraticaViewModel viewModel;
	public FormulaCuadraticaView()
	{
		InitializeComponent();
		viewModel = new FormulaCuadraticaViewModel();
		BindingContext = viewModel;
	}
}