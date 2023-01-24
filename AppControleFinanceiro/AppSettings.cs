namespace AppControleFinanceiro;

public class AppSettings
{
    private static string DatabaseName = "controlefinanceiro.db";
    private static string DatabaseDirectory = FileSystem.AppDataDirectory;
    public static string DatabasePath = Path.Combine(DatabaseDirectory, DatabaseName);
}
