﻿using SiparisTakip.Dal.Abstract.StokDal;
using SiparisTakip.Dal.Concrete.EntityFramework.Repository;
using SiparisTakip.Entity.Models;
using SiparisTakip.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SiparisTakip.Bll.Stok
{
    public class StokManager : IStokService
    {
        IStokDal _stokDal;

        public StokManager(IStokDal stokDal)
        {
            this._stokDal = stokDal;
        }

        public Entity.Models.Stok Getir(int id)
        {
            return _stokDal.Getir(id);
        }

        public int Guncelle(Entity.Models.Stok entity)
        {
            return _stokDal.Guncelle(entity);
        }

        public Entity.Models.Stok Kaydet(Entity.Models.Stok entity)
        {
            return _stokDal.Kaydet(entity);
        }

        public List<Entity.Models.Stok> Listele()
        {
            return _stokDal.Listele();
        }

        public List<Entity.Models.Stok> Listele(Expression<Func<Entity.Models.Stok, bool>> predicate)
        {
            return _stokDal.Guncelle(predicate);
        }

        public bool Sil(int id)
        {
            return _stokDal.Sil(id);
        }

        public bool Sil(Entity.Models.Stok entity)
        {
            return _stokDal.Sil(entity);
        }
    }
}
