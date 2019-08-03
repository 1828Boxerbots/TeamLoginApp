using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceProject
{
    public class AttendanceSql
    {
        public UserList TheUserList { get; set; }
        public SchoolList TheSchoolList { get; set; }

        public AttendanceSql()
        {
        }

        public void Connect()
        {
        }

    }
}

//<? php
////Variables for connecting to your database.
////These variable values come from your hosting account.
//$hostname = "Attendance1828.db.9710270.db4.hostedresource.net";
//$username = "Attendance1828";
//$dbname = "Attendance1828";

////These variable values need to be changed by you before deploying
//$password = "your password"; (B0xerB0ts!)
//$usertable = "your_tablename";
//$yourfield = "your_field";

////Connecting to your database
//mysql_connect($hostname, $username, $password) OR DIE("Unable to
//connect to database! Please try again later.");
//mysql_select_db($dbname);

////Fetching from your database table.
//$query = "SELECT * FROM $usertable";
//$result = mysql_query($query);

//if ($result) {
//    while($row = mysql_fetch_array($result)) {
