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

namespace L_KMSM_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Positionen_2 recording.
    /// </summary>
    [TestModule("e86e4d40-2a47-40fd-b30a-5ed433ed957c", ModuleType.Recording, 1)]
    public partial class Positionen_2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::L_KMSM_001.L_KMSM_001Repository repository.
        /// </summary>
        public static global::L_KMSM_001.L_KMSM_001Repository repo = global::L_KMSM_001.L_KMSM_001Repository.Instance;

        static Positionen_2 instance = new Positionen_2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Positionen_2()
        {
            Charge = "";
            Seriennummer = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Positionen_2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Charge;

        /// <summary>
        /// Gets or sets the value of variable Charge.
        /// </summary>
        [TestVariable("6334e5c7-ca22-4791-9ec0-a222068a5d59")]
        public string Charge
        {
            get { return _Charge; }
            set { _Charge = value; }
        }

        string _Seriennummer;

        /// <summary>
        /// Gets or sets the value of variable Seriennummer.
        /// </summary>
        [TestVariable("75a72e0e-bde9-44d5-bfd7-f1dfc4239960")]
        public string Seriennummer
        {
            get { return _Seriennummer; }
            set { _Seriennummer = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKMSM.FlexGrid.ColKmspMgistRow2' at Center.", repo.TblKMSM.FlexGrid.ColKmspMgistRow2Info, new RecordItemIndex(0));
            repo.TblKMSM.FlexGrid.ColKmspMgistRow2.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}{Back}{Delete}{Delete}2' with focus on 'TblKMSM.ColKmspMgistRow1'.", repo.TblKMSM.ColKmspMgistRow1Info, new RecordItemIndex(1));
            repo.TblKMSM.ColKmspMgistRow1.EnsureVisible();
            Keyboard.Press("{Back}{Back}{Delete}{Delete}2");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKMSM.FlexGrid.ColZuteilungRow2' at Center.", repo.TblKMSM.FlexGrid.ColZuteilungRow2Info, new RecordItemIndex(2));
            repo.TblKMSM.FlexGrid.ColZuteilungRow2.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2,00') on item 'TblKMSM.FlexGrid.ColKmspMgistRow2'.", repo.TblKMSM.FlexGrid.ColKmspMgistRow2Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblKMSM.FlexGrid.ColKmspMgistRow2Info, "Text", "2,00");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKMSM.PbDataAccessSave' at Center.", repo.TblKMSM.PbDataAccessSaveInfo, new RecordItemIndex(4));
            repo.TblKMSM.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Für diesen Artikel muß eine Chargennummer eingegeben werden!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Für diesen Artikel muß eine Chargennummer eingegeben werden!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(6));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Charge'.", new RecordItemIndex(7));
            Keyboard.Press(Charge);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Charge) on item 'TblKMSM.FlexGrid.ColLgpbChgnrRow5'.", repo.TblKMSM.FlexGrid.ColLgpbChgnrRow5Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblKMSM.FlexGrid.ColLgpbChgnrRow5Info, "Text", Charge);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
