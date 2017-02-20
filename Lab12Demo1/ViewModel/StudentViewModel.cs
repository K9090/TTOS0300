using MVVMDemo.Model;
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
    }
}