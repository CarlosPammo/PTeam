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
    /// Lógica de interacción para SearchContact.xaml
    /// </summary>
    public partial class SearchContact : Window
    {
        private contact Contact { get; set; }
        private List<contact> contacts { get; set; }

        public delegate void GetContact(contact contact);
        public SearchContact()
        {
            InitializeComponent();
        }

        private void CbxSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            contact selected = (contact)DGContacts.SelectedItem;
            NewContact editor = new NewContact(selected);
            editor.OnAccept += EditContact;
            editor.Show();
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            DGContacts.DataContext = contacts
                // Obtiene todos los contactos cuya propiedad Name 
                // Contenga el texto del texbnox Search
                .Where(c => c.Name.Contains(TbSearch.Text));
            DGContacts.Items.Refresh();
        }
        private void EditContact(contact contact)
        {
            DGContacts.Items.Refresh();
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Telephone_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Name_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cellphone_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DGContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
