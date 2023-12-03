using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportKursach.Models
{
    public class Competition : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Kind { get; set; }
        public int Members { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
