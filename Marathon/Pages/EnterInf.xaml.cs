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

namespace Marathon.Pages
{
    /// <summary>
    /// Логика взаимодействия для EnterInf.xaml
    /// </summary>
    public partial class EnterInf : Page
    {
        public EnterInf()
        {
            InitializeComponent();
        }

        private void NewRunner_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new RegistrationPage());
        }
    }
}
