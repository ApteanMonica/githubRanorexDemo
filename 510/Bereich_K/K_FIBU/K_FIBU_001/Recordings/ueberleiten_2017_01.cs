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

namespace K_FIBU_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ueberleiten_2017_01 recording.
    /// </summary>
    [TestModule("c8e12b48-d854-45b2-bd24-7c8d66e77dd5", ModuleType.Recording, 1)]
    public partial class Ueberleiten_2017_01 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_FIBU_001.K_FIBU_001Repository repository.
        /// </summary>
        public static global::K_FIBU_001.K_FIBU_001Repository repo = global::K_FIBU_001.K_FIBU_001Repository.Instance;

        static Ueberleiten_2017_01 instance = new Ueberleiten_2017_01();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ueberleiten_2017_01()
        {
            Jahr = "2017";
            Periode = "01";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ueberleiten_2017_01 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("7c4e58b5-f821-4e61-87c3-046bf6c45643")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Periode;

        /// <summary>
        /// Gets or sets the value of variable Periode.
        /// </summary>
        [TestVariable("2f7a5408-7b47-4b57-8221-8ad5730184d9")]
        public string Periode
        {
            get { return _Periode; }
            set { _Periode = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmVerbuch.JahrPeriode_von_Jahr'", repo.FrmVerbuch.JahrPeriode_von_JahrInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.FrmVerbuch.JahrPeriode_von_JahrInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'FrmVerbuch.JahrPeriode_von_Jahr'.", repo.FrmVerbuch.JahrPeriode_von_JahrInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.FrmVerbuch.JahrPeriode_von_Jahr);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmVerbuch.JahrPeriode_von_Jahr' at Center.", repo.FrmVerbuch.JahrPeriode_von_JahrInfo, new RecordItemIndex(2));
            repo.FrmVerbuch.JahrPeriode_von_Jahr.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jahr' with focus on 'FrmVerbuch.JahrPeriode_von_Jahr'.", repo.FrmVerbuch.JahrPeriode_von_JahrInfo, new RecordItemIndex(4));
            repo.FrmVerbuch.JahrPeriode_von_Jahr.PressKeys(Jahr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Periode' with focus on 'FrmVerbuch.von_Peride'.", repo.FrmVerbuch.von_PerideInfo, new RecordItemIndex(6));
            repo.FrmVerbuch.von_Peride.PressKeys(Periode);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jahr' with focus on 'FrmVerbuch.bis_Jahr'.", repo.FrmVerbuch.bis_JahrInfo, new RecordItemIndex(8));
            repo.FrmVerbuch.bis_Jahr.PressKeys(Jahr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Periode' with focus on 'FrmVerbuch.bis_Periode'.", repo.FrmVerbuch.bis_PeriodeInfo, new RecordItemIndex(10));
            repo.FrmVerbuch.bis_Periode.PressKeys(Periode);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'FrmVerbuch.JahrPeriode_von_Jahr'.", repo.FrmVerbuch.JahrPeriode_von_JahrInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmVerbuch.JahrPeriode_von_JahrInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Periode) on item 'FrmVerbuch.von_Peride'.", repo.FrmVerbuch.von_PerideInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmVerbuch.von_PerideInfo, "Text", Periode);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'FrmVerbuch.bis_Jahr'.", repo.FrmVerbuch.bis_JahrInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmVerbuch.bis_JahrInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Periode) on item 'FrmVerbuch.bis_Periode'.", repo.FrmVerbuch.bis_PeriodeInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmVerbuch.bis_PeriodeInfo, "Text", Periode);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmVerbuch.PbOK' at Center.", repo.FrmVerbuch.PbOKInfo, new RecordItemIndex(16));
            repo.FrmVerbuch.PbOK.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.BereichsSummenBerechnen'", repo.DlgMessageBox.BereichsSummenBerechnenInfo, new ActionTimeout(120000), new RecordItemIndex(17));
            repo.DlgMessageBox.BereichsSummenBerechnenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Die Periode(n) wurde(n) schon berechnet! - Überschreiben?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Die Periode(n) wurde(n) schon berechnet! - Überschreiben?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(19));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
