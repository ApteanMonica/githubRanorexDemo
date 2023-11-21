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

namespace V_FADR_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Lieferschein_laden_2 recording.
    /// </summary>
    [TestModule("61239865-c532-4ae6-88d0-e6a0e8cd0e8e", ModuleType.Recording, 1)]
    public partial class Lieferschein_laden_2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_FADR_001.V_FADR_001Repository repository.
        /// </summary>
        public static global::V_FADR_001.V_FADR_001Repository repo = global::V_FADR_001.V_FADR_001Repository.Instance;

        static Lieferschein_laden_2 instance = new Lieferschein_laden_2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Lieferschein_laden_2()
        {
            Tagesdatum = "15.12.2023";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Lieferschein_laden_2 Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("2576ac5a-4af2-4639-89cf-5dc2dcdb4574")]
        public string Tagesdatum
        {
            get { return repo.Tagesdatum; }
            set { repo.Tagesdatum = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.Rech_art_FlexGrid.ColLskDatumRow1' at Center.", repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow1Info, new RecordItemIndex(0));
            //repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow1.Click();
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblFadr.Rech_art_FlexGrid.ColLskDatumRow1' at Center.", repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow1Info, new RecordItemIndex(1));
            //repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow1.DoubleClick();
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+X' Press.", new RecordItemIndex(2));
            //Keyboard.Press(System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.Rech_art_FlexGrid.ColLskDatumRow2' at Center.", repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow2Info, new RecordItemIndex(3));
            //repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow2.Click();
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+V' Press.", new RecordItemIndex(4));
            //Keyboard.Press(System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.Rech_art_FlexGrid.ColLskDatumRow2' at Center.", repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow2Info, new RecordItemIndex(5));
            repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow2.Click();
            
            Tagesdatum = Ranorex.AutomationHelpers.UserCodeCollections.SystemLibrary.GetDateTimeAsString("dd.MM.yyyy");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Tagesdatum' with focus on 'TblFadr.Rech_art_FlexGrid.ColLskDatumRow2'.", repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow2Info, new RecordItemIndex(7));
            repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow2.PressKeys(Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.Rech_art_FlexGrid.ColLskDatumRow1' at Center.", repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow1Info, new RecordItemIndex(10));
            repo.TblFadr.Rech_art_FlexGrid.ColLskDatumRow1.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(11));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick at {X=1069,Y=511}.", new RecordItemIndex(12));
            Mouse.MoveTo(1069, 511);
            Mouse.DoubleClick(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(13));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}{Back}'.", new RecordItemIndex(14));
            Keyboard.Press("{Delete}{Back}");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(15));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(16));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.PbCommonLoad' at Center.", repo.TblFadr.PbCommonLoadInfo, new RecordItemIndex(17));
            repo.TblFadr.PbCommonLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(120000), new RecordItemIndex(18));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Es wurden keine Lieferscheine gefunden die zur Belegerstellung berechtigt sind.\r\nNähere Information unter Menu/Extras/Warum wird Auftrag nicht fakturiert') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Es wurden keine Lieferscheine gefunden die zur Belegerstellung berechtigt sind.\r\nNähere Information unter Menu/Extras/Warum wird Auftrag nicht fakturiert");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(20));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}