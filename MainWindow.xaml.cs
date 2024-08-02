using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TrainStationTestApp.ViewModels;
using TrainStationTestApp.ViewModels.Base;
using TrainStationTestApp.Models;

namespace TrainStationTestApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private MainViewModel ViewModel { get; } = new MainViewModel();

    public MainWindow()
    {
        InitializeComponent();
        InitData();

        DataContext = ViewModel;
    }

    private void InitData()
    {
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(200, 200), new Point(600, 200)), 1));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(600, 200), new Point(700, 200)), 5));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(700, 200), new Point(900, 300)), 5));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(200, 250), new Point(600, 250)), 1));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(600, 250), new Point(800, 250)), 5));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(50, 300), new Point(150, 300)), 5));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(150, 300), new Point(700, 300)), 2));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(700, 300), new Point(900, 300)), 5));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(50, 350), new Point(180, 350)), 4));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(180, 350), new Point(550, 350)), 3));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(550, 350), new Point(800, 350)), 6));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(800, 350), new Point(900, 350)), 7));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(130, 400), new Point(560, 400)), 1));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(250, 400), new Point(560, 400)), 6));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(100, 375), new Point(130, 400)), 4));
        ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(50, 375), new Point(100, 375)), 4));


        //ViewModel.Lines.Add(new Segment(new Line { X1 = 50, Y1 = 375, X2 = 100, Y2 = 375,
        //    Stroke = Brushes.DarkBlue,
        //    StrokeThickness = 2
        //}, 4));
        //ViewModel.Lines.Add(new (new line)

    }
}