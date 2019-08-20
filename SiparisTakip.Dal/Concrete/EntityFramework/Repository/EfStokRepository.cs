using SiparisTakip.Dal.Abstract.StokDal;
using SiparisTakip.Dal.Concrete.EntityFramework.Context;
using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EfStokRepository : IStokDal
    {
        SiparisTakipContext SiparisTakipContext = new SiparisTakipContext();
        public Stok Getir(int id)
        {
            return SiparisTakipContext.Stok.AsNoTracking().Where(x => x.StokID == id).SingleOrDefault();
        }

        public int Guncelle(Stok entity)
        {
            SiparisTakipContext.Stok.AddOrUpdate(entity);
            return SiparisTakipContext.SaveChanges();
        }

        public List<Stok> Guncelle(Expression<Func<Stok, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Stok Kaydet(Stok entity)
        {
            using (var aaa = new SiparisTakipContext())
            {
                aaa.Stok.Add(entity);
                SiparisTakipContext.SaveChanges();
                return entity;
            }
            //SiparisTakipContext.Stok.Add(entity);
            //SiparisTakipContext.SaveChanges();
            //return entity;
        }

        public List<Stok> Listele()
        {
            return SiparisTakipContext.Stok.AsNoTracking().ToList();
        }

        public List<Stok> Listele(Expression<Func<Stok, bool>> predicate)
        {
            return SiparisTakipContext.Stok.Where(predicate).ToList();
        }

        public bool Sil(int id)
        {
            var stok = Getir(id);
            return Sil(stok);
        }
        

        public bool Sil(Stok entity)
        {
            SiparisTakipContext.Stok.Remove(entity);
            return SiparisTakipContext.SaveChanges()>0;
            
        }
    }
}
