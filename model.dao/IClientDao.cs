using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.model.dao
{
    internal interface IClientDao
    {

        bool Register(string name, string username, string password);
        bool Login(string client_username, string client_password);

        bool SignIn(Client client);

        void SignOut();
    }
}
