using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketPurchaseSystem.Domain.Abstractions;
using TicketPurchaseSystem.Domain.Entities;

namespace TicketPurchaseSystem.DataAccess.SqlServer
{
    public class ScheludeRepostory : IScheludeRepostory
    {
        DBEntities1 DBEntities1 = new DBEntities1();
        public void AddData(Schedule data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Schedule data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Schedule> GetAllData()
        {
            var schedules = from a in DBEntities1.Schedules select a;
            return new ObservableCollection<Schedule>(schedules);
        }

        public Schedule GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Schedule data)
        {
            throw new NotImplementedException();
        }
    }
}
