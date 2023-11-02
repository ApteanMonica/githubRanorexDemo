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

namespace B_ST_001_B_BANK.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Neuanlage_Bankverbindung recording.
    /// </summary>
    [TestModule("245a434e-9a22-478c-8e63-3268ec839e39", ModuleType.Recording, 1)]
    public partial class Neuanlage_Bankverbindung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ST_001_B_BANK.B_BANK_Schnelltest_Repository repository.
        /// </summary>
        public static global::B_ST_001_B_BANK.B_BANK_Schnelltest_Repository repo = global::B_ST_001_B_BANK.B_BANK_Schnelltest_Repository.Instance;

        static Neuanlage_Bankverbindung instance = new Neuanlage_Bankverbindung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Neuanlage_Bankverbindung()
        {
            Bank = "B_BANK_ST";
            Bankname = "B_BANK_ST_SCHNELLTEST";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Neuanlage_Bankverbindung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Bankname;

        /// <summary>
        /// Gets or sets the value of variable Bankname.
        /// </summary>
        [TestVariable("38887dd7-166f-4ad4-b51e-11bc0767388f")]
        public string Bankname
        {
            get { return _Bankname; }
            set { _Bankname = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Bank.
        /// </summary>
        [TestVariable("adfd5bea-f068-45ea-a5d5-0cd5dfd72b6b")]
        public string Bank
        {
            get { return repo.Bank; }
            set { repo.Bank = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBank.PbNew' at Center.", repo.FrmBank.PbNewInfo, new RecordItemIndex(0));
            repo.FrmBank.PbNew.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'FrmBank.Bank'", repo.FrmBank.BankInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.FrmBank.BankInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Bank' with focus on 'FrmBank.Bank'.", repo.FrmBank.BankInfo, new RecordItemIndex(2));
            repo.FrmBank.Bank.PressKeys(Bank);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Bankname' with focus on 'FrmBank.Name'.", repo.FrmBank.NameInfo, new RecordItemIndex(4));
            repo.FrmBank.Name.PressKeys(Bankname);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBank.PbDataAccessSave' at Center.", repo.FrmBank.PbDataAccessSaveInfo, new RecordItemIndex(6));
            repo.FrmBank.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(120000), new RecordItemIndex(7));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Kein Ländercode eingetragen!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(8));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Kein Ländercode eingetragen!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(9));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AT' with focus on 'FrmBank.Land'.", repo.FrmBank.LandInfo, new RecordItemIndex(10));
            repo.FrmBank.Land.PressKeys("AT");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0' with focus on 'FrmBank.Text_Status'.", repo.FrmBank.Text_StatusInfo, new RecordItemIndex(12));
            repo.FrmBank.Text_Status.PressKeys("0");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(13));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBank.PbDataAccessSave' at Center.", repo.FrmBank.PbDataAccessSaveInfo, new RecordItemIndex(14));
            repo.FrmBank.PbDataAccessSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
