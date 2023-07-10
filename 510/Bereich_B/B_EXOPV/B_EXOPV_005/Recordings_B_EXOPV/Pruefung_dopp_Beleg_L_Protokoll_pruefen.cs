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
    ///The Pruefung_dopp_Beleg_L_Protokoll_pruefen recording.
    /// </summary>
    [TestModule("52ae346e-0801-4a96-b82c-76aa59b69469", ModuleType.Recording, 1)]
    public partial class Pruefung_dopp_Beleg_L_Protokoll_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_005.B_EXOPV_005Repository repository.
        /// </summary>
        public static global::B_EXOPV_005.B_EXOPV_005Repository repo = global::B_EXOPV_005.B_EXOPV_005Repository.Instance;

        static Pruefung_dopp_Beleg_L_Protokoll_pruefen instance = new Pruefung_dopp_Beleg_L_Protokoll_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_dopp_Beleg_L_Protokoll_pruefen()
        {
            Tagesdatum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_dopp_Beleg_L_Protokoll_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("99d1b8e5-78d4-420f-b643-a57158a884e7")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FehlerprotokollBExopv001TxtEditor.FehlerprotokollBExopv001TxtEditor'", repo.FehlerprotokollBExopv001TxtEditor.FehlerprotokollBExopv001TxtEditorInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.FehlerprotokollBExopv001TxtEditor.FehlerprotokollBExopv001TxtEditorInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Starte Prüfung B_EXOPV_005') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(1));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Starte Prüfung B_EXOPV_005");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tagesdatum) on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Beende Prüfung B_EXOPV_005') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Beende Prüfung B_EXOPV_005");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exop: 0\tBeleg: ER03_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 29,') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 0\tBeleg: ER03_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 29,");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exop: 0\tBeleg: ER04_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 30,') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(5));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 0\tBeleg: ER04_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 30,");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exop: 0\tBeleg: ER04_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 31,') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(6));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 0\tBeleg: ER04_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 31,");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exop: 0\tBeleg: ER03_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 34,') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(7));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 0\tBeleg: ER03_B_EXOPV_005: Belegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 34,");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exop: 30\tBeleg: ER04_B_EXOPV_005: Fremdbeleg FB04_B_EXOPV_005: Fremdbelegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 32') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(8));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 30\tBeleg: ER04_B_EXOPV_005: Fremdbeleg FB04_B_EXOPV_005: Fremdbelegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 32");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exop: 32\tBeleg: ER06_B_EXOPV_005: Fremdbeleg FB04_B_EXOPV_005: Fremdbelegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 30') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(9));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 32\tBeleg: ER06_B_EXOPV_005: Fremdbeleg FB04_B_EXOPV_005: Fremdbelegnummer mehrfach in externer Schnittstelle vorhanden in Zeile 30");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exop: 28\tBeleg: ER01_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(10));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 28\tBeleg: ER01_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exop: 28\tBeleg: ER01_B_EXOPV_005: Fremdbelegnr FB01_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(11));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 28\tBeleg: ER01_B_EXOPV_005: Fremdbelegnr FB01_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exop: 29\tBeleg: ER03_B_EXOPV_005: Fremdbelegnr FB02_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(12));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 29\tBeleg: ER03_B_EXOPV_005: Fremdbelegnr FB02_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exop: 34\tBeleg: ER03_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(13));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 34\tBeleg: ER03_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Exop: 34\tBeleg: ER03_B_EXOPV_005: Fremdbelegnr FB03_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!') on item 'FehlerprotokollBExopv001TxtEditor.Text15'.", repo.FehlerprotokollBExopv001TxtEditor.Text15Info, new RecordItemIndex(14));
            Validate.AttributeContains(repo.FehlerprotokollBExopv001TxtEditor.Text15Info, "Text", "Exop: 34\tBeleg: ER03_B_EXOPV_005: Fremdbelegnr FB03_B_EXOPV_005: Doppelte Belegnummer: Status = (F)ehler!");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'FehlerprotokollBExopv001TxtEditor'.", repo.FehlerprotokollBExopv001TxtEditor.SelfInfo, new RecordItemIndex(15));
            Keyboard.PrepareFocus(repo.FehlerprotokollBExopv001TxtEditor.Self);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
