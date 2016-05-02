using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCheck
{
    public class Clients : INotifyPropertyChanged
    {
        public Clients()
        {
            this.Person = new ObservableCollection<Client>();
            this.Name = "work";

            Client person1 = new Client();
            person1.Name = "Name1";
            person1.SurName = "Surname1";
            person1.Adres = "iets";
            person1.Phone = "4454545646456";
            person1.Email = "iets@email.com";
            this.Person.Add(person1);

            Client person2 = new Client();
            person2.Name = "Name2";
            person2.SurName = "Surname2";
            person2.Adres = "iets2";
            person2.Phone = "452452452";
            person2.Email = "iets2@email.com";
            this.Person.Add(person2);


        }

        public ObservableCollection<Client> Person { get; private set; }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != Name)
                {
                    name = value;
                    INotifyPropertyChanged("Title");
                }

            }
        }



        public void Add(Client item)
        {
            this.Person.Add(item);
        }

        public void Remove(Client item)
        {
            this.Person.Remove(item);
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
