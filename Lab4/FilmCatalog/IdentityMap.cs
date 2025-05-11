using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace FilmCatalog
{
    internal class IdentityMap
    {
        private SQLiteConnection connection;
        private Dictionary<int, Film> films = new Dictionary<int, Film>();

        public IdentityMap(SQLiteConnection c)
        {
            connection = c;
        }

        public Film Get(int id)
        {
            films.TryGetValue(id, out Film film);
            if (film != null)
            {
                return film;
            }
            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM films WHERE id = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Image image = Image.FromFile(reader.GetString(4));
                        film = new Film(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), image);
                        films.Add(id, film);
                        return film;
                    }
                }
            }
            return null;
        }
    }
}
