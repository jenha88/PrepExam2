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
using System.Windows.Shapes;

namespace boop
{
    /// <summary>
    /// Interaction logic for wind.xaml
    /// </summary>
    public partial class wind : Window
    {
        public wind()
        {
            InitializeComponent();
        }
        public void SW (Car ihateithere)
        {
            img.Source = new BitmapImage(new Uri(ihateithere.Picture));
            txtMil.Text = Convert.ToString(ihateithere.Mileage);
       }
    }
}
