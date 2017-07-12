using System;
using System.Collections.Generic;
using MonitoriaFatec.Models;
using System.Linq;

namespace MonitoriaFatec.Controllers
{
    public class Agenda
    {
        public int idAgenda;
        public string disciplina;
        public string evento;
        public string monitor;
        public int idDisciplina;
        public int idMonitor;
        public string hora;
        public string data;

    }

    public class CalendarioDao
    {

        public List<Agenda> Lista()
        {
            List<Agenda> agenda = new List<Agenda>();

            using (var context = new MONITORIA_FATECEntities())
            {
                var busca = from c in context.CALENDAR
                            join d in context.DISCIPLINE on c.ID_DISCIPLINE equals d.IDDISCIPLINE
                            join m in context.USUARIO on c.IDMONITOR equals m.IDUSER
                            select new
                            {
                                c.IDCALENDARIO,
                                c.DATE_HOUR,
                                d.NMDISCIPLINE,
                                c.ID_DISCIPLINE,
                                c.EVENTO,
                                c.IDMONITOR,
                                m.NMUSER
                            };

               

                foreach(var item in busca)
                {
                    Agenda a = new Agenda {
                        idAgenda = item.IDCALENDARIO,
                        disciplina = item.NMDISCIPLINE,
                        evento = item.EVENTO,
                        monitor = item.NMUSER,
                        idDisciplina = item.ID_DISCIPLINE,
                        idMonitor = item.IDMONITOR,
                        hora = item.DATE_HOUR.ToString("HH:mm:ss"),
                        data = item.DATE_HOUR.Date.ToString("dd/MM/yyyy"),
                    };
                    agenda.Add(a);
                }

                
            }
            return agenda;
        }

        public void Cadastrar(CALENDAR calendario)
        {
            using (var context = new MONITORIA_FATECEntities())
            {
                context.CALENDAR.Add(calendario);
                context.SaveChanges();

            }

        }

        public void Excluir(int id)
        {
            using (var context = new MONITORIA_FATECEntities())
            {

                var calendario = new CALENDAR { IDCALENDARIO = id };
                context.CALENDAR.Attach(calendario);
                context.CALENDAR.Remove(calendario);
                context.SaveChanges();
            }

        }
    }

  
}