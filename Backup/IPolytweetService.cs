using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PolytweetService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IPolytweetService
    {

        [OperationContract]
        User connect(String login,String pwd);

    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class User
    {
        [DataMember]
        public long javaId { get; set; }
        
        [DataMember]
        public string login { get; set; }
        
        [DataMember]
        public string password { get; set; }

        [DataMember]
        public List<long> walledChannels { get; set; }
    }
}
