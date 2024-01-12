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

namespace K_PBU_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kostenstellen_Einschraenkung_von_bis_setzen recording.
    /// </summary>
    [TestModule("4734ed7e-3a0d-4877-8588-6b6424afcb68", ModuleType.Recording, 1)]
    public partial class Kostenstellen_Einschraenkung_von_bis_setzen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_PBU_001.K_PBU_001Repository repository.
        /// </summary>
        public static global::K_PBU_001.K_PBU_001Repository repo = global::K_PBU_001.K_PBU_001Repository.Instance;

        static Kostenstellen_Einschraenkung_von_bis_setzen instance = new Kostenstellen_Einschraenkung_von_bis_setzen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kostenstellen_Einschraenkung_von_bis_setzen()
        {
            Kostenstelle = "10";
            Kostenstelle2 = "20";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kostenstellen_Einschraenkung_von_bis_setzen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Kostenstelle;

        /// <summary>
        /// Gets or sets the value of variable Kostenstelle.
        /// </summary>
        [TestVariable("cf49c119-88f5-46b5-b4f4-e4bc81d509be")]
        public string Kostenstelle
        {
            get { return _Kostenstelle; }
            set { _Kostenstelle = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Kostenstelle2.
        /// </summary>
        [TestVariable("aaddb638-39d3-4dbb-8a60-516b679f8341")]
        public string Kostenstelle2
        {
            get { return repo.Kostenstelle2; }
            set { repo.Kostenstelle2 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblK.PbCommonNeu' at Center.", repo.TblK.PbCommonNeuInfo, new RecordItemIndex(0));
            repo.TblK.PbCommonNeu.Click();
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'True' on item 'TblK.CbBereich1'.", repo.TblK.CbBereich1Info, new RecordItemIndex(1));
            repo.TblK.CbBereich1.Element.SetAttributeValue("Checked", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblK.CbBereich1' at Center.", repo.TblK.CbBereich1Info, new RecordItemIndex(2));
            repo.TblK.CbBereich1.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'TblK.CbBereich1'.", repo.TblK.CbBereich1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblK.CbBereich1Info, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblK.PbCommonLaden' at Center.", repo.TblK.PbCommonLadenInfo, new RecordItemIndex(4));
            repo.TblK.PbCommonLaden.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgLaden.TitleBar100AuswahlKostenstellen'", repo.DlgLaden.TitleBar100AuswahlKostenstellenInfo, new ActionTimeout(60000), new RecordItemIndex(5));
            repo.DlgLaden.TitleBar100AuswahlKostenstellenInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Auswahl Kostenstellen') on item 'DlgLaden.TitleBar100AuswahlKostenstellen'.", repo.DlgLaden.TitleBar100AuswahlKostenstellenInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.DlgLaden.TitleBar100AuswahlKostenstellenInfo, "Text", "Auswahl Kostenstellen");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgLaden.TextKostenstellenVon' at Center.", repo.DlgLaden.TextKostenstellenVonInfo, new RecordItemIndex(7));
            repo.DlgLaden.TextKostenstellenVon.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Kostenstelle' with focus on 'DlgLaden.TextKostenstellenVon'.", repo.DlgLaden.TextKostenstellenVonInfo, new RecordItemIndex(8));
            repo.DlgLaden.TextKostenstellenVon.PressKeys(Kostenstelle);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Kostenstelle2' with focus on 'DlgLaden.TextBis'.", repo.DlgLaden.TextBisInfo, new RecordItemIndex(10));
            repo.DlgLaden.TextBis.PressKeys(Kostenstelle2);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgLaden.PbOk' at Center.", repo.DlgLaden.PbOkInfo, new RecordItemIndex(12));
            repo.DlgLaden.PbOk.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
