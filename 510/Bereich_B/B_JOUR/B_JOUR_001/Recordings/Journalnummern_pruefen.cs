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

namespace B_JOUR_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Journalnummern_pruefen recording.
    /// </summary>
    [TestModule("6c1b7ce1-88be-41b4-9ef9-1f4a2aec7e7e", ModuleType.Recording, 1)]
    public partial class Journalnummern_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_JOUR_001.B_JOUR_001Repository repository.
        /// </summary>
        public static global::B_JOUR_001.B_JOUR_001Repository repo = global::B_JOUR_001.B_JOUR_001Repository.Instance;

        static Journalnummern_pruefen instance = new Journalnummern_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Journalnummern_pruefen()
        {
            Geschaeftsjahr = "2017";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Journalnummern_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Geschaeftsjahr.
        /// </summary>
        [TestVariable("490c43e4-8984-4e55-a0c4-5eea71b4c984")]
        public string Geschaeftsjahr
        {
            get { return repo.Geschaeftsjahr; }
            set { repo.Geschaeftsjahr = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Geschaeftsjahr' with focus on 'FrmJournal.Buchungsjahr'.", repo.FrmJournal.BuchungsjahrInfo, new RecordItemIndex(0));
            repo.FrmJournal.Buchungsjahr.PressKeys(Geschaeftsjahr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmJournal.Buchungsjahr'.", repo.FrmJournal.BuchungsjahrInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.FrmJournal.Buchungsjahr);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Geschaeftsjahr) on item 'FrmJournal.Buchungsjahr'.", repo.FrmJournal.BuchungsjahrInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmJournal.BuchungsjahrInfo, "Text", Geschaeftsjahr);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmJournal.PbCommonBuchungenpruefen' at Center.", repo.FrmJournal.PbCommonBuchungenpruefenInfo, new RecordItemIndex(3));
            repo.FrmJournal.PbCommonBuchungenpruefen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox'", repo.DlgMessageBox.SelfInfo, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.DlgMessageBox.SelfInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'\nAnzahl der nicht journalisierten Buchungen lt eingegebenen Zeitraum ermitteln?\r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "\nAnzahl der nicht journalisierten Buchungen lt eingegebenen Zeitraum ermitteln?\r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(6));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Anzahl nicht journalisierter Buchungen: 10\r\n\r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(8));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Anzahl nicht journalisierter Buchungen: 10\r\n\r\n");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Noch keine Journalisierung im Geschäftsjahr 2017 erfolgt!\r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(9));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Noch keine Journalisierung im Geschäftsjahr 2017 erfolgt!\r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(10));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
