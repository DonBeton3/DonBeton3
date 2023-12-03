using SportKursach.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportKursach.ViewModels
{
    public class CompetitionViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Competition> _yourListOfCompetitions;
        private Competition selectedCompetition;
        public Competition SelectedCompetition
        {
            get { return selectedCompetition; }
            set { selectedCompetition = value; OnPropertyChanged("SelectedCompetition"); }
        }

        public ObservableCollection<Competition> YourListOfCompetitions
        {
            get { return _yourListOfCompetitions; }
            set
            {
                if (_yourListOfCompetitions != value)
                {
                    _yourListOfCompetitions = value;
                    OnPropertyChanged(nameof(YourListOfCompetitions));
                }
            }
        }

        public CompetitionViewModel()
        {
            YourListOfCompetitions = new ObservableCollection<Competition>
        {
            new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
             new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
             new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
             new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
             new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
             new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
            new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
             new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
             new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
             new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
             new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
             new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 165, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
              new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
             new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
            new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },
             new Competition { Name = "Шаховий турнір", Kind = "Шахи", Members = 55, Place = "Київ, центр", Date = DateTime.Now },
            new Competition { Name = "Шашковий перепал", Kind = "Шашки", Members = 15, Place = "Кременчук", Date = DateTime.Now.AddDays(7) },

        };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
