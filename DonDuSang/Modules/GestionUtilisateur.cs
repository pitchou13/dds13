using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Filtering;
using DonDuSang.DataLayer;
using DonDuSang.Forms;
using DonDuSang.Model;

namespace DonDuSang.Modules
{
    public partial class GestionUtilisateur : UserControl, IRibbonModule
    {
        public GestionUtilisateur()
        {
            InitializeComponent();
        }

        RibbonControl IRibbonModule.Ribbon
        {
            get { return ribbonControl1; }
        }

        private void GestionUtilisateur_Load(object sender, System.EventArgs e)
        {
            RefreshDataSource();
            gridViewUtilisateur.Columns[0].Visible = false;
            gridViewUtilisateur.Columns[1].Visible = false;
            gridViewUtilisateur.Columns[2].Caption = "Nom d'utilisateur";
            gridViewUtilisateur.Columns[2].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridViewUtilisateur.Columns[3].Caption = "Mot de passe";
            gridViewUtilisateur.Columns[3].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridViewUtilisateur.Columns[4].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridViewUtilisateur.Columns[5].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridViewUtilisateur.Columns[6].Visible = false;

        }

        private void ribbonControl1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "biNouveauUtilisateur":
                    CreateUser();
                    break;
                case "biModifierUtilisateur":
                    ModifyUser();
                    break;
                case "biSupprimerUtilisateur":
                    DeleteUser();
                    break;
                case "biFermer":
                    CloseForm();
                    break;
            }
        }

        private void CreateUser()
        {
            var utilisater = new UtilisateurEdit(new Utilisateur(), true);
            utilisater.ShowDialog();
            RefreshDataSource();
        }

        private void ModifyUser()
        {
            if (gridViewUtilisateur == null) return;
            var utilisateur = (Utilisateur) gridViewUtilisateur.GetFocusedRow();
            EditUser(utilisateur);
        }

        private void DeleteUser()
        {
            if (gridViewUtilisateur == null) return;
            var utilisateur = (Utilisateur)gridViewUtilisateur.GetFocusedRow();
            new RepositoryUtilisateur().Remove(utilisateur);
            MessageBox.Show("Supression réussite");
            RefreshDataSource();

        }

        private void EditUser(Utilisateur user)
        {
            var utilisateur = new UtilisateurEdit(user, false);
            utilisateur.ShowDialog();
            RefreshDataSource();
        }



        private void gridControlUtilisateur_DoubleClick(object sender, System.EventArgs e)
        {
            ModifyUser();
        }

        private void RefreshDataSource()
        {
            var repositoryUtilisateur = new RepositoryUtilisateur();
            gridControlUtilisateur.DataSource = repositoryUtilisateur.FindAll();
        }

        private static void CloseForm()
        {
            Application.Exit();
        }

    }
}
