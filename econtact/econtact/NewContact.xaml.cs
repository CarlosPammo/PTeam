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
        private List<contact> contacts { get; set; }

        public NewContact()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            contacts = new List<contact>
                           {
                               new contact
                                   {
                                        Name = "Carlos",
                                        Lastname = "Pammo",
                                        
                                   },
                                   new contact
                                   {
                                        Name = "Roberto",
                                        Lastname = "Illanes",
                                        
                                   },
                           };

            //DGContacts.DataContext = Contacts;
            //DGContacts.Items.Refresh();
        }
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
