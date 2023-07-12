namespace Otus.Teaching.Pcf.Administration.WebHost.Helper
{
    public class MongoConfiguration : IMongoConfiguration
    {
        public string ConnectionString { get; set; }
        public string Database {get;set; }
        public string EmployeeCollection { get; set; }
        public string RoleCollection { get; set; }
    }
    public interface IMongoConfiguration
    {
        string ConnectionString { get; set; }
        string Database { get; set; }
        string EmployeeCollection { get; set; }
        string RoleCollection { get; set; }
    }
}
