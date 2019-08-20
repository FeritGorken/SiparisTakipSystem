using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.StokDal
{
    public interface IStokDal
    {
        Stok Kaydet(Stok entity);
        List<Stok> Listele();
        List<Stok> Listele(Expression<Func<Stok,bool>> predicate);
        Stok Getir(int id);
        int Guncelle(Stok entity);
        bool Sil(int id);
        bool Sil(Stok entity);
        List<Stok> Guncelle(Expression<Func<Stok, bool>> predicate);
    }
}
