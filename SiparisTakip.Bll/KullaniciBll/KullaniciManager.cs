using SiparisTakip.Dal.Abstract.KullaniciDal;
using SiparisTakip.Dal.Concrete.EntityFramework.Repository;
using SiparisTakip.Entity.Models;
using SiparisTakip.Interfaces.Kullanici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.KullaniciBll
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal;

        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            this._kullaniciDal = kullaniciDal;
        }

        public Kullanici Getir(int id)
        {
            return _kullaniciDal.Getir(id);
        }

        public int Guncelle(Kullanici entity)
        {
            return _kullaniciDal.Guncelle(entity);
        }

        public Kullanici Kaydet(Kullanici entity)
        {
            return _kullaniciDal.Kaydet(entity);
        }

        public Kullanici KullaniciGiris(string kullaniciAdi, string parola)
        {
            try
            {
                if(string.IsNullOrEmpty(kullaniciAdi.Trim()) || string.IsNullOrEmpty(parola.Trim()))
                {
                    throw new Exception("Kullanici Adı veya parola Boş geçilemez");
                    
                }
             
                var sifre = new ToPasswordRepository().Md5(parola);
                var kullanici=_kullaniciDal.KullaniciGiris(kullaniciAdi, sifre);
                if (kullanici == null)
                    throw new Exception("Kullanici ve Parola hatalı");
                else
                    return kullanici;
            }
            catch(Exception error)
            {
                throw new Exception("Hata olustu"+error.Message);
            }
        }


        public List<Kullanici> Listele()
        {
            return _kullaniciDal.Listele();
        }

        public List<Kullanici> Listele(Expression<Func<Kullanici, bool>> predicate)
        {
            return _kullaniciDal.Guncelle(predicate);
        }

        public bool Sil(int id)
        {
            return _kullaniciDal.Sil(id);
        }

        public bool Sil(Kullanici entity)
        {
           
            return _kullaniciDal.Sil(entity);
        }
    }
}
