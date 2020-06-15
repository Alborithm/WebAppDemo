using System;

namespace WebApplication1.Data
{
    public class ConnectionString
    {
        public string MySQL { get; set; }

        public ConnectionString(string connectionString)
        {
            MySQL = connectionString;
        }
    }
}