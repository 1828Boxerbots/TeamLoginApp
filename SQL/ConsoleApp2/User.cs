using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceProject
{
    public class User
    {
        public enum AccessType
        {
            ADMIN,
            STUDENT,
            MENTOR
        };

        // properties
        public int Id { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUpdateBy { get; set; }

        public int SubTeamId { get; set; }
        public bool IsActive { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AccessType TheAccessType { get; private set; }

        public int ClassOf{ get; set; }
        public bool Gender { get; set; }
        public int SchoolId { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        
        // path for image
        public string ImageLink { get; set; }

        // constructor
        public User(string firstname, string lastname, User.AccessType access, int schoolId = 0, int graduatingYear = 0)
        {
        }

        /// <summary>
        /// fetch data from data stream
        /// </summary>
        /// <param name="inputStream"></param>
        public void Fetch(object inputStream)
        {
            // TBD
Id = 0;
LastUpdateDate = DateTime.Now;
LastUpdateBy = "me";
SubTeamId = 0;
IsActive = true;
FirstName = "firstName";
LastName = "lastname";
TheAccessType = AccessType.STUDENT;
ClassOf = 2010;
Gender = true;
SchoolId = 1;
Email1 = "user@yahoo.com";
Email2 = "user@gmail.com";
ImageLink = null;
        }

        /// <summary>
        /// send data to database 
        /// </summary>
        /// <param name="user"></param>
        public void Send(User user)
        {
            // TBD
        }
    }

}
