using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;
using DonDuSang.DataLayer;

namespace DonDuSang.Forms
{
    public partial class Authentification : Form
    {
        public RepositoryUtilisateur RepositoryAuthentification;

        public Authentification()
        {
            InitializeComponent();
        }
       
        private void Connecter_Click(object sender, EventArgs e)
        {
            pEFalse2.Visible = false;
            if (textEditLogin.Text == "")
            {
                pEFalse1.Visible = true;
            }
            else
            {
                var repositoryUser = new RepositoryUtilisateur();
                var authentification =
                    repositoryUser.FindAll().Any(p => p.Pseudo == textEditLogin.Text);
                if (authentification)
                {
                    pEFalse1.Visible = false;
                    if (textEditPassword.Text != "")
                    {
                        var authentification2 =repositoryUser.FindAll()
                                .Where(p => p.Pseudo == textEditLogin.Text && p.Mdp == textEditPassword.Text).ToList();
                        if (authentification2.IsEmpty())
                        {
                            pEFalse2.Visible = true;
                        }
                        else
                        {
                            Hide();
                            new FrmMain(authentification2.First().Administrateur, authentification2.First().Type).Show();
                        }
                    }
                    else
                    {
                        pEFalse2.Visible = true;
                    }
                }
                else
                {
                    pEFalse1.Visible = true;
                }
            }
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textEditLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            textEditPassword.Select();
            textEditPassword.SelectionStart = 0;
            textEditPassword.SelectionLength = textEditPassword.Text.Length;
        }

        private void textEditLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down) return;
            textEditPassword.Select();
            textEditPassword.SelectionStart = 0;
            textEditPassword.SelectionLength = textEditPassword.Text.Length;
        }

        private void textEditPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Connecter_Click(sender,e);
            }
        }

        private void textEditPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up) return;
            textEditLogin.Select();
            textEditLogin.SelectionStart = 0;
            textEditLogin.SelectionLength = textEditLogin.Text.Length;
        }

        private void textEditLogin_Enter(object sender, EventArgs e)
        {
            textEditLogin.SelectAll();
        }

        private void textEditPassword_Enter(object sender, EventArgs e)
        {
            textEditPassword.SelectAll();
        }
    }
}
