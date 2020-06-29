using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace Wybory2020
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Kandydat>().Wait();
        }

        public Task<List<Kandydat>> GetPeopleAsync()
        {
            return _database.Table<Kandydat>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Kandydat kandydat)
        {
            return _database.InsertAsync(kandydat);
        }
    }
}
