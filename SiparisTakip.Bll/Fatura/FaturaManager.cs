using SiparisTakip.Dal.Abstract.FaturaDal;
using SiparisTakip.Entity.Models;
using SiparisTakip.Interfaces.Fatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Fatura
{
    public class FaturaManager : IFaturaService
    {
        IFaturaDal _faturaDal;
        public FaturaManager(IFaturaDal faturaDal)
        {
            this._faturaDal = faturaDal;
        }
        public IQueryable FaturaRaporu(DateTime baslangic, DateTime bitis)
        {
            return _faturaDal.FaturaRaporu(baslangic, bitis);
        }

        public Entity.Models.Fatura Getir(int id)
        {
            return _faturaDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Fatura entity)
        {
            return _faturaDal.Guncelle(entity);
        }

        public Entity.Models.Fatura Kaydet(Entity.Models.Fatura entity)
        {
            return _faturaDal.Kaydet(entity);
        }

        public List<Entity.Models.Fatura> Listele()
        {
            return _faturaDal.Listele();
        }

        public List<Entity.Models.Fatura> Listele(Expression<Func<Entity.Models.Fatura, bool>> predicate)
        {
            return _faturaDal.Listele(predicate);
        }

        public bool Sil(int id)
        {
            return _faturaDal.Sil(id);
        }

        public bool Sil(Entity.Models.Fatura entity)
        {
            return Sil(entity);
        }
    }
}
