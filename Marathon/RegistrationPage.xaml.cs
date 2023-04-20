﻿using Marathon.Data;
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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DbConnect.entObj.User.Count(x => x.Email == TxbEmail.Text) > 0)
            {
                MessageBox.Show("Такой email уже используется!",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            else
            {
                try
                {

                }
                catch (Exception ex)
                {

                    
                }
            }

        }
    }
}
