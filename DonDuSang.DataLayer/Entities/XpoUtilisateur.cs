using System;
using DevExpress.Xpo;

namespace DonDuSang.DataLayer.Entities
{
    public class XpoUtilisateur : XPBaseObject
    {
        public XpoUtilisateur()
        {

        }

        public XpoUtilisateur(Session session)
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

        private String _pseudo;
        public String Pseudo
        {
            get { return _pseudo; }
            set { SetPropertyValue("Pseudo", ref _pseudo, value); }
        }

        private String _mdp;
        public String Mdp
        {
            get { return _mdp; }
            set { SetPropertyValue("Mdp", ref _mdp, value); }
        }

        private bool _administrateur;
        public bool Administrateur
        {
            get { return _administrateur; }
            set { SetPropertyValue("Administrateur", ref _administrateur, value); }
        }

        private string _type;
        public string Type
        {
            get { return _type; }
            set { SetPropertyValue("Type", ref _type, value); }
        }

        private bool _etat;
        public bool Etat
        {
            get { return _etat; }
            set { SetPropertyValue("Etat", ref _etat, value); }
        }
    }
}
