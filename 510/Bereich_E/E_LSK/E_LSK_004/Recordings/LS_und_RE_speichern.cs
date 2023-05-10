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

namespace E_LSK_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LS_und_RE_speichern recording.
    /// </summary>
    [TestModule("0a68ffb1-1090-4e2b-9d6d-63abe2e251c7", ModuleType.Recording, 1)]
    public partial class LS_und_RE_speichern : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_LSK_004.E_LSK_004Repository repository.
        /// </summary>
        public static global::E_LSK_004.E_LSK_004Repository repo = global::E_LSK_004.E_LSK_004Repository.Instance;

        static LS_und_RE_speichern instance = new LS_und_RE_speichern();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LS_und_RE_speichern()
        {
            Lieferscheinsumme = "70,00";
            Beleg_Nr = "QS-N001";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LS_und_RE_speichern Instance
        {
            get { return instance; }
        }

#region Variables

        string _Lieferscheinsumme;

        /// <summary>
        /// Gets or sets the value of variable Lieferscheinsumme.
        /// </summary>
        [TestVariable("ff22745e-8bbb-4826-b263-9e745a509e56")]
        public string Lieferscheinsumme
        {
            get { return _Lieferscheinsumme; }
            set { _Lieferscheinsumme = value; }
        }

        string _Beleg_Nr;

        /// <summary>
        /// Gets or sets the value of variable Beleg_Nr.
        /// </summary>
        [TestVariable("5d0542d7-bd6f-477a-ac88-92d3ed6746a8")]
        public string Beleg_Nr
        {
            get { return _Beleg_Nr; }
            set { _Beleg_Nr = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.FrmKopf.Rechnungskontrolle' at Center.", repo.MdiLSR.FrmKopf.RechnungskontrolleInfo, new RecordItemIndex(0));
            repo.MdiLSR.FrmKopf.Rechnungskontrolle.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferscheinsumme) on item 'MdiLSR.FrmKopf.Lieferscheine'.", repo.MdiLSR.FrmKopf.LieferscheineInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.LieferscheineInfo, "Text", Lieferscheinsumme);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'MdiLSR.FrmKopf.DfDifferenz'.", repo.MdiLSR.FrmKopf.DfDifferenzInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.DfDifferenzInfo, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferscheinsumme) on item 'MdiLSR.FrmKopf.ColLskSummeRow1'.", repo.MdiLSR.FrmKopf.ColLskSummeRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.ColLskSummeRow1Info, "Text", Lieferscheinsumme);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.FrmKopf.PbRichtig' at Center.", repo.MdiLSR.FrmKopf.PbRichtigInfo, new RecordItemIndex(4));
            repo.MdiLSR.FrmKopf.PbRichtig.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'DlgMessageBox.LieferscheinRechnung'", repo.DlgMessageBox.LieferscheinRechnungInfo, new ActionTimeout(5000), new RecordItemIndex(5));
            repo.DlgMessageBox.LieferscheinRechnungInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Bitte geben Sie ein Rechnungsdatum ein') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Bitte geben Sie ein Rechnungsdatum ein");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(7));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'MdiLSR.FrmKopf.Rechnungsdatum' at Center.", repo.MdiLSR.FrmKopf.RechnungsdatumInfo, new RecordItemIndex(8));
            repo.MdiLSR.FrmKopf.Rechnungsdatum.Click(System.Windows.Forms.MouseButtons.Right);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ELSK.AktuellesDatum' at UpperCenter.", repo.ELSK.AktuellesDatumInfo, new RecordItemIndex(9));
            repo.ELSK.AktuellesDatum.Click(Location.UpperCenter);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MdiLSR.FrmKopf.Rechnungsdatum'.", repo.MdiLSR.FrmKopf.RechnungsdatumInfo, new RecordItemIndex(10));
            repo.MdiLSR.FrmKopf.Rechnungsdatum.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.FrmKopf.IntBelegnr' at Center.", repo.MdiLSR.FrmKopf.IntBelegnrInfo, new RecordItemIndex(11));
            repo.MdiLSR.FrmKopf.IntBelegnr.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Beleg_Nr' with focus on 'MdiLSR.FrmKopf.IntBelegnr'.", repo.MdiLSR.FrmKopf.IntBelegnrInfo, new RecordItemIndex(12));
            repo.MdiLSR.FrmKopf.IntBelegnr.PressKeys(Beleg_Nr);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.FrmKopf.PbRichtig' at Center.", repo.MdiLSR.FrmKopf.PbRichtigInfo, new RecordItemIndex(13));
            repo.MdiLSR.FrmKopf.PbRichtig.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Standardzahlungsbedingung') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(14));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Standardzahlungsbedingung");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(15));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MdiLSR.FrmSearchPage.CellTmpColS2Row1' at Center.", repo.MdiLSR.FrmSearchPage.CellTmpColS2Row1Info, new RecordItemIndex(16));
            repo.MdiLSR.FrmSearchPage.CellTmpColS2Row1.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='R') on item 'MdiLSR.FrmKopf.DfRechStatus'.", repo.MdiLSR.FrmKopf.DfRechStatusInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.DfRechStatusInfo, "Text", "R");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
