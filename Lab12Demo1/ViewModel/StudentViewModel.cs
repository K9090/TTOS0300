using MVVMDemo.Model;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace MVVMDemo.ViewModel
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }
        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            students.Add(new Student { FirstName = "Mark", LastName = "Allen", AsioID = "A4324" });
            students.Add(new Student { FirstName = "John", LastName = "Doe", AsioID = "R4365" });
            students.Add(new Student { FirstName = "Linda", LastName = "Kernell", AsioID = "J5699" });
            Students = students;
        }
        //metodi StudentViewModeliin jolla haetaan oppilastiedot mysql-palvemilta
        public void LoadStudentsFromMysql()
        {
            try
            {
                ObservableCollection<Student> students = new ObservableCollection<Student>();
                //luodaan yhteys labranetin mysql-palvelimelle
                string connStr = GetMysqlConnectionString();
                string sql = "SELECT firstname, lastname, asioid FROM student";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MVVMDemo.Model.Student s = new Model.Student();
                            s.FirstName = reader.GetString(0);
                            s.LastName = reader.GetString(1);
                            s.AsioID = reader.GetString(2);
                            students.Add(s);
                        }
                        Students = students;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private string GetMysqlConnectionString()
        {
            string pw = "";
            // Get password from App.Config -configuration file
            // pw = MVVMDemo.Properties.Settings.Default.pw;
            return string.Format("Data source=mysql.labranet.jamk.fi;Initial Catalog=____;user=____;password={0}", pw);
        }
    }
}