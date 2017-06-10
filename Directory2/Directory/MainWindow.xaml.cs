using Directory.Model;
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

namespace Directory
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Contact> Contacts { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Contacts = new List<Contact>();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (TbPhone.IsValid())
            {
                Contact contact = new Contact
                {
                    Name = TbName.Text,
                    LastnameDad = TbLastnameDad.Text,
                    LastnameMom = TbLastnameMom.Text,
                    Telephone = TbPhone.Text
                };
                Contacts.Add(contact);
                DGContacts.DataContext = Contacts;
                DGContacts.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Invalid Phone");
            }
            
        }     
    }
}
