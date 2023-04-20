using Marathon.Data;
using Marathon.Pages;
using Marathon.Resources;
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

namespace Marathon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DbConnect.entObj = new marathonEntities1();

            FrameApp.frmObj = FrmMain;
            
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow mainWindow = new MainWindow();
            LoginPage login = new LoginPage();
            login.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Content = null;
            FrameApp.frmObj.Navigate(new EnterInf());
        }

        private void FrmMain_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
