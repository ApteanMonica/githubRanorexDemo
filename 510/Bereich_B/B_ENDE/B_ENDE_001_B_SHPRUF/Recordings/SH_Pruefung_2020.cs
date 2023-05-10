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

namespace B_ENDE_001_B_SHPRUF.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SH_Pruefung_2020 recording.
    /// </summary>
    [TestModule("bdc37524-98d0-429b-9f11-8266becf5e14", ModuleType.Recording, 1)]
    public partial class SH_Pruefung_2020 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ENDE_001_B_SHPRUF.B_ENDE_001_B_SHPRUFRepository repository.
        /// </summary>
        public static global::B_ENDE_001_B_SHPRUF.B_ENDE_001_B_SHPRUFRepository repo = global::B_ENDE_001_B_SHPRUF.B_ENDE_001_B_SHPRUFRepository.Instance;

        static SH_Pruefung_2020 instance = new SH_Pruefung_2020();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SH_Pruefung_2020()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SH_Pruefung_2020 Instance
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2020' with focus on 'FrmMain.Jahr'.", repo.FrmMain.JahrInfo, new RecordItemIndex(0));
            repo.FrmMain.Jahr.PressKeys("2020");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2020') on item 'FrmMain.Jahr'.", repo.FrmMain.JahrInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmMain.JahrInfo, "Text", "2020");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmMain.Periode'.", repo.FrmMain.PeriodeInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmMain.PeriodeInfo, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmMain.Benutzer'.", repo.FrmMain.BenutzerInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmMain.BenutzerInfo, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'FrmMain.CbDabu'.", repo.FrmMain.CbDabuInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmMain.CbDabuInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'FrmMain.CbDatei'.", repo.FrmMain.CbDateiInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmMain.CbDateiInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'FrmMain.CbKorrektur'.", repo.FrmMain.CbKorrekturInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmMain.CbKorrekturInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.PbOK' at Center.", repo.FrmMain.PbOKInfo, new RecordItemIndex(8));
            repo.FrmMain.PbOK.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(300000), new RecordItemIndex(9));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(300000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Überprüfung beendet.\r\nEs wurden keine Differenzen gefunden.') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Überprüfung beendet.\r\nEs wurden keine Differenzen gefunden.");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(11));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
