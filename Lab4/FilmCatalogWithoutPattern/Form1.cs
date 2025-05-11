using System.Data.SQLite;
using System.Diagnostics;

namespace FilmCatalog
{
    public partial class Form1 : Form
    {
        private SQLiteConnection connection;
        public Form1()
        {
            InitializeComponent();

            connection = new SQLiteConnection("Data Source=:memory:");
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS films (id INTEGER PRIMARY KEY, name TEXT, genre TEXT, description TEXT, imagepath TEXT)", connection))
            {
                command.ExecuteNonQuery();
            }

            using (SQLiteCommand command = new SQLiteCommand("INSERT INTO films (name, genre, description, imagepath) VALUES " +
                "('1+1', 'драма, комедия', 'Пострадав в результате несчастного случая, богатый аристократ Филипп нанимает в помощники человека, который менее всего подходит для этой работы, – молодого жителя предместья Дрисса, только что освободившегося из тюрьмы. Несмотря на то, что Филипп прикован к инвалидному креслу, Дриссу удается привнести в размеренную жизнь аристократа дух приключений.', '.\\images\\1+1.jpg')," +
                "('Интерстеллар', 'фантастика, драма, приключения', 'Когда засуха, пыльные бури и вымирание растений приводят человечество к продовольственному кризису, коллектив исследователей и учёных отправляется сквозь червоточину (которая предположительно соединяет области пространства-времени через большое расстояние) в путешествие, чтобы превзойти прежние ограничения для космических путешествий человека и найти планету с подходящими для человечества условиями.', '.\\images\\interstellar.jpg')," +
                "('Побег из Шоушенка', 'драма', 'Бухгалтер Энди Дюфрейн обвинён в убийстве собственной жены и её любовника.\nОказавшись в тюрьме под названием Шоушенк, он сталкивается с жестокостью и беззаконием, царящими по обе стороны решётки. Каждый, кто попадает в эти стены, становится их рабом до конца жизни. Но Энди, обладающий живым умом и доброй душой, находит подход как к заключённым, так и к охранникам, добиваясь их особого к себе расположения.', '.\\images\\pobeg_iz_shoushenka.jpg')," +
                "('Джентльмены', 'криминал, комедия, боевик', 'Один ушлый американец ещё со студенческих лет приторговывал наркотиками, а теперь придумал схему нелегального обогащения с использованием поместий обедневшей английской аристократии и очень неплохо на этом разбогател. Другой пронырливый журналист приходит к Рэю, правой руке американца, и предлагает тому купить киносценарий, в котором подробно описаны преступления его босса при участии других представителей лондонского криминального мира — партнёра-еврея, китайской диаспоры, чернокожих спортсменов и даже русского олигарха.', '.\\images\\djentelmeni.jpg')," +
                "('Остров проклятых', 'триллер, детектив, драма', 'Два американских судебных пристава отправляются на один из островов в штате Массачусетс, чтобы расследовать исчезновение пациентки клиники для умалишенных преступников. При проведении расследования им придется столкнуться с паутиной лжи, обрушившимся ураганом и смертельным бунтом обитателей клиники.', '.\\images\\ostrov_proklatih.jpg')", connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private void listBox_filmlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM films WHERE id = @id", connection))
            {
                command.Parameters.AddWithValue("@id", listBox_filmlist.SelectedIndex + 1);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Image image = Image.FromFile(reader.GetString(4));
                        Film film = new Film(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), image);
                        label_filmname.Text = film.name;
                        label_genre.Text = film.genre;
                        label_description.Text = film.description;
                        pictureBox_image.Image = film.image;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process process = Process.GetCurrentProcess();
            long memory = process.WorkingSet64 / 1024;
            label_memory.Text = "Используемая память: " + memory + " kb";
        }
    }
}
