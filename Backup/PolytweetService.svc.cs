using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PolytweetService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    public class PolytweetService : IPolytweetService
    {
        public User connect(String login, String pwd)
        {
            PolytweetDAL.PolytweetDAO dao = PolytweetDAL.PolytweetDAO.Instance;

            PolytweetDAL.User tmp = dao.connect(login, pwd);
            if (tmp != null)
            {
                User u = null;
                u.login = tmp.Login;
                u.password = tmp.Password;
                u.javaId = tmp.JavaID;

                return u;
            }
            return null;
        }
    }
}
