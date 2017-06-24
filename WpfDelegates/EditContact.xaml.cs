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
using eContact.Model;

namespace eContact
{
	/// <summary>
	/// Interaction logic for EditarContacto.xaml
	/// </summary>
	public partial class EditContact : Window
	{
		private Contact Contact { get; set; }
		public delegate void GetContact(Contact contact);
		public event GetContact OnAccept;

        public EditContact()
        {
            InitializeComponent();
            Contact = new Contact();
        }

		public EditContact(Contact contact) : this()
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
			Contact.Address = TbAddress.Text;
			Contact.Name = TbName.Text;
			Contact.Lastname = TbLastname.Text;
			Contact.Telephone = TbPhone.Text;
			OnAccept(Contact);
			Close();
		}

        private void TbPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            int number;
            bool isValid = int.TryParse(TbPhone.Text, out number);
            if(!isValid)
            {
                TbPhone.Text = "";
            }
        }
    }
}
