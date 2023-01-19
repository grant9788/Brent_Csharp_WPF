/// Form Name: Customers
/// Purpose: To allow the user to either data or display and object
/// Change Log: B.Grant 1/18/2023
///
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

namespace Brent_Csharp_WPF.GUI
{
    /// <summary>
    /// Interaction logic for Customers.xaml
    /// </summary>
 

    public partial class Customers : Window
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow.Show();
            this.Close();
        }
    }
}
