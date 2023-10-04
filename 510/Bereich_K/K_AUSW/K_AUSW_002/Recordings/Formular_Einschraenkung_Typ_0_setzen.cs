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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.FlexGrid_TblAtbz.ColTypRow1' at Center.", repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, new RecordItemIndex(1));
            repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FrmMain.FlexGrid_TblAtbz.ColTypRow1' at Center.", repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, new RecordItemIndex(2));
            repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1.Click(System.Windows.Forms.MouseButtons.Right);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'KAUSW.Auswahlliste'", repo.KAUSW.AuswahllisteInfo, new ActionTimeout(120000), new RecordItemIndex(3));
            repo.KAUSW.AuswahllisteInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KAUSW.Auswahlliste' at Center.", repo.KAUSW.AuswahllisteInfo, new RecordItemIndex(4));
            repo.KAUSW.Auswahlliste.Click();
            
            // Auswahlliste Konditionen
            Report.Log(ReportLevel.Info, "Section", "Auswahlliste Konditionen", new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'Form100AuswahllisteKonditionen.TitleBar100AuswahllisteKonditionen'", repo.Form100AuswahllisteKonditionen.TitleBar100AuswahllisteKonditionenInfo, new ActionTimeout(120000), new RecordItemIndex(6));
            repo.Form100AuswahllisteKonditionen.TitleBar100AuswahllisteKonditionenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'DlgListBox.CellTmpColS2Row1'.", repo.DlgListBox.CellTmpColS2Row1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgListBox.CellTmpColS2Row1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgListBox.Row1Column0' at Center.", repo.DlgListBox.Row1Column0Info, new RecordItemIndex(8));
            repo.DlgListBox.Row1Column0.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1ms.", new RecordItemIndex(9));
            Delay.Duration(1, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgListBox.PbOk' at Center.", repo.DlgListBox.PbOkInfo, new RecordItemIndex(10));
            repo.DlgListBox.PbOk.Click();
            
            // zurück zum Formular Kostenstellenauswahl ändern
            Report.Log(ReportLevel.Info, "Section", "zurück zum Formular Kostenstellenauswahl ändern", new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmMain.FlexGrid_TblAtbz.ColTypRow1'.", repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmMain.FlexGrid_TblAtbz.ColTypRow1'.", repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, new RecordItemIndex(13));
            Keyboard.PrepareFocus(repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(14));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'FrmMain.FlexGrid_TblAtbz.ColVon1Row1'.", repo.FrmMain.FlexGrid_TblAtbz.ColVon1Row1Info, new RecordItemIndex(15));
            Keyboard.PrepareFocus(repo.FrmMain.FlexGrid_TblAtbz.ColVon1Row1);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(16));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(17));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'FrmMain.FlexGrid_TblAtbz.ColBis1Row1'.", repo.FrmMain.FlexGrid_TblAtbz.ColBis1Row1Info, new RecordItemIndex(18));
            Keyboard.PrepareFocus(repo.FrmMain.FlexGrid_TblAtbz.ColBis1Row1);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(19));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(20));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.PbDataAccessSpeichern' at Center.", repo.FrmMain.PbDataAccessSpeichernInfo, new RecordItemIndex(21));
            repo.FrmMain.PbDataAccessSpeichern.Click();
            
            // Formularauswahl prüfen
            Report.Log(ReportLevel.Info, "Section", "Formularauswahl prüfen", new RecordItemIndex(22));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmMain.FlexGrid_TblAtbz.ColTypRow1'.", repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.FrmMain.FlexGrid_TblAtbz.ColTypRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmMain.FlexGrid_TblAtbz.ColVon1Row1'.", repo.FrmMain.FlexGrid_TblAtbz.ColVon1Row1Info, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.FrmMain.FlexGrid_TblAtbz.ColVon1Row1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmMain.FlexGrid_TblAtbz.ColBis1Row1'.", repo.FrmMain.FlexGrid_TblAtbz.ColBis1Row1Info, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.FrmMain.FlexGrid_TblAtbz.ColBis1Row1Info, "Text", "");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
