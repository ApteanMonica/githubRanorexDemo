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

namespace B_BER_Schnelltest.Recordings_Bereiche
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Aenderung_Bereich_Meldung recording.
    /// </summary>
    [TestModule("bd66f7a1-21ea-4ef5-8935-a441854e2842", ModuleType.Recording, 1)]
    public partial class Aenderung_Bereich_Meldung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BER_Schnelltest.B_BER_SchnelltestRepository repository.
        /// </summary>
        public static global::B_BER_Schnelltest.B_BER_SchnelltestRepository repo = global::B_BER_Schnelltest.B_BER_SchnelltestRepository.Instance;

        static Aenderung_Bereich_Meldung instance = new Aenderung_Bereich_Meldung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Aenderung_Bereich_Meldung()
        {
            BER_BEZ_AEN = "B_BER_Schnelltest_AEN";
            FIBU_POS_AEN = "6";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Aenderung_Bereich_Meldung Instance
        {
            get { return instance; }
        }

#region Variables

        string _BER_BEZ_AEN;

        /// <summary>
        /// Gets or sets the value of variable BER_BEZ_AEN.
        /// </summary>
        [TestVariable("ce8eaf31-67c2-46d6-bdf4-30e1057b7833")]
        public string BER_BEZ_AEN
        {
            get { return _BER_BEZ_AEN; }
            set { _BER_BEZ_AEN = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable FIBU_POS_AEN.
        /// </summary>
        [TestVariable("2c73edd3-71cc-4cd2-aa6c-a159ceb3ce9b")]
        public string FIBU_POS_AEN
        {
            get { return repo.FIBU_POS_AEN; }
            set { repo.FIBU_POS_AEN = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBer.row5.ColBerBezRow5' at Center.", repo.TblBer.row5.ColBerBezRow5Info, new RecordItemIndex(0));
            repo.TblBer.row5.ColBerBezRow5.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblBer.row5.ColBerBezRow5' at Center.", repo.TblBer.row5.ColBerBezRow5Info, new RecordItemIndex(1));
            repo.TblBer.row5.ColBerBezRow5.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BER_BEZ_AEN' with focus on 'TblBer.row5.ColBerBezRow5'.", repo.TblBer.row5.ColBerBezRow5Info, new RecordItemIndex(2));
            repo.TblBer.row5.ColBerBezRow5.PressKeys(BER_BEZ_AEN);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FIBU_POS_AEN' with focus on 'TblBer.row5.ColBerPosRow5'.", repo.TblBer.row5.ColBerPosRow5Info, new RecordItemIndex(4));
            repo.TblBer.row5.ColBerPosRow5.PressKeys(FIBU_POS_AEN);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}{Tab}'.", new RecordItemIndex(5));
            Keyboard.Press("{Tab}{Tab}{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '9' with focus on 'TblBer.row5.ColBerKontrBestandRow5'.", repo.TblBer.row5.ColBerKontrBestandRow5Info, new RecordItemIndex(6));
            repo.TblBer.row5.ColBerKontrBestandRow5.PressKeys("9");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(60000), new RecordItemIndex(8));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Bereichskonto '5' / '9' nicht vorhanden !') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Bereichskonto '5' / '9' nicht vorhanden !");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(10));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(11));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBer.row5.ColBerKontrBestandRow5' at Center.", repo.TblBer.row5.ColBerKontrBestandRow5Info, new RecordItemIndex(12));
            repo.TblBer.row5.ColBerKontrBestandRow5.Click();
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(13));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblBer.row5.ColBerKontrBestandRow5' at Center.", repo.TblBer.row5.ColBerKontrBestandRow5Info, new RecordItemIndex(14));
            //repo.TblBer.row5.ColBerKontrBestandRow5.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press.", new RecordItemIndex(15));
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(16));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}{Tab}{Tab}'.", new RecordItemIndex(17));
            Keyboard.Press("{Tab}{Tab}{Tab}{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBer.row5.ColBerKzherkRow5' at Center.", repo.TblBer.row5.ColBerKzherkRow5Info, new RecordItemIndex(18));
            repo.TblBer.row5.ColBerKzherkRow5.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBer.row5.ColBerCd1VerrRow5' at Center.", repo.TblBer.row5.ColBerCd1VerrRow5Info, new RecordItemIndex(19));
            repo.TblBer.row5.ColBerCd1VerrRow5.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBer.PbDataAccessSave' at Center.", repo.TblBer.PbDataAccessSaveInfo, new RecordItemIndex(20));
            repo.TblBer.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(60000), new RecordItemIndex(21));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Mehrere Herkunftsbereiche nicht zulässig') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Mehrere Herkunftsbereiche nicht zulässig");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(23));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBer.row5.ColBerKzherkRow5' at Center.", repo.TblBer.row5.ColBerKzherkRow5Info, new RecordItemIndex(24));
            repo.TblBer.row5.ColBerKzherkRow5.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBer.PbDataAccessSave' at Center.", repo.TblBer.PbDataAccessSaveInfo, new RecordItemIndex(25));
            repo.TblBer.PbDataAccessSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}