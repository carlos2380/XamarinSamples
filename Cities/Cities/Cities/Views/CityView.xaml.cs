using Cities.Models;
using Cities.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cities.Views
{
    public partial class CityView : ContentPage
    {
        public CityView(City city)
        {
            InitializeComponent();
            BindingContext = new CityViewModel(city);
        }
    }
}
