using System;
using System.Collections.Generic;
using System.Text;

namespace LivreOr2019_NoSQL
{
    public class Message
    {
        public Message(string nom, string description)
        {
            Nom = nom;
            Description = description;
        }

        public string Nom { get; set; }
        public string Description { get; set; }
    }
}
