using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCS.Models
{
    public class Model
    {
        public class Index
        {
            public string Welcome { get; set; }
            public string Title { get; set; }
            public string Massage { get; set; }
        }
        public class Services
        {
            public string Title { get; set; }
            public string Details { get; set; }
            public string Cost { get; set; }
        }

        public class Teams
        {
            public string Name { get; set; }
            public string Role { get; set; }
            public string Bio { get; set; }
            
        }
        public class Contact
        {
            public string Address { get; set; }
            public string Email { get; set; }
        }
    }
}