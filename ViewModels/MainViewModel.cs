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
using System.Windows.Controls;
using System.Windows.Input;
using TrainStationTestApp.ViewModels.Base;
using System.Globalization;
using System.Windows.Data;

namespace TrainStationTestApp.ViewModels;

public class MainViewModel : ViewModel
{
    public ObservableCollection<Segment> Lines { get; } = new ObservableCollection<Segment>();
    public ICommand LeftMouseDowned { get; set; }
    public ICommand MouseOverCommand { get; set; }
    public ICommand MouseLeaveCommand { get; set; }

    public MainViewModel()
    {
        LeftMouseDowned = new RelayCommand<object>(_ => TestMethod(_));
        MouseOverCommand = new RelayCommand<object>(_ => MouseOverOn(_));
        MouseLeaveCommand = new RelayCommand<object>(_ => MouseOverOff(_));
    }

    public void TestMethod(object shapeParam)
    {
        throw new NotImplementedException();
    }

    public void MouseOverOn(object e)
    {
        if (e is Segment currentSegment) 
        {
            foreach (var line in Lines) 
            {
                if (line.GroupId == currentSegment.GroupId) 
                {
                    line.IsSelectedSegment = true;
                }
            }
        }

    }      

    public void MouseOverOff(object e)
    {
        if (e is Segment currentSegment) 
        {
            foreach (var line in Lines) 
            {
                if (line.GroupId == currentSegment.GroupId) 
                {
                    line.IsSelectedSegment = false;
                }
            }
        }
    }

}
