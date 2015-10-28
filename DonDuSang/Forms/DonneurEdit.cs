using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DonDuSang.DataLayer;
using DonDuSang.Model;

namespace DonDuSang.Forms
{
    public partial class DonneurEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Guid IdUser { get; set; }
        private readonly Donneur _donneur = new Donneur();
        readonly bool _newUser = true;
        public DonneurEdit(Donneur donneur,bool newDonneur)
        {
            InitializeComponent();
            if (!newDonneur)
            {
                IdUser = donneur.Id;
                textEditNom.Text = donneur.Nom;
                textEditPrenom.Text = donneur.Prenom;
                comboBoxEditSexe.SelectedText = donneur.Sexe;
            }
            _donneur = donneur;
            _newUser = newDonneur;
        }

        private void biSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void biSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            Close();
        }

        private void biAnnulerChangement_ItemClick(object sender, ItemClickEventArgs e)
        {
            textEditNom.Text = _donneur.Nom;
            textEditPrenom.Text = _donneur.Prenom;
            comboBoxEditSexe.SelectedText = _donneur.Sexe;
        }

        private void biSupprimer_ItemClick(object sender, ItemClickEventArgs e)
        {
            new RepositoryUtilisateur().Remove(IdUser);
            MessageBox.Show("Supression réussite");
            Close();

        }

        private void biFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        void FillTextbox()
        {
            
        }
    }
}