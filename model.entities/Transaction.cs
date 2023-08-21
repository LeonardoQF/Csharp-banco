using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities 
{
    internal class Transaction
    {
        //attributes 
        private int transaction_id { get; set; }
        private double value { get; set; }

        private String receiver { get; set; }

        private DateTime moment { get; set; }

        public Transaction() { }

        public Transaction(double value, DateTime moment, String receiver)
        {
            this.value = value;
            this.moment = moment;
            this.receiver = receiver;
        }


        public override string ToString()
        {
            return "Id : " + transaction_id + "\n"
                + "Valor : " + value + "\n"
                + "Recebente: " + receiver + "\n"
                + "Data: " + moment + "\n"
                + "=============================";
        }


    }
}
