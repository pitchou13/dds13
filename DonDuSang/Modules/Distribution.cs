using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace DonDuSang.Modules
{
    public partial class Distribution : UserControl, IRibbonModule
    {

        public Distribution()
        {
            InitializeComponent();
        }

        RibbonControl IRibbonModule.Ribbon { get { return ribbonControl1; } }

    }
}
