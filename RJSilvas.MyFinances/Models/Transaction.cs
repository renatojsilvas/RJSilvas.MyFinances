using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RJSilvas.MyFinances.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public DateTime Date { get; set;}

        public string Category { get; set; }

        public decimal Value { get; set; }
    }
}
