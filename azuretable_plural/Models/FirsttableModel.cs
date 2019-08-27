using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace azuretable_plural.Models
{
    public class FirsttableModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public int PhoneNum { get; set; }
    
        public DateTimeOffset timestamp { get; set; }
    }
}