﻿using System;
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
using EjemploWpfApp.UI.Consulta;
using EjemploWpfApp.UI.Registro;

namespace EjemploWpfApp
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

        private void RegistrarButton_Click(object sender, RoutedEventArgs e)
        {
            RPersonas rp = new RPersonas();
            rp.Show();
        }

        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            CPersonas cp = new CPersonas();
            cp.Show();
        }
    }
}
