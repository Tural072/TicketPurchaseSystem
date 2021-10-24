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
    public class PilotRepostory : IPilotRepostory
    {
        DBEntities1 DBEntities1 = new DBEntities1();
        public void AddData(Pilot data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Pilot data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Pilot> GetAllData()
        {
            var types = from a in DBEntities1.Pilots select a;
            return new ObservableCollection<Pilot>(types);
        }

        public Pilot GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Pilot data)
        {
            throw new NotImplementedException();
        }
    }
}
