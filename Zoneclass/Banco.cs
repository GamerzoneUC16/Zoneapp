using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Zoneclass
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {
            // conexão com Mysql no C#

            MySqlCommand cmd = new MySqlCommand();
            try // tentar abrir
            {
                string strCon = @"server=127.0.0.1;database=usbw;user id=root;password=";
                MySqlConnection cn = new MySqlConnection(strCon);
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception)
            {
                throw;
            }


            return cmd;
        }
    }
}