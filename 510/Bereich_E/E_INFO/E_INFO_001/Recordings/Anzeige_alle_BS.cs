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

namespace E_INFO_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Anzeige_alle_BS recording.
    /// </summary>
    [TestModule("b3fd697f-568d-4d60-bd7a-46db7fa140b5", ModuleType.Recording, 1)]
    public partial class Anzeige_alle_BS : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_INFO_001.E_INFO_001Repository repository.
        /// </summary>
        public static global::E_INFO_001.E_INFO_001Repository repo = global::E_INFO_001.E_INFO_001Repository.Instance;

        static Anzeige_alle_BS instance = new Anzeige_alle_BS();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Anzeige_alle_BS()
        {
            Bestellung1 = "301900002";
            Status_L = "L";
            Status_E = "E";
            Bestellung2 = "301900005";
            Artikel1 = "100011";
            Lieferschein1 = "301900004";
            Kunde = "200003";
            Bestellung3 = "BS21/00002";
            Status_B = "B";
            Bestellung5 = "BS20/00001";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Anzeige_alle_BS Instance
        {
            get { return instance; }
        }

#region Variables

        string _Bestellung1;

        /// <summary>
        /// Gets or sets the value of variable Bestellung1.
        /// </summary>
        [TestVariable("1253f6d5-a1af-4268-b05f-af833a4c1087")]
        public string Bestellung1
        {
            get { return _Bestellung1; }
            set { _Bestellung1 = value; }
        }

        string _Status_L;

        /// <summary>
        /// Gets or sets the value of variable Status_L.
        /// </summary>
        [TestVariable("e40ff96f-ecb7-419a-b7c5-12b32bd31d77")]
        public string Status_L
        {
            get { return _Status_L; }
            set { _Status_L = value; }
        }

        string _Status_E;

        /// <summary>
        /// Gets or sets the value of variable Status_E.
        /// </summary>
        [TestVariable("28ed9957-0876-4ec7-bf68-4cfd1eb2a63b")]
        public string Status_E
        {
            get { return _Status_E; }
            set { _Status_E = value; }
        }

        string _Bestellung2;

        /// <summary>
        /// Gets or sets the value of variable Bestellung2.
        /// </summary>
        [TestVariable("05920157-e902-4812-83c6-1c52c08a818d")]
        public string Bestellung2
        {
            get { return _Bestellung2; }
            set { _Bestellung2 = value; }
        }

        string _Kunde;

        /// <summary>
        /// Gets or sets the value of variable Kunde.
        /// </summary>
        [TestVariable("7450abb6-4f48-43a8-ad04-6ea8d3b1a0fc")]
        public string Kunde
        {
            get { return _Kunde; }
            set { _Kunde = value; }
        }

        string _Bestellung3;

        /// <summary>
        /// Gets or sets the value of variable Bestellung3.
        /// </summary>
        [TestVariable("91f8ce6c-1999-468b-a86a-4962f6879adc")]
        public string Bestellung3
        {
            get { return _Bestellung3; }
            set { _Bestellung3 = value; }
        }

        string _Status_B;

        /// <summary>
        /// Gets or sets the value of variable Status_B.
        /// </summary>
        [TestVariable("b5aaa47d-b7c6-4951-9f8d-31a85aca685c")]
        public string Status_B
        {
            get { return _Status_B; }
            set { _Status_B = value; }
        }

        string _Bestellung5;

        /// <summary>
        /// Gets or sets the value of variable Bestellung5.
        /// </summary>
        [TestVariable("cd924ad4-f612-4d17-b1fd-9791fbeb98b5")]
        public string Bestellung5
        {
            get { return _Bestellung5; }
            set { _Bestellung5 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Artikel1.
        /// </summary>
        [TestVariable("e93b9587-13ce-4669-95c3-50ed2feb672f")]
        public string Artikel1
        {
            get { return repo.Artikel1; }
            set { repo.Artikel1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Lieferschein1.
        /// </summary>
        [TestVariable("bdad7eb3-d139-424a-b36d-4b6ba8de94e2")]
        public string Lieferschein1
        {
            get { return repo.Lieferschein1; }
            set { repo.Lieferschein1 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiEInfo.Lieferant' at Center.", repo.MdiEInfo.LieferantInfo, new RecordItemIndex(0));
            repo.MdiEInfo.Lieferant.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad3}{NumPad0}{NumPad0}{NumPad0}{LShiftKey}%{Tab}' with focus on 'MdiEInfo.Lieferant'.", repo.MdiEInfo.LieferantInfo, new RecordItemIndex(1));
            repo.MdiEInfo.Lieferant.PressKeys("{NumPad3}{NumPad0}{NumPad0}{NumPad0}{LShiftKey}%{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiEInfo.PbBestellkopf' at Center.", repo.MdiEInfo.PbBestellkopfInfo, new RecordItemIndex(2));
            repo.MdiEInfo.PbBestellkopf.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(3));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bestellung1) on item 'MdiEInfo.FlexGrid.ColBskNrRow2'.", repo.MdiEInfo.FlexGrid.ColBskNrRow2Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.MdiEInfo.FlexGrid.ColBskNrRow2Info, "Text", Bestellung1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Status_L) on item 'MdiEInfo.FlexGrid.ColBskStatusRow2'.", repo.MdiEInfo.FlexGrid.ColBskStatusRow2Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.MdiEInfo.FlexGrid.ColBskStatusRow2Info, "Text", Status_L);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='28,00') on item 'MdiEInfo.FlexGrid.ColBskNettoRow2'.", repo.MdiEInfo.FlexGrid.ColBskNettoRow2Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.MdiEInfo.FlexGrid.ColBskNettoRow2Info, "Text", "28,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='33,60') on item 'MdiEInfo.FlexGrid.ColBskBruttoRow2'.", repo.MdiEInfo.FlexGrid.ColBskBruttoRow2Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.MdiEInfo.FlexGrid.ColBskBruttoRow2Info, "Text", "33,60");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bestellung2) on item 'MdiEInfo.FlexGrid.ColBskNrRow5'.", repo.MdiEInfo.FlexGrid.ColBskNrRow5Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.MdiEInfo.FlexGrid.ColBskNrRow5Info, "Text", Bestellung2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Status_E) on item 'MdiEInfo.FlexGrid.ColBskStatusRow5'.", repo.MdiEInfo.FlexGrid.ColBskStatusRow5Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.MdiEInfo.FlexGrid.ColBskStatusRow5Info, "Text", Status_E);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiEInfo.BestellNr' at Center.", repo.MdiEInfo.BestellNrInfo, new RecordItemIndex(10));
            repo.MdiEInfo.BestellNr.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'bs21%' with focus on 'MdiEInfo.BestellNr'.", repo.MdiEInfo.BestellNrInfo, new RecordItemIndex(11));
            repo.MdiEInfo.BestellNr.EnsureVisible();
            Keyboard.Press("bs21%");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiEInfo.PbBestellkopf' at Center.", repo.MdiEInfo.PbBestellkopfInfo, new RecordItemIndex(12));
            repo.MdiEInfo.PbBestellkopf.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bestellung3) on item 'MdiEInfo.FlexGrid.ColBskNrRow2'.", repo.MdiEInfo.FlexGrid.ColBskNrRow2Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.MdiEInfo.FlexGrid.ColBskNrRow2Info, "Text", Bestellung3);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Status_B) on item 'MdiEInfo.FlexGrid.ColBskStatusRow2'.", repo.MdiEInfo.FlexGrid.ColBskStatusRow2Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.MdiEInfo.FlexGrid.ColBskStatusRow2Info, "Text", Status_B);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'06.2021') on item 'MdiEInfo.ChildTableWindow.ColBskDatumRow2'.", repo.MdiEInfo.ChildTableWindow.ColBskDatumRow2Info, new RecordItemIndex(15));
            //Validate.AttributeContains(repo.MdiEInfo.ChildTableWindow.ColBskDatumRow2Info, "Text", "06.2021");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiEInfo.PbBestellpos' at Center.", repo.MdiEInfo.PbBestellposInfo, new RecordItemIndex(16));
            repo.MdiEInfo.PbBestellpos.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(17));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bestellung3) on item 'MdiEInfo.ChildTableWindow.ColBskNrRow2'.", repo.MdiEInfo.ChildTableWindow.ColBskNrRow2Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow.ColBskNrRow2Info, "Text", Bestellung3);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Diverse Artikelbezeichnung') on item 'MdiEInfo.ChildTableWindow.ColArtBezRow2'.", repo.MdiEInfo.ChildTableWindow.ColArtBezRow2Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow.ColArtBezRow2Info, "Text", "Diverse Artikelbezeichnung");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Status_B) on item 'MdiEInfo.ChildTableWindow.ColBspStatusRow2'.", repo.MdiEInfo.ChildTableWindow.ColBspStatusRow2Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow.ColBspStatusRow2Info, "Text", Status_B);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='5') on item 'MdiEInfo.ChildTableWindow.ColBspBestaetigtRow2'.", repo.MdiEInfo.ChildTableWindow.ColBspBestaetigtRow2Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow.ColBspBestaetigtRow2Info, "Text", "5");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2,000') on item 'MdiEInfo.ChildTableWindow.ColBspPreisBstgRow2'.", repo.MdiEInfo.ChildTableWindow.ColBspPreisBstgRow2Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow.ColBspPreisBstgRow2Info, "Text", "2,000");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiEInfo.BestellNr' at Center.", repo.MdiEInfo.BestellNrInfo, new RecordItemIndex(23));
            repo.MdiEInfo.BestellNr.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MdiEInfo.BestellNr' at Center.", repo.MdiEInfo.BestellNrInfo, new RecordItemIndex(24));
            repo.MdiEInfo.BestellNr.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'MdiEInfo.BestellNr'.", repo.MdiEInfo.BestellNrInfo, new RecordItemIndex(25));
            repo.MdiEInfo.BestellNr.EnsureVisible();
            Keyboard.Press("{Delete}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiEInfo.PbBestellpos' at Center.", repo.MdiEInfo.PbBestellposInfo, new RecordItemIndex(26));
            repo.MdiEInfo.PbBestellpos.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel1) on item 'MdiEInfo.ChildTableWindow.ColArtNrRow2'.", repo.MdiEInfo.ChildTableWindow.ColArtNrRow2Info, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow.ColArtNrRow2Info, "Text", Artikel1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bestellung5) on item 'MdiEInfo.ChildTableWindow.ColBskNrRow9'.", repo.MdiEInfo.ChildTableWindow.ColBskNrRow9Info, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow.ColBskNrRow9Info, "Text", Bestellung5);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='4') on item 'MdiEInfo.ChildTableWindow.ColBspZeileRow9'.", repo.MdiEInfo.ChildTableWindow.ColBspZeileRow9Info, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow.ColBspZeileRow9Info, "Text", "4");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Status_L) on item 'MdiEInfo.ChildTableWindow.ColBspStatusRow5'.", repo.MdiEInfo.ChildTableWindow.ColBspStatusRow5Info, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow.ColBspStatusRow5Info, "Text", Status_L);
            
            // BAR: Validierung angepasst mit IF Operator das beide Formate mit und ohne Komma akzeptiert werden.
            Report.Log(ReportLevel.Info, "Validation", "BAR: Validierung angepasst mit IF Operator das beide Formate mit und ohne Komma akzeptiert werden.\r\nValidating AttributeRegex (Text~'[20,00]|[20]') on item 'MdiEInfo.ChildTableWindow.ColBspMengeRow5'.", repo.MdiEInfo.ChildTableWindow.ColBspMengeRow5Info, new RecordItemIndex(31));
            Validate.AttributeRegex(repo.MdiEInfo.ChildTableWindow.ColBspMengeRow5Info, "Text", new Regex("[20,00]|[20]"));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeNotEqual (Text!='20') on item 'MdiEInfo.ChildTableWindow.ColBspGeliefertRow5'.", repo.MdiEInfo.ChildTableWindow.ColBspGeliefertRow5Info, new RecordItemIndex(32));
            Validate.AttributeNotEqual(repo.MdiEInfo.ChildTableWindow.ColBspGeliefertRow5Info, "Text", "20");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
