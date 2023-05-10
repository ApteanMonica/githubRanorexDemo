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

namespace B_ZAHLV_001.Recordings_B_BUAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Buchungen_Summen_pruefen recording.
    /// </summary>
    [TestModule("4fa5da62-f56c-4afb-8c6f-d693e7cb49c2", ModuleType.Recording, 1)]
    public partial class Buchungen_Summen_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHLV_001.B_ZAHLV_001Repository repository.
        /// </summary>
        public static global::B_ZAHLV_001.B_ZAHLV_001Repository repo = global::B_ZAHLV_001.B_ZAHLV_001Repository.Instance;

        static Buchungen_Summen_pruefen instance = new Buchungen_Summen_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Buchungen_Summen_pruefen()
        {
            Beleg_Nr = "1001";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Buchungen_Summen_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Beleg_Nr.
        /// </summary>
        [TestVariable("24b9faec-0120-49e5-8e4d-1149c135bc26")]
        public string Beleg_Nr
        {
            get { return repo.Beleg_NR; }
            set { repo.Beleg_NR = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Buchungen anzeigen') on item 'Form100BuchungenAnzeigen.TitleBar100BuchungenAnzeigen'.", repo.Form100BuchungenAnzeigen.TitleBar100BuchungenAnzeigenInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.Form100BuchungenAnzeigen.TitleBar100BuchungenAnzeigenInfo, "Text", "Buchungen anzeigen");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg_Nr) on item 'Form100BuchungenAnzeigen.Beleg'.", repo.Form100BuchungenAnzeigen.BelegInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.BelegInfo, "Text", Beleg_Nr);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'Form100BuchungenAnzeigen.StatusBar_Summenzeile_unten_Brutto'", repo.Form100BuchungenAnzeigen.StatusBar_Summenzeile_unten_BruttoInfo, new ActionTimeout(120000), new RecordItemIndex(2));
            repo.Form100BuchungenAnzeigen.StatusBar_Summenzeile_unten_BruttoInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Brutto               19.200,00 S                19.200,00 H         Netto               19.200,00 S                19.330,00 H') on item 'Form100BuchungenAnzeigen.StatusBar_Summenzeile_unten_Brutto'.", repo.Form100BuchungenAnzeigen.StatusBar_Summenzeile_unten_BruttoInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.StatusBar_Summenzeile_unten_BruttoInfo, "Text", "Brutto               19.200,00 S                19.200,00 H         Netto               19.200,00 S                19.330,00 H");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row1Column0_erste_Zeile_markieren' at Center.", repo.Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row1Column0_erste_Zeile_markierenInfo, new RecordItemIndex(4));
            repo.Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row1Column0_erste_Zeile_markieren.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100BuchungenAnzeigen.PageDown' at Center.", repo.Form100BuchungenAnzeigen.PageDownInfo, new RecordItemIndex(6));
            //repo.Form100BuchungenAnzeigen.PageDown.Click();
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            //Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}'.", new RecordItemIndex(8));
            Keyboard.Press("{LShiftKey down}");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'End' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.End, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row39Column0_letzte_Zeile_markieren' at Center.", repo.Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row39Column0_letzte_Zeile_markierenInfo, new RecordItemIndex(11));
            //repo.Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row39Column0_letzte_Zeile_markieren.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(12));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey up}'.", new RecordItemIndex(13));
            Keyboard.Press("{LShiftKey up}");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(14));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100BuchungenAnzeigen.PbCommonSumme' at Center.", repo.Form100BuchungenAnzeigen.PbCommonSummeInfo, new RecordItemIndex(15));
            repo.Form100BuchungenAnzeigen.PbCommonSumme.Click();
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100BuchungenAnzeigen.PageRight' at Center.", repo.Form100BuchungenAnzeigen.PageRightInfo, new RecordItemIndex(16));
            //repo.Form100BuchungenAnzeigen.PageRight.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBelegnrRow0'", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBelegnrRow0Info, new ActionTimeout(120000), new RecordItemIndex(17));
            repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBelegnrRow0Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Summe Soll') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBelegnrRow0'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBelegnrRow0Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBelegnrRow0Info, "Text", "Summe Soll");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='19.200,00') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBetragRow0'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBetragRow0Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBetragRow0Info, "Text", "19.200,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='S') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColSHRow0'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColSHRow0Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColSHRow0Info, "Text", "S");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColUstbetragRow0'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColUstbetragRow0Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColUstbetragRow0Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='19.200,00') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBruttoRow0'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBruttoRow0Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBruttoRow0Info, "Text", "19.200,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Summe Haben') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBelegnrRow1'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBelegnrRow1Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBelegnrRow1Info, "Text", "Summe Haben");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='19.330,00') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBetragRow1'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBetragRow1Info, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBetragRow1Info, "Text", "19.330,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='H') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColSHRow1'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColSHRow1Info, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColSHRow1Info, "Text", "H");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='302,00') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColUstbetragRow1'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColUstbetragRow1Info, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColUstbetragRow1Info, "Text", "302,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='19.200,00') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBruttoRow1'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBruttoRow1Info, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBruttoRow1Info, "Text", "19.200,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Saldo') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBelegnrRow2'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBelegnrRow2Info, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBelegnrRow2Info, "Text", "Saldo");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='-130,00') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBetragRow2'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBetragRow2Info, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBetragRow2Info, "Text", "-130,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='S') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColSHRow2'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColSHRow2Info, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColSHRow2Info, "Text", "S");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='-302,00') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColUstbetragRow2'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColUstbetragRow2Info, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColUstbetragRow2Info, "Text", "-302,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBruttoRow2'.", repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBruttoRow2Info, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.SplitGrid_FlexGrid_Fusszeilen_nach_Summenbildung.ColBruttoRow2Info, "Text", "0,00");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
