using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace MVVM
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Car selectedCars;

        public ObservableCollection<Car> Phones { get; set; }
        public Car SelectedPhone
        {
            get { return selectedCars; }
            set
            {
                selectedCars = value;
                OnPropertyChanged("SelectedPhone");
            }
        }

        public ApplicationViewModel()
        {
            Phones = new ObservableCollection<Car>
            {
                new Car { Title="2017 CHEVROLET VOLT PREMIER", Company="CHEVROLET", Price=17000 },
                new Car {Title="2017 FORD EDGE SEL", Company="FORD", Price =15000 },
                new Car {Title="2019 SUBARU OUTBACK 2.5I PREMIUM", Company="SUBARU", Price=19000 },
                new Car {Title="2017 BMW X1 XDRIVE28I", Company="BMW", Price=19000 }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}