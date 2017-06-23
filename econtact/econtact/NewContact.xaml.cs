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
    /// Lógica de interacción para NewContact.xaml
    /// </summary>
    public partial class NewContact : Window
    {
        private contact Contact { get; set; }
        public delegate void GetContact(contact contact);
        public event GetContact OnAccept;
        public NewContact()
        {
            InitializeComponent();
            Contact = new contact();
        }
        public NewContact(contact contact) : this()
		{
            TbAddress.Text = contact.Address;
            TbName.Text = contact.Name;
            TbLastname.Text = contact.Lastname;
            TbPhone.Text = contact.Telephone;
            Contact = contact;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {
            Contact.Name = TbName.Text;
            Contact.Lastname = TbLastname.Text;
            Contact.Telephone = TbPhone.Text;
            Contact.Cellphone = TbCellphone.Text;
            Contact.Address = TbAddress.Text;
            Contact.Birthdate = TbBirthdate.Text;
            OnAccept(Contact);
            Close();
        }

        private void CbxGroup(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
