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

namespace B_EXOPV_005.Recordings_B_EXOPV
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Fehlerprotokoll_Pruefung_kontrollieren recording.
    /// </summary>
    [TestModule("7a5cb8fc-5689-4b12-8a7e-db1beabf090b", ModuleType.Recording, 1)]
    public partial class Fehlerprotokoll_Pruefung_kontrollieren : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_005.B_EXOPV_005Repository repository.
        /// </summary>
        public static global::B_EXOPV_005.B_EXOPV_005Repository repo = global::B_EXOPV_005.B_EXOPV_005Repository.Instance;

        static Fehlerprotokoll_Pruefung_kontrollieren instance = new Fehlerprotokoll_Pruefung_kontrollieren();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Fehlerprotokoll_Pruefung_kontrollieren()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Fehlerprotokoll_Pruefung_kontrollieren Instance
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

            // Prüfung Zeilen extra
            Report.Log(ReportLevel.Info, "Section", "Prüfung Zeilen extra", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Starte Prüfung B_EXOPV_005') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(1));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Starte Prüfung B_EXOPV_005");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Beende Prüfung B_EXOPV_005') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Beende Prüfung B_EXOPV_005");
            
            // Zeilen-/Beleg-Reihenfolge wechselt - deshalb Validerung gesamter Textblock deaktiviert (Textblock mit allen Belegnummern)
            try {
                //Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nZeilen-/Beleg-Reihenfolge wechselt - deshalb Validerung gesamter Textblock deaktiviert (Textblock mit allen Belegnummern)\r\nValidating AttributeContains (Text>'Exop: 0\tBeleg: ER03_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 29, \r\nExop: 0\tBeleg: ER04_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 30, \r\nExop: 0\tBeleg: ER04_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 31, \r\nExop: 0\tBeleg: ER03_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 34, \r\nExop: 30\tBeleg: ER04_B_EXOPV_005: Fremdbeleg FB04_B_EXOPV_005: Fremdbelegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 32\r\nExop: 32\tBeleg: ER06_B_EXOPV_005: Fremdbeleg FB04_B_EXOPV_005: Fremdbelegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 30\r\nExop: 28\tBeleg: ER01_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!\r\nExop: 28\tBeleg: ER01_B_EXOPV_005: Fremdbelegnr FB01_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!\r\nExop: 29\tBeleg: ER03_B_EXOPV_005: Fremdbelegnr FB02_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!\r\nExop: 34\tBeleg: ER03_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!\r\nExop: 34\tBeleg: ER03_B_EXOPV_005: Fremdbelegnr FB03_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(3));
                //Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 0\tBeleg: ER03_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 29, \r\nExop: 0\tBeleg: ER04_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 30, \r\nExop: 0\tBeleg: ER04_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 31, \r\nExop: 0\tBeleg: ER03_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 34, \r\nExop: 30\tBeleg: ER04_B_EXOPV_005: Fremdbeleg FB04_B_EXOPV_005: Fremdbelegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 32\r\nExop: 32\tBeleg: ER06_B_EXOPV_005: Fremdbeleg FB04_B_EXOPV_005: Fremdbelegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 30\r\nExop: 28\tBeleg: ER01_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!\r\nExop: 28\tBeleg: ER01_B_EXOPV_005: Fremdbelegnr FB01_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!\r\nExop: 29\tBeleg: ER03_B_EXOPV_005: Fremdbelegnr FB02_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!\r\nExop: 34\tBeleg: ER03_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!\r\nExop: 34\tBeleg: ER03_B_EXOPV_005: Fremdbelegnr FB03_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>'[100] Fehlerhafte Zeilen wurden mit Status >F< in Schnittstelle gespeichert') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(4));
                Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "[100] Fehlerhafte Zeilen wurden mit Status >F< in Schnittstelle gespeichert", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>'Exop: 0\tBeleg: ER03_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 29,') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(5));
                Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 0\tBeleg: ER03_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 29,", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>'Exop: 0\tBeleg: ER04_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 30,') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(6));
                Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 0\tBeleg: ER04_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 30,", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>'Exop: 0\tBeleg: ER04_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 31,') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(7));
                Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 0\tBeleg: ER04_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 31,", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>'Exop: 0\tBeleg: ER03_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 34,') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(8));
                Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 0\tBeleg: ER03_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 34,", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>'Exop: 32\tBeleg: ER06_B_EXOPV_005: Fremdbeleg FB04_B_EXOPV_005: Fremdbelegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 30') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(9));
                Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 32\tBeleg: ER06_B_EXOPV_005: Fremdbeleg FB04_B_EXOPV_005: Fremdbelegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 30", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>'Exop: 30\tBeleg: ER04_B_EXOPV_005: Fremdbeleg FB04_B_EXOPV_005: Fremdbelegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 32') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(10));
                Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 30\tBeleg: ER04_B_EXOPV_005: Fremdbeleg FB04_B_EXOPV_005: Fremdbelegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 32", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>'Exop: 28\tBeleg: ER01_B_EXOPV_005: Doppelte Belegnummer! Dieser Satz wird mit Status >F< als Fehler in der Schnittstelle gespeichert!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(11));
                Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 28\tBeleg: ER01_B_EXOPV_005: Doppelte Belegnummer! Dieser Satz wird mit Status >F< als Fehler in der Schnittstelle gespeichert!", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>'Exop: 28\tBeleg: ER01_B_EXOPV_005: Doppelte Fremdbelegnummer: FB01_B_EXOPV_005! Dieser Satz wird mit Status >F< als Fehler in der Schnittstelle gespeichert!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(12));
                Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 28\tBeleg: ER01_B_EXOPV_005: Doppelte Fremdbelegnummer: FB01_B_EXOPV_005! Dieser Satz wird mit Status >F< als Fehler in der Schnittstelle gespeichert!", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(12)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>'Exop: 29\tBeleg: ER03_B_EXOPV_005: Doppelte Fremdbelegnummer: FB02_B_EXOPV_005! Dieser Satz wird mit Status >F< als Fehler in der Schnittstelle gespeichert!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(13));
                Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 29\tBeleg: ER03_B_EXOPV_005: Doppelte Fremdbelegnummer: FB02_B_EXOPV_005! Dieser Satz wird mit Status >F< als Fehler in der Schnittstelle gespeichert!", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(13)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>'Exop: 34\tBeleg: ER03_B_EXOPV_005: Doppelte Belegnummer! Dieser Satz wird mit Status >F< als Fehler in der Schnittstelle gespeichert!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(14));
                Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 34\tBeleg: ER03_B_EXOPV_005: Doppelte Belegnummer! Dieser Satz wird mit Status >F< als Fehler in der Schnittstelle gespeichert!", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(14)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
