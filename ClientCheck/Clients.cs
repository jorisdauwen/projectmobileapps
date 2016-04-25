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
            this.Items = new ObservableCollection<Client>();
            this.Name = "work";

            Client person1 = new Client();
            person1.Name = "Name1";
            person1.Surname = "Surname1";
            this.Items.Add(person1);

            Client person2 = new Client();
            person2.Name = "Name2";
            person2.Surname = "Surname2";
            this.Items.Add(person2);


        }

        public ObservableCollection<Client> Items { get; private set; }

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
            this.Items.Add(item);
        }

        public void Remove(Client item)
        {
            this.Items.Remove(item);
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
