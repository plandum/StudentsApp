namespace StudentsApp;

public partial class App : Application
{
    public const string DATABASE_NAME = "students.db";
    public static StudentsRepository database;
    public static StudentsRepository Database
    {
        get
        {
            if (database == null)
            {
                database = new StudentsRepository(
                    Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
            }
            return database;
        }
    }

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
