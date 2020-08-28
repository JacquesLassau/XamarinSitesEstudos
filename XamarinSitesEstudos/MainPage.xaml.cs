using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace XamarinSitesEstudos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnTapGestureRecognizerTapped_InstitutoTim(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://cursos.timtec.com.br/courses");            
        }

        public void OnTapGestureRecognizerTapped_CodeCademy(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://www.codecademy.com/");
        }

        public void OnTapGestureRecognizerTapped_Udacity(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://br.udacity.com/course/java-programming-basics--ud282");
        }

        public void OnTapGestureRecognizerTapped_Udemy(object sender, EventArgs e)
        {
            Launcher.OpenAsync("https://www.udemy.com/pt/courses/free/");
        }
    }
}
