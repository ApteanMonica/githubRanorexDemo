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

namespace B_BUDA_002.Recordings_B_BUDA
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Dauerbuchung_aendern_Bereiche recording.
    /// </summary>
    [TestModule("c675be2d-2aeb-449b-9dcf-ac9a960fb340", ModuleType.Recording, 1)]
    public partial class Dauerbuchung_aendern_Bereiche : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUDA_002.B_BUDA_002Repository repository.
        /// </summary>
        public static global::B_BUDA_002.B_BUDA_002Repository repo = global::B_BUDA_002.B_BUDA_002Repository.Instance;

        static Dauerbuchung_aendern_Bereiche instance = new Dauerbuchung_aendern_Bereiche();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Dauerbuchung_aendern_Bereiche()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Dauerbuchung_aendern_Bereiche Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgDetail.TblDetail.Row2'", repo.DlgDetail.TblDetail.Row2Info, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.DlgDetail.TblDetail.Row2Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDetail.TblDetail.Row2Column0' at Center.", repo.DlgDetail.TblDetail.Row2Column0Info, new RecordItemIndex(1));
            repo.DlgDetail.TblDetail.Row2Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDetail.PbBereich' at Center.", repo.DlgDetail.PbBereichInfo, new RecordItemIndex(2));
            repo.DlgDetail.PbBereich.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmSB_Bereichsaufteilung.BereichsAufteilungKonto'", repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKontoInfo, new ActionTimeout(120000), new RecordItemIndex(3));
            repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKontoInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Bereichs-Aufteilung - Konto: 7778') on item 'FrmSB_Bereichsaufteilung.BereichsAufteilungKonto'.", repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKontoInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKontoInfo, "Text", "Bereichs-Aufteilung - Konto: 7778");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'494,99\t\t0\t0\t30\tKST 30') on item 'FrmSB_Bereichsaufteilung.FlexGrid1.Row1'.", repo.FrmSB_Bereichsaufteilung.FlexGrid1.Row1Info, new RecordItemIndex(5));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.FlexGrid1.Row1Info, "Text", "494,99\t\t0\t0\t30\tKST 30");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'495,01\t\t0\t0\t50\tKST 50') on item 'FrmSB_Bereichsaufteilung.FlexGrid1.Row2'.", repo.FrmSB_Bereichsaufteilung.FlexGrid1.Row2Info, new RecordItemIndex(6));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.FlexGrid1.Row2Info, "Text", "495,01\t\t0\t0\t50\tKST 50");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '490,00' with focus on 'FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBetragRow1'.", repo.FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBetragRow1Info, new RecordItemIndex(7));
            repo.FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBetragRow1.PressKeys("490,00");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '20' with focus on 'FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBektnr1Row1'.", repo.FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBektnr1Row1Info, new RecordItemIndex(10));
            repo.FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBektnr1Row1.PressKeys("20");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBektnr1Row1'.", repo.FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBektnr1Row1Info, new RecordItemIndex(11));
            Keyboard.PrepareFocus(repo.FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBektnr1Row1);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmSB_Bereichsaufteilung.PbOk' at Center.", repo.FrmSB_Bereichsaufteilung.PbOkInfo, new RecordItemIndex(12));
            repo.FrmSB_Bereichsaufteilung.PbOk.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(120000), new RecordItemIndex(13));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Bitte Buchungsbetrag komplett aufteilen !') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Bitte Buchungsbetrag komplett aufteilen !");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(15));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '500,00' with focus on 'FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBetragRow2'.", repo.FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBetragRow2Info, new RecordItemIndex(16));
            repo.FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBetragRow2.PressKeys("500,00");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBetragRow2'.", repo.FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBetragRow2Info, new RecordItemIndex(17));
            Keyboard.PrepareFocus(repo.FrmSB_Bereichsaufteilung.FlexGrid1.ColBubeBetragRow2);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'490,00') on item 'FrmSB_Bereichsaufteilung.FlexGrid1.Row1'.", repo.FrmSB_Bereichsaufteilung.FlexGrid1.Row1Info, new RecordItemIndex(18));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.FlexGrid1.Row1Info, "Text", "490,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'20\tBaustoffe') on item 'FrmSB_Bereichsaufteilung.FlexGrid1.Row1'.", repo.FrmSB_Bereichsaufteilung.FlexGrid1.Row1Info, new RecordItemIndex(19));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.FlexGrid1.Row1Info, "Text", "20\tBaustoffe");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'500,00') on item 'FrmSB_Bereichsaufteilung.FlexGrid1.Row2'.", repo.FrmSB_Bereichsaufteilung.FlexGrid1.Row2Info, new RecordItemIndex(20));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.FlexGrid1.Row2Info, "Text", "500,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'50\tKST 50') on item 'FrmSB_Bereichsaufteilung.FlexGrid1.Row2'.", repo.FrmSB_Bereichsaufteilung.FlexGrid1.Row2Info, new RecordItemIndex(21));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.FlexGrid1.Row2Info, "Text", "50\tKST 50");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmSB_Bereichsaufteilung.PbOk' at Center.", repo.FrmSB_Bereichsaufteilung.PbOkInfo, new RecordItemIndex(22));
            repo.FrmSB_Bereichsaufteilung.PbOk.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgDetail.TitleBar100BuchungenFuerDauerbuchu'", repo.DlgDetail.TitleBar100BuchungenFuerDauerbuchuInfo, new ActionTimeout(120000), new RecordItemIndex(23));
            repo.DlgDetail.TitleBar100BuchungenFuerDauerbuchuInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgDetail.TitleBar100BuchungenFuerDauerbuchu'.", repo.DlgDetail.TitleBar100BuchungenFuerDauerbuchuInfo, new RecordItemIndex(24));
            Validate.Exists(repo.DlgDetail.TitleBar100BuchungenFuerDauerbuchuInfo);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDetail.PbPruefen' at Center.", repo.DlgDetail.PbPruefenInfo, new RecordItemIndex(25));
            //repo.DlgDetail.PbPruefen.Click();
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Primär- und Fixbereiche überprüft.\r\nEs wurden keine Fehler gefunden.') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(26));
            //Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Primär- und Fixbereiche überprüft.\r\nEs wurden keine Fehler gefunden.");
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(27));
            //repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'DlgDetail.TitleBar100BuchungenFuerDauerbuchu'.", repo.DlgDetail.TitleBar100BuchungenFuerDauerbuchuInfo, new RecordItemIndex(28));
            Keyboard.PrepareFocus(repo.DlgDetail.TitleBar100BuchungenFuerDauerbuchu);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
