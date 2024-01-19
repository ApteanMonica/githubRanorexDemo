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

namespace B_SCOPY_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The alle_markieren_ohne_BUST_ohne_UST_Fehlermeldung recording.
    /// </summary>
    [TestModule("78018d83-d72b-4615-9faf-e7b6507fbd65", ModuleType.Recording, 1)]
    public partial class Alle_markieren_ohne_BUST_ohne_UST_Fehlermeldung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_SCOPY_001.B_SCOPY_001Repository repository.
        /// </summary>
        public static global::B_SCOPY_001.B_SCOPY_001Repository repo = global::B_SCOPY_001.B_SCOPY_001Repository.Instance;

        static Alle_markieren_ohne_BUST_ohne_UST_Fehlermeldung instance = new Alle_markieren_ohne_BUST_ohne_UST_Fehlermeldung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Alle_markieren_ohne_BUST_ohne_UST_Fehlermeldung()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Alle_markieren_ohne_BUST_ohne_UST_Fehlermeldung Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbUSt2_UST_A' at Center.", repo.FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbUSt2_UST_AInfo, new RecordItemIndex(0));
            repo.FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbUSt2_UST_A.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbUSt2_UST_A'.", repo.FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbUSt2_UST_AInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbUSt2_UST_AInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbBst1_BUST_K'.", repo.FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbBst1_BUST_KInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbBst1_BUST_KInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbSkgr2_SKTGR_A'.", repo.FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbSkgr2_SKTGR_AInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbSkgr2_SKTGR_AInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbSkkt2_SKTKTO_A'.", repo.FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbSkkt2_SKTKTO_AInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmBSCOPY.Frame2_10_Checkboxen_Datenauswahl.CbSkkt2_SKTKTO_AInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBSCOPY.PbStandard1' at Center.", repo.FrmBSCOPY.PbStandard1Info, new RecordItemIndex(5));
            repo.FrmBSCOPY.PbStandard1.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgMessageBox.StammdatenKopieren'", repo.DlgMessageBox.StammdatenKopierenInfo, new ActionTimeout(60000), new RecordItemIndex(6));
            repo.DlgMessageBox.StammdatenKopierenInfo.WaitForExists(60000);
            
            // E00, E05, E10, E1N, E20, EX3, IGB, IGL, R10, R1N, R20, U00, U05, U10, U13, U20, V00, V05, V13, V20
            Report.Log(ReportLevel.Info, "Validation", "E00, E05, E10, E1N, E20, EX3, IGB, IGL, R10, R1N, R20, U00, U05, U10, U13, U20, V00, V05, V13, V20\r\nValidating AttributeContains (Text>'Vorgang abgebrochen') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(7));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Vorgang abgebrochen");
            
            // E00, E05, E10, E1N, E20, EX3, IGB, IGL, R10, R1N, R20, U00, U05, U10, U13, U20, V00, V05, V13, V20
            Report.Log(ReportLevel.Info, "Validation", "E00, E05, E10, E1N, E20, EX3, IGB, IGL, R10, R1N, R20, U00, U05, U10, U13, U20, V00, V05, V13, V20\r\nValidating AttributeContains (Text>'Es fehlen folgende UST-Codes: DRE, ') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(8));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Es fehlen folgende UST-Codes: DRE, ");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(10));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(11));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Es ist ein Fehler aufgetreten!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Es ist ein Fehler aufgetreten!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(13));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
