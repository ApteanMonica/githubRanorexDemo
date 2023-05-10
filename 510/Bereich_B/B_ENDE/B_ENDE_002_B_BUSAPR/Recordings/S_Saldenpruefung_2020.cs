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

namespace B_ENDE_002_B_BUSAPR.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The S_Saldenpruefung_2020 recording.
    /// </summary>
    [TestModule("bbbdcc90-2c5b-48fa-92e4-856ae9a943ce", ModuleType.Recording, 1)]
    public partial class S_Saldenpruefung_2020 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ENDE_002_B_BUSAPR.B_ENDE_002_B_BUSAPRRepository repository.
        /// </summary>
        public static global::B_ENDE_002_B_BUSAPR.B_ENDE_002_B_BUSAPRRepository repo = global::B_ENDE_002_B_BUSAPR.B_ENDE_002_B_BUSAPRRepository.Instance;

        static S_Saldenpruefung_2020 instance = new S_Saldenpruefung_2020();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public S_Saldenpruefung_2020()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static S_Saldenpruefung_2020 Instance
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2020' with focus on 'Form100PruefungSachkontenSalden.Jahr'.", repo.Form100PruefungSachkontenSalden.JahrInfo, new RecordItemIndex(0));
            repo.Form100PruefungSachkontenSalden.Jahr.PressKeys("2020");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2020') on item 'Form100PruefungSachkontenSalden.Jahr'.", repo.Form100PruefungSachkontenSalden.JahrInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.Form100PruefungSachkontenSalden.JahrInfo, "Text", "2020");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'Form100PruefungSachkontenSalden.Text'.", repo.Form100PruefungSachkontenSalden.TextInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.Form100PruefungSachkontenSalden.TextInfo, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'Form100PruefungSachkontenSalden.CbNormal'.", repo.Form100PruefungSachkontenSalden.CbNormalInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.Form100PruefungSachkontenSalden.CbNormalInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'Form100PruefungSachkontenSalden.CbUst'.", repo.Form100PruefungSachkontenSalden.CbUstInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.Form100PruefungSachkontenSalden.CbUstInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'Form100PruefungSachkontenSalden.CbKorr'.", repo.Form100PruefungSachkontenSalden.CbKorrInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.Form100PruefungSachkontenSalden.CbKorrInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'Form100PruefungSachkontenSalden.RbBasis'.", repo.Form100PruefungSachkontenSalden.RbBasisInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.Form100PruefungSachkontenSalden.RbBasisInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100PruefungSachkontenSalden.PbStart' at Center.", repo.Form100PruefungSachkontenSalden.PbStartInfo, new RecordItemIndex(8));
            repo.Form100PruefungSachkontenSalden.PbStart.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(180000), new RecordItemIndex(9));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Saldenprüfung beendet !') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Saldenprüfung beendet !");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(11));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2020') on item 'Form100PruefungSachkontenSalden.Jahr'.", repo.Form100PruefungSachkontenSalden.JahrInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.Form100PruefungSachkontenSalden.JahrInfo, "Text", "2020");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'Form100PruefungSachkontenSalden.PeriodeVon'.", repo.Form100PruefungSachkontenSalden.PeriodeVonInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.Form100PruefungSachkontenSalden.PeriodeVonInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='14') on item 'Form100PruefungSachkontenSalden.Bis'.", repo.Form100PruefungSachkontenSalden.BisInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.Form100PruefungSachkontenSalden.BisInfo, "Text", "14");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
