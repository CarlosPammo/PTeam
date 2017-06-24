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
using econtact.Model;

namespace econtact
{
    /// <summary>
    /// Lógica de interacción para NewContact.xaml
    /// </summary>
    public partial class NewContact : Window
    {
        private contact Contact { get; set; }
        private List<contact> contacts { get; set; }
        public delegate void GetContact(contact contact);
        public event GetContact OnAccept;
        public NewContact()
        {
            InitializeComponent();
            Contact = new contact();
        }
        public NewContact(contact contact) : this()
		{
           
            Contact = contact;
        }
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {
            if (TbPhone.IsValid())
            {
                contact contact = new contact
                {
                    Name = TbName.Text,
                    Lastname = TbLastname.Text,
                    Cellphone = TbCellphone.Text,
                    Telephone = TbPhone.Text,
                    Address=TbAddress.Text,
                    Birthdate=TbBirthdate.Text
                };
                contacts.Add(contact);
            }
            else
            {
                MessageBox.Show("Invalid Phone");
            }
        }
    }
}
