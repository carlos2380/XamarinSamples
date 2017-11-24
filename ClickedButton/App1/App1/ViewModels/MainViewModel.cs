using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class MainViewModel : BindableObject
    {
        private string _message;
        private int _counter;
        public ICommand ClicCommand {get{return new Command(ButtonClic); } }
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value; 
                OnPropertyChanged("Message");
            }
        }

        private void ButtonClic()
        {
            _counter++;
            Message = string.Format("Botón pulsado {0} veces!", _counter);
        }
    }
}
