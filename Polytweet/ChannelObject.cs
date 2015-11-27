using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Polytweet
{
    public class ChannelObject
    {
        public String Nom { get; set; }
        public byte[] ImageChannel { get; set; }
        public ObservableCollection<PolytweetServiceClient.Message> ListMessage { get; set; }

        public ChannelObject(PolytweetServiceClient.Channel ch)
        {
            this.Nom = ch.name;
            // TODO : 
            // if(ch.visibility.equals("private")
            // else
            String bird_pr = "bird.png";
            String bird_pu = "bird.png";
            String path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "..\\..\\..\\Data\\" + bird_pr;
            this.ImageChannel = lireFichier(path);

            this.ListMessage = new ObservableCollection<PolytweetServiceClient.Message>();
            foreach (PolytweetServiceClient.Message m in ch.msgList)
            {
                this.ListMessage.Add(m);
            }

        }

        public void refreshMessage(PolytweetServiceClient.Message[] ml)
        {
            this.ListMessage.Clear();
            foreach (PolytweetServiceClient.Message m in ml)
            {
                this.ListMessage.Add(m);
            }
        }
        public override string ToString() {
            return this.Nom+"("+this.ListMessage.Count+")";
        }

        /******************* dataReader ******************/
        private static byte[] lireFichier(string chemin)
        {
            byte[] data = null;
            FileInfo fileInfo = new FileInfo(chemin);
            int nbBytes = (int)fileInfo.Length;
            FileStream fileStream = new FileStream(chemin, FileMode.Open,
            FileAccess.Read);
            BinaryReader br = new BinaryReader(fileStream);
            data = br.ReadBytes(nbBytes);
            return data;
        }

    }

    public class ChannelCollection : ObservableCollection<ChannelObject>
    {
        public ChannelCollection() { }
        public ChannelCollection(PolytweetServiceClient.Channel[] list)
        {
            foreach (PolytweetServiceClient.Channel c in list)
            {
                this.Add(new ChannelObject(c));
            }
        }
    }
}
