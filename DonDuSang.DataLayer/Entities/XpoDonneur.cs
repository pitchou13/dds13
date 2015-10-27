using System;
using DevExpress.Xpo;

namespace DonDuSang.DataLayer.Entities
{
    public class XpoDonneur : XPBaseObject
    {
        public XpoDonneur()
        {

        }

        public XpoDonneur(Session session)
            : base(session)
        {

        }

        private Guid _oid;
        [Key]
        public Guid Oid
        {
            get { return _oid; }
            set { SetPropertyValue("Oid", ref _oid, value); }
        }

        private String _nom;
        public String Nom
        {
            get { return _nom; }
            set { SetPropertyValue("Nom", ref _nom, value); }
        }

        private String _prenom;
        public String Prenom
        {
            get { return _prenom; }
            set { SetPropertyValue("Prenom", ref _prenom, value); }
        }

        private DateTime _dateNaissance;
        public DateTime DateNaissance
        {
            get { return _dateNaissance; }
            set { SetPropertyValue("DateNaissance", ref _dateNaissance, value); }
        }

        private string _sexe;
        public string Sexe
        {
            get { return _sexe; }
            set { SetPropertyValue("Sexe", ref _sexe, value); }
        }

        private string _adresse;
        public string Adresse
        {
            get { return _adresse; }
            set { SetPropertyValue("Adresse", ref _adresse, value); }
        }

        private string _mail;
        public string Mail
        {
            get { return _mail; }
            set { SetPropertyValue("Mail", ref _mail, value); }
        }

        private Int32 _numTel;
        public Int32 NumTel
        {
            get { return _numTel; }
            set { SetPropertyValue("NumTel", ref _numTel, value); }
        }

        private bool _etat;
        public bool Etat
        {
            get { return _etat; }
            set { SetPropertyValue("Etat", ref _etat, value); }
        }
    }
}
