namespace SueldoSemanal19796703
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

		private void Button_Clicked(object sender, EventArgs e)
		{
            if (double.TryParse(Horas.Text, out double tiempo) && double.TryParse(Pago.Text, out double dinero))
            {
                double pago = tiempo * dinero;
                PagoSemanal.Text = $"${pago}";
            }
            else
            {
                DisplayAlert("Error", "No se permiten espacios en blanco ni letras", "Ok");
            }
        }
    }

}
