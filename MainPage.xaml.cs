using System.ComponentModel;
using System.Windows.Input;


namespace Hillel_Lesson27_HW_4;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}
