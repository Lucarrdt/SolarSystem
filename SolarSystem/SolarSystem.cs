using System;
using System.Collections.Generic;
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

namespace SolarSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class Planets
    {
        protected string PName { get; set; }
        protected double PVelocity { get; set; }
    }

    public class Sun : Planets
    {
        public Sun()
        {
            PName = "Sun";
            PVelocity = 0;
        }
        
    }
    public class Mercury : Planets
    {
        public Mercury()
        {
            PName = "Mercury";
            PVelocity = 47.87;
        }
    }
    public class Venus : Planets
    {
        public Venus()
        {
            PName = "Venus";
            PVelocity = 35.02;
        }
    }
    public class Earth : Planets
    {
        public Earth()
        {
            PName = "Earth";
            PVelocity = 29.78;
        }
    }
    public class Mars : Planets
    {
        public Mars()
        {
            PName = "Mars";
            PVelocity = 24.13;
        }
    }
    public class Jupiter : Planets
    {
        public Jupiter()
        {
            PName = "Jupiter";
            PVelocity = 13.07;
        }
    }
    public class Saturn : Planets
    {
        public Saturn()
        {
            PName = "Saturn";
            PVelocity = 9.69;
        }
    }
    public class Uranus : Planets
    {
        public Uranus()
        {
            PName = "Uranus";
            PVelocity = 6.81;
        }
    }
    public class Neptune : Planets
    {
        public Neptune()
        {
            PName = "Neptune";
            PVelocity = 5.43;
        }
    }
    public class Pluto : Planets
    {
        public Pluto()
        {
            PName = "Pluto";
            PVelocity = 4.74;
        }
    }
}