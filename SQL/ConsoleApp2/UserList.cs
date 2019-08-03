using System;
using System.Collections.Generic;

namespace AttendanceProject
{
    public class UserList
    {
        private List<User> _list = new List<User>();

        public UserList()
        {
        }

        /// <summary>
        /// get list of users from local copy or database
        /// </summary>
        /// <param name="forceReload"> if TRUE, then force database reload</param>
        /// <returns> list of users from local copy or database </returns>
        public List<User> GetList(bool forceReload = false)
        {
            if (_list != null || forceReload || _list.Count == 0)
            {
                return _list;
            }
            _list = null; // TBD
            return _list;
        }

        /// <summary>
        /// get single user with given ID
        /// </summary>
        /// <param name="id">numeric ID cross-referenced with database</param>
        /// <returns>
        ///     User structure for valid
        ///     NULL if it cannot be found
        /// </returns>
        public User GetUser(int id)
        {
            if (_list == null || _list.Count ==0)
            {
                Fetch();
                if (_list == null)
                {
                    return null;
                }
            }
            foreach(User user in _list)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }

        /// <summary>
        /// add row of user to database
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="access"></param>
        /// <param name="schoolId"></param>
        /// <param name="graduatingYear"></param>
        public void AddUser(string firstName, string lastName, User.AccessType access, int schoolId = 0, int graduatingYear = 0)
        {
            try
            {
                User user = new User(firstName, lastName, access, schoolId, graduatingYear);
                AddUser(user);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AddUser(User user)
        {
            try
            {
                // add to local list
                _list.Add(user);

                // add to database
                Send(user);
            }
            catch (Exception)
            {
                throw; 
            }
        }

        /// <summary>
        /// fetch from database
        /// </summary>
        private void Fetch()
        {
            // TBD
        }

        /// <summary>
        /// send to database
        /// </summary>
        /// <param name="user"></param>
        private void Send(User user)
        {
            // TBD
        }
    }
}
