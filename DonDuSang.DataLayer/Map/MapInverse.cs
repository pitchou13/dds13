using DonDuSang.DataLayer.Entities;
using DonDuSang.Model;

namespace DonDuSang.DataLayer.Map
{
    public static class MapInverse
    {
        public static Utilisateur MapUtilisateur(XpoUtilisateur xpoUtilisateur)
        {
            var utilisateur = new Utilisateur
            {
                Id = xpoUtilisateur.Oid,
                Pseudo = xpoUtilisateur.Pseudo,
                Mdp = xpoUtilisateur.Mdp,
                Administrateur = xpoUtilisateur.Administrateur,
                Type = xpoUtilisateur.Type,
                Etat = xpoUtilisateur.Etat
            };
            return utilisateur;
        }

        public static Donneur MapDonneur(XpoDonneur xpoDonneur)
        {
            var donneur = new Donneur
            {
                Id = xpoDonneur.Oid,
                Nom = xpoDonneur.Nom,
                Prenom = xpoDonneur.Prenom,
                DateNaissance = xpoDonneur.DateNaissance,
                Sexe = xpoDonneur.Sexe,
                Adresse = xpoDonneur.Adresse,
                Mail = xpoDonneur.Mail,
                NumTel = xpoDonneur.NumTel,
                Etat = xpoDonneur.Etat
            };
            return donneur;
        }
    }
}
