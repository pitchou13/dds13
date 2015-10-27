using System;
using DevExpress.XtraBars.Ribbon;

namespace DonDuSang {
    public interface IRibbonModule
    {
        RibbonControl Ribbon { get; }
    }
}
