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

namespace B_EXOPV_005.Recordings_B_EXOPV
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verbuchung_dopp_Beleg_L_Dialoge recording.
    /// </summary>
    [TestModule("f8b28fa4-646a-42df-a9d5-4e45f56b6632", ModuleType.Recording, 1)]
    public partial class Verbuchung_dopp_Beleg_L_Dialoge : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_005.B_EXOPV_005Repository repository.
        /// </summary>
        public static global::B_EXOPV_005.B_EXOPV_005Repository repo = global::B_EXOPV_005.B_EXOPV_005Repository.Instance;

        static Verbuchung_dopp_Beleg_L_Dialoge instance = new Verbuchung_dopp_Beleg_L_Dialoge();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verbuchung_dopp_Beleg_L_Dialoge()
        {
            LF_01 = "303201";
            LF_02 = "303202";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verbuchung_dopp_Beleg_L_Dialoge Instance
        {
            get { return instance; }
        }

#region Variables

        string _LF_01;

        /// <summary>
        /// Gets or sets the value of variable LF_01.
        /// </summary>
        [TestVariable("e277e4e7-f0dc-435e-8a22-a387a482d1df")]
        public string LF_01
        {
            get { return _LF_01; }
            set { _LF_01 = value; }
        }

        string _LF_02;

        /// <summary>
        /// Gets or sets the value of variable LF_02.
        /// </summary>
        [TestVariable("ec7e78a6-458e-4462-90ad-2fab6730d245")]
        public string LF_02
        {
            get { return _LF_02; }
            set { _LF_02 = value; }
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

            // Meldung1_Beleg
            Report.Log(ReportLevel.Info, "Section", "Meldung1_Beleg", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgBelegnrFehler.TitleBar100BelegNrFehler'", repo.DlgBelegnrFehler.TitleBar100BelegNrFehlerInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.DlgBelegnrFehler.TitleBar100BelegNrFehlerInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgBelegnrFehler.TitleBar100BelegNrFehler'.", repo.DlgBelegnrFehler.TitleBar100BelegNrFehlerInfo, new RecordItemIndex(2));
            Validate.Exists(repo.DlgBelegnrFehler.TitleBar100BelegNrFehlerInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_01) on item 'DlgBelegnrFehler.Frame2.DfAdrNr'.", repo.DlgBelegnrFehler.Frame2.DfAdrNrInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgBelegnrFehler.Frame2.DfAdrNrInfo, "Text", LF_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Beleg im selben Jahr schon als OP vorhanden !') on item 'DlgBelegnrFehler.Frame2.Label3'.", repo.DlgBelegnrFehler.Frame2.Label3Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.DlgBelegnrFehler.Frame2.Label3Info, "Text", "Beleg im selben Jahr schon als OP vorhanden !");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'ER01') on item 'DlgBelegnrFehler.Frame2.DfBelegNr'.", repo.DlgBelegnrFehler.Frame2.DfBelegNrInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.DlgBelegnrFehler.Frame2.DfBelegNrInfo, "Text", "ER01");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'ER01') on item 'DlgBelegnrFehler.Frame2.NeueBelegNr'.", repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, "Text", "ER01");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgBelegnrFehler.PbAkzeptieren' at Center.", repo.DlgBelegnrFehler.PbAkzeptierenInfo, new RecordItemIndex(7));
            repo.DlgBelegnrFehler.PbAkzeptieren.Click();
            
            // Meldung2_Fremdbeleg Lieferant 01
            Report.Log(ReportLevel.Info, "Section", "Meldung2_Fremdbeleg Lieferant 01", new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehler'.", repo.DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehlerInfo, new RecordItemIndex(9));
            Validate.Exists(repo.DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehlerInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_01) on item 'DlgFremdbelegnrFehler.Frame2.DfAdrNr'.", repo.DlgFremdbelegnrFehler.Frame2.DfAdrNrInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.DfAdrNrInfo, "Text", LF_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Fremdbeleg im selben Jahr schon als OP vorhanden !') on item 'DlgFremdbelegnrFehler.Frame2.Label3'.", repo.DlgFremdbelegnrFehler.Frame2.Label3Info, new RecordItemIndex(11));
            Validate.AttributeContains(repo.DlgFremdbelegnrFehler.Frame2.Label3Info, "Text", "Fremdbeleg im selben Jahr schon als OP vorhanden !");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'FB01') on item 'DlgFremdbelegnrFehler.Frame2.DfBelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.DfBelegNrInfo, new RecordItemIndex(12));
            Validate.AttributeContains(repo.DlgFremdbelegnrFehler.Frame2.DfBelegNrInfo, "Text", "FB01");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'FB01') on item 'DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, new RecordItemIndex(13));
            Validate.AttributeContains(repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, "Text", "FB01");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgFremdbelegnrFehler.PbAkzeptieren' at Center.", repo.DlgFremdbelegnrFehler.PbAkzeptierenInfo, new RecordItemIndex(14));
            repo.DlgFremdbelegnrFehler.PbAkzeptieren.Click();
            
            // Meldung3_Fremdbeleg LF 01
            Report.Log(ReportLevel.Info, "Section", "Meldung3_Fremdbeleg LF 01", new RecordItemIndex(15));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehler'.", repo.DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehlerInfo, new RecordItemIndex(16));
            Validate.Exists(repo.DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehlerInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_01) on item 'DlgFremdbelegnrFehler.Frame2.DfAdrNr'.", repo.DlgFremdbelegnrFehler.Frame2.DfAdrNrInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.DfAdrNrInfo, "Text", LF_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Fremdbeleg im selben Jahr schon als OP vorhanden !') on item 'DlgFremdbelegnrFehler.Frame2.Label3'.", repo.DlgFremdbelegnrFehler.Frame2.Label3Info, new RecordItemIndex(18));
            Validate.AttributeContains(repo.DlgFremdbelegnrFehler.Frame2.Label3Info, "Text", "Fremdbeleg im selben Jahr schon als OP vorhanden !");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'FB02') on item 'DlgFremdbelegnrFehler.Frame2.DfBelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.DfBelegNrInfo, new RecordItemIndex(19));
            Validate.AttributeContains(repo.DlgFremdbelegnrFehler.Frame2.DfBelegNrInfo, "Text", "FB02");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'FB02') on item 'DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, new RecordItemIndex(20));
            Validate.AttributeContains(repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, "Text", "FB02");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgFremdbelegnrFehler.PbUEber' at Center.", repo.DlgFremdbelegnrFehler.PbUEberInfo, new RecordItemIndex(21));
            repo.DlgFremdbelegnrFehler.PbUEber.Click();
            
            // Meldung 5 Lieferant 02
            Report.Log(ReportLevel.Info, "Section", "Meldung 5 Lieferant 02", new RecordItemIndex(22));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgBelegnrFehler.TitleBar100BelegNrFehler'.", repo.DlgBelegnrFehler.TitleBar100BelegNrFehlerInfo, new RecordItemIndex(23));
            Validate.Exists(repo.DlgBelegnrFehler.TitleBar100BelegNrFehlerInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_02) on item 'DlgBelegnrFehler.Frame2.DfAdrNr'.", repo.DlgBelegnrFehler.Frame2.DfAdrNrInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.DlgBelegnrFehler.Frame2.DfAdrNrInfo, "Text", LF_02);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Beleg im selben Jahr schon als OP vorhanden !') on item 'DlgBelegnrFehler.Frame2.Label3'.", repo.DlgBelegnrFehler.Frame2.Label3Info, new RecordItemIndex(25));
            Validate.AttributeContains(repo.DlgBelegnrFehler.Frame2.Label3Info, "Text", "Beleg im selben Jahr schon als OP vorhanden !");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'ER03') on item 'DlgBelegnrFehler.Frame2.DfBelegNr'.", repo.DlgBelegnrFehler.Frame2.DfBelegNrInfo, new RecordItemIndex(26));
            Validate.AttributeContains(repo.DlgBelegnrFehler.Frame2.DfBelegNrInfo, "Text", "ER03");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'ER03') on item 'DlgBelegnrFehler.Frame2.NeueBelegNr'.", repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, new RecordItemIndex(27));
            Validate.AttributeContains(repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, "Text", "ER03");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgBelegnrFehler.Frame2.NeueBelegNr' at Center.", repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, new RecordItemIndex(28));
            repo.DlgBelegnrFehler.Frame2.NeueBelegNr.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(29));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ER03_EXOPV_005N' with focus on 'DlgBelegnrFehler.Frame2.NeueBelegNr'.", repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, new RecordItemIndex(30));
            repo.DlgBelegnrFehler.Frame2.NeueBelegNr.PressKeys("ER03_EXOPV_005N");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(31));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER03_EXOPV_005N') on item 'DlgBelegnrFehler.Frame2.NeueBelegNr'.", repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, "Text", "ER03_EXOPV_005N");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgBelegnrFehler.PbOk' at Center.", repo.DlgBelegnrFehler.PbOkInfo, new RecordItemIndex(33));
            repo.DlgBelegnrFehler.PbOk.Click();
            
            // Meldung5_Fremdbeleg Lieferant 02
            Report.Log(ReportLevel.Info, "Section", "Meldung5_Fremdbeleg Lieferant 02", new RecordItemIndex(34));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehler'.", repo.DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehlerInfo, new RecordItemIndex(35));
            Validate.Exists(repo.DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehlerInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_02) on item 'DlgFremdbelegnrFehler.Frame2.DfAdrNr'.", repo.DlgFremdbelegnrFehler.Frame2.DfAdrNrInfo, new RecordItemIndex(36));
            Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.DfAdrNrInfo, "Text", LF_02);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Fremdbeleg im selben Jahr schon als OP vorhanden !') on item 'DlgFremdbelegnrFehler.Frame2.Label3'.", repo.DlgFremdbelegnrFehler.Frame2.Label3Info, new RecordItemIndex(37));
            Validate.AttributeContains(repo.DlgFremdbelegnrFehler.Frame2.Label3Info, "Text", "Fremdbeleg im selben Jahr schon als OP vorhanden !");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'FB03') on item 'DlgFremdbelegnrFehler.Frame2.DfBelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.DfBelegNrInfo, new RecordItemIndex(38));
            Validate.AttributeContains(repo.DlgFremdbelegnrFehler.Frame2.DfBelegNrInfo, "Text", "FB03");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'FB03') on item 'DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, new RecordItemIndex(39));
            Validate.AttributeContains(repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, "Text", "FB03");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr' at Center.", repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, new RecordItemIndex(40));
            repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(41));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(42));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(43));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'FB03_EXOPV_005N' with focus on 'DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, new RecordItemIndex(44));
            repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr.PressKeys("FB03_EXOPV_005N");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(45));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='FB03_EXOPV_005N') on item 'DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, new RecordItemIndex(46));
            Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, "Text", "FB03_EXOPV_005N");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgFremdbelegnrFehler.PbOk' at Center.", repo.DlgFremdbelegnrFehler.PbOkInfo, new RecordItemIndex(47));
            repo.DlgFremdbelegnrFehler.PbOk.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
