using System;
using System.Collections.Generic;
using de.fhb.mobileSysteme.Uebung3.Entities;
using log4net;

namespace de.fhb.mobileSysteme.Uebung3.Manager
{
    /// <summary>
    /// Management class for handling chat messages.
    /// </summary>
    public sealed class MessageManager
    {
        private ILog _log = LogManager.GetLogger("MessageManager");
        private Stack<Message> _messages = new Stack<Message>();

        #region Singleton

        private static readonly MessageManager instance = new MessageManager();

        private MessageManager() { }

        public static MessageManager Instance
        {
            get
            {
                return instance;
            }
        }

        #endregion Singleton

        /// <summary>
        /// Adds a new message and writes info to log.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="user"></param>
        public void AddMessage(string text, User user)
        {
            Message message = new Message(text, DateTime.Now, user.Name);
            _messages.Push(message);
            _log.Info(message.ToString());
        }

        public Stack<Message> GetMessages()
        {
            return _messages;
        }
    }

}