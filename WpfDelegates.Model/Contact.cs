using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eContact.Model
{
	public class Contact
	{
        public int Id { get; set; }
		public string Name { get; set; }
		public string Lastname { get; set; }
		public string Telephone { get; set; }
		public string Address { get; set; }
	}
}
