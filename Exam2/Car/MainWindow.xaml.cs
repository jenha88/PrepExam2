using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace Car
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Car> C = new List<Car>(); 
        public MainWindow()
        {
            InitializeComponent();
            using (var client= new HttpClient())
            {
                string jsonData = client.GetStringAsync("https://timmyluong11.github.io/JamJamTestJSON/RandCar2.json").Result;



            }
        }
    }
}
