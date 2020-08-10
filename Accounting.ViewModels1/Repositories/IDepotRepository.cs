using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels;

namespace Accounting.DataLayer.Repositories
{
    public interface IDepotRepository
    {
        List<Depot> GetAllDepot();

        IEnumerable<Depot> GetDepotsFiliter(string prometr);
        List<float> GetMojodi(int filiter =0); 

        List<DepotNameViewModel> GetDepotName(string filiter="");
        Depot GetDepotById(int depotID);

        bool InsertDepot(Depot depot);

        bool UpdateDepot(Depot depot);

        bool DeleteDepot(Depot depot);

        bool DeleteDepot(int DepotID);


        int EndID();

        int EndNumbeHalah();
    }
}
