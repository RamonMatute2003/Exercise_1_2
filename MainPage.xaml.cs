using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using System.Text.RegularExpressions;

namespace Exercise_1_2 {
    public partial class MainPage:ContentPage {
        public MainPage() {
            InitializeComponent();

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific.Entry),(handler,view) =>
            {
                #if ANDROID
                            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
                #endif
            });
        }

        private void add(object sender,EventArgs e) {//add=añadir
            if(validations()){
                Employee employee=new Employee();
                employee.set_name(txt_names.Text);
                employee.set_surnames(txt_surnames.Text);
                employee.set_email(txt_email.Text);
                employee.set_birth_date(birth_date.Date.Year+"/"+birth_date.Date.Month+"/"+birth_date.Date.Day);
                Navigation.PushAsync(new Page_result());
            }
        }

        private bool validations(){//validations=validaciones
            var name_surname=new Regex(@"^([A-Za-z]+)(?:\s[A-Za-z]+)?(?:\s[A-Za-z]+)?$");
            var email=new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            if(string.IsNullOrWhiteSpace(txt_names.Text) || string.IsNullOrWhiteSpace(txt_surnames.Text) || string.IsNullOrWhiteSpace(txt_email.Text)){
                DisplayAlert("Advertencia","No dejar campos vacios","OK");
                return false;
            }

            if(!name_surname.IsMatch(txt_names.Text)) {
                DisplayAlert("Advertencia","Revisa bien los nombres que ingresastes","OK");
                return false;
            }

            if(!name_surname.IsMatch(txt_surnames.Text)) {
                DisplayAlert("Advertencia","Revisa bien los apellidos que ingresastes","OK");
                return false;
            }

            if(!email.IsMatch(txt_email.Text)) {
                DisplayAlert("Advertencia","Revisa bien el correo electronico que ingresaste","OK");
                return false;
            }

            if(Convert.ToUInt16(birth_date.Date.Year)>2010){
                DisplayAlert("Advertencia","Revisa bien la fecha que ingresaste (Solo se permite de que haya nacido en el 2010 o antes)","OK");
                return false;
            }

            return true;
        }
    }
}
