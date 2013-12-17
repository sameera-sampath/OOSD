using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace OOSD
{
    public class searchingHandler
    {
        Connection connection;
        public searchingHandler()
        {
            connection = new Connection();
        }

        public DataSet search(string title , String author, String catalog )
        {
            
            if(title!="")
            {
             return   connection.titleSearch(title);

            }

            if(author!="")
            {
           return connection.authorSearch(author);

            }

            if(catalog!="")
            {
         return       connection.catalogSearch(catalog);

            }
                return null;

              
            }

        
    }
}
