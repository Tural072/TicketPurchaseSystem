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
    public class AirplaneRepostory : IAirplaneRepostory
    {
        DBEntities context = new DBEntities();
        public void AddData(Airplanes data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Airplanes data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Airplanes> GetAllData()
        {
            var airplane = from a in context.Airplanes select a;
            return new ObservableCollection<Airplanes>(airplane);
        }

        public Airplanes GetData(int id)
        {
            var airplane = context.Airplanes.FirstOrDefault(a => a.Id == id);
            return airplane;
        }

        public void UpdateData(Airplanes data)
        {
            throw new NotImplementedException();
        }
    }
}
