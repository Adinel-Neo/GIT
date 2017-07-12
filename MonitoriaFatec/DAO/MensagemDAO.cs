using MonitoriaFatec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoriaFatec.DAO
{
    public class MensagemDAO
    {
        public void Envia(USERMESSAGE Mensagem)
        {
            using(var context = new MONITORIA_FATECEntities())
            {
                context.USERMESSAGE.Add(Mensagem);
                context.SaveChanges();
            }
        }
    }
}