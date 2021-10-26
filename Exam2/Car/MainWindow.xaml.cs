using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
        private List<Car> c;
        public MainWindow()
        {
            InitializeComponent();
            using (var client= new HttpClient())
            {
                string jsonData = client.GetStringAsync("https://timmyluong11.github.io/JamJamTestJSON/RandCar2.json").Result;
                //Car cc = JsonConvert.DeserializeObject<Car>(jsonData);
               List<Car> beep = JsonConvert.DeserializeObject<List<Car>>(jsonData);
                foreach (var item in beep)
                {
                    C.Add(item);

                }
             
            }
            PopulateCB(C);
        }
        private void PopulateCB(List<Car> vroom)
        {
            cbColor.Items.Add("All");
            cbColor.SelectedIndex = 0;

            foreach (var item in vroom)
            {
                if (!cbColor.Items.Contains(item.CarColor))
                {
                    cbColor.Items.Add(item.CarColor);

                }
            }
        }
        private List<Car>FilterColor(List<Car> F)
        {
            List<Car> c = new List<Car>();
            string f = cbColor.SelectedValue.ToString();

            foreach (var item in F)
            {
                if (f.ToLower() == "all")
                {
                    c.Add(item);
                }
                else if (item.CarColor.Contains(f))
                {
                    c.Add(item);
                }

            }
            return c; 
        }
        private List<Car> FilterYear(List<Car> FF)
        {
            List<Car> c = new List<Car>(); 
            int YR = 0;
            string Y = txtYear.Text;
            if (string.IsNullOrEmpty(Y) == true)
            {
                MessageBox.Show("╚(•⌂•)╝ I can't read this stupid!");
            }
            else if (int.TryParse(Y, out YR) == false)
            {
                MessageBox.Show("┻━┻ ︵ヽ(`Д´)ﾉ︵ ┻━┻ this isn't a number!");
            }
            foreach (var item in FF)
            {
                if (item.Year>=YR)
                {
                    c.Add(item);
                }
            }
            return c;
        }
        private void btbPush_Click(object sender, RoutedEventArgs e)
        {
            c = FilterColor(C);
            c = FilterYear(C);
            PopulateCB(c);
            
        }

        private void btbExport_Click(object sender, RoutedEventArgs e)
        {
            string jj = JsonConvert.SerializeObject(c);
            File.WriteAllText("car.json", jj);

            MessageBox.Show("(∩^o^)⊃━☆ Yay it successful exported!");
        }
    }
}
