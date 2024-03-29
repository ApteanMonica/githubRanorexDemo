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
    ///The Suchen_Loeschen_auf_Status_9_setzen recording.
    /// </summary>
    [TestModule("d795756a-a9f5-4979-9d07-d40cd63d6463", ModuleType.Recording, 1)]
    public partial class Suchen_Loeschen_auf_Status_9_setzen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ST_001_B_BANK.B_BANK_Schnelltest_Repository repository.
        /// </summary>
        public static global::B_ST_001_B_BANK.B_BANK_Schnelltest_Repository repo = global::B_ST_001_B_BANK.B_BANK_Schnelltest_Repository.Instance;

        static Suchen_Loeschen_auf_Status_9_setzen instance = new Suchen_Loeschen_auf_Status_9_setzen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Suchen_Loeschen_auf_Status_9_setzen()
        {
            Bank_Name_AEN = "B_BANK_SCHNELLTEST";
            Bank_NR = "B_BANK_ST";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Suchen_Loeschen_auf_Status_9_setzen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Bank_Name_AEN;

        /// <summary>
        /// Gets or sets the value of variable Bank_Name_AEN.
        /// </summary>
        [TestVariable("5d5aadd0-b641-42cf-b179-fbb9dff50a91")]
        public string Bank_Name_AEN
        {
            get { return _Bank_Name_AEN; }
            set { _Bank_Name_AEN = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Bank_NR.
        /// </summary>
        [TestVariable("d1e07b1e-fad0-40ea-9d1d-09d65a9fda8a")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBank.PbNavigationBack' at Center.", repo.FrmBank.PbNavigationBackInfo, new RecordItemIndex(0));
            repo.FrmBank.PbNavigationBack.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Bank_NR) on item 'FrmBank.Suchergebis_Tabelle.CellTmpBANKNRRow1'.", repo.FrmBank.Suchergebis_Tabelle.CellTmpBANKNRRow1Info, new RecordItemIndex(1));
            Validate.AttributeContains(repo.FrmBank.Suchergebis_Tabelle.CellTmpBANKNRRow1Info, "Text", Bank_NR);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Bank_Name_AEN) on item 'FrmBank.Suchergebis_Tabelle.CellTmpBANKNAMERow1'.", repo.FrmBank.Suchergebis_Tabelle.CellTmpBANKNAMERow1Info, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmBank.Suchergebis_Tabelle.CellTmpBANKNAMERow1Info, "Text", Bank_Name_AEN);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmBank.Suchergebis_Tabelle.Row1Column01' at Center.", repo.FrmBank.Suchergebis_Tabelle.Row1Column01Info, new RecordItemIndex(3));
            repo.FrmBank.Suchergebis_Tabelle.Row1Column01.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'FrmBank.Bank_Bank_NR'", repo.FrmBank.Bank_Bank_NRInfo, new ActionTimeout(60000), new RecordItemIndex(4));
            repo.FrmBank.Bank_Bank_NRInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBank.PbAllgemeinLoeschen' at Center.", repo.FrmBank.PbAllgemeinLoeschenInfo, new RecordItemIndex(5));
            repo.FrmBank.PbAllgemeinLoeschen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(120000), new RecordItemIndex(6));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Möchten Sie den Status von Bank B_BANK_ST - B_BANK_SCHNELLTEST  auf gelöscht setzen?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(7));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Möchten Sie den Status von Bank B_BANK_ST - B_BANK_SCHNELLTEST  auf gelöscht setzen?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(8));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Der Status von Bank B_BANK_ST - B_BANK_SCHNELLTEST  wurde auf gelöscht gesetzt.') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(10));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Der Status von Bank B_BANK_ST - B_BANK_SCHNELLTEST  wurde auf gelöscht gesetzt.");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(11));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
