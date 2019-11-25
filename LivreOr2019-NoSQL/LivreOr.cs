using System;
using System.Collections.Generic;
using System.Text;

namespace LivreOr2019_NoSQL
{
    public class LivreOr
    {

        private List<Message> _messages = new List<Message>();
        public IEnumerable<Message> Messages => _messages;


        //public IEnumerable<Message> Messages { get;  }
        
        //public IEnumerable<Message> Messages
        //{
        //    get
        //    {
        //        return _messages;
        //    }

        //    set
        //    {
        //        _messages = value;
        //    }
        //}

        //public IEnumerable<Message> getMessages()
        //{
        //    return _messages;
        //}

        //public void setMessages(List<Message> messages)
        //{
        //    _messages = messages;
        //}

        public void AddMessage(string nom, string description)
        {
            AddMessage(new Message(nom, description));
        }

        public void AddMessage(Message message)
        {
            _messages.Add(message);
        }
    }
}
