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

namespace B_JOUR_002.Recordings_2015
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefung_2015_journalisierte_Buchungen recording.
    /// </summary>
    [TestModule("3a6c3842-a785-4db2-8834-1610ee6889e2", ModuleType.Recording, 1)]
    public partial class Pruefung_2015_journalisierte_Buchungen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_JOUR_002.B_JOUR_002Repository repository.
        /// </summary>
        public static global::B_JOUR_002.B_JOUR_002Repository repo = global::B_JOUR_002.B_JOUR_002Repository.Instance;

        static Pruefung_2015_journalisierte_Buchungen instance = new Pruefung_2015_journalisierte_Buchungen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_2015_journalisierte_Buchungen()
        {
            GJ_2015 = "2015";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_2015_journalisierte_Buchungen Instance
        {
            get { return instance; }
        }

#region Variables

        string _GJ_2015;

        /// <summary>
        /// Gets or sets the value of variable GJ_2015.
        /// </summary>
        [TestVariable("aba38264-ad93-433a-9cc2-35f953aa1209")]
        public string GJ_2015
        {
            get { return _GJ_2015; }
            set { _GJ_2015 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmJournal.Buchungsjahr' at Center.", repo.FrmJournal.BuchungsjahrInfo, new RecordItemIndex(0));
            repo.FrmJournal.Buchungsjahr.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}{Back}{Back}{Back}' with focus on 'FrmJournal.Buchungsjahr'.", repo.FrmJournal.BuchungsjahrInfo, new RecordItemIndex(1));
            repo.FrmJournal.Buchungsjahr.PressKeys("{Back}{Back}{Back}{Back}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmJournal.Buchungsjahr' at Center.", repo.FrmJournal.BuchungsjahrInfo, new RecordItemIndex(2));
            repo.FrmJournal.Buchungsjahr.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GJ_2015' with focus on 'FrmJournal'.", repo.FrmJournal.SelfInfo, new RecordItemIndex(3));
            repo.FrmJournal.Self.EnsureVisible();
            Keyboard.Press(GJ_2015);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$GJ_2015) on item 'FrmJournal.Buchungsjahr'.", repo.FrmJournal.BuchungsjahrInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmJournal.BuchungsjahrInfo, "Text", GJ_2015);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmJournal.PbCommonBuchungenpruefen' at Center.", repo.FrmJournal.PbCommonBuchungenpruefenInfo, new RecordItemIndex(5));
            repo.FrmJournal.PbCommonBuchungenpruefen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Anzahl der nicht journalisierten Buchungen lt eingegebenen Zeitraum ermitteln?\r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Anzahl der nicht journalisierten Buchungen lt eingegebenen Zeitraum ermitteln?\r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(7));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'DlgMessageBox.Journaldruck'", repo.DlgMessageBox.JournaldruckInfo, new ActionTimeout(5000), new RecordItemIndex(8));
            repo.DlgMessageBox.JournaldruckInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Anzahl nicht journalisierter Buchungen: 2\r\n\r\nDiese Buchungen können in 'Buchen abfragen/ändern', mit entsprechender Filtereinschränkung , angezeigt werden.\r\n\r\n\r\nZusatzinfo:\r\nNoch keine Journalisierung im Geschäftsjahr 2015 erfolgt!\r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(9));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Anzahl nicht journalisierter Buchungen: 2\r\n\r\nDiese Buchungen können in 'Buchen abfragen/ändern', mit entsprechender Filtereinschränkung , angezeigt werden.\r\n\r\n\r\nZusatzinfo:\r\nNoch keine Journalisierung im Geschäftsjahr 2015 erfolgt!\r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(10));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
