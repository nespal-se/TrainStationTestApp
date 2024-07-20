using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using TrainStationTestApp.Commands;
using TrainStationTestApp.Models;

namespace TrainStationTestApp.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Segment> Lines { get; } = new ObservableCollection<Segment>();
        public RelayCommand LeftMouseDowned { get; set; }

        public MainViewModel()
        {
            LeftMouseDowned = new RelayCommand(_ => TestMethod(_));

        }

        public void TestMethod(object _)
        {

        }
    }
}
