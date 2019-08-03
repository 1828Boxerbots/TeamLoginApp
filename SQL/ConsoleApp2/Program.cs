
using AttendanceProject;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            AttendanceSql table = new AttendanceSql();
            table.Connect();
            //table.TheSchoolList.AddSchool("Vail Academy and High School", "VAHS");
            //table.TheSchoolList.AddSchool("Cienega High School", "Cienega");

            table.TheUserList.AddUser("tito", "vita", User.AccessType.ADMIN);
            table.TheUserList.AddUser("ryan", "alterman", User.AccessType.ADMIN);
            table.TheUserList.AddUser("dakota", "doyle", User.AccessType.MENTOR);

            table.TheUserList.AddUser("aiden", "clarke", User.AccessType.STUDENT, 1, 2010);
            table.TheUserList.AddUser("brighton", "staples", User.AccessType.STUDENT, 1, 2010);

            User user = new User("logan", "clarke", User.AccessType.STUDENT, 1, 2010);
            table.TheUserList.AddUser(user);

            User user2 = table.TheUserList.GetUser(2);
        }
    }
}
