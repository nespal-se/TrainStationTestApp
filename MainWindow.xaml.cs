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

namespace TrainStationTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel ViewModel { get; } = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            ViewModel.Lines.Add(new Segment( new EllipseGeometry(new Point(50, 50), 15, 15)));
            ViewModel.Lines.Add(new Segment(new RectangleGeometry(new Rect(85, 85, 30, 30))));
            ViewModel.Lines.Add(new Segment(new EllipseGeometry(new Point(150, 150), 15, 15)));
            ViewModel.Lines.Add(new Segment(new LineGeometry(new Point(200, 200), new Point(250, 280))));

            DataContext = ViewModel;
        }
    }
}