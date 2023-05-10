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

namespace B_BUCH_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Meldung_Eingabe_Zahlungsart recording.
    /// </summary>
    [TestModule("d30237c0-c2ff-47a9-b7b9-99126c426054", ModuleType.Recording, 1)]
    public partial class Meldung_Eingabe_Zahlungsart : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_001.B_BUCH_001Repository repository.
        /// </summary>
        public static global::B_BUCH_001.B_BUCH_001Repository repo = global::B_BUCH_001.B_BUCH_001Repository.Instance;

        static Meldung_Eingabe_Zahlungsart instance = new Meldung_Eingabe_Zahlungsart();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Meldung_Eingabe_Zahlungsart()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Meldung_Eingabe_Zahlungsart Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgMessageBox'.", repo.DlgMessageBox.SelfInfo, new RecordItemIndex(0));
            Validate.Exists(repo.DlgMessageBox.SelfInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Bitte Zahlungsart eingeben') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Bitte Zahlungsart eingeben");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(2));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBuch.FrmRG.unterer_Frame_3.DfZahlart' at Center.", repo.MdiBuch.FrmRG.unterer_Frame_3.DfZahlartInfo, new RecordItemIndex(3));
            repo.MdiBuch.FrmRG.unterer_Frame_3.DfZahlart.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'S' with focus on 'MdiBuch.FrmRG.unterer_Frame_3.DfZahlart'.", repo.MdiBuch.FrmRG.unterer_Frame_3.DfZahlartInfo, new RecordItemIndex(4));
            repo.MdiBuch.FrmRG.unterer_Frame_3.DfZahlart.PressKeys("S");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(5));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBuch.PbStandard2_Weiter' at Center.", repo.MdiBuch.PbStandard2_WeiterInfo, new RecordItemIndex(6));
            repo.MdiBuch.PbStandard2_Weiter.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgMessageBox'.", repo.DlgMessageBox.SelfInfo, new RecordItemIndex(7));
            Validate.Exists(repo.DlgMessageBox.SelfInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Bankverbindung') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(8));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Bankverbindung");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(9));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBuch.FrmRG.unterer_Frame_3.DfZahlart' at Center.", repo.MdiBuch.FrmRG.unterer_Frame_3.DfZahlartInfo, new RecordItemIndex(10));
            repo.MdiBuch.FrmRG.unterer_Frame_3.DfZahlart.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}B' with focus on 'MdiBuch.FrmRG.unterer_Frame_3.DfZahlart'.", repo.MdiBuch.FrmRG.unterer_Frame_3.DfZahlartInfo, new RecordItemIndex(11));
            repo.MdiBuch.FrmRG.unterer_Frame_3.DfZahlart.PressKeys("{Back}B");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(12));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBuch.PbStandard2_Weiter' at Center.", repo.MdiBuch.PbStandard2_WeiterInfo, new RecordItemIndex(13));
            repo.MdiBuch.PbStandard2_Weiter.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
