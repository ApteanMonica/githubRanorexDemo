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
    ///The Neuanlage_speichern_pruefen recording.
    /// </summary>
    [TestModule("c722c0d9-100a-4eda-bb75-ef9d2c1c0528", ModuleType.Recording, 1)]
    public partial class Neuanlage_speichern_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ST_001_B_BANK.B_BANK_Schnelltest_Repository repository.
        /// </summary>
        public static global::B_ST_001_B_BANK.B_BANK_Schnelltest_Repository repo = global::B_ST_001_B_BANK.B_BANK_Schnelltest_Repository.Instance;

        static Neuanlage_speichern_pruefen instance = new Neuanlage_speichern_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Neuanlage_speichern_pruefen()
        {
            Bank_NR = "B_BANK_ST";
            Bank_Name = "B_BANK_ST_SCHNELLTEST";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Neuanlage_speichern_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Bank_Name;

        /// <summary>
        /// Gets or sets the value of variable Bank_Name.
        /// </summary>
        [TestVariable("6bc044fe-12d0-448c-9808-472a50f842a3")]
        public string Bank_Name
        {
            get { return _Bank_Name; }
            set { _Bank_Name = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Bank_NR.
        /// </summary>
        [TestVariable("d402d358-ac6b-43f3-b5a0-11b232f568bb")]
        public string Bank_NR
        {
            get { return repo.Bank_NR; }
            set { repo.Bank_NR = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBank.PbDataAccessSave' at Center.", repo.FrmBank.PbDataAccessSaveInfo, new RecordItemIndex(0));
            repo.FrmBank.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bank_NR) on item 'FrmBank.Bank'.", repo.FrmBank.BankInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmBank.BankInfo, "Text", Bank_NR);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bank_Name) on item 'FrmBank.Name'.", repo.FrmBank.NameInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmBank.NameInfo, "Text", Bank_Name);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='AT') on item 'FrmBank.Land'.", repo.FrmBank.LandInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmBank.LandInfo, "Text", "AT");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmBank.Text_Status'.", repo.FrmBank.Text_StatusInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmBank.Text_StatusInfo, "Text", "0");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
