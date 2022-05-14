using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RJSilvas.MyFinances.Models
{
    public class Account
    {
        public Account()
        {
            Transactions = new List<Transaction>()
            {
                new Transaction() { Id = 1, Date = new DateTime(2022, 5, 12), Category = "Salário", Value = 1245.45m } ,
                new Transaction() { Id = 2, Date = new DateTime(2022, 5, 13), Category = "Mercado", Value = -10 },
                new Transaction() { Id = 3, Date = new DateTime(2022, 5, 13), Category = "Restaurante", Value = -35.45m }
            };
        }

        public string Name => "Renato";

        public string Type => "Conta corrente";

        public decimal Amount => Transactions.Sum(t => t.Value);

        public List<Transaction> Transactions { get; set; }
    }
}
