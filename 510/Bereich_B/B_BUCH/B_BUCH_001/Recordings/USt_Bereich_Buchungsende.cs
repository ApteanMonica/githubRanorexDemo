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
    ///The USt_Bereich_Buchungsende recording.
    /// </summary>
    [TestModule("6e74bd50-0ccb-4bcc-a1fd-0094c5ca4f84", ModuleType.Recording, 1)]
    public partial class USt_Bereich_Buchungsende : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_001.B_BUCH_001Repository repository.
        /// </summary>
        public static global::B_BUCH_001.B_BUCH_001Repository repo = global::B_BUCH_001.B_BUCH_001Repository.Instance;

        static USt_Bereich_Buchungsende instance = new USt_Bereich_Buchungsende();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public USt_Bereich_Buchungsende()
        {
            Buchungstext = "ER-Buchungs-Test_1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static USt_Bereich_Buchungsende Instance
        {
            get { return instance; }
        }

#region Variables

        string _Buchungstext;

        /// <summary>
        /// Gets or sets the value of variable Buchungstext.
        /// </summary>
        [TestVariable("6d2bab21-2816-441d-8ec4-474b5f37ab92")]
        public string Buchungstext
        {
            get { return _Buchungstext; }
            set { _Buchungstext = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V20') on item 'MdiBuch.FrmS.DfUstCd'.", repo.MdiBuch.FrmS.DfUstCdInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.MdiBuch.FrmS.DfUstCdInfo, "Text", "V20");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20') on item 'MdiBuch.FrmS.DfUstSatz'.", repo.MdiBuch.FrmS.DfUstSatzInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MdiBuch.FrmS.DfUstSatzInfo, "Text", "20");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V') on item 'MdiBuch.FrmS.DfUstmv'.", repo.MdiBuch.FrmS.DfUstmvInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.MdiBuch.FrmS.DfUstmvInfo, "Text", "V");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='16,67') on item 'MdiBuch.FrmS.DfUstbetrag'.", repo.MdiBuch.FrmS.DfUstbetragInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.MdiBuch.FrmS.DfUstbetragInfo, "Text", "16,67");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Buchungstext) on item 'MdiBuch.FrmS.DfText1'.", repo.MdiBuch.FrmS.DfText1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.MdiBuch.FrmS.DfText1Info, "Text", Buchungstext);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBuch.FrmS.DfBubeBektnr1' at Center.", repo.MdiBuch.FrmS.DfBubeBektnr1Info, new RecordItemIndex(5));
            repo.MdiBuch.FrmS.DfBubeBektnr1.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '20' with focus on 'MdiBuch.FrmS.DfBubeBektnr1'.", repo.MdiBuch.FrmS.DfBubeBektnr1Info, new RecordItemIndex(6));
            repo.MdiBuch.FrmS.DfBubeBektnr1.PressKeys("20");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(8));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F12}'.", new RecordItemIndex(9));
            Keyboard.Press("{F12}");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgMessageBox'", repo.DlgMessageBox.SelfInfo, new ActionTimeout(60000), new RecordItemIndex(10));
            repo.DlgMessageBox.SelfInfo.WaitForExists(60000);
            
            // Leerzeichen in Meldung in 510 ab SP14
            Report.Log(ReportLevel.Info, "Validation", "Leerzeichen in Meldung in 510 ab SP14\r\nValidating AttributeRegex (Text~'(Buchung  OK ?)|(Buchung OK ?)') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(11));
            Validate.AttributeRegex(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", new Regex("(Buchung  OK ?)|(Buchung OK ?)"));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(12));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
