﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using econtact.Model;


namespace econtact
{
    /// <summary>
    /// Lógica de interacción para MenuWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<contact> Contacts { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Init()
        {
            Contacts = new List<contact>();
        }
                          
        private void btnExitApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NewContact Ncontact = new NewContact();
            Ncontact.Owner = this;
            Ncontact.ShowDialog();
        }
    }
}
