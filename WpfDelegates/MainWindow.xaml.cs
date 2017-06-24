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
using System.Windows.Navigation;
using System.Windows.Shapes;
using eContact.Model;

namespace eContact
{
	
	public partial class MainWindow : Window
	{
		private List<Contact> Contacts { get; set; }

		public MainWindow()
		{
			InitializeComponent();
			Init();
		}

		private void Init()
		{
			Contacts = new List<Contact>
				           {
							   new Contact
								   {
                                        Id = 1,
										Name = "Valeria",
										Lastname = "Ledezma",
										Address = "Pcata Baja",
										Telephone = "72735728"
								   },
								   new Contact
								   {
                                        Id = 2,
										Name = "Omar",
										Lastname = "Corrales",
										Address = "Por all",
										Telephone = "65349521"
								   },
				           };

			DGContacts.DataContext = Contacts;
			DGContacts.Items.Refresh();
		}

		private void BtnClose_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void BtnNew_Click(object sender, RoutedEventArgs e)
		{
			EditContact editor = new EditContact();
			editor.OnAccept += AddNewCoctact;
			editor.Show();
		}

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Contact selected = (Contact)DGContacts.SelectedItem;
            EditContact editor = new EditContact(selected);
            editor.OnAccept += EditContact;
            editor.Show();
        }

		private void BtnSearch_Click(object sender, RoutedEventArgs e)
		{
            DGContacts.DataContext = Contacts
                .Where(c => c.Name.Contains(TbSearch.Text));
            DGContacts.Items.Refresh();
		}

		private void AddNewCoctact(Contact contact)
		{
			Contacts.Add(contact);
			DGContacts.DataContext = Contacts;
			DGContacts.Items.Refresh();
		}

        private void EditContact(Contact contact)
        {
            DGContacts.Items.Refresh();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Contact selected = (Contact)DGContacts.SelectedItem;
            Contacts.Remove(selected);
            DGContacts.Items.Refresh();
        }
	}
}
