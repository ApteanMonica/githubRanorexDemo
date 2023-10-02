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

namespace K_AUSW_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Formular_Einschraenkung_Typ_0_setzen recording.
    /// </summary>
    [TestModule("b0cd00a4-ba29-460c-98aa-e5f10fcff430", ModuleType.Recording, 1)]
    public partial class Formular_Einschraenkung_Typ_0_setzen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_AUSW_002.K_AUSW_002Repository repository.
        /// </summary>
        public static global::K_AUSW_002.K_AUSW_002Repository repo = global::K_AUSW_002.K_AUSW_002Repository.Instance;

        static Formular_Einschraenkung_Typ_0_setzen instance = new Formular_Einschraenkung_Typ_0_setzen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Formular_Einschraenkung_Typ_0_setzen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Formular_Einschraenkung_Typ_0_setzen Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='GUV') on item 'FrmMain.FlexGrid_TblAtbz.ColAusaCdRow1'.", repo.FrmMain.FlexGrid_TblAtbz.ColAusaCdRow1Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmMain.FlexGrid_TblAtbz.ColAusaCdRow1Info, "Text", "GUV");
            
            // neu Beginn
            Report.Log(ReportLevel.Info, "Section", "neu Beginn", new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.FlexGrid_TblAtbz.ColTypRow1' at Center.", repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, new RecordItemIndex(2));
            repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FrmMain.FlexGrid_TblAtbz.ColTypRow1' at Center.", repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, new RecordItemIndex(3));
            repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1.Click(System.Windows.Forms.MouseButtons.Right);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'KAUSW.Auswahlliste'", repo.KAUSW.AuswahllisteInfo, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.KAUSW.AuswahllisteInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KAUSW.Auswahlliste' at Center.", repo.KAUSW.AuswahllisteInfo, new RecordItemIndex(5));
            repo.KAUSW.Auswahlliste.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'Form100AuswahllisteKonditionen.TitleBar100AuswahllisteKonditionen'", repo.Form100AuswahllisteKonditionen.TitleBar100AuswahllisteKonditionenInfo, new ActionTimeout(120000), new RecordItemIndex(6));
            repo.Form100AuswahllisteKonditionen.TitleBar100AuswahllisteKonditionenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0'.", new RecordItemIndex(7));
            Keyboard.Press("0");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(8));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmMain.FlexGrid_TblAtbz.ColTypRow1'.", repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmMain.FlexGrid_TblAtbz.ColTypRow1'.", repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, "Text", "0");
            
            // neu Ende
            Report.Log(ReportLevel.Info, "Section", "neu Ende", new RecordItemIndex(13));
            
            // alt2 Beginn
            //Report.Log(ReportLevel.Info, "Section", "alt2 Beginn", new RecordItemIndex(14));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.FlexGrid_TblAtbz.ColTypRow1' at Center.", repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, new RecordItemIndex(15));
            //repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1.Click();
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FrmMain.FlexGrid_TblAtbz.ColTypRow1' at Center.", repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, new RecordItemIndex(16));
            //repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1.Click(System.Windows.Forms.MouseButtons.Right);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(17));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Down' Press.", new RecordItemIndex(18));
            //Keyboard.Press(System.Windows.Forms.Keys.Down, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(19));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(20));
            //Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'Form100AuswahllisteKonditionen.TitleBar100AuswahllisteKonditionen'", repo.Form100AuswahllisteKonditionen.TitleBar100AuswahllisteKonditionenInfo, new ActionTimeout(60000), new RecordItemIndex(21));
            //repo.Form100AuswahllisteKonditionen.TitleBar100AuswahllisteKonditionenInfo.WaitForExists(60000);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0'.", new RecordItemIndex(22));
            //Keyboard.Press("0");
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(23));
            //Delay.Duration(2000, false);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(24));
            //Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmMain.FlexGrid_TblAtbz.ColTypRow1'.", repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, new RecordItemIndex(25));
            //Validate.AttributeEqual(repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, "Text", "0");
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(26));
            //Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmMain.FlexGrid_TblAtbz.ColTypRow1'.", repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, new RecordItemIndex(27));
            //Validate.AttributeEqual(repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, "Text", "0");
            
            // alt2 Ende
            Report.Log(ReportLevel.Info, "Section", "alt2 Ende", new RecordItemIndex(28));
            
            // alt Beginn
            Report.Log(ReportLevel.Info, "Section", "alt Beginn", new RecordItemIndex(29));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.FlexGrid_TblAtbz.ColAusaCdRow1' at Center.", repo.FrmMain.FlexGrid_TblAtbz.ColAusaCdRow1Info, new RecordItemIndex(30));
            //repo.FrmMain.FlexGrid_TblAtbz.ColAusaCdRow1.Click();
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(31));
            //Delay.Duration(2000, false);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(32));
            //Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(33));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(34));
            //Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(35));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0'.", new RecordItemIndex(36));
            //Keyboard.Press("0");
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(37));
            //Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            // alt Ende
            Report.Log(ReportLevel.Info, "Section", "alt Ende", new RecordItemIndex(38));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(39));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(40));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(41));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'FrmMain.FlexGrid_TblAtbz.ColVon1Row1'.", repo.FrmMain.FlexGrid_TblAtbz.ColVon1Row1Info, new RecordItemIndex(42));
            Keyboard.PrepareFocus(repo.FrmMain.FlexGrid_TblAtbz.ColVon1Row1);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(43));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(44));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(45));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'FrmMain.FlexGrid_TblAtbz.ColBis1Row1'.", repo.FrmMain.FlexGrid_TblAtbz.ColBis1Row1Info, new RecordItemIndex(46));
            Keyboard.PrepareFocus(repo.FrmMain.FlexGrid_TblAtbz.ColBis1Row1);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(47));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(48));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.PbDataAccessSpeichern' at Center.", repo.FrmMain.PbDataAccessSpeichernInfo, new RecordItemIndex(49));
            repo.FrmMain.PbDataAccessSpeichern.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmMain.FlexGrid_TblAtbz.ColTypRow1'.", repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, new RecordItemIndex(50));
            Validate.AttributeEqual(repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmMain.FlexGrid_TblAtbz.ColVon1Row1'.", repo.FrmMain.FlexGrid_TblAtbz.ColVon1Row1Info, new RecordItemIndex(51));
            Validate.AttributeEqual(repo.FrmMain.FlexGrid_TblAtbz.ColVon1Row1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmMain.FlexGrid_TblAtbz.ColBis1Row1'.", repo.FrmMain.FlexGrid_TblAtbz.ColBis1Row1Info, new RecordItemIndex(52));
            Validate.AttributeEqual(repo.FrmMain.FlexGrid_TblAtbz.ColBis1Row1Info, "Text", "");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
