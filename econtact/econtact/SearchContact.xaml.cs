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
using econtact.Model;

namespace econtact
{
    /// <summary>
    /// Lógica de interacción para SearchContact.xaml
    /// </summary>
    public partial class SearchContact : Window
    {
        public SearchContact()
        {
            InitializeComponent();
        }

        private void CbxSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            contact selected = (contact)DGcontacts.SelectedItem;
            NewContact editor = new NewContact(selected);
            editor.OnAccept += EditContact;
            editor.Show();
        }
        private void EditContact(contact contact)
        {
            DGcontacts.Items.Refresh();
        }
        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
