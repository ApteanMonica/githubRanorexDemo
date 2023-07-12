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

namespace B_BUAB_007.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Summe recording.
    /// </summary>
    [TestModule("b2938238-8acf-4ca4-95de-56df045d1893", ModuleType.Recording, 1)]
    public partial class Summe : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUAB_007.B_BUAB_007Repository repository.
        /// </summary>
        public static global::B_BUAB_007.B_BUAB_007Repository repo = global::B_BUAB_007.B_BUAB_007Repository.Instance;

        static Summe instance = new Summe();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Summe()
        {
            summe_Soll = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Summe Instance
        {
            get { return instance; }
        }

#region Variables

        string _summe_Soll;

        /// <summary>
        /// Gets or sets the value of variable summe_Soll.
        /// </summary>
        [TestVariable("bcb3efbe-95c6-4238-9ccb-ef8aa99b4b97")]
        public string summe_Soll
        {
            get { return _summe_Soll; }
            set { _summe_Soll = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB1.Row1Column0' at Center.", repo.TblB1.Row1Column0Info, new RecordItemIndex(0));
            repo.TblB1.Row1Column0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}' with focus on 'TblB'.", repo.TblB.SelfInfo, new RecordItemIndex(1));
            repo.TblB.Self.PressKeys("{LShiftKey down}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB.Row3Column0' at Center.", repo.TblB.Row3Column0Info, new RecordItemIndex(2));
            repo.TblB.Row3Column0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey up}' with focus on 'TblB'.", repo.TblB.SelfInfo, new RecordItemIndex(3));
            repo.TblB.Self.PressKeys("{LShiftKey up}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB1.PbCommonSumme' at Center.", repo.TblB1.PbCommonSummeInfo, new RecordItemIndex(4));
            repo.TblB1.PbCommonSumme.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.020,41') on item 'TblB.ChildTableWindow.ColBetragRow1'.", repo.TblB.ChildTableWindow.ColBetragRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblB.ChildTableWindow.ColBetragRow1Info, "Text", "1.020,41");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.020,41') on item 'TblB.ChildTableWindow.ColBetragSummeS'.", repo.TblB.ChildTableWindow.ColBetragSummeSInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblB.ChildTableWindow.ColBetragSummeSInfo, "Text", "1.020,41");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.020,41') on item 'TblB.ChildTableWindow.ColBetragSummeH'.", repo.TblB.ChildTableWindow.ColBetragSummeHInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblB.ChildTableWindow.ColBetragSummeHInfo, "Text", "1.020,41");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'TblB.ChildTableWindow.ColBetragSummeSaldo'.", repo.TblB.ChildTableWindow.ColBetragSummeSaldoInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblB.ChildTableWindow.ColBetragSummeSaldoInfo, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'AccessibleValue' from item 'TblB.ChildTableWindow.ColBetragRow1' and assigning its value to variable 'summe_Soll'.", repo.TblB.ChildTableWindow.ColBetragRow1Info, new RecordItemIndex(9));
            summe_Soll = repo.TblB.ChildTableWindow.ColBetragRow1.Element.GetAttributeValueText("AccessibleValue");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$summe_Soll) on item 'TblB.ChildTableWindow.ColBetragSummeH'.", repo.TblB.ChildTableWindow.ColBetragSummeHInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblB.ChildTableWindow.ColBetragSummeHInfo, "Text", summe_Soll);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
