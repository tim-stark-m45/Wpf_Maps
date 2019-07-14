using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Maps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<MapLocation> Locations { get; private set; } = new ObservableCollection<MapLocation>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            var rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Locations.Add(new MapLocation
                {
                    Name = $"Location{i}", Location=new Location
                    {
                        Latitude = rand.Next(-180,180),
                        Longitude = rand.Next(-180,180)
                    }
                });
            }
        }
    }

    public class MapLocation
    {
        public Location Location { get; set; }
        public string Name { get; set; }
    }
}
