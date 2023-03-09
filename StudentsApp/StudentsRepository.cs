using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentsApp
{
    public class StudentsRepository
    {
        SQLiteConnection database;
        public StudentsRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Students>();
        }
        public IEnumerable<Students> GetItems()
        {
            return database.Table<Students>().ToList();
        }
        public Students GetItem(int id)
        {
            return database.Get<Students>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Students>(id);
        }
        public int SaveItem(Students item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
