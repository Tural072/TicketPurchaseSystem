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
        public void AddData(Pilots data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Pilots data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Pilots> GetAllData()
        {
            throw new NotImplementedException();
        }

        public Pilots GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Pilots data)
        {
            throw new NotImplementedException();
        }
    }
}
