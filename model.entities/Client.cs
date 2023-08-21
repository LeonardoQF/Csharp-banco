using Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Client
    {

        //attributes 
        private int client_id { get; set; }
        private string client_name { get; set; }
        private string client_password { get; set; }
        private string client_username { get; set; }

        private List<Transaction> transactions { get; }

        //constructors
        public Client() { }

        public Client(int client_id, string client_name, string client_username, string client_password)
        {
            this.client_id = client_id;
            this.client_name = client_name;
            this.client_username = client_username;
            this.client_password = client_password;
        }

        //getters and setters

        /* public int ClientId
         {
             get { return client_id; }
             set { client_id = value; }
         }*/

    }

}

