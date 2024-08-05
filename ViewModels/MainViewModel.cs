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
using TrainStationTestApp.Data;


namespace TrainStationTestApp.ViewModels;

public class MainViewModel : ViewModel
{
    private readonly ILinesRepository linesRepository;
    public ObservableCollection<Segment> Lines { get; } = new ObservableCollection<Segment>();

    public ICommand LeftMouseDowned { get; set; }
    public ICommand MouseOverCommand { get; set; }
    public ICommand MouseLeaveCommand { get; set; }

    public MainViewModel(ILinesRepository linesRepository) {
        LeftMouseDowned = new RelayCommand<object>(_ => AnotherMethod(_));
        MouseOverCommand = new RelayCommand<object>(_ => MouseOverOn(_));
        MouseLeaveCommand = new RelayCommand<object>(_ => MouseOverOff(_));

        this.linesRepository = linesRepository;
        GetData();
    }

    public void AnotherMethod(object shapeParam)
    {

    }

    public void MouseOverOn(object e)
    {
        if (e is Segment currentSegment) 
        {

            foreach (var line in Lines){
                if (line.GroupId == currentSegment.GroupId) 
                {
                    line.IsSelectedSegment = true;
                }
            }
            
            ToolTipText = $"Парк: {currentSegment.GroupId}";
            IsToolTipOpen = true;
        }
        //TODO: добавление заливки
    }      

    public void MouseOverOff(object e)
    {
        if (e is Segment currentSegment) 
        {
            foreach (var line in Lines) {
                if (line.GroupId == currentSegment.GroupId) 
                {
                    line.IsSelectedSegment = false;
                }
            }
        }
        IsToolTipOpen = false;
    }

    private void GetData() {
        var allLines = linesRepository.GetAllLines();
        foreach (var line in allLines) {
            Lines.Add(new Segment(line.LineSegment, line.GroupId));
        }
    }

    private string toolTipText;
    public string ToolTipText {
        get => toolTipText;
        set {
            toolTipText= value;
            OnPropertyChanged();
        }
    }

    private bool isToolTipOpen;
    public bool IsToolTipOpen {
        get => isToolTipOpen;
        set {
            isToolTipOpen = value;
            OnPropertyChanged();
        }
    }   
}
