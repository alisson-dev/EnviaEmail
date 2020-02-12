using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envio_Email
{
    public class Dados
    {
        public static string stringConexao
        {
            get
            {
                return @"Data Source = 192.168.25.99; Initial Catalog = bd; User ID = sa; Password = sasa; Pooling = False";
                //return @"Data Source = 192.168.25.95; Initial Catalog = email_teste; User ID = sa; Password = senha; Pooling = False";
            }
        }
    }
}


