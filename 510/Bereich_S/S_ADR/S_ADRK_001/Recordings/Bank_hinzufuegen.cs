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

namespace S_ADRK_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Bank_hinzufuegen recording.
    /// </summary>
    [TestModule("fcc14d1d-53b1-4328-b017-f68a38171d78", ModuleType.Recording, 1)]
    public partial class Bank_hinzufuegen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ADRK_001.S_ADRK_001Repository repository.
        /// </summary>
        public static global::S_ADRK_001.S_ADRK_001Repository repo = global::S_ADRK_001.S_ADRK_001Repository.Instance;

        static Bank_hinzufuegen instance = new Bank_hinzufuegen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Bank_hinzufuegen()
        {
            IBAN = "AT54 1953 0001 0017 0699";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Bank_hinzufuegen Instance
        {
            get { return instance; }
        }

#region Variables

        string _IBAN;

        /// <summary>
        /// Gets or sets the value of variable IBAN.
        /// </summary>
        [TestVariable("2acc137a-68c7-4d74-b0ac-dc77945b82a2")]
        public string IBAN
        {
            get { return _IBAN; }
            set { _IBAN = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.PbCommonBank' at Center.", repo.FrmAdr.PbCommonBankInfo, new RecordItemIndex(0));
            repo.FrmAdr.PbCommonBank.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKlbkAdr.PbSpeichern' at Center.", repo.FrmKlbkAdr.PbSpeichernInfo, new RecordItemIndex(1));
            repo.FrmKlbkAdr.PbSpeichern.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKlbkAdr.ChildTableWindow.FlexGrid' at Center.", repo.FrmKlbkAdr.ChildTableWindow.FlexGridInfo, new RecordItemIndex(2));
            repo.FrmKlbkAdr.ChildTableWindow.FlexGrid.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Insert}' with focus on 'FrmKlbkAdr.ChildTableWindow.FlexGrid'.", repo.FrmKlbkAdr.ChildTableWindow.FlexGridInfo, new RecordItemIndex(3));
            repo.FrmKlbkAdr.ChildTableWindow.FlexGrid.PressKeys("{Insert}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKlbkAdr.ChildTableWindow.IBAN' at Center.", repo.FrmKlbkAdr.ChildTableWindow.IBANInfo, new RecordItemIndex(4));
            repo.FrmKlbkAdr.ChildTableWindow.IBAN.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$IBAN' with focus on 'FrmKlbkAdr.ChildTableWindow.IBAN'.", repo.FrmKlbkAdr.ChildTableWindow.IBANInfo, new RecordItemIndex(5));
            repo.FrmKlbkAdr.ChildTableWindow.IBAN.EnsureVisible();
            Keyboard.Press(IBAN);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmKlbkAdr.ChildTableWindow.FlexGrid'.", repo.FrmKlbkAdr.ChildTableWindow.FlexGridInfo, new RecordItemIndex(6));
            repo.FrmKlbkAdr.ChildTableWindow.FlexGrid.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKlbkAdr.PbSpeichern' at Center.", repo.FrmKlbkAdr.PbSpeichernInfo, new RecordItemIndex(7));
            repo.FrmKlbkAdr.PbSpeichern.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKlbkAdr.Schliessen' at Center.", repo.FrmKlbkAdr.SchliessenInfo, new RecordItemIndex(8));
            repo.FrmKlbkAdr.Schliessen.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.PbCommonBank' at Center.", repo.FrmAdr.PbCommonBankInfo, new RecordItemIndex(9));
            repo.FrmAdr.PbCommonBank.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Bankhaus Carl Spängler & Co. AG') on item 'FrmKlbkAdr.ChildTableWindow.Name_Bank'.", repo.FrmKlbkAdr.ChildTableWindow.Name_BankInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmKlbkAdr.ChildTableWindow.Name_BankInfo, "Text", "Bankhaus Carl Spängler & Co. AG");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
