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

namespace L_LGINV_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Festlegung recording.
    /// </summary>
    [TestModule("9e210911-ec3f-462d-860f-eb5f461a58e0", ModuleType.Recording, 1)]
    public partial class Festlegung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::L_LGINV_001.L_LGINV_001Repository repository.
        /// </summary>
        public static global::L_LGINV_001.L_LGINV_001Repository repo = global::L_LGINV_001.L_LGINV_001Repository.Instance;

        static Festlegung instance = new Festlegung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Festlegung()
        {
            Inventur_Nr = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Festlegung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Inventur_Nr;

        /// <summary>
        /// Gets or sets the value of variable Inventur_Nr.
        /// </summary>
        [TestVariable("8a9993ce-ccdc-4b54-b7cc-d9f4ccf51446")]
        public string Inventur_Nr
        {
            get { return _Inventur_Nr; }
            set { _Inventur_Nr = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLginv.PbCommonFestlegung' at Center.", repo.MdiLginv.PbCommonFestlegungInfo, new RecordItemIndex(0));
            repo.MdiLginv.PbCommonFestlegung.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Inventurfestlegung') on item 'TblFestlegung.TitleBar100Inventurfestlegung'.", repo.TblFestlegung.TitleBar100InventurfestlegungInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.TblFestlegung.TitleBar100InventurfestlegungInfo, "Text", "Inventurfestlegung");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFestlegung.RibbonBar.PbDataAccessLoad' at Center.", repo.TblFestlegung.RibbonBar.PbDataAccessLoadInfo, new RecordItemIndex(2));
            repo.TblFestlegung.RibbonBar.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFestlegung.Row1Column0' at LowerCenter.", repo.TblFestlegung.Row1Column0Info, new RecordItemIndex(3));
            repo.TblFestlegung.Row1Column0.Click(Location.LowerCenter);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFestlegung.RibbonBar.PbCommonStart' at Center.", repo.TblFestlegung.RibbonBar.PbCommonStartInfo, new RecordItemIndex(4));
            repo.TblFestlegung.RibbonBar.PbCommonStart.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFestlegung.RibbonBar.PbDataAccessLoad' at Center.", repo.TblFestlegung.RibbonBar.PbDataAccessLoadInfo, new RecordItemIndex(5));
            repo.TblFestlegung.RibbonBar.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'TblFestlegung.Row1Column0'.", repo.TblFestlegung.Row1Column0Info, new RecordItemIndex(6));
            Validate.NotExists(repo.TblFestlegung.Row1Column0Info);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFestlegung.RibbonBar.PbCommonZaehlungBeendet' at Center.", repo.TblFestlegung.RibbonBar.PbCommonZaehlungBeendetInfo, new RecordItemIndex(7));
            repo.TblFestlegung.RibbonBar.PbCommonZaehlungBeendet.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblZaehlungBeendet.InventurNr' at Center.", repo.TblZaehlungBeendet.InventurNrInfo, new RecordItemIndex(8));
            repo.TblZaehlungBeendet.InventurNr.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F4}' with focus on 'TblZaehlungBeendet.InventurNr'.", repo.TblZaehlungBeendet.InventurNrInfo, new RecordItemIndex(9));
            repo.TblZaehlungBeendet.InventurNr.PressKeys("{F4}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LLGINV.DropDown' at UpperCenter.", repo.LLGINV.DropDownInfo, new RecordItemIndex(10));
            repo.LLGINV.DropDown.Click(Location.UpperCenter);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'TblZaehlungBeendet.InventurNr'.", repo.TblZaehlungBeendet.InventurNrInfo, new RecordItemIndex(11));
            repo.TblZaehlungBeendet.InventurNr.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~$Inventur_Nr) on item 'TblZaehlungBeendet.InventurNr'.", repo.TblZaehlungBeendet.InventurNrInfo, new RecordItemIndex(12));
            Validate.AttributeRegex(repo.TblZaehlungBeendet.InventurNrInfo, "Text", new Regex(Inventur_Nr));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblZaehlungBeendet.PbDataAccessLoad' at Center.", repo.TblZaehlungBeendet.PbDataAccessLoadInfo, new RecordItemIndex(13));
            repo.TblZaehlungBeendet.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblZaehlungBeendet.Row1Column0' at LowerCenter.", repo.TblZaehlungBeendet.Row1Column0Info, new RecordItemIndex(14));
            repo.TblZaehlungBeendet.Row1Column0.Click(Location.LowerCenter);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblZaehlungBeendet.PbCommonStart' at Center.", repo.TblZaehlungBeendet.PbCommonStartInfo, new RecordItemIndex(15));
            repo.TblZaehlungBeendet.PbCommonStart.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblZaehlungBeendet.Schliessen' at Center.", repo.TblZaehlungBeendet.SchliessenInfo, new RecordItemIndex(16));
            repo.TblZaehlungBeendet.Schliessen.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFestlegung.Schliessen' at Center.", repo.TblFestlegung.SchliessenInfo, new RecordItemIndex(17));
            repo.TblFestlegung.Schliessen.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
