using Dapper;
using Microsoft.Data.SqlClient;
using WinFormsDapper.Data.Models.Person;

namespace WinFormsDapper.Data
{
    public class DBAccess
    {
        public List<Person> GetPeople(string searchName)
        {
            using (var conn = new SqlConnection(DBHelper.ConnString("AdventureWorks2019")))
            {
                var sqlParameters = new { searchName = "%" + searchName + "%" };
                var sqlQuery = "" +
                    "select * " +
                    " from person.person " +
                    "where LastName like @searchName " +
                    "   OR FirstName like @searchName " +
                    "order by LastName, FirstName";
                var retValue = conn.Query<Person>(sqlQuery, sqlParameters).ToList();
                return retValue;
            }
        }
    }
}
