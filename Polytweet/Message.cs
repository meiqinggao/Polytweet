using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polytweet
{
   

    public class Message
    {
        public String Author { get; set; }
        public String Content {get; set;}

        public Message(String auth, String cont)
        {
            this.Author = auth;
            this.Content = cont;
        }

        public void displayMessage()
        {
            System.Console.WriteLine(this.Content);
        }
    }
}
