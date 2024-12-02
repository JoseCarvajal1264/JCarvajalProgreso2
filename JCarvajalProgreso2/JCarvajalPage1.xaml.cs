using Android.Content.Res;
using JCarvajalProgreso2.Models;
using JCarvajalProgreso2.Repositories;
using JCarvajalProgreso2.Interfaces;


namespace JCarvajalProgreso2;

public partial class JCarvajalPage1 : ContentPage
{
	public JCarvajalPage1()
	{
        IRecargaRepos _recargaRepo;
        JCarvajalDatos recarga = new JCarvajalDatos();

        public JCarvajalPage1()
        {
            _recargaRepo = new RecargaRepo();
            InitializeComponent();

            recarga = _recargaRepo.DevuelveRecarga(1);
            BindingContext = recarga;
        }

        public async void GuardarRecarga_Clicked(object sender, EventArgs e)
        {
            JCarvajalDatos recarga = new JCarvajalDatos
            {
                Nombre = "José Luis Verstappen Carvajal tu papá",
                Numero = 0979363672,
            };
            bool guardar_recarga = _recargaRepo.CrearEstudianteUdla(recarga);

            if (guardar_recarga)
            {
                await DisplayAlert("Alerta", "Todo Bien", "OK");
                Navigation.PushAsync(new JCarvajalPage1);
            }
            else
            {
                await DisplayAlert("Alerta", "Negado mi pana", "OK");
            }
        }
    }
}