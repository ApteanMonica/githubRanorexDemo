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
    ///The Rechnung_erstellen recording.
    /// </summary>
    [TestModule("6d10b96a-a394-45ea-bc07-a136facbac00", ModuleType.Recording, 1)]
    public partial class Rechnung_erstellen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_FADR_001.V_FADR_001Repository repository.
        /// </summary>
        public static global::V_FADR_001.V_FADR_001Repository repo = global::V_FADR_001.V_FADR_001Repository.Instance;

        static Rechnung_erstellen instance = new Rechnung_erstellen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Rechnung_erstellen()
        {
            Auftragsnummer = "201900005";
            Rechnungsnummer = "";
            Tagesdatum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Rechnung_erstellen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Rechnungsnummer;

        /// <summary>
        /// Gets or sets the value of variable Rechnungsnummer.
        /// </summary>
        [TestVariable("8107eb30-6054-42ba-8953-5373fde332b2")]
        public string Rechnungsnummer
        {
            get { return _Rechnungsnummer; }
            set { _Rechnungsnummer = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Auftragsnummer.
        /// </summary>
        [TestVariable("3f603517-740d-47df-bc01-ff6361981830")]
        public string Auftragsnummer
        {
            get { return repo.Auftragsnummer; }
            set { repo.Auftragsnummer = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("fa008b4f-9528-48ae-9f6a-d3fea2e8d07e")]
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

            Tagesdatum = Ranorex.AutomationHelpers.UserCodeCollections.SystemLibrary.GetDateTimeAsString("dd.MM.yyyy");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblFadr.Rech_art_FlexGrid.ColLskDatumRow1'.", repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'TblFadr.Rech_art_FlexGrid.ColLskDatumRow2'.", repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow2Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow2Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.Rech_art_FlexGrid.ColReaBezRow2' at Center.", repo.TblFadr.Rech_art_FlexGrid.ColReaBezRow2Info, new RecordItemIndex(3));
            repo.TblFadr.Rech_art_FlexGrid.ColReaBezRow2.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(4));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+X' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(8));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblFadr.Rech_art_FlexGrid.ColLskDatumRow2'.", repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow2Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow2Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.Rech_art_FlexGrid.ColReaBezRow1' at Center.", repo.TblFadr.Rech_art_FlexGrid.ColReaBezRow1Info, new RecordItemIndex(11));
            repo.TblFadr.Rech_art_FlexGrid.ColReaBezRow1.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(12));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(13));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(14));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+V' Press.", new RecordItemIndex(15));
            Keyboard.Press(System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(16));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(17));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'TblFadr.Rech_art_FlexGrid.ColLskDatumRow1'.", repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow1Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow1Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.PbCommonLoad' at Center.", repo.TblFadr.PbCommonLoadInfo, new RecordItemIndex(19));
            repo.TblFadr.PbCommonLoad.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.untere_Tabelle.Column0_mit_Auftragsnummer' at Center.", repo.TblFadr.untere_Tabelle.Column0_mit_AuftragsnummerInfo, new RecordItemIndex(20));
            repo.TblFadr.untere_Tabelle.Column0_mit_Auftragsnummer.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Auftragsnummer) on item 'TblFadr.untere_Tabelle.ColAufkNr'.", repo.TblFadr.untere_Tabelle.ColAufkNrInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.TblFadr.untere_Tabelle.ColAufkNrInfo, "Text", Auftragsnummer);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.PbSpec2VSRechnung' at Center.", repo.TblFadr.PbSpec2VSRechnungInfo, new RecordItemIndex(22));
            repo.TblFadr.PbSpec2VSRechnung.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgDrucken.PbVorschau'", repo.DlgDrucken.PbVorschauInfo, new ActionTimeout(120000), new RecordItemIndex(23));
            repo.DlgDrucken.PbVorschauInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDrucken.PbVorschau' at Center.", repo.DlgDrucken.PbVorschauInfo, new RecordItemIndex(24));
            repo.DlgDrucken.PbVorschau.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'Vorschau.TitleBar'", repo.Vorschau.TitleBarInfo, new ActionTimeout(120000), new RecordItemIndex(25));
            repo.Vorschau.TitleBarInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Vorschau.DruckvorschauSchliessen' at Center.", repo.Vorschau.DruckvorschauSchliessenInfo, new RecordItemIndex(26));
            repo.Vorschau.DruckvorschauSchliessen.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(27));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDrucken.Schliessen' at Center.", repo.DlgDrucken.SchliessenInfo, new RecordItemIndex(28));
            repo.DlgDrucken.Schliessen.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(29));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.untere_Tabelle.Column0_mit_Auftragsnummer' at Center.", repo.TblFadr.untere_Tabelle.Column0_mit_AuftragsnummerInfo, new RecordItemIndex(30));
            repo.TblFadr.untere_Tabelle.Column0_mit_Auftragsnummer.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.PbSpec2Fakturenerstellung' at Center.", repo.TblFadr.PbSpec2FakturenerstellungInfo, new RecordItemIndex(31));
            repo.TblFadr.PbSpec2Fakturenerstellung.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Rechnungsnummer' with focus on 'TblFadr.untere_Tabelle.Rechnungsnummer'.", repo.TblFadr.untere_Tabelle.RechnungsnummerInfo, new RecordItemIndex(32));
            repo.TblFadr.untere_Tabelle.Rechnungsnummer.PressKeys(Rechnungsnummer);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(33));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~$Rechnungsnummer) on item 'TblFadr.untere_Tabelle.Rechnungsnummer'.", repo.TblFadr.untere_Tabelle.RechnungsnummerInfo, new RecordItemIndex(34));
            Validate.AttributeRegex(repo.TblFadr.untere_Tabelle.RechnungsnummerInfo, "Text", new Regex(Rechnungsnummer));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
