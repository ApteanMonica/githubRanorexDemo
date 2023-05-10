﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace L_LAGS_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verwaltung_Lagerplatz recording.
    /// </summary>
    [TestModule("102c5130-6a51-4668-b4d4-5a559f65458b", ModuleType.Recording, 1)]
    public partial class Verwaltung_Lagerplatz : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::L_LAGS_001.L_LAGS_001Repository repository.
        /// </summary>
        public static global::L_LAGS_001.L_LAGS_001Repository repo = global::L_LAGS_001.L_LAGS_001Repository.Instance;

        static Verwaltung_Lagerplatz instance = new Verwaltung_Lagerplatz();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verwaltung_Lagerplatz()
        {
            Lager_nr = "500";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verwaltung_Lagerplatz Instance
        {
            get { return instance; }
        }

#region Variables

        string _Lager_nr;

        /// <summary>
        /// Gets or sets the value of variable Lager_nr.
        /// </summary>
        [TestVariable("cd571cb6-b5b0-4296-b2a9-8d574be10ab7")]
        public string Lager_nr
        {
            get { return _Lager_nr; }
            set { _Lager_nr = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLag.PbNavigationLgpl' at Center.", repo.MdiLag.PbNavigationLgplInfo, new RecordItemIndex(0));
            repo.MdiLag.PbNavigationLgpl.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Verwaltung Lagerplätze') on item 'MdiLgpl.TitleBar100VerwaltungLagerplaetze'.", repo.MdiLgpl.TitleBar100VerwaltungLagerplaetzeInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.MdiLgpl.TitleBar100VerwaltungLagerplaetzeInfo, "Text", "Verwaltung Lagerplätze");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLgpl.Lager' at Center.", repo.MdiLgpl.LagerInfo, new RecordItemIndex(2));
            repo.MdiLgpl.Lager.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Lager_nr' with focus on 'MdiLgpl.Lager'.", repo.MdiLgpl.LagerInfo, new RecordItemIndex(3));
            repo.MdiLgpl.Lager.PressKeys(Lager_nr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MdiLgpl.Lager'.", repo.MdiLgpl.LagerInfo, new RecordItemIndex(4));
            repo.MdiLgpl.Lager.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLgpl.RibbonBar.PbDataAccessLoad' at Center.", repo.MdiLgpl.RibbonBar.PbDataAccessLoadInfo, new RecordItemIndex(5));
            repo.MdiLgpl.RibbonBar.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'MdiLgpl.Row1Column0'.", repo.MdiLgpl.Row1Column0Info, new RecordItemIndex(6));
            Validate.NotExists(repo.MdiLgpl.Row1Column0Info);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLgpl.RibbonBar.PbDataAccessSave' at Center.", repo.MdiLgpl.RibbonBar.PbDataAccessSaveInfo, new RecordItemIndex(7));
            repo.MdiLgpl.RibbonBar.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLgpl.FlexGrid' at Center.", repo.MdiLgpl.FlexGridInfo, new RecordItemIndex(8));
            repo.MdiLgpl.FlexGrid.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Insert}' with focus on 'MdiLgpl.FlexGrid'.", repo.MdiLgpl.FlexGridInfo, new RecordItemIndex(9));
            repo.MdiLgpl.FlexGrid.PressKeys("{Insert}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'A{LShiftKey up}{Subtract}{NumPad0}{NumPad0}{NumPad0}{Tab}' with focus on 'MdiLgpl.FlexGrid1.ColLgplNrRow1'.", repo.MdiLgpl.FlexGrid1.ColLgplNrRow1Info, new RecordItemIndex(10));
            repo.MdiLgpl.FlexGrid1.ColLgplNrRow1.EnsureVisible();
            Keyboard.Press("A{LShiftKey up}{Subtract}{NumPad0}{NumPad0}{NumPad0}{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Standardlagerplatz' with focus on 'MdiLgpl.FlexGrid1.ColLgplBezRow1'.", repo.MdiLgpl.FlexGrid1.ColLgplBezRow1Info, new RecordItemIndex(11));
            repo.MdiLgpl.FlexGrid1.ColLgplBezRow1.EnsureVisible();
            Keyboard.Press("Standardlagerplatz");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MdiLgpl.FlexGrid1.ColLgplBezRow1'.", repo.MdiLgpl.FlexGrid1.ColLgplBezRow1Info, new RecordItemIndex(12));
            repo.MdiLgpl.FlexGrid1.ColLgplBezRow1.EnsureVisible();
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}{Tab}{Tab}' with focus on 'MdiLgpl.FlexGrid1.ColLgpkCdRow1'.", repo.MdiLgpl.FlexGrid1.ColLgpkCdRow1Info, new RecordItemIndex(13));
            repo.MdiLgpl.FlexGrid1.ColLgpkCdRow1.EnsureVisible();
            Keyboard.Press("{NumPad1}{Tab}{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad0}{Tab}' with focus on 'MdiLgpl.FlexGrid1.ColLgplSperreRow1'.", repo.MdiLgpl.FlexGrid1.ColLgplSperreRow1Info, new RecordItemIndex(14));
            repo.MdiLgpl.FlexGrid1.ColLgplSperreRow1.EnsureVisible();
            Keyboard.Press("{NumPad0}{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Insert}' with focus on 'MdiLgpl.FlexGrid1.ColLgplSperreRow1'.", repo.MdiLgpl.FlexGrid1.ColLgplSperreRow1Info, new RecordItemIndex(15));
            repo.MdiLgpl.FlexGrid1.ColLgplSperreRow1.EnsureVisible();
            Keyboard.Press("{Insert}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'A{Subtract}{NumPad0}{NumPad0}{NumPad1}{Tab}' with focus on 'MdiLgpl.FlexGrid1.ColLgplNrRow2'.", repo.MdiLgpl.FlexGrid1.ColLgplNrRow2Info, new RecordItemIndex(16));
            repo.MdiLgpl.FlexGrid1.ColLgplNrRow2.PressKeys("A{Subtract}{NumPad0}{NumPad0}{NumPad1}{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Lagerplatz1{Tab}' with focus on 'MdiLgpl.FlexGrid1.ColLgplBezRow2'.", repo.MdiLgpl.FlexGrid1.ColLgplBezRow2Info, new RecordItemIndex(17));
            repo.MdiLgpl.FlexGrid1.ColLgplBezRow2.EnsureVisible();
            Keyboard.Press("Lagerplatz1{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}{Tab}{Tab}' with focus on 'MdiLgpl.FlexGrid1.ColLgpkCdRow2'.", repo.MdiLgpl.FlexGrid1.ColLgpkCdRow2Info, new RecordItemIndex(18));
            repo.MdiLgpl.FlexGrid1.ColLgpkCdRow2.EnsureVisible();
            Keyboard.Press("{NumPad1}{Tab}{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad0}' with focus on 'MdiLgpl.FlexGrid1.ColLgplSperreRow2'.", repo.MdiLgpl.FlexGrid1.ColLgplSperreRow2Info, new RecordItemIndex(19));
            repo.MdiLgpl.FlexGrid1.ColLgplSperreRow2.PressKeys("{NumPad0}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLgpl.RibbonBar.PbDataAccessSave' at Center.", repo.MdiLgpl.RibbonBar.PbDataAccessSaveInfo, new RecordItemIndex(20));
            repo.MdiLgpl.RibbonBar.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLgpl.RibbonBar.PbNavigationLag' at Center.", repo.MdiLgpl.RibbonBar.PbNavigationLagInfo, new RecordItemIndex(21));
            repo.MdiLgpl.RibbonBar.PbNavigationLag.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLag.TpAllgemein.StandardLagerplatz' at CenterRight.", repo.MdiLag.TpAllgemein.StandardLagerplatzInfo, new RecordItemIndex(22));
            repo.MdiLag.TpAllgemein.StandardLagerplatz.Click(Location.CenterRight);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LLAGS.DropDown' at 0;0.", repo.LLAGS.DropDownInfo, new RecordItemIndex(23));
            repo.LLAGS.DropDown.Click("0;0");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MdiLag.TpAllgemein.StandardLagerplatz'.", repo.MdiLag.TpAllgemein.StandardLagerplatzInfo, new RecordItemIndex(24));
            repo.MdiLag.TpAllgemein.StandardLagerplatz.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLag.PbDataAccessSave' at Center.", repo.MdiLag.PbDataAccessSaveInfo, new RecordItemIndex(25));
            repo.MdiLag.PbDataAccessSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
