using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork /*: IDisposable*/
    {
        //    Accounting_DBEntities db = new Accounting_DBEntities();

        //    private IDepotRepository _depotRepository;
        //    private IBiltRepository _biltRepository;

        //    private GenericRepository<Matrial> _matrialRepository;

        //    public GenericRepository<Matrial> MAtrialRepository
        //    {
        //        get
        //        {
        //            if (_matrialRepository == null)
        //            {
        //                _matrialRepository = new GenericRepository<Matrial>(db);
        //            }

        //            return _matrialRepository;
        //        }
        //    }

        //    private GenericRepository<OrderCustomer2> _orderCustomer2;
        //    public GenericRepository<OrderCustomer2> OrderCustomer2
        //    {
        //        get
        //        {
        //            if (_orderCustomer2 == null)
        //            {
        //                _orderCustomer2 = new GenericRepository<OrderCustomer2>(db);
        //            }
        //            return _orderCustomer2;
        //        }

        //    }
        //    private GenericRepository<Section> _sectionRepository;

        //    private GenericRepository<Speed> _speedRepository;
        //    public GenericRepository<Speed> SpeedRepository 
        //        { 
        //        get
        //            {
        //            if (_speedRepository==null)
        //            {
        //                _speedRepository=new GenericRepository<Speed>(db);
        //            }
        //            return _speedRepository;
        //            }
        //        }
        //    public GenericRepository<Section> SectionRepository
        //    {
        //        get
        //        {
        //            if (_sectionRepository == null)
        //            {
        //                _sectionRepository = new GenericRepository<Section>(db);
        //            }

        //            return _sectionRepository;
        //        }
        //    }


        //    private GenericRepository<Elat> _elatRepository;
        //    public GenericRepository<Elat> ElatRepository
        //    {
        //        get
        //        {
        //            if (_elatRepository == null)
        //            {
        //                _elatRepository = new GenericRepository<Elat>(db);
        //            }

        //            return _elatRepository;
        //        }
        //    }


        //    private GenericRepository<Persen> _persenRepository;
        //    public GenericRepository<Persen> PersenRepository
        //    {
        //        get
        //        {
        //            if (_persenRepository == null)
        //            {
        //                _persenRepository = new GenericRepository<Persen>(db);
        //            }

        //            return _persenRepository;
        //        }
        //    }


        //    private GenericRepository<ReportStop> _reporterStopRepository;
        //    public GenericRepository<ReportStop> Repository
        //    {
        //        get
        //        {
        //            if (_reporterStopRepository == null)
        //            {
        //                _reporterStopRepository = new GenericRepository<ReportStop>(db);
        //            }

        //            return _reporterStopRepository;
        //        }
        //    }

        //    private GenericRepository<formolsharj1> _formlsharjRepository;

        //    public GenericRepository<formolsharj1> FromlRepository
        //    {
        //        get
        //        {
        //            if (_formlsharjRepository == null)
        //            {
        //                _formlsharjRepository = new GenericRepository<formolsharj1>(db);
        //            }

        //            return _formlsharjRepository;
        //        }
        //    }

        //    private GenericRepository<Zaiat> _zaiat;
        //    public GenericRepository<Zaiat> ZaiatRepository 
        //        {
        //        get
        //            {
        //            if (_zaiat==null)
        //            {
        //                _zaiat=new GenericRepository<Zaiat>(db);

        //            }
        //            return  _zaiat;
        //            }
        //        }

        //    private GenericRepository<Pardakht> _PardakhtRepository;

        //    public GenericRepository<Pardakht> PardakhtRepository
        //    {
        //        get
        //        {
        //            if (_PardakhtRepository == null)
        //            {
        //                _PardakhtRepository = new GenericRepository<Pardakht>(db);
        //            }

        //            return _PardakhtRepository;
        //        }
        //    }

        //    private GenericRepository<RezervPro> _rezervProRepository;
        //    public GenericRepository<RezervPro> RezervProRepository
        //    {
        //        get
        //        {
        //            if (_rezervProRepository == null)
        //            {
        //                _rezervProRepository = new GenericRepository<RezervPro>(db);
        //            }

        //            return _rezervProRepository;
        //        }
        //    }

        //    private GenericRepository<settingPro> _settingProRepository;

        //    private GenericRepository<HavaleWord> _havaleWordRepository;
        //    public GenericRepository<HavaleWord> HavaleWordRepository
        //    {
        //        get
        //        {
        //            if (_havaleWordRepository == null)
        //            {
        //                _havaleWordRepository = new GenericRepository<HavaleWord>(db);
        //            }

        //            return _havaleWordRepository;
        //        }
        //    }

        //    public GenericRepository<settingPro> SettingProRepository
        //    {
        //        get
        //        {
        //            if (_settingProRepository == null)
        //            {
        //                _settingProRepository = new GenericRepository<settingPro>(db);
        //            }

        //            return _settingProRepository;
        //        }
        //    }


        //    private GenericRepository<Program> _programRepository;

        //    public GenericRepository<Program> ProgramRepository
        //    {
        //        get
        //        {
        //            if (_programRepository == null)
        //            {
        //                _programRepository = new GenericRepository<Program>(db);
        //            }

        //            return _programRepository;
        //        }
        //    }

        //    private GenericRepository<Mojodi> _mojodiRepository;
        //    public GenericRepository<Mojodi> MojodiRepository
        //    {
        //        get
        //        {
        //            if (_mojodiRepository == null)
        //            {
        //                _mojodiRepository = new GenericRepository<Mojodi>(db);
        //            }

        //            return _mojodiRepository;
        //        }
        //    }


        //    private GenericRepository<UserLog> _userLogRepository;
        //    public GenericRepository<UserLog> UserLogRepository
        //    {
        //        get
        //        {
        //            if (_userLogRepository == null)
        //            {
        //                _userLogRepository = new GenericRepository<UserLog>(db);
        //            }
        //            return _userLogRepository;
        //        }
        //    }



        //    private GenericRepository<Havaleh2> _havaleh2Repository;
        //    public GenericRepository<Havaleh2> Havaleh2Repository
        //    {
        //        get
        //        {
        //            if (_havaleh2Repository == null)
        //            {
        //                _havaleh2Repository = new GenericRepository<Havaleh2>(db);
        //            }
        //            return _havaleh2Repository;
        //        }
        //    }

        //    private GenericRepository<Mojodi2> _mojodi2Repository;
        //    public GenericRepository<Mojodi2> Mojodi2Repository
        //    {
        //        get
        //        {
        //            if (_mojodi2Repository == null)
        //            {
        //                _mojodi2Repository = new GenericRepository<Mojodi2>(db);
        //            }
        //            return _mojodi2Repository;
        //        }
        //    }

        //    //private GenericRepository<Calendar> _calendeRepository;
        //    //public GenericRepository<Calendar> CalendeRepository {
        //    //    get
        //    //    {
        //    //        if (_calendeRepository==null)
        //    //        {
        //    //            _calendeRepository=new GenericRepository<Calendar>(db);
        //    //        }

        //    //        return _calendeRepository;
        //    //    }
        //    //}

        //    private GenericRepository<Customer> _customerRepository;

        //    public GenericRepository<Customer> CustomerRepository
        //    {
        //        get
        //        {
        //            if (_customerRepository == null)
        //            {
        //                _customerRepository = new GenericRepository<Customer>(db);
        //            }

        //            return _customerRepository;
        //        }
        //    }


        //    private GenericRepository<Products> _productsRepository;

        //    public GenericRepository<Products> ProductsRepository
        //    {
        //        get
        //        {
        //            if (_productsRepository == null)
        //            {
        //                _productsRepository = new GenericRepository<Products>(db);
        //            }

        //            return _productsRepository;
        //        }
        //    }

        //    private GenericRepository<UnitMatrial> _unitmatrialRepository;

        //    public GenericRepository<UnitMatrial> UnitmartialRepository
        //    {
        //        get
        //        {
        //            if (_unitmatrialRepository == null)
        //            {
        //                _unitmatrialRepository = new GenericRepository<UnitMatrial>(db);
        //            }

        //            return _unitmatrialRepository;
        //        }
        //    }

        //    private GenericRepository<MatrialPack> _matrialPack;
        //    public GenericRepository<MatrialPack> MatrialPackRepository
        //    {
        //        get
        //        {
        //            if (_matrialPack == null)
        //            {
        //                _matrialPack = new GenericRepository<MatrialPack>(db);
        //            }

        //            return _matrialPack;
        //        }
        //    }

        //    private GenericRepository<Seller> _sellerRepository;

        //    public GenericRepository<Seller> SellerRepository
        //    {
        //        get
        //        {
        //            if (_sellerRepository == null)
        //            {
        //                _sellerRepository = new GenericRepository<Seller>(db);
        //            }

        //            return _sellerRepository;
        //        }
        //    }


        //    private GenericRepository<Stop> _stopeRepository;

        //    public GenericRepository<Stop> StopRepository
        //    {
        //        get
        //        {
        //            if (_stopeRepository == null)
        //            {
        //                _stopeRepository = new GenericRepository<Stop>(db);
        //            }

        //            return _stopeRepository;
        //        }
        //    }

        //    public IDepotRepository DepotRepository
        //    {
        //        get
        //        {
        //            if (_depotRepository == null)
        //            {
        //                _depotRepository = new DepotRepository(db);
        //            }

        //            return _depotRepository;
        //        }
        //    }

        //    public IBiltRepository BiltRepository
        //    {
        //        get
        //        {
        //            if (_biltRepository==null)
        //            {
        //                _biltRepository=new BiltRepository(db);
        //            }
        //            return _biltRepository;
        //        }
        //    }

        //    private GenericRepository<Order> _orderRepository;

        //    public GenericRepository<Order> OrderRepository
        //    {
        //        get
        //        {
        //            if (_orderRepository == null)
        //            {
        //                _orderRepository = new GenericRepository<Order>(db);
        //            }

        //            return _orderRepository;
        //        }
        //    }

        //    public void save()
        //    {
        //        db.SaveChanges();
        //    }
        //public void Dispose()
        //{
        //    db.Dispose();
        //}
    }
}
