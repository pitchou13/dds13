using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DonDuSang.DataLayer;
using DonDuSang.Model;

namespace DonDuSang.Forms
{
    public partial class UtilisateurEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Guid IdUser { get; set; }
        private readonly Utilisateur _utilisateur = new Utilisateur();
        readonly bool _newUser = true;
        public UtilisateurEdit(Utilisateur utilisateur,bool newUser)
        {
            InitializeComponent();
            if (!newUser)
            {
                IdUser = utilisateur.Id;
                textEditUser.Text = utilisateur.Pseudo;
                textEditMdp.Text = utilisateur.Mdp;
                radioGroup1.EditValue = utilisateur.Administrateur;
                comboBoxEditType.SelectedText = utilisateur.Type;
            }
            if (!utilisateur.Administrateur)
            {
                lbType.Enabled = true;
                comboBoxEditType.Enabled = true;
            }
            _utilisateur = utilisateur;
            _newUser = newUser;
        }

        private void biSauvegarder_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_newUser)
            {
                if (radioGroup1.EditValue.Equals(true))
                {
                    var utilisateur = FactoryUtilisateur.CreateUser(textEditUser.Text, textEditMdp.Text, true, true);
                    new RepositoryUtilisateur().Save(utilisateur);                          
                    MessageBox.Show("Ajout réussis");
                }
                else
                {
                    var utilisateur = FactoryUtilisateur.CreateUser(textEditUser.Text, textEditMdp.Text, false, comboBoxEditType.SelectedText);
                    new RepositoryUtilisateur().Save(utilisateur);
                    MessageBox.Show("mise à jours réussis");
                }
                
            }
            else
            {
                if (radioGroup1.EditValue.Equals(true))
                {
                    var utilisateur = new Utilisateur
                    {
                        Id = IdUser,
                        Pseudo = textEditUser.Text,
                        Mdp = textEditMdp.Text,
                        Administrateur = true,
                        Type = null
                    };
                    new RepositoryUtilisateur().Save(utilisateur);
                    MessageBox.Show("Ajout réussis");
                }
                else
                {
                    var utilisateur = new Utilisateur
                    {
                        Id = IdUser,
                        Pseudo = textEditUser.Text,
                        Mdp = textEditMdp.Text,
                        Administrateur = false,
                        Type = comboBoxEditType.SelectedText
                    };
                    new RepositoryUtilisateur().Save(utilisateur);
                    MessageBox.Show("mise à jours réussis");
                }
            }
        }

        private void biSauvegarderFermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_newUser)
            {
                if (radioGroup1.EditValue.Equals(true))
                {
                    var utilisateur = FactoryUtilisateur.CreateUser(textEditUser.Text, textEditMdp.Text, true, true);
                    new RepositoryUtilisateur().Save(utilisateur);
                    MessageBox.Show("Ajout réussis");
                }
                else
                {
                    var utilisateur = FactoryUtilisateur.CreateUser(textEditUser.Text, textEditMdp.Text, false, comboBoxEditType.SelectedText);
                    new RepositoryUtilisateur().Save(utilisateur);
                    MessageBox.Show("mise à jours réussis");
                }

            }
            else
            {
                if (radioGroup1.EditValue.Equals(true))
                {
                    var utilisateur = new Utilisateur
                    {
                        Id = IdUser,
                        Pseudo = textEditUser.Text,
                        Mdp = textEditMdp.Text,
                        Administrateur = true,
                        Type = null
                    };
                    new RepositoryUtilisateur().Save(utilisateur);
                    MessageBox.Show("Ajout réussis");
                }
                else
                {
                    var utilisateur = new Utilisateur
                    {
                        Id = IdUser,
                        Pseudo = textEditUser.Text,
                        Mdp = textEditMdp.Text,
                        Administrateur = false,
                        Type = comboBoxEditType.SelectedText
                    };
                    new RepositoryUtilisateur().Save(utilisateur);
                    MessageBox.Show("Mise à jours réussis");
                }
            }
            Close();
        }

        private void biAnnulerChangement_ItemClick(object sender, ItemClickEventArgs e)
        {
            textEditUser.Text = _utilisateur.Pseudo;
            textEditMdp.Text = _utilisateur.Mdp;
            radioGroup1.EditValue = _utilisateur.Administrateur;
            comboBoxEditType.SelectedText = _utilisateur.Type;
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

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.EditValue.Equals(false))
            {
                lbType.Enabled = true;
                comboBoxEditType.Enabled = true;
            }
            else
            {
                lbType.Enabled = false;
                comboBoxEditType.Enabled = false;
            }
        }
    }
}