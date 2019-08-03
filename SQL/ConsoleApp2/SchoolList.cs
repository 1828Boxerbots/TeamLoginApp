using System.Collections.Generic;

namespace AttendanceProject
{
    public class SchoolList
    {
        private List<KeyValuePair<int,string>> _list = new List<KeyValuePair<int, string>>();

        /// <summary>
        /// get list from database
        /// </summary>
        /// <returns></returns>
        public List<KeyValuePair<int, string>> GetList(bool forceReload = false)
        {
            if (_list == null || forceReload || _list.Count == 0)
            {
                Fetch();
            }
            return _list;
        }

        /// <summary>
        /// get school name from ID
        /// </summary>
        /// <param name="key">ID from key/value pair</param>
        /// <returns>string of school name</returns>
        public string GetSchool(int key)
        {
            if (_list == null || _list.Count == 0)
            {
                return null;
            }
            foreach(var item in _list)
            {
                if (item.Key == key)
                {
                    return item.Value;
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// utility function to fill up the (_list) variable
        /// </summary>
        private void Fetch()
        {
            // TBD
        }
    }
}
