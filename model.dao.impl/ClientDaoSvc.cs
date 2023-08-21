using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.model.dao;
using Entities;
using MySql.Data.MySqlClient;
using Banco.ADO;

namespace Banco.model
{
    public class ClientDaoSvc : IClientDao
    {
        MySqlConnection conn;

        public ClientDaoSvc(MySqlConnection conn)
        {
            this.conn = conn;
        }
       
        public bool Login(string client_username, string client_password)
        {
            MySqlCommand command = null;
            try
            {
                String sql = "SELECT client_id FROM clients WHERE username = " + client_username + " and password = " + client_password;

                command = new MySqlCommand(sql, conn);



            }
            catch
            {

            }
            finally
            {
                Connection.closeConnection();
            }
        }

        public bool Register(string name, string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool SignIn(Client client)
        {
            throw new NotImplementedException();
        }

        public void SignOut()
        {
            throw new NotImplementedException();
        }
    }
}
