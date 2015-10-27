using System;
using System.Windows.Forms;
using DonDuSang.DataLayer;
using DonDuSang.Model;

namespace DonDuSang.Forms
{
    public partial class Authentification2 : Form
    {
        public Authentification2()
        {
            InitializeComponent();
        }
       
        private void Creer_Click(object sender, EventArgs e)
        {
            if (textEditPassword.Text != textEditPassword2.Text)
            {
                pEFalse.Visible = true;
            }
            else
            {
                pEFalse.Visible = false;
                var user = FactoryUtilisateur.CreateUser(textEditLogin.Text, textEditPassword.Text, true, true);
                new RepositoryUtilisateur().Save(user);
                Hide();
                new FrmMain(true,null).Show();
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
            if (e.KeyCode != Keys.Enter) return;
            textEditPassword2.Select();
            textEditPassword2.SelectionStart = 0;
            textEditPassword2.SelectionLength = textEditPassword2.Text.Length;
        }

        private void textEditPassword_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    textEditLogin.Select();
                    textEditLogin.SelectionStart = 0;
                    textEditLogin.SelectionLength = textEditLogin.Text.Length;
                    break;
                case Keys.Down:
                    textEditPassword2.Select();
                    textEditPassword2.SelectionStart = 0;
                    textEditPassword2.SelectionLength = textEditPassword2.Text.Length;
                    break;
            }
        }

        private void textEditPassword2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Creer_Click(sender, e);
            }
        }

        private void textEditPassword2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up) return;
            textEditPassword.Select();
            textEditPassword.SelectionStart = 0;
            textEditPassword.SelectionLength = textEditPassword.Text.Length;
        }

        private void textEditLogin_Enter(object sender, EventArgs e)
        {
            textEditLogin.SelectAll();
        }

        private void textEditPassword_Enter(object sender, EventArgs e)
        {
            textEditPassword.SelectAll();
        }

        private void textEditPassword2_Enter(object sender, EventArgs e)
        {
            textEditPassword2.SelectAll();
        }
    }
}
