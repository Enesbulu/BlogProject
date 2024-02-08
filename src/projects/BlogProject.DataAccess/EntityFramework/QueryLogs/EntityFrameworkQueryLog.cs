namespace BlogProject.DataAccess.EntityFramework.QueryLogs
{
    public class EntityFrameworkQueryLog
    {
        public static void LogQuery(string query)
        {
            string currentPath = $@"{Directory.GetCurrentDirectory()}\Logs\EntityFrameworkQueryLogs\Logs.txt";
            using StreamWriter writer = new(currentPath, true);
            writer.WriteLine(query);
        }
    }
}
