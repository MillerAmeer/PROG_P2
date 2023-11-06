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

namespace Modules
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

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Register reg = new Register();
            reg.Show(); 
            this.Close();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            string UserName = User_Name.Text;
            string PassWord = Pass_wrd.Text;
        }
        private void OnExit(object sender, ExitEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
