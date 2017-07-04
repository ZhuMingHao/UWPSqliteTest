using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UWPSqliteTest
{
    [DataContract]
    public class Item : ViewModelBase
    {
        private string _name;
        private string _description;

        [PrimaryKey]

        public int ID { get; set; }

        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(); } }
        public string Description { get { return _description; } set { _description = value; OnPropertyChanged(); } }

    }
}
