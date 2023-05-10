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

namespace B_BUKA_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SplittBu_02_splitten recording.
    /// </summary>
    [TestModule("43382c40-cd7e-47c3-9015-244d4d537605", ModuleType.Recording, 1)]
    public partial class SplittBu_02_splitten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUKA_004.B_BUKA_004Repository repository.
        /// </summary>
        public static global::B_BUKA_004.B_BUKA_004Repository repo = global::B_BUKA_004.B_BUKA_004Repository.Instance;

        static SplittBu_02_splitten instance = new SplittBu_02_splitten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SplittBu_02_splitten()
        {
            SplittBu_02_Text = "SplittBu_02";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SplittBu_02_splitten Instance
        {
            get { return instance; }
        }

#region Variables

        string _SplittBu_02_Text;

        /// <summary>
        /// Gets or sets the value of variable SplittBu_02_Text.
        /// </summary>
        [TestVariable("4cf371be-05d8-4f16-86cb-3e19b8a995cc")]
        public string SplittBu_02_Text
        {
            get { return _SplittBu_02_Text; }
            set { _SplittBu_02_Text = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuka.FlexGrid1.Row5Column0' at Center.", repo.TblBuka.FlexGrid1.Row5Column0Info, new RecordItemIndex(0));
            repo.TblBuka.FlexGrid1.Row5Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuka.PbToolBarItemsSplittung' at Center.", repo.TblBuka.PbToolBarItemsSplittungInfo, new RecordItemIndex(1));
            repo.TblBuka.PbToolBarItemsSplittung.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '20' with focus on 'TblBuka.FlexGrid1.ColAusgangRow6'.", repo.TblBuka.FlexGrid1.ColAusgangRow6Info, new RecordItemIndex(2));
            repo.TblBuka.FlexGrid1.ColAusgangRow6.PressKeys("20");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(3));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgMessageBox'.", repo.DlgMessageBox.SelfInfo, new RecordItemIndex(4));
            Validate.Exists(repo.DlgMessageBox.SelfInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Minusbetrag!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Minusbetrag!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(6));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuka.PbDataAccessSave' at Center.", repo.TblBuka.PbDataAccessSaveInfo, new RecordItemIndex(7));
            repo.TblBuka.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'TblBuka.FlexGrid1.ColPosRow5'.", repo.TblBuka.FlexGrid1.ColPosRow5Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblBuka.FlexGrid1.ColPosRow5Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='-10,00') on item 'TblBuka.FlexGrid1.ColAusgangRow5'.", repo.TblBuka.FlexGrid1.ColAusgangRow5Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblBuka.FlexGrid1.ColAusgangRow5Info, "Text", "-10,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='9.910,00') on item 'TblBuka.FlexGrid1.ColSaldoLfdRow5'.", repo.TblBuka.FlexGrid1.ColSaldoLfdRow5Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblBuka.FlexGrid1.ColSaldoLfdRow5Info, "Text", "9.910,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='19') on item 'TblBuka.FlexGrid1.ColTagRow6'.", repo.TblBuka.FlexGrid1.ColTagRow6Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblBuka.FlexGrid1.ColTagRow6Info, "Text", "19");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0003') on item 'TblBuka.FlexGrid1.ColBelegRow6'.", repo.TblBuka.FlexGrid1.ColBelegRow6Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblBuka.FlexGrid1.ColBelegRow6Info, "Text", "0003");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'TblBuka.FlexGrid1.ColPosRow6'.", repo.TblBuka.FlexGrid1.ColPosRow6Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TblBuka.FlexGrid1.ColPosRow6Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$SplittBu_02_Text) on item 'TblBuka.FlexGrid1.ColTextRow6'.", repo.TblBuka.FlexGrid1.ColTextRow6Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.TblBuka.FlexGrid1.ColTextRow6Info, "Text", SplittBu_02_Text);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='9.890,00') on item 'TblBuka.FlexGrid1.ColSaldoLfdRow6'.", repo.TblBuka.FlexGrid1.ColSaldoLfdRow6Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.TblBuka.FlexGrid1.ColSaldoLfdRow6Info, "Text", "9.890,00");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
