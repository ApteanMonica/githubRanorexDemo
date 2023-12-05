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

namespace V_FADR_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Lieferschein_laden_2_Eingabe_umgedreht recording.
    /// </summary>
    [TestModule("b9c846d6-f529-4c91-9c9a-8391693aeb4f", ModuleType.Recording, 1)]
    public partial class Lieferschein_laden_2_Eingabe_umgedreht : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_FADR_001.V_FADR_001Repository repository.
        /// </summary>
        public static global::V_FADR_001.V_FADR_001Repository repo = global::V_FADR_001.V_FADR_001Repository.Instance;

        static Lieferschein_laden_2_Eingabe_umgedreht instance = new Lieferschein_laden_2_Eingabe_umgedreht();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Lieferschein_laden_2_Eingabe_umgedreht()
        {
            Tagesdatum = "";
            Datum_leer = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Lieferschein_laden_2_Eingabe_umgedreht Instance
        {
            get { return instance; }
        }

#region Variables

        string _Datum_leer;

        /// <summary>
        /// Gets or sets the value of variable Datum_leer.
        /// </summary>
        [TestVariable("c4aee2a7-8af0-4adf-8967-7eaf7702afa9")]
        public string Datum_leer
        {
            get { return _Datum_leer; }
            set { _Datum_leer = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("2a322f47-8ea6-496c-a39a-14e611868adc")]
        public string Tagesdatum
        {
            get { return repo.Tagesdatum; }
            set { repo.Tagesdatum = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.TitleBar100Fakturierung_mit_Text_Fakturierung' at Center.", repo.TblFadr.TitleBar100Fakturierung_mit_Text_FakturierungInfo, new RecordItemIndex(0));
            repo.TblFadr.TitleBar100Fakturierung_mit_Text_Fakturierung.Click();
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasFocus='True') on item 'TblFadr.TitleBar100Fakturierung_mit_Text_Fakturierung'.", repo.TblFadr.TitleBar100Fakturierung_mit_Text_FakturierungInfo, new RecordItemIndex(1));
            //Validate.AttributeEqual(repo.TblFadr.TitleBar100Fakturierung_mit_Text_FakturierungInfo, "HasFocus", "True");
            
            Tagesdatum = Ranorex.AutomationHelpers.UserCodeCollections.SystemLibrary.GetDateTimeAsString("dd.MM.yyyy");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow1'.", repo.TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow1Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow2'.", repo.TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow2Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow2Info, "Text", "");
            
            // Tagesdatum in Zeile 2 LS-Datum einfügen
            Report.Log(ReportLevel.Info, "Section", "Tagesdatum in Zeile 2 LS-Datum einfügen", new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.tblRechArt_Pfad_verkuerzt_2.colRechartRow2' at Center.", repo.TblFadr.tblRechArt_Pfad_verkuerzt_2.colRechartRow2Info, new RecordItemIndex(6));
            repo.TblFadr.tblRechArt_Pfad_verkuerzt_2.colRechartRow2.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 7s.", new RecordItemIndex(7));
            Delay.Duration(7000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 7s.", new RecordItemIndex(9));
            Delay.Duration(7000, false);
            
            Tagesdatum = Ranorex.AutomationHelpers.UserCodeCollections.SystemLibrary.GetDateTimeAsString("dd.MM.yyyy");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Tagesdatum'.", new RecordItemIndex(11));
            Keyboard.Press(Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 7s.", new RecordItemIndex(12));
            Delay.Duration(7000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(13));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 7s.", new RecordItemIndex(14));
            Delay.Duration(7000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(15));
            
            // LS-Datum in Zeile 1 löschen
            Report.Log(ReportLevel.Info, "Section", "LS-Datum in Zeile 1 löschen", new RecordItemIndex(16));
            
            // search timeout erhöht
            Report.Log(ReportLevel.Info, "Mouse", "search timeout erhöht\r\nMouse Left Click item 'TblFadr.tblRechArt_Pfad_verkuerzt_2.colRechartRow1' at Center.", repo.TblFadr.tblRechArt_Pfad_verkuerzt_2.colRechartRow1Info, new RecordItemIndex(17));
            repo.TblFadr.tblRechArt_Pfad_verkuerzt_2.colRechartRow1.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 7s.", new RecordItemIndex(18));
            Delay.Duration(7000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(20));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 7s.", new RecordItemIndex(21));
            Delay.Duration(7000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(22));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(23));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(24));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 7s.", new RecordItemIndex(25));
            Delay.Duration(7000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(26));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Datum_leer'.", new RecordItemIndex(27));
            Keyboard.Press(Datum_leer);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 7s.", new RecordItemIndex(28));
            Delay.Duration(7000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(29));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(30));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 7s.", new RecordItemIndex(31));
            Delay.Duration(7000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(32));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow1'.", repo.TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow1Info, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow1Info, "Text", "");
            
            // Prüfen: LS-Datum Zeile 1 leer, Zeile 2 Tagesdatum
            Report.Log(ReportLevel.Info, "Section", "Prüfen: LS-Datum Zeile 1 leer, Zeile 2 Tagesdatum", new RecordItemIndex(34));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow1'.", repo.TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow1Info, new RecordItemIndex(35));
            Validate.AttributeEqual(repo.TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow2'.", repo.TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow2Info, new RecordItemIndex(36));
            Validate.AttributeEqual(repo.TblFadr.tblRechArt_Pfad_verkuerzt_2.ColLskDatumRow2Info, "Text", Tagesdatum);
            
            // Laden + Meldung prüfen
            Report.Log(ReportLevel.Info, "Section", "Laden + Meldung prüfen", new RecordItemIndex(37));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.PbCommonLoad' at Center.", repo.TblFadr.PbCommonLoadInfo, new RecordItemIndex(38));
            repo.TblFadr.PbCommonLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(120000), new RecordItemIndex(39));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Es wurden keine Lieferscheine gefunden die zur Belegerstellung berechtigt sind.\r\nNähere Information unter Menu/Extras/Warum wird Auftrag nicht fakturiert') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(40));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Es wurden keine Lieferscheine gefunden die zur Belegerstellung berechtigt sind.\r\nNähere Information unter Menu/Extras/Warum wird Auftrag nicht fakturiert");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(41));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
