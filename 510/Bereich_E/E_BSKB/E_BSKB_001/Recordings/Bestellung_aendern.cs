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
    ///The Bestellung_aendern recording.
    /// </summary>
    [TestModule("54876573-9a05-4fae-91f0-29dcc5f06153", ModuleType.Recording, 1)]
    public partial class Bestellung_aendern : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_BSKB_001.E_BSKB_001Repository repository.
        /// </summary>
        public static global::E_BSKB_001.E_BSKB_001Repository repo = global::E_BSKB_001.E_BSKB_001Repository.Instance;

        static Bestellung_aendern instance = new Bestellung_aendern();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Bestellung_aendern()
        {
            Preis1 = "2,208";
            Menge_2 = "20";
            Preis4 = "2";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Bestellung_aendern Instance
        {
            get { return instance; }
        }

#region Variables

        string _Preis1;

        /// <summary>
        /// Gets or sets the value of variable Preis1.
        /// </summary>
        [TestVariable("581c2664-1d5d-4fcf-a0f5-df9f9257c775")]
        public string Preis1
        {
            get { return _Preis1; }
            set { _Preis1 = value; }
        }

        string _Menge_2;

        /// <summary>
        /// Gets or sets the value of variable Menge_2.
        /// </summary>
        [TestVariable("9098aea5-4fd7-45c1-8925-493c6681a49b")]
        public string Menge_2
        {
            get { return _Menge_2; }
            set { _Menge_2 = value; }
        }

        string _Preis4;

        /// <summary>
        /// Gets or sets the value of variable Preis4.
        /// </summary>
        [TestVariable("6a3d99d3-1aca-4812-baa5-e9879ef8e67f")]
        public string Preis4
        {
            get { return _Preis4; }
            set { _Preis4 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBskb.FlexGrid.ColBspPreisBstgRow1' at Center.", repo.TblBskb.FlexGrid.ColBspPreisBstgRow1Info, new RecordItemIndex(0));
            repo.TblBskb.FlexGrid.ColBspPreisBstgRow1.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'TblBskb.FlexGrid.ColBspPreisBstgRow1'.", repo.TblBskb.FlexGrid.ColBspPreisBstgRow1Info, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.TblBskb.FlexGrid.ColBspPreisBstgRow1);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Preis1' with focus on 'TblBskb.FlexGrid.ColBspPreisBstgRow1'.", repo.TblBskb.FlexGrid.ColBspPreisBstgRow1Info, new RecordItemIndex(2));
            repo.TblBskb.FlexGrid.ColBspPreisBstgRow1.EnsureVisible();
            Keyboard.Press(Preis1);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBskb.FlexGrid.ColBspBestaetigtRow2' at Center.", repo.TblBskb.FlexGrid.ColBspBestaetigtRow2Info, new RecordItemIndex(3));
            repo.TblBskb.FlexGrid.ColBspBestaetigtRow2.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'TblBskb.FlexGrid.ColBspBestaetigtRow2'.", repo.TblBskb.FlexGrid.ColBspBestaetigtRow2Info, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.TblBskb.FlexGrid.ColBspBestaetigtRow2);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Menge_2' with focus on 'TblBskb.FlexGrid.ColBspBestaetigtRow2'.", repo.TblBskb.FlexGrid.ColBspBestaetigtRow2Info, new RecordItemIndex(5));
            repo.TblBskb.FlexGrid.ColBspBestaetigtRow2.EnsureVisible();
            Keyboard.Press(Menge_2);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'TblBskb.FlexGrid.ColBspBestaetigtRow2'.", repo.TblBskb.FlexGrid.ColBspBestaetigtRow2Info, new RecordItemIndex(6));
            repo.TblBskb.FlexGrid.ColBspBestaetigtRow2.EnsureVisible();
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBskb.FlexGrid.ColBspPreisBstgRow4' at Center.", repo.TblBskb.FlexGrid.ColBspPreisBstgRow4Info, new RecordItemIndex(7));
            repo.TblBskb.FlexGrid.ColBspPreisBstgRow4.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'TblBskb.FlexGrid.ColBspPreisBstgRow4'.", repo.TblBskb.FlexGrid.ColBspPreisBstgRow4Info, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.TblBskb.FlexGrid.ColBspPreisBstgRow4);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Preis4' with focus on 'TblBskb.FlexGrid.ColBspPreisBstgRow4'.", repo.TblBskb.FlexGrid.ColBspPreisBstgRow4Info, new RecordItemIndex(9));
            repo.TblBskb.FlexGrid.ColBspPreisBstgRow4.EnsureVisible();
            Keyboard.Press(Preis4);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'TblBskb.FlexGrid.ColBspPreisBstgRow4'.", repo.TblBskb.FlexGrid.ColBspPreisBstgRow4Info, new RecordItemIndex(10));
            repo.TblBskb.FlexGrid.ColBspPreisBstgRow4.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBskb.PbDataAccessSave' at Center.", repo.TblBskb.PbDataAccessSaveInfo, new RecordItemIndex(11));
            repo.TblBskb.PbDataAccessSave.Click();
            
            // BAR: wait for für Bestätigungsmeldung  hinzugefügt!
            Report.Log(ReportLevel.Info, "Wait", "BAR: wait for für Bestätigungsmeldung  hinzugefügt!\r\nWaiting 3m to exist. Associated repository item: 'DlgMessageBox.BestellungBestaetigen'", repo.DlgMessageBox.BestellungBestaetigenInfo, new ActionTimeout(180000), new RecordItemIndex(12));
            repo.DlgMessageBox.BestellungBestaetigenInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'ACHTUNG: Der Preis mind. einer Position') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(13));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "ACHTUNG: Der Preis mind. einer Position");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(14));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Ihre eigene Mindesteinkaufsmenge wurde unterschritten!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(15));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Ihre eigene Mindesteinkaufsmenge wurde unterschritten!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(16));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
