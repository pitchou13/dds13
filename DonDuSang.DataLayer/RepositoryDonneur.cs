using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using DevExpress.Xpo;
using DonDuSang.DataLayer.Entities;
using DonDuSang.Model;

namespace DonDuSang.DataLayer
{
    public class RepositoryDonneur
    {
        public Donneur FindBy(Guid id)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var donneur = uow.GetObjectByKey<Donneur>(id);
                return donneur;
            }
        }

        public IEnumerable<Donneur> FindAll()
        {
            var listeDonneurs = new List<Donneur>();
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var donneurs = new XPCollection<XpoDonneur>(uow);
                listeDonneurs.AddRange(donneurs.Select(Map.MapInverse.MapDonneur).Where(u=>u.Etat));
            }
            return listeDonneurs;
        }

        public void Save(Donneur entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                Map.Map.MapDonneur(entity, uow);
                uow.CommitChanges();
            }
        }

        public void Add(Utilisateur entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Donneur entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var donneur = uow.GetObjectByKey<XpoDonneur>(entity.Id);
                donneur.Etat = false;
                uow.CommitChanges();
            }
        }
        public void Remove(Guid id)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var donneur = uow.GetObjectByKey<XpoDonneur>(id);
                donneur.Etat = false;
                uow.CommitChanges();
            }
        }
    }
}
