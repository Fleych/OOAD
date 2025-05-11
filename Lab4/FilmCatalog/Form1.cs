using System.Data.SQLite;
using System.Diagnostics;

namespace FilmCatalog
{
    public partial class Form1 : Form
    {
        private IdentityMap identityMap;

        public Form1()
        {
            InitializeComponent();

            SQLiteConnection connection = new SQLiteConnection("Data Source=:memory:");
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS films (id INTEGER PRIMARY KEY, name TEXT, genre TEXT, description TEXT, imagepath TEXT)", connection))
            {
                command.ExecuteNonQuery();
            }
            identityMap = new IdentityMap(connection);

            using (SQLiteCommand command = new SQLiteCommand("INSERT INTO films (name, genre, description, imagepath) VALUES " +
                "('1+1', '�����, �������', '��������� � ���������� ����������� ������, ������� ���������� ������ �������� � ��������� ��������, ������� ����� ����� �������� ��� ���� ������, � �������� ������ ���������� ������, ������ ��� ��������������� �� ������. �������� �� ��, ��� ������ �������� � ����������� ������, ������ ������� ��������� � ����������� ����� ����������� ��� �����������.', '.\\images\\1+1.jpg')," +
                "('������������', '����������, �����, �����������', '����� ������, ������� ���� � ��������� �������� �������� ������������ � ������������������ �������, ��������� �������������� � ������ ������������ ������ ����������� (������� ���������������� ��������� ������� ������������-������� ����� ������� ����������) � �����������, ����� ��������� ������� ����������� ��� ����������� ����������� �������� � ����� ������� � ����������� ��� ������������ ���������.', '.\\images\\interstellar.jpg')," +
                "('����� �� ��������', '�����', '��������� ���� ������� ������ � �������� ����������� ���� � � ���������.\n���������� � ������ ��� ��������� �������, �� ������������ � ����������� � �����������, �������� �� ��� ������� �������. ������, ��� �������� � ��� �����, ���������� �� ����� �� ����� �����. �� ����, ���������� ����� ���� � ������ �����, ������� ������ ��� � �����������, ��� � � ����������, ��������� �� ������� � ���� ������������.', '.\\images\\pobeg_iz_shoushenka.jpg')," +
                "('�����������', '��������, �������, ������', '���� ����� ���������� ��� �� ������������ ��� ������������� �����������, � ������ �������� ����� ������������ ���������� � �������������� �������� ���������� ���������� ������������ � ����� ������� �� ���� ����������. ������ ����������� ��������� �������� � ���, ������ ���� ����������, � ���������� ���� ������ ������������, � ������� �������� ������� ������������ ��� ����� ��� ������� ������ �������������� ����������� ������������� ���� � �������-�����, ��������� ��������, ���������� ����������� � ���� �������� ��������.', '.\\images\\djentelmeni.jpg')," +
                "('������ ���������', '�������, ��������, �����', '��� ������������ �������� �������� ������������ �� ���� �� �������� � ����� �����������, ����� ������������ ������������ ��������� ������� ��� ����������� ������������. ��� ���������� ������������� �� �������� ����������� � �������� ���, ������������ �������� � ����������� ������ ���������� �������.', '.\\images\\ostrov_proklatih.jpg')", connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private void listBox_filmlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film film = identityMap.Get(listBox_filmlist.SelectedIndex + 1);
            label_filmname.Text = film.name;
            label_genre.Text = film.genre;
            label_description.Text = film.description;
            pictureBox_image.Image = film.image;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process process = Process.GetCurrentProcess();
            long memory = process.WorkingSet64 / 1024;
            label_memory.Text = "������������ ������: " + memory + " kb";
        }
    }
}
