using SiparisTakip.Dal.Abstract.FaturaDal;
using SiparisTakip.Dal.Concrete.EntityFramework.Context;
using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EfFaturaRepository : IFaturaDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();

        public IQueryable FaturaRaporu(DateTime baslangic, DateTime bitis)
        {
            throw new NotImplementedException();
        }

        public Fatura Getir(int id)
        {
            return SiparisTakipContext.Fatura.AsNoTracking().Where(x => x.FaturaID == id).SingleOrDefault();
        }

        public int Guncelle(Fatura entity)
        {
            throw new NotImplementedException();
        }

        public Fatura Kaydet(Fatura entity)
        {
            throw new NotImplementedException();
        }

        public List<Fatura> Listele()
        {
            throw new NotImplementedException();
        }

        public List<Fatura> Listele(Expression<Func<Fatura, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }

        public bool Sil(Fatura entity)
        {
            throw new NotImplementedException();
        }
    }
}
