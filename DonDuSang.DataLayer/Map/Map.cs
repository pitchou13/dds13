using DevExpress.Xpo;
using DonDuSang.DataLayer.Entities;
using DonDuSang.Model;

namespace DonDuSang.DataLayer.Map
{
    public static class Map
    {
        public static XpoUtilisateur MapUtilisateur(Utilisateur utilisateur, UnitOfWork uow)
        {
            XpoUtilisateur xpoUtilisateur;
            if (utilisateur.NewObject)
            {
                xpoUtilisateur = new XpoUtilisateur(uow)
                {
                    Oid = utilisateur.Id
                };
            }
            else
            {
                xpoUtilisateur = uow.GetObjectByKey<XpoUtilisateur>(utilisateur.Id);
            }

            xpoUtilisateur.Pseudo = utilisateur.Pseudo;
            xpoUtilisateur.Mdp = utilisateur.Mdp;
            xpoUtilisateur.Administrateur = utilisateur.Administrateur;
            xpoUtilisateur.Type = utilisateur.Type;
            xpoUtilisateur.Etat = utilisateur.Etat;

            return xpoUtilisateur;
        }

        public static XpoDonneur MapDonneur(Donneur donneur, UnitOfWork uow)
        {
            XpoDonneur xpoDonneur;
            if (donneur.NewObject)
            {
                xpoDonneur = new XpoDonneur(uow)
                {
                    Oid = donneur.Id
                };
            }
            else
            {
                xpoDonneur= uow.GetObjectByKey<XpoDonneur>(donneur.Id);
            }

            xpoDonneur.Nom = donneur.Nom;
            xpoDonneur.Prenom = donneur.Prenom;
            xpoDonneur.DateNaissance = donneur.DateNaissance;
            xpoDonneur.Sexe = donneur.Sexe;
            xpoDonneur.Adresse = donneur.Adresse;
            xpoDonneur.Mail = donneur.Mail;
            xpoDonneur.NumTel = donneur.NumTel;
            xpoDonneur.Etat = donneur.Etat;

            return xpoDonneur;
        }
    }
}
