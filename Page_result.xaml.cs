namespace Exercise_1_2;

public partial class Page_result : ContentPage
{
	public Page_result()
	{
		InitializeComponent();

		txt_result.Text="Tu usuario con nombre: "+Employee.get_name()+" "+Employee.get_surnames()+", correo: "+Employee.get_email()+" y fecha de nacimiento: "+Employee.get_birth_date()+" se ha creado con exito";
	}
}