using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DonDuSang.DataLayer;
using DonDuSang.Forms;
using DonDuSang.Model;

namespace DonDuSang.Modules
{
    public partial class Acceuil : UserControl, IRibbonModule
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        RibbonControl IRibbonModule.Ribbon
        {
            get { return ribbonControl1; }
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            RefreshDataSource();
            gridViewDonneur.Columns[0].Visible = false;
            gridViewDonneur.Columns[1].Visible = false;
            gridViewDonneur.Columns[2].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridViewDonneur.Columns[3].Caption = "Prénom";
            gridViewDonneur.Columns[4].Caption = "Date de naissance";
            gridViewDonneur.Columns[5].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridViewDonneur.Columns[9].Visible = false;
        }

        private void ribbonControl1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "biNouveauDonneur":
                    CreateDonneur();
                    break;
                case "biModifierDonneur":
                    ModifyDonneur();
                    break;
                case "biSupprimerDonneur":
                    DeleteDonneur();
                    break;
                case "biFermer":
                    CloseForm();
                    break;
            }
        }

        private void CreateDonneur()
        {
            var donneur = new DonneurEdit(new Donneur(), true);
            donneur.ShowDialog();
            RefreshDataSource();
        }

        private void ModifyDonneur()
        {
            if (gridViewDonneur == null) return;
            var donneur = (Donneur)gridViewDonneur.GetFocusedRow();
            EditDonneur(donneur);
        }

        private void DeleteDonneur()
        {
            if (gridViewDonneur != null)
            {
                var resultat = MessageBox.Show("Voulez vous vraiment supprimer cet donneur ?", "Attention",
                MessageBoxButtons.YesNo);
                if (resultat != DialogResult.Yes) return;
                var donneur = (Donneur)gridViewDonneur.GetFocusedRow();
                new RepositoryDonneur().Remove(donneur);
                MessageBox.Show("Supression réussite");
                RefreshDataSource();
            }
            else
            {
                MessageBox.Show("Données inexistants");
            }
        }

        private void EditDonneur(Donneur don)
        {
            var donneur = new DonneurEdit(don, false);
            donneur.ShowDialog();
            RefreshDataSource();
        }



        private void gridControlDonneur_DoubleClick(object sender, EventArgs e)
        {
            ModifyDonneur();
        }

        private void RefreshDataSource()
        {
            var repositoryDonneur = new RepositoryDonneur();
            gridControlDonneur.DataSource = repositoryDonneur.FindAll();
        }

        private static void CloseForm()
        {
            Application.Exit();
        }
    }
}
