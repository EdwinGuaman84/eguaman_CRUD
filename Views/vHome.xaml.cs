using eguaman_CRUD.Modelos;

namespace eguaman_CRUD.Views;

public partial class vHome : ContentPage
{
	public vHome()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void btnObtener_Clicked(object sender, EventArgs e)
    {
        statusMessage.Text = "";
        List<Persona> people= App.personRepo.GetAllPeople();

        var personas = App.personRepo.GetAllPeople(); // Llama al método que tú ya tienes
        listaPersona.ItemsSource = personas; // Asigna la lista a la vista



        // listaPersona.ItemsSource = people;
    }

    private void btnAgregar_Clicked(object sender, EventArgs e)
    {
        statusMessage.Text = "";
        App.personRepo.AddNewPerson(txtNombre.Text);
        statusMessage.Text = App.personRepo.StatusMessage;

    }
}