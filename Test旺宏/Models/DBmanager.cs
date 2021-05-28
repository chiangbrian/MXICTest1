using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.Data.SqlClient;
using System.Configuration;

namespace Test旺宏.Models
{
    public class DBmanager
    {
        private readonly string Conn = ConfigurationManager.ConnectionStrings["DB1"].ConnectionString;
    }
}