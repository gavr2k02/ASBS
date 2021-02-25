using System;

namespace ASBS.SQLCommand
{
    abstract class SQL
    {
        public string ConnString { get; set; }

        protected SQL(string connString)
        {
            ConnString = connString ?? throw new ArgumentNullException(nameof(connString));
        }
    }
}
