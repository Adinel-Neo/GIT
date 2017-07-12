using MonitoriaFatec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoriaFatec.DAO
{
    public class TipoConteudoDAO
    {
        public IList<TYPECONTENT> Lista()
        {
            using (var context = new MONITORIA_FATECEntities())
            {
                return context.TYPECONTENT.ToList<TYPECONTENT>();

            }

        }
    }
}