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

namespace E_BSKB_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Position_splitten recording.
    /// </summary>
    [TestModule("7dfef80e-881c-42db-b132-b8eb2f5d6158", ModuleType.Recording, 1)]
    public partial class Position_splitten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_BSKB_001.E_BSKB_001Repository repository.
        /// </summary>
        public static global::E_BSKB_001.E_BSKB_001Repository repo = global::E_BSKB_001.E_BSKB_001Repository.Instance;

        static Position_splitten instance = new Position_splitten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Position_splitten()
        {
            Menge32 = "2";
            Menge31 = "3";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Position_splitten Instance
        {
            get { return instance; }
        }

#region Variables

        string _Menge32;

        /// <summary>
        /// Gets or sets the value of variable Menge32.
        /// </summary>
        [TestVariable("a8d53b77-8785-49d1-bb57-ef736bf7545b")]
        public string Menge32
        {
            get { return _Menge32; }
            set { _Menge32 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Menge31.
        /// </summary>
        [TestVariable("c799a7d7-800c-43da-899f-b5f7d0ff4869")]
        public string Menge31
        {
            get { return repo.Menge31; }
            set { repo.Menge31 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBskb.FlexGrid.Row3Column0' at Center.", repo.TblBskb.FlexGrid.Row3Column0Info, new RecordItemIndex(0));
            repo.TblBskb.FlexGrid.Row3Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBskb.PbExtrasSplitten' at Center.", repo.TblBskb.PbExtrasSplittenInfo, new RecordItemIndex(1));
            repo.TblBskb.PbExtrasSplitten.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1' at Center.", repo.DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1Info, new RecordItemIndex(2));
            repo.DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1' at Center.", repo.DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1Info, new RecordItemIndex(3));
            repo.DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Menge31' with focus on 'DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1'.", repo.DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1Info, new RecordItemIndex(4));
            repo.DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1.PressKeys(Menge31);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1'.", repo.DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1Info, new RecordItemIndex(5));
            repo.DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1.EnsureVisible();
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Insert}' with focus on 'DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1'.", repo.DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1Info, new RecordItemIndex(6));
            repo.DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow1.PressKeys("{Insert}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgSplittenBsp.TblSBsp.ColSBspDtbstgRow2' at Center.", repo.DlgSplittenBsp.TblSBsp.ColSBspDtbstgRow2Info, new RecordItemIndex(7));
            repo.DlgSplittenBsp.TblSBsp.ColSBspDtbstgRow2.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{PageDown}' with focus on 'DlgSplittenBsp.TblSBsp.ColSBspDtbstgRow2'.", repo.DlgSplittenBsp.TblSBsp.ColSBspDtbstgRow2Info, new RecordItemIndex(8));
            repo.DlgSplittenBsp.TblSBsp.ColSBspDtbstgRow2.PressKeys("{PageDown}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Menge32) on item 'DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow2'.", repo.DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow2Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.DlgSplittenBsp.TblSBsp.ColSBspBestaetigtRow2Info, "Text", Menge32);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PbSpeichern' at Center.", repo.PbSpeichernInfo, new RecordItemIndex(10));
            repo.PbSpeichern.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='5') on item 'TblBskb.FlexGrid.ColBspNrRow5'.", repo.TblBskb.FlexGrid.ColBspNrRow5Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblBskb.FlexGrid.ColBspNrRow5Info, "Text", "5");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
