using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPurchaseSystem.Domain.Abstractions
{
    public interface IRepostory<T>
    {
        T GetData(int id);
        ObservableCollection<T> GetAllData();
        void AddData(T data);
        void UpdateData(T data);
        void DeleteData(T data);
    }
}
