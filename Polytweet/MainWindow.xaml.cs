using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Polytweet
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ChannelCollection channelCollection;
        private ChannelCollection channelCollectionEmpty ;
        PolytweetServiceClient.PolytweetServiceClient ptsc;
        PolytweetServiceClient.User user;

        public MainWindow()
        {
            InitializeComponent();

            ptsc = new PolytweetServiceClient.PolytweetServiceClient();
            user = ptsc.connect("bobo", "pass");
            ptsc.initTestContext();
            channelCollection = new ChannelCollection();
            //channelCollection.Add(new ChannelObject(ptsc.findChannel("name")[0]));
            channelCollection = new ChannelCollection(ptsc.getAllChannel());
            channelCollectionEmpty = new ChannelCollection();

            ObjectDataProvider channelSource = (ObjectDataProvider)FindResource("ChannelCollection");
            channelSource.ObjectInstance = channelCollection;
            ObjectDataProvider channelSourceEmpty = (ObjectDataProvider)FindResource("ChannelCollectionEmpty");
            channelSourceEmpty.ObjectInstance = channelCollectionEmpty;
            
            foreach(ChannelObject c in channelCollection)
            {
                cbx_choixChannel.Items.Add(c);
            }
        }
        private void refreshChannels()
        {
            cbx_choixChannel.Items.Clear();
            foreach (ChannelObject c in channelCollection)
            {
                cbx_choixChannel.Items.Add(c);
            }
            foreach (ChannelObject c in channelCollectionEmpty)
            {
                cbx_choixChannel.Items.Add(c);
            }

        }

        /******************* Buttons ******************/
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            Expander_channels.IsExpanded = !Expander_channels.IsExpanded;
            Expander_newMessage.IsExpanded = false;
            Expander_newChannel.IsExpanded= false;
            Expander_settings.IsExpanded = false;
            changeButtonColor();
        }
        private void B2_Click(object sender, RoutedEventArgs e)
        {
            Expander_newMessage.IsExpanded = !Expander_newMessage.IsExpanded;
            Expander_channels.IsExpanded = false;
            Expander_newChannel.IsExpanded = false;
            Expander_settings.IsExpanded = false;
            changeButtonColor();
        }
        private void B3_Click(object sender, RoutedEventArgs e)
        {
            Expander_channels.IsExpanded = false;
            Expander_newMessage.IsExpanded = false;
            Expander_newChannel.IsExpanded = !Expander_newChannel.IsExpanded;
            Expander_settings.IsExpanded = false;
            changeButtonColor();
        }
        private void B4_Click(object sender, RoutedEventArgs e)
        {
            tbk_changeUser.Text = "Changer d'utilisateur (" + user.login + ")";

            Expander_channels.IsExpanded = false;
            Expander_newMessage.IsExpanded = false;
            Expander_newChannel.IsExpanded = false;
            Expander_settings.IsExpanded = !Expander_settings.IsExpanded;
            changeButtonColor();
        }

        private void Bt_lookForChannel_Click(object sender, RoutedEventArgs e)
        {
            //ptsc.findChannel(tb_lookForChannel.Text);
            System.Console.WriteLine("channel en cours de recherche");
        }

        private void Bt_newMessage_Click(object sender, RoutedEventArgs e)
        {
            ChannelObject c = (ChannelObject)cbx_choixChannel.SelectedItem;
            ptsc.publishMessage((int)user.javaId, c.Nom, tb_newMessage.Text, 0);
            tb_newMessage.Clear();
            c.refreshMessage(ptsc.findChannel(c.Nom).msgList);
            refreshChannels();
            System.Console.WriteLine("nouveau Message ajouté");
        }

        private void Bt_newChannel_Click(object sender, RoutedEventArgs e)
        {
            PolytweetServiceClient.Channel chn = ptsc.createChannel((int)user.javaId, tb_newChannel.Text);
            channelCollection.Add(new ChannelObject(chn));
            refreshChannels();
            tb_newChannel.Clear();
            System.Console.WriteLine("nouvelle channel ajoutée");
        }
        private void Bt_Connect_Click(object sender, RoutedEventArgs e)
        {
            this.user = ((PolytweetServiceClient.IPolytweetService)ptsc).connect(tb_userName.Text, pwd_user.Password);
            if (user != null)
            {
                tbk_changeUser.Text = "Changer d'utilisateur (" + user.login + ")";
            }
            else
            {
                tbk_changeUser.Text = "Utilisateur " + tb_userName.Text+ " inconnu et/ou mot de passe incorrect !";
            }
            tb_userName.Clear();
            pwd_user.Clear();
        }

        private void changeButtonColor()
        {
            System.Windows.Media.SolidColorBrush selectColor = Brushes.DodgerBlue;
            System.Windows.Media.SolidColorBrush unselectColor = Brushes.DeepSkyBlue;

            if (Expander_channels.IsExpanded)
                B1.Background = selectColor;
            else
                B1.Background = unselectColor;

            if (Expander_newMessage.IsExpanded)
                B2.Background = selectColor;
            else
                B2.Background = unselectColor;

            if (Expander_newChannel.IsExpanded)
                B3.Background = selectColor;
            else
                B3.Background = unselectColor;

            if (Expander_settings.IsExpanded)
                B4.Background = selectColor;
            else
                B4.Background = unselectColor;

        }

        

        /********************Drag and Drop*****************/
        ListBox dragSource = null;
        // On initie le Drag and Drop
        private void ImageDragEvent(object sender, MouseButtonEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            dragSource = parent;
            object data = GetDataFromListBox(dragSource, e.GetPosition(parent));
            if (data != null)
            {
                DragDrop.DoDragDrop(parent, data, DragDropEffects.Move);
            }
        }
        // On ajoute l'objet dans la nouvelle ListBox et on le supprime de l'ancienne
        private void ImageDropEvent(object sender, DragEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            ChannelObject data = (ChannelObject)e.Data.GetData(typeof(ChannelObject));
            //PolytweetServiceClient.Channel data = (PolytweetServiceClient.Channel)e.Data.GetData(typeof(PolytweetServiceClient.Channel));
            ((IList)dragSource.ItemsSource).Remove(data);
            ((IList)parent.ItemsSource).Add(data);
        }
        // On récupére l'objet que que l'on a dropé
        private static object GetDataFromListBox(ListBox source, Point point)
        {
            UIElement element = (UIElement)source.InputHitTest(point);
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data =
                    source.ItemContainerGenerator.ItemFromContainer(element);
                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = (UIElement)VisualTreeHelper.GetParent(element);
                    }
                    if (element == source)
                    {
                        return null;
                    }
                }
                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }
            return null;

        }
    }
}
