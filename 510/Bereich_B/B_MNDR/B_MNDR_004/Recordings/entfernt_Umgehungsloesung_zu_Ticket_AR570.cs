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

namespace B_MNDR_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The entfernt_Umgehungsloesung_zu_Ticket_AR570 recording.
    /// </summary>
    [TestModule("9e6686b7-f668-4e93-821a-d6fd23ea3632", ModuleType.Recording, 1)]
    public partial class Entfernt_Umgehungsloesung_zu_Ticket_AR570 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_MNDR_004.B_MNDR_004Repository repository.
        /// </summary>
        public static global::B_MNDR_004.B_MNDR_004Repository repo = global::B_MNDR_004.B_MNDR_004Repository.Instance;

        static Entfernt_Umgehungsloesung_zu_Ticket_AR570 instance = new Entfernt_Umgehungsloesung_zu_Ticket_AR570();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Entfernt_Umgehungsloesung_zu_Ticket_AR570()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Entfernt_Umgehungsloesung_zu_Ticket_AR570 Instance
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

            // Meldung disabled Ticket siehe AR570
            //Report.Log(ReportLevel.Info, "Validation", "Meldung disabled Ticket siehe AR570\r\nValidating AttributeContains (Text>'Es wurden Daten geändert!\r\nSollen die Änderungen gespeichert werden?') on item 'Mahnung_Meldung.LabelMeldungstext'.", repo.Mahnung_Meldung.LabelMeldungstextInfo, new RecordItemIndex(0));
            //Validate.AttributeContains(repo.Mahnung_Meldung.LabelMeldungstextInfo, "Text", "Es wurden Daten geändert!\r\nSollen die Änderungen gespeichert werden?");
            
            // Meldung disabled Ticket siehe AR570
            //Report.Log(ReportLevel.Info, "Mouse", "Meldung disabled Ticket siehe AR570\r\nMouse Left Click item 'Mahnung_Meldung.Button0' at Center.", repo.Mahnung_Meldung.Button0Info, new RecordItemIndex(1));
            //repo.Mahnung_Meldung.Button0.Click();
            
            // Zum bestätigen der Meldung in 521 und 511 bis im SP erledigt wird (AR570)
            Report.Log(ReportLevel.Info, "Keyboard", "Zum bestätigen der Meldung in 521 und 511 bis im SP erledigt wird (AR570)\r\nKey sequence 'J'.", new RecordItemIndex(2));
            Keyboard.Press("J");
            
            // Programmverhalten war lt. Entwicklung immer so und sollte so beibehalten werden AR570.
            Report.Log(ReportLevel.Info, "Mouse", "Programmverhalten war lt. Entwicklung immer so und sollte so beibehalten werden AR570.\r\nMouse Left DoubleClick item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6' at Center.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6Info, new RecordItemIndex(3));
            repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6Info, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'J' with focus on 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6Info, new RecordItemIndex(5));
            repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6.PressKeys("J");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='J') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6Info, "Text", "J");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmVorschlagAEndern.PbDataAccessSave' at Center.", repo.FrmVorschlagAEndern.PbDataAccessSaveInfo, new RecordItemIndex(8));
            repo.FrmVorschlagAEndern.PbDataAccessSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
