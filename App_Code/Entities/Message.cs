using System;

namespace de.fhb.mobileSysteme.Uebung3.Entities
{
    /// <summary>
    /// A single chat message.
    /// </summary>
    [Serializable]
    public class Message : IComparable<Message>
    {
        /// <summary>
        /// Creates new chate message.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="date"></param>
        /// <param name="userName"></param>
        public Message(String text, DateTime date, String userName)
        {
            Text = text;
            Date = date;
            UserName = userName;
        }

        public String Text { get; set; }
        public DateTime Date { get; set; }
        public String UserName { get; set; }

        #region IComparable<Message> Members

        /// <summary>
        /// @see IComparable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Message other)
        {
            return Date.CompareTo(other.Date);
        }

        #endregion

        /// <summary>
        /// Returns message in the form 01.01.2000 15:00:00 [user name] - message
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return String.Format("{0:G} [{1}] - {2}", Date, UserName, Text);
        }
    }
}