using System;

namespace DonDuSang.Model
{
    public class Donneur
    {
        public Guid Id { get; set; }
        public bool NewObject { get; set; }
        public string Nom{ get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Sexe { get; set; }
        public string Adresse { get; set; }
        public string Mail { get; set; }
        public Int32 NumTel { get; set; }
        public bool Etat { get; set; }
    }

    public static class FactoryDonneur
    {
        public static Donneur CreateDonneur(string nom, string prenom, DateTime dateTime, string sexe, string adresse, string mail, Int32 numTel)
        {
            var user = new Donneur
            {
                Id = Guid.NewGuid(),
                NewObject = true,
                Nom = nom,
                Prenom = prenom,
                DateNaissance = dateTime,
                Sexe = sexe,
                Adresse = adresse,
                Mail = mail,
                NumTel = numTel,
                Etat = true
            };
            return user;
        }
    }
}
