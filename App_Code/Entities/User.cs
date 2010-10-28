using System;
using System.Web.Security;

namespace de.fhb.mobileSysteme.Uebung3.Entities
{
    /// <summary>
    /// A user for authentication
    /// </summary>
    [Serializable]
    public class User : IEquatable<User>, IComparable<User>
    {
        private User()
        {
        }

        /// <summary>
        /// creates new user.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public User(String name, String password)
        {
            Name = name;
            HashedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "sha1");
        }

        public String Name { get; set; }
        public String HashedPassword { get; set; }

        #region IComparable<User> Members

        /// <summary>
        /// Comparison based on name and hashed password
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(User other)
        {
            return Name.CompareTo(other.Name) == 0
                       ? HashedPassword.CompareTo(other.HashedPassword)
                       : Name.CompareTo(other.Name);
        }

        #endregion

        #region IEquatable<User> Members

        /// <summary>
        /// Compares one user with another based on user name and hashed password.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(User other)
        {
            return Name.Equals(other.Name) && HashedPassword.Equals(other.HashedPassword);
        }

        #endregion
    }
}