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
    ///The Einschraenkung_LS_Datum_zuruecktauschen recording.
    /// </summary>
    [TestModule("d8adec14-9545-43c8-93de-c16c809655d2", ModuleType.Recording, 1)]
    public partial class Einschraenkung_LS_Datum_zuruecktauschen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_FADR_001.V_FADR_001Repository repository.
        /// </summary>
        public static global::V_FADR_001.V_FADR_001Repository repo = global::V_FADR_001.V_FADR_001Repository.Instance;

        static Einschraenkung_LS_Datum_zuruecktauschen instance = new Einschraenkung_LS_Datum_zuruecktauschen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Einschraenkung_LS_Datum_zuruecktauschen()
        {
            Tagesdatum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Einschraenkung_LS_Datum_zuruecktauschen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("4e5f470d-7c80-4fcd-a59f-7ea0e362d9d7")]
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow1'.", repo.TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow2'.", repo.TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow2Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow2Info, "Text", Tagesdatum);
            
            // LS-Datum in row2 entfernen
            Report.Log(ReportLevel.Info, "Section", "LS-Datum in row2 entfernen", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow2' at Center.", repo.TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow2Info, new RecordItemIndex(4));
            repo.TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow2.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(5));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(8));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+X' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 7s.", new RecordItemIndex(11));
            Delay.Duration(7000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(12));
            
            // LS-Datum in row1 einfügem
            Report.Log(ReportLevel.Info, "Section", "LS-Datum in row1 einfügem", new RecordItemIndex(13));
            
            // search timeout erhöht
            Report.Log(ReportLevel.Info, "Mouse", "search timeout erhöht\r\nMouse Left Click item 'TblFadr.tblRechArt_Pfad_verkuerzt_dzt_nicht_verwendet.ColLskDatumRow1' at Center.", repo.TblFadr.tblRechArt_Pfad_verkuerzt_dzt_nicht_verwendet.ColLskDatumRow1Info, new RecordItemIndex(14));
            repo.TblFadr.tblRechArt_Pfad_verkuerzt_dzt_nicht_verwendet.ColLskDatumRow1.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(15));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+V' Press.", new RecordItemIndex(17));
            Keyboard.Press(System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(18));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(20));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(21));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(22));
            
            // Prüfen: LS-Datum Zeile 1 leer, Zeile 2 Tagesdatum
            Report.Log(ReportLevel.Info, "Section", "Prüfen: LS-Datum Zeile 1 leer, Zeile 2 Tagesdatum", new RecordItemIndex(23));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow1'.", repo.TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow1Info, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow1Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow2'.", repo.TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow2Info, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.TblFadr.Rech_art_FlexGrid_Pfad_lang.ColLskDatumRow2Info, "Text", "");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}