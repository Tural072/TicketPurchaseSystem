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
    public class TicketRepostory : ITicketRepostory
    {
        public void AddData(Ticket data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Ticket data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Ticket> GetAllData()
        {
            throw new NotImplementedException();
        }

        public Ticket GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Ticket data)
        {
            throw new NotImplementedException();
        }
    }
}
