using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cities.Models;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Cities.Views;

namespace Cities.ModelViews
{
    class MainModelView : BindableObject
    {
        public ObservableCollection<City> Cities { get; set; }
        public City _selectedCity;
        

        public MainModelView()
        {
         
            Cities = new ObservableCollection<City>
            {
                new City
                {
                    Nombre = "New York",
                    Descripcion = "Seattle es la ciudad más grande del Estado de Washington, en el noroeste de los Estados Unidos de América. El área metropolitana de la ciudad comprende Seattle-Tacoma-Bellevue, es la 15.ª más poblada del país y la mayor del Noroeste del Pacífico.",
                    Imagen = ImageSource.FromResource("Cities.Resources.NewYork.png")
                },
                new City
                {
                    Nombre = "Paris",
                    Descripcion = "París es la capital de Francia y de la región de Isla de Francia. Constituida en la única comuna unidepartamental del país, está situada a ambos márgenes de un largo meandro del río Sena, en el centro de la Cuenca parisina, entre la confluencia del río Marne y el Sena.",
                    Imagen = ImageSource.FromResource("Cities.Resources.Paris.png")
                },
                new City
                {
                    Nombre = "Roma",
                    Descripcion = "Roma es una ciudad y capital italiana, capital de la Ciudad metropolitana de Roma Capital, de la región del Lacio y de Italia. Es el municipio más poblado de Italia y es la cuarta ciudad más poblada de la Unión Europea. Por antonomasia se la conoce como la Ciudad Eterna, l'Urbe (‘la Ciudad’) o Città Eterna.",
                    Imagen = ImageSource.FromResource("Cities.Resources.Roma.png")
                },
                new City
                {
                    Nombre = "Sevilla",
                    Descripcion = "Sevilla es un municipio y ciudad española, capital de la provincia homónima y de la comunidad autónoma de Andalucía. Cuenta con 702.355 habitantes, siendo la ciudad más poblada de Andalucía, la cuarta de España después de Madrid, Barcelona y Valencia.",
                    Imagen = ImageSource.FromResource("Cities.Resources.Sevilla.png")
                }
            };
        }
        public City SelectedCity
        {
            get { return _selectedCity; }
            set
            {
                if (_selectedCity != value)

                {

                    _selectedCity = value;

                    OnPropertyChanged("SelectedCity");
                    openCityView();



                }
            }
        }

        private async  void openCityView()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CityView(_selectedCity));
        }
        
    }
}
