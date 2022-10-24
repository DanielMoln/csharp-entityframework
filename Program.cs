using EntityFramework2;
using EntityFramework2.models;

internal class Program
{
    public static string CONNECTION_STRING = "Server=localhost;Database=Database1;User Id=DESKTOP-DQ4B2LG\\DanielMolnar;Trusted_Connection=True;" +
        "MultipleActiveResultSets=true;";

    private static void Main(string[] args)
    {
        using (SQL sql = new SQL())
        {
            var user = sql.Users.Where(user => user.Name.Contains("test"));
            /*sql.Users.Add(new User()
            {
                UserID = "testUser",
                Name = "Test User 1",
                BirthDate = new DateTime(2008, 12, 24),
                Address = "Szombathely"
            });
            sql.SaveChanges();*/
            // users
            foreach (var u in sql.Users)
            {
                Console.WriteLine(u.ToString());
            }

            // modify
            var specificUser = sql.Users.SingleOrDefault(a => a.UserID == "testUser");
            specificUser.Name = "Módosított Név";
            sql.SaveChanges();
        }
    }
} 