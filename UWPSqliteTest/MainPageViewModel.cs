
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSqliteTest
{
    public class MainPageViewModel : ViewModelBase
    {

        private ObservableCollection<Item> _list;
        public ObservableCollection<Item> List
        {
            get
            {
                return _list;
            }
            set
            {
                _list = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            _list = new ObservableCollection<Item>
            {
                new Item{ Name="Nico",Description="developer"},
                new Item{ Name="Nico",Description="developer"},
                new Item{ Name="Nico",Description="developer"},
                new Item{ Name="Nico",Description="developer"},
            };
            DBManager manager = DBManager.Instance;
            manager.Init<Item>();
            manager.InsertSqlite<Item>(new Item { Name="zhu",Description= "developer" });
           var items =  manager.GetTableValue<Item>();

            foreach(var tem in items)
            {
                _list.Add(tem);
            }
            
        }
    }
}
