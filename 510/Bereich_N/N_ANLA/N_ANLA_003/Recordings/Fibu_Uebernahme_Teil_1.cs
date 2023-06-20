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

namespace N_ANLA_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Fibu_Uebernahme_Teil_1 recording.
    /// </summary>
    [TestModule("196b8eef-4fcf-41e4-a144-c91cadcb48dd", ModuleType.Recording, 1)]
    public partial class Fibu_Uebernahme_Teil_1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_ANLA_003.N_ANLA_003Repository repository.
        /// </summary>
        public static global::N_ANLA_003.N_ANLA_003Repository repo = global::N_ANLA_003.N_ANLA_003Repository.Instance;

        static Fibu_Uebernahme_Teil_1 instance = new Fibu_Uebernahme_Teil_1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Fibu_Uebernahme_Teil_1()
        {
            Anlage_1 = "N_ANLA_003_01";
            Bezeichnung_Anlage_1 = "Anlage_003_01";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Fibu_Uebernahme_Teil_1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Anlage_1;

        /// <summary>
        /// Gets or sets the value of variable Anlage_1.
        /// </summary>
        [TestVariable("5b135898-9e11-4ff1-8a74-4a84d138cb6e")]
        public string Anlage_1
        {
            get { return _Anlage_1; }
            set { _Anlage_1 = value; }
        }

        string _Bezeichnung_Anlage_1;

        /// <summary>
        /// Gets or sets the value of variable Bezeichnung_Anlage_1.
        /// </summary>
        [TestVariable("b4a3170a-fc8e-496d-94d0-841179fdf3f8")]
        public string Bezeichnung_Anlage_1
        {
            get { return _Bezeichnung_Anlage_1; }
            set { _Bezeichnung_Anlage_1 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnla.PbNew' at Center.", repo.FrmAnla.PbNewInfo, new RecordItemIndex(0));
            repo.FrmAnla.PbNew.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnla.PbBuchenBuchen' at Center.", repo.FrmAnla.PbBuchenBuchenInfo, new RecordItemIndex(1));
            repo.FrmAnla.PbBuchenBuchen.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Down' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Down, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Right' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Right, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgZugang.TitleBar100AVZBuchungenZugang'", repo.DlgZugang.TitleBar100AVZBuchungenZugangInfo, new ActionTimeout(120000), new RecordItemIndex(5));
            repo.DlgZugang.TitleBar100AVZBuchungenZugangInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgZugang.CbNkr' at Center.", repo.DlgZugang.CbNkrInfo, new RecordItemIndex(6));
            repo.DlgZugang.CbNkr.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'DlgZugang.CbNkr'.", repo.DlgZugang.CbNkrInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgZugang.CbNkrInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2022') on item 'DlgZugang.DfGjhrBez'.", repo.DlgZugang.DfGjhrBezInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.DlgZugang.DfGjhrBezInfo, "Text", "2022");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anlage_1' with focus on 'DlgZugang.DfAnlaNr'.", repo.DlgZugang.DfAnlaNrInfo, new RecordItemIndex(9));
            repo.DlgZugang.DfAnlaNr.PressKeys(Anlage_1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'DlgZugang.DfAnlaNr'.", repo.DlgZugang.DfAnlaNrInfo, new RecordItemIndex(10));
            Keyboard.PrepareFocus(repo.DlgZugang.DfAnlaNr);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Anlage_1) on item 'DlgZugang.DfAnlaNr'.", repo.DlgZugang.DfAnlaNrInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.DlgZugang.DfAnlaNrInfo, "Text", Anlage_1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Bezeichnung_Anlage_1' with focus on 'DlgZugang.DfAnlaBez'.", repo.DlgZugang.DfAnlaBezInfo, new RecordItemIndex(12));
            repo.DlgZugang.DfAnlaBez.PressKeys(Bezeichnung_Anlage_1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'DlgZugang.DfAnlaBez'.", repo.DlgZugang.DfAnlaBezInfo, new RecordItemIndex(13));
            Keyboard.PrepareFocus(repo.DlgZugang.DfAnlaBez);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bezeichnung_Anlage_1) on item 'DlgZugang.DfAnlaBez'.", repo.DlgZugang.DfAnlaBezInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.DlgZugang.DfAnlaBezInfo, "Text", Bezeichnung_Anlage_1);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}