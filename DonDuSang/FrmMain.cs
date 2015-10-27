using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;
using DonDuSang.Modules;

namespace DonDuSang
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private bool _admin;
        private string _type;
        public FrmMain(bool admin, string type)
        {
            InitializeComponent();
            //InitView<Acceuil>();
            _admin = admin;
            _type = type;
            ribbonControl.Toolbar.ItemLinks.Add(rgbiSkins);
            if (!_admin) return;
            var navigationItem = new NavigationBarItem {Text = "Gestion d'Utilisateur"};
            officeNavigationBar1.Items.Add(navigationItem);
        }

         #region Navigation Bar
        T Find<T>(Control container) where T : Control
        {
            for (int i = 0; i < container.Controls.Count; i++)
            {
                if (container.Controls[i] is T)
                {
                    return (T)container.Controls[i];
                }
            }
            return null;
        }

        void ChangeView<T>() where T : Control, new()
        {
            if (transitionManager1.IsTransition)
            {
                transitionManager1.EndTransition();
            }

            transitionManager1.StartTransition(modulesContainer);
            try
            {
                var find = new T { Parent = modulesContainer, Dock = DockStyle.Fill };
                var moduleControl = find as Control;
                var ribbonModuleControl = moduleControl as IRibbonModule;
                if (ribbonModuleControl != null)
                {
                    Ribbon.MergeRibbon(ribbonModuleControl.Ribbon);
                }
                else
                {
                    Ribbon.UnMergeRibbon();
                }
                find.BringToFront();
            }
            finally
            {
                transitionManager1.EndTransition();
            }
        }

        private void InitView<T>() where T : Control, new()
        {
            var find = new T {Parent = modulesContainer, Dock = DockStyle.Fill};
            var moduleControl = find as Control;
            var ribbonModuleControl = moduleControl as IRibbonModule;
            if (ribbonModuleControl != null)
            {
                Ribbon.MergeRibbon(ribbonModuleControl.Ribbon);
            }
            else
            {
                Ribbon.UnMergeRibbon();
            }
            find.BringToFront();
        }

        private void officeNavigationBar_ItemClick(object sender, NavigationBarItemEventArgs e)
        {
            if ((!_admin) && (_type != e.Item.Text)) return;
            switch (e.Item.Text)
            {
                case "Acceuil":
                    ChangeView<Acceuil>();
                    break;
                case "Service Médicale":
                    ChangeView<ServiceMedicale>();
                    break;
                case "Prélevement":
                    ChangeView<Prelevement>();
                    break;
                case "Controle Biologique":
                    ChangeView<ControleBiologique>();
                    break;
                case "Distribution":
                    ChangeView<Distribution>();
                    break;
                case "Gestion d'Utilisateur":
                    ChangeView<GestionUtilisateur>();
                    break;
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /*
        void RegisterNavPane(NavBarControl navBar, ModuleType type)
        {
            NavBarGroup navGroup = new NavBarGroup();
            navGroup.Tag = type;
            navGroup.Name = "navGroup" + ViewModel.GetModuleName(type);
            navGroup.Caption = ViewModel.GetModuleCaption(type);
            navGroup.LargeImage = (System.Drawing.Image)ViewModel.GetModuleImage(type);
            navGroup.GroupStyle = NavBarGroupStyle.ControlContainer;
            navGroup.ControlContainer = new NavBarGroupControlContainer();
            navBar.Controls.Add(navGroup.ControlContainer);
            navBar.Groups.Add(navGroup);
        }
        void navBar_ActiveGroupChanged(object sender, NavBarGroupEventArgs e)
        {
            var navPaneModuleType = (ModuleType)e.Group.Tag;
            if (ViewModel.SelectedNavPaneModuleType != navPaneModuleType)
                ViewModel.SelectedModuleType = ViewModel.GetMainModuleType(navPaneModuleType);
            Control moduleControl = GetNavPaneModule(navPaneModuleType);
            moduleControl.Dock = DockStyle.Fill;
            e.Group.ControlContainer.Controls.Add(moduleControl);

            var collapsedGroupModuleType = ViewModel.GetNavPaneModuleType(navPaneModuleType, true);
            e.Group.CollapsedNavPaneContentControl = GetNavPaneModule(collapsedGroupModuleType);
        }*/
        #endregion Navigation Bar
    }
}