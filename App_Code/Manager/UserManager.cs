using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using de.fhb.mobileSysteme.Uebung3.Entities;
using log4net;

namespace de.fhb.mobileSysteme.Uebung3.Manager
{
    /// <summary>
    /// Manages User Data.
    /// </summary>
    public class UserManager
    {
        /// <summary>
        /// Logger
        /// </summary>
        private static readonly ILog _log = LogManager.GetLogger("UserManager");

        private static string _filepath;
        private static List<User> _users = new List<User>();

        /// <summary>
        /// Needed for setting path to user file. Called at application start.
        /// </summary>
        /// <param name="filepath"></param>
        public static void Init(String filepath)
        {
            _filepath = filepath;
        }

        /// <summary>
        /// Determines if a user exists in local userbase.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static Boolean Authenticate(User user)
        {
            if (_users.Contains(user))
            {
                _log.Info(String.Format("User {0} logged in.", user.Name));
                return true;
            }
            else
            {
                _log.Info(String.Format("User {0} failed to authenticate.", user.Name));
                return false;
            }
        }

        /// <summary>
        /// Determines if a user exists in local userbase.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Boolean Authenticate(string userName, string password)
        {
            var user = new User(userName, password);
            return Authenticate(user);
        }

        /// <summary>
        /// Saves the user List to an XML file.
        /// </summary>
        public static void SaveUsers()
        {
            var xmlSerializer = new XmlSerializer(typeof (List<User>));
            using (var fileStream = new FileStream(_filepath, FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, _users);
                fileStream.Close();
            }
        }

        /// <summary>
        /// Loads the user List from an XML file.
        /// </summary>
        /// <returns></returns>
        public static Boolean LoadUsers()
        {
            if (!File.Exists(_filepath))
                return false;

            var xmlSerializer = new XmlSerializer(typeof (List<User>));

            using (var fileStream = new FileStream(_filepath, FileMode.Open))
            {
                _users = xmlSerializer.Deserialize(fileStream) as List<User>;
                fileStream.Close();
            }

            return true;
        }

        /// <summary>
        /// Adds a user to the user base.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public static void AddUser(String name, String password)
        {
            var user = new User(name, password);
            AddUser(user);
        }

        /// <summary>
        /// Adds a user to the user base.
        /// </summary>
        /// <param name="user"></param>
        public static void AddUser(User user)
        {
            _users.Add(user);
            SaveUsers();
        }
    }
}