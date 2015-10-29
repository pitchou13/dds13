using System;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DonDuSang.DataLayer;
using DonDuSang.Model;

namespace DonDuSang.Forms
{
    public partial class DonneurEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Guid IdDonneur { get; set; }
        private readonly Donneur _donneur = new Donneur();
        readonly bool _newDonneur = true;
        public DonneurEdit(Donneur donneur,bool newDonneur)
        {
            InitializeComponent();
            if (!newDonneur)
            {
                IdDonneur = donneur.Id;
                textEditNom.Text = donneur.Nom;
                textEditPrenom.Text = donneur.Prenom;
                dateEditNaissance.Text = donneur.DateNaissance.ToShortDateString();
                comboBoxEditSexe.SelectedItem = donneur.Sexe;
                textEditAdresse.Text = donneur.Adresse;
                textEditMail.Text = donneur.Mail;
                textEditNumTel.Text = donneur.NumTel.ToString(CultureInfo.InvariantCulture);
            }
            _donneur = donneur;
            _newDonneur = newDonneur;
        }

        private void biSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_newDonneur)
            {
                var donneur = FactoryDonneur.CreateDonneur(textEditNom.Text, textEditPrenom.Text, dateEditNaissance.DateTime, comboBoxEditSexe.SelectedText, textEditAdresse.Text, textEditMail.Text, Convert.ToInt32(textEditNumTel.Text));
                new RepositoryDonneur().Save(donneur);
                MessageBox.Show("Ajout réussis");
            }
            else
            {
                var donneur = new Donneur
                {
                    Id = IdDonneur,
                    Nom = textEditNom.Text,
                    Prenom = textEditPrenom.Text,
                    DateNaissance = dateEditNaissance.DateTime,
                    Sexe = comboBoxEditSexe.SelectedText,
                    Adresse = textEditAdresse.Text,
                    Mail = textEditMail.Text,
                    NumTel = Convert.ToInt32(textEditNumTel.Text),
                };
                new RepositoryDonneur().Save(donneur);
                MessageBox.Show("mise à jours réussis");
            }
        }

        private void biSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_newDonneur)
            {
                var donneur = FactoryDonneur.CreateDonneur(textEditNom.Text, textEditPrenom.Text, dateEditNaissance.DateTime, comboBoxEditSexe.SelectedText, textEditAdresse.Text, textEditMail.Text, Convert.ToInt32(textEditNumTel.Text));
                new RepositoryDonneur().Save(donneur);
                MessageBox.Show("Ajout réussis");
            }
            else
            {
                var donneur = new Donneur
                {
                    Id = IdDonneur,
                    Nom = textEditNom.Text,
                    Prenom = textEditPrenom.Text,
                    DateNaissance = dateEditNaissance.DateTime,
                    Sexe = comboBoxEditSexe.SelectedText,
                    Adresse = textEditAdresse.Text,
                    Mail = textEditMail.Text,
                    NumTel = Convert.ToInt32(textEditNumTel.Text),
                };
                new RepositoryDonneur().Save(donneur);
                MessageBox.Show("mise à jours réussis");
            }
            Close();
        }

        private void biAnnulerChangement_ItemClick(object sender, ItemClickEventArgs e)
        {
            textEditNom.Text = _donneur.Nom;
            textEditPrenom.Text = _donneur.Prenom;
            dateEditNaissance.Text = _donneur.DateNaissance.ToShortDateString();
            comboBoxEditSexe.SelectedItem = _donneur.Sexe;
            textEditAdresse.Text = _donneur.Adresse;
            textEditMail.Text = _donneur.Mail;
            textEditNumTel.Text = _donneur.NumTel.ToString(CultureInfo.InvariantCulture);
        }

        private void biSupprimer_ItemClick(object sender, ItemClickEventArgs e)
        {
            new RepositoryDonneur().Remove(IdDonneur);
            MessageBox.Show("Supression réussite");
            Close();

        }

        private void biFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}