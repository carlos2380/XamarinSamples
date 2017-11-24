using Cities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Cities.ModelViews
{
    public class CityViewModel : BindableObject
    {
        private string _nombre;
        private string _descripcion;
        private ImageSource _imagen;
        public CityViewModel(City city)
        {
            _nombre = city.Nombre;
            _descripcion = city.Descripcion;
            _imagen = city.Imagen;


        }

        public string Descripcion

        {

            get { return _descripcion; }



        }

        public string Nombre

        {

            get { return _nombre; }

        }

        public ImageSource Imagen

        {

            get { return _imagen; }

        }
    }
}
