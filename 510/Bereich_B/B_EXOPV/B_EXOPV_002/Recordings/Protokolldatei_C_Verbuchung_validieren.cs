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

namespace B_EXOPV_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefung_Stapel recording.
    /// </summary>
    [TestModule("b98544e5-b74b-43d8-8494-db2220d685e8", ModuleType.Recording, 1)]
    public partial class Protokolldatei_C_Verbuchung_validieren : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_002.B_EXOPV_002Repository repository.
        /// </summary>
        public static global::B_EXOPV_002.B_EXOPV_002Repository repo = global::B_EXOPV_002.B_EXOPV_002Repository.Instance;

        static Protokolldatei_C_Verbuchung_validieren instance = new Protokolldatei_C_Verbuchung_validieren();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Protokolldatei_C_Verbuchung_validieren()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Protokolldatei_C_Verbuchung_validieren Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FehlerprotokollBExopv001TxtEditor.FehlerprotokollBExopv001TxtEditor'", repo.FehlerprotokollBExopv001TxtEditor.FehlerprotokollBExopv001TxtEditorInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.FehlerprotokollBExopv001TxtEditor.FehlerprotokollBExopv001TxtEditorInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Fehlerprotokoll_b_exopv_002_C') on item 'FehlerprotokollBExopv001TxtEditor.FehlerprotokollBExopv001TxtEditor'.", repo.FehlerprotokollBExopv001TxtEditor.FehlerprotokollBExopv001TxtEditorInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.FehlerprotokollBExopv001TxtEditorInfo, "Text", "Fehlerprotokoll_b_exopv_002_C");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'B_EXOPV - Starte Verbuchung') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "B_EXOPV - Starte Verbuchung");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[100] Starte Verbuchung RS\\2-Verkauf') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "[100] Starte Verbuchung RS\\2-Verkauf");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Beleg: R20/0001:') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Beleg: R20/0001:");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exsa: 1\tBeleg R20/0001: Bereichskonto <1 / 15> nicht vorhanden!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(5));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exsa: 1\tBeleg R20/0001: Bereichskonto <1 / 15> nicht vorhanden!");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Beleg: R20/0003:') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(6));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Beleg: R20/0003:");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exsa: 1\t: Bereichskonto ist leer bei Pflichtigkeit für Firma <100> / Sachkonto <4000> / Bereich <1>!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(7));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exsa: 1\t: Bereichskonto ist leer bei Pflichtigkeit für Firma <100> / Sachkonto <4000> / Bereich <1>!");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Beleg: R20/0003:') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(8));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Beleg: R20/0003:");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exsa: 1\tSachkonto <4000 Bitte korrekten USt-Code angeben!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(9));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exsa: 1\tSachkonto <4000 Bitte korrekten USt-Code angeben!");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[100] Fehlerhafte Zeilen wurden mit Status >F< in Schnittstelle gespeichert') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(10));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "[100] Fehlerhafte Zeilen wurden mit Status >F< in Schnittstelle gespeichert");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[100] Beende Verbuchung RS\\2-Verkauf') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(11));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "[100] Beende Verbuchung RS\\2-Verkauf");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Anzahl Buchungen gelesen  6\r\nAnzahl Buchungen verbucht 4  Summe verbucht: 4600,00') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(12));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Anzahl Buchungen gelesen  6\r\nAnzahl Buchungen verbucht 4  Summe verbucht: 4600,00");
            
            // Stapel Lager
            Report.Log(ReportLevel.Info, "Section", "Stapel Lager", new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[100] Starte Verbuchung RS\\2-Lager') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(14));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "[100] Starte Verbuchung RS\\2-Lager");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Beleg: 2020-01:') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(15));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Beleg: 2020-01:");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Buchungssymbol <UM> nicht vorhanden!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(16));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Buchungssymbol <UM> nicht vorhanden!");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Beleg: 2020-01:') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(17));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Beleg: 2020-01:");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exsa: 2\tUst-Code(M20) für Konto (4500) lt. Kontenstamm (M/V) nichtzulässig!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(18));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exsa: 2\tUst-Code(M20) für Konto (4500) lt. Kontenstamm (M/V) nichtzulässig!");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Beleg: 2020-01') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(19));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Beleg: 2020-01");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exsa: 3\tUst-Code(M20) für Konto (4580) lt. Kontenstamm (M/V) nichtzulässig!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(20));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exsa: 3\tUst-Code(M20) für Konto (4580) lt. Kontenstamm (M/V) nichtzulässig!");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[100] Fehlerhafte Zeilen wurden mit Status >F< in Schnittstelle gespeichert') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(21));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "[100] Fehlerhafte Zeilen wurden mit Status >F< in Schnittstelle gespeichert");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[100] Beende Verbuchung RS\\2-Lager') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(22));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "[100] Beende Verbuchung RS\\2-Lager");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Anzahl Buchungen gelesen  1\r\nAnzahl Buchungen verbucht 0  Summe verbucht:') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(23));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Anzahl Buchungen gelesen  1\r\nAnzahl Buchungen verbucht 0  Summe verbucht:");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
