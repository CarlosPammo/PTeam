using System;
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
    public partial class MenuWindow : Window
    {
        private List<Contact> Contacts { get; set; }
        public MenuWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Contacts = new List<Contact>();
        }
                          
        private void btnExitApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
          //  Contact newContact = new Contact();
            NewContact editor = new NewContact(nContact);
            //editor.OnAccept += AddNewCoctact;
            editor.Show();
        }
    }
}
