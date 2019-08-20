using SiparisTakip.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Dal.Abstract.KullaniciDal
{
   public interface IKullaniciDal
    {
        Kullanici Kaydet(Kullanici entity);
        List<Kullanici> Listele();
        List<Kullanici> Listele(Expression<Func<Kullanici, bool>> predicate);
        Kullanici Getir(int id);
        int Guncelle(Kullanici entity);
        bool Sil(int id);
        bool Sil(Kullanici entity);
        Kullanici KullaniciGiris(string kullaniciAdi, string sifre);
        List<Kullanici> Guncelle(Expression<Func<Kullanici, bool>> predicate);
    }
}
