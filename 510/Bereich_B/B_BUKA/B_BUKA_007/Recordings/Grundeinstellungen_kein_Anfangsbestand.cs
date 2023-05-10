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

namespace B_BUKA_007.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Grundeinstellungen_kein_Anfangsbestand recording.
    /// </summary>
    [TestModule("5954640a-8075-49f5-be1e-55ca152a65cd", ModuleType.Recording, 1)]
    public partial class Grundeinstellungen_kein_Anfangsbestand : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUKA_007.B_BUKA_007Repository repository.
        /// </summary>
        public static global::B_BUKA_007.B_BUKA_007Repository repo = global::B_BUKA_007.B_BUKA_007Repository.Instance;

        static Grundeinstellungen_kein_Anfangsbestand instance = new Grundeinstellungen_kein_Anfangsbestand();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Grundeinstellungen_kein_Anfangsbestand()
        {
            Kassa = "2707";
            Datum_von = "01.12.2019";
            Datum_bis = "31.12.2019";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Grundeinstellungen_kein_Anfangsbestand Instance
        {
            get { return instance; }
        }

#region Variables

        string _Datum_von;

        /// <summary>
        /// Gets or sets the value of variable Datum_von.
        /// </summary>
        [TestVariable("a227374d-bc48-4b1f-8bd0-2c33c8f0c910")]
        public string Datum_von
        {
            get { return _Datum_von; }
            set { _Datum_von = value; }
        }

        string _Datum_bis;

        /// <summary>
        /// Gets or sets the value of variable Datum_bis.
        /// </summary>
        [TestVariable("fe0b32d3-c0a5-4d5a-a345-8a476622c2db")]
        public string Datum_bis
        {
            get { return _Datum_bis; }
            set { _Datum_bis = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Kassa.
        /// </summary>
        [TestVariable("e1687c0a-961c-410e-ab7d-7235fc823eaf")]
        public string Kassa
        {
            get { return repo.Kassa; }
            set { repo.Kassa = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuka.PbDataAccessNew' at Center.", repo.TblBuka.PbDataAccessNewInfo, new RecordItemIndex(0));
            repo.TblBuka.PbDataAccessNew.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Kassa' with focus on 'TblBuka.ToolBar.Zahlkonto'.", repo.TblBuka.ToolBar.ZahlkontoInfo, new RecordItemIndex(1));
            repo.TblBuka.ToolBar.Zahlkonto.PressKeys(Kassa);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Datum_von' with focus on 'TblBuka.ToolBar.DatumVon'.", repo.TblBuka.ToolBar.DatumVonInfo, new RecordItemIndex(3));
            repo.TblBuka.ToolBar.DatumVon.PressKeys(Datum_von);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum_bis) on item 'TblBuka.ToolBar.DatumBis'.", repo.TblBuka.ToolBar.DatumBisInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblBuka.ToolBar.DatumBisInfo, "Text", Datum_bis);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kassa) on item 'TblBuka.ToolBar.Zahlkonto'.", repo.TblBuka.ToolBar.ZahlkontoInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblBuka.ToolBar.ZahlkontoInfo, "Text", Kassa);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(120000), new RecordItemIndex(7));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Hinweis: fortlaufende Belegnummer wird im neuen Jahr weitergeführt\r\n\r\nmanuelles Zurücksetzen: kurzfr. Deaktivierung der autom. Nummer erforderlich (PD-Menü: Optionen)\r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Hinweis: fortlaufende Belegnummer wird im neuen Jahr weitergeführt\r\n\r\nmanuelles Zurücksetzen: kurzfr. Deaktivierung der autom. Nummer erforderlich (PD-Menü: Optionen)\r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(9));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuka.PbDataAccessLoad' at Center.", repo.TblBuka.PbDataAccessLoadInfo, new RecordItemIndex(10));
            repo.TblBuka.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(120000), new RecordItemIndex(11));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Saldovortrag kann nicht erstellt werden!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(12));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Saldovortrag kann nicht erstellt werden!");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Kassa-Anfangsbestand ist noch nicht') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(13));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Kassa-Anfangsbestand ist noch nicht");
            
            // Ticket IO852 - Meldungs-OK-Button muß 3 x bestätigt werden
            Report.Log(ReportLevel.Info, "Mouse", "Ticket IO852 - Meldungs-OK-Button muß 3 x bestätigt werden\r\nMouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(14));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
