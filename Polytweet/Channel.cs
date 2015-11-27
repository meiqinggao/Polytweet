using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polytweet
{
    public class Channel
    {
        public String Name { get; set; }
        public ObservableCollection<Message> listMessage { get; set; }

        public Channel(String n)
        {
            this.Name = "#"+n;
            listMessage = new ObservableCollection<Message>();
        }

        public Channel(PolytweetServiceClient.Channel ch)
        {

        }

        public void addMessage(String c)
        {
            this.listMessage.Add(new Message("authDefault",c));
        }
        public void addMessage(Message m)
        {
            this.listMessage.Add(m);
        }

        public void displayMessages()
        {
            foreach(Message m in this.listMessage){
                System.Console.WriteLine(m.Content);
                m.displayMessage();
            }
        }

        public override string ToString() {
            return Name + "(" + listMessage.Count + ")";
        
        }
    }
}
