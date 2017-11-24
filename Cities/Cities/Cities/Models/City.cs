using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cities.Models
{
    public class City
    {
        public string Nombre { get; set; }
        public string Descripcion {get; set;}
        public ImageSource Imagen { get;  set;}
    }
}
