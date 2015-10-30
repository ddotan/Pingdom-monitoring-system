using Logger;
using Pingdom.BussinessLogic;
using Pingdom.ObjectModel;
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

namespace Pingdom.Dashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private PingdomManager m_PingdomManager = new PingdomManager();
        public MainWindow()
        {
            InitializeComponent();
        }



        private void buttonImport_Click(object sender, RoutedEventArgs e)
        {
            
            if (comboBoxChecks.SelectedIndex > -1)
            {
                m_PingdomManager.Upload(comboBoxChecks.Text);
            }
            else
            {
                MessageBox.Show("Please choose check type!", "Error");

            }
        }


    }
}
