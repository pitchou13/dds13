using System;

namespace DonDuSang.Model
{
    public class Utilisateur
    {
        public Guid Id { get; set; }
        public bool NewObject { get; set; }
        public string Pseudo { get; set; }
        public string Mdp { get; set; }
        public bool Administrateur { get; set; }
        public string Type { get; set; }
        public bool Etat { get; set; }
    }

    public static class FactoryUtilisateur
    {
        public static Utilisateur CreateUser(string pseudo, string mdp, bool administrateur, bool etat)
        {
            var user = new Utilisateur
            {
                Id = Guid.NewGuid(),
                NewObject = true,
                Pseudo = pseudo,
                Mdp = mdp,
                Administrateur = administrateur,
                Type = null,
                Etat = true
            };
            return user;
        }

        public static Utilisateur CreateUser(string pseudo, string mdp, bool administrateur, string type)
        {
            var user = new Utilisateur
            {
                Id = Guid.NewGuid(),
                NewObject = true,
                Pseudo = pseudo,
                Mdp = mdp,
                Administrateur = administrateur,
                Type = type,
                Etat = true
            };
            return user;
        }
    }
}
