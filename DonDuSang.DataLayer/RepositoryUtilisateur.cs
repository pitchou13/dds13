using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using DevExpress.Xpo;
using DonDuSang.DataLayer.Entities;
using DonDuSang.Model;

namespace DonDuSang.DataLayer
{
    public class RepositoryUtilisateur
    {
        public Utilisateur FindBy(Guid id)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var authentification = uow.GetObjectByKey<Utilisateur>(id);
                return authentification;
            }
        }

        public IEnumerable<Utilisateur> FindAll()
        {
            var listeUsers = new List<Utilisateur>();
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var users = new XPCollection<XpoUtilisateur>(uow);
                listeUsers.AddRange(users.Select(Map.MapInverse.MapUtilisateur).Where(u=>u.Etat));
            }
            return listeUsers;
        }

        public void Save(Utilisateur entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                Map.Map.MapUtilisateur(entity, uow);
                uow.CommitChanges();
            }
        }

        public void Add(Utilisateur entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Utilisateur entity)
        {
            var config = new AppSettingsReader();
            using (
                var uow = new UnitOfWork
                {
                    ConnectionString = ((string)config.GetValue("connect", typeof(string)))
                })
            {
                var authentification = uow.GetObjectByKey<XpoUtilisateur>(entity.Id);
                authentification.Etat = false;
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
                var authentification = uow.GetObjectByKey<XpoUtilisateur>(id);
                authentification.Etat = false;
                uow.CommitChanges();
            }
        }
    }
}
