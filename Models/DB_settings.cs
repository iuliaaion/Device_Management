using System;
namespace Management_APP.Models
{
    public class DB_settings : IDB_settings
    {
        public string Device_collection_name { get; set; }
        public string connection_string { get; set; }
        public string DB_name { get; set; }
    }

    public interface IDB_settings
    {
        string Device_collection_name { get; set; }
        string connection_string { get; set; }
        string DB_name { get; set; }
    }
}
