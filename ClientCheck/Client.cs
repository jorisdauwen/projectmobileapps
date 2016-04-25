using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCheck
{
    public class Client : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != Name)
                {
                    name = value;
                    INotifyPropertyChanged("Name");

                }


            }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set
            {
                if (value != Surname)
                {
                    surname = value;
                    INotifyPropertyChanged("Surname");

                }


            }
        }

        private string adres;

        public string Adres
        {
            get { return adres; }
            set
            {
                if (value != Adres)
                {
                    adres = value;
                    INotifyPropertyChanged("Adres");

                }


            }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set
            {
                if (value != Phone)
                {
                    phone = value;
                    INotifyPropertyChanged("Phone");

                }


            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                if (value != Email)
                {
                    email = value;
                    INotifyPropertyChanged("Email");

                }


            }
        }





        public event PropertyChangedEventHandler PropertyChanged;


        private void INotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }


        }
    
    }
}
