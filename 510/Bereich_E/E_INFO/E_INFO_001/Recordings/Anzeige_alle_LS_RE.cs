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
    ///The Anzeige_alle_LS_RE recording.
    /// </summary>
    [TestModule("43babad3-a262-49dc-96fb-061599882380", ModuleType.Recording, 1)]
    public partial class Anzeige_alle_LS_RE : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_INFO_001.E_INFO_001Repository repository.
        /// </summary>
        public static global::E_INFO_001.E_INFO_001Repository repo = global::E_INFO_001.E_INFO_001Repository.Instance;

        static Anzeige_alle_LS_RE instance = new Anzeige_alle_LS_RE();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Anzeige_alle_LS_RE()
        {
            Bestellung1 = "301900002";
            Status_L = "L";
            Bestellung2 = "BS20/00001";
            Status_E = "E";
            Artikel1 = "100011";
            Lieferschein1 = "301900004";
            Kunde = "200003";
            Rechnung1 = "301900005";
            Rechnung2 = "301900003";
            Rechnung3 = "B_EXOPS_3_1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Anzeige_alle_LS_RE Instance
        {
            get { return instance; }
        }

#region Variables

        string _Bestellung1;

        /// <summary>
        /// Gets or sets the value of variable Bestellung1.
        /// </summary>
        [TestVariable("257cf322-0392-42ac-bcad-907fad73f050")]
        public string Bestellung1
        {
            get { return _Bestellung1; }
            set { _Bestellung1 = value; }
        }

        string _Status_L;

        /// <summary>
        /// Gets or sets the value of variable Status_L.
        /// </summary>
        [TestVariable("906d4973-a496-42d3-a0fe-8d4e7edd4686")]
        public string Status_L
        {
            get { return _Status_L; }
            set { _Status_L = value; }
        }

        string _Bestellung2;

        /// <summary>
        /// Gets or sets the value of variable Bestellung2.
        /// </summary>
        [TestVariable("dad2a04d-438a-42b6-981e-a129678afd04")]
        public string Bestellung2
        {
            get { return _Bestellung2; }
            set { _Bestellung2 = value; }
        }

        string _Status_E;

        /// <summary>
        /// Gets or sets the value of variable Status_E.
        /// </summary>
        [TestVariable("02846743-eecb-42aa-ac68-f07e4863d8b2")]
        public string Status_E
        {
            get { return _Status_E; }
            set { _Status_E = value; }
        }

        string _Kunde;

        /// <summary>
        /// Gets or sets the value of variable Kunde.
        /// </summary>
        [TestVariable("4ad5e1d7-fb4f-46f7-b474-df57bc1e0859")]
        public string Kunde
        {
            get { return _Kunde; }
            set { _Kunde = value; }
        }

        string _Rechnung1;

        /// <summary>
        /// Gets or sets the value of variable Rechnung1.
        /// </summary>
        [TestVariable("88f2dc60-9c49-4518-b006-0aaaf50d44dc")]
        public string Rechnung1
        {
            get { return _Rechnung1; }
            set { _Rechnung1 = value; }
        }

        string _Rechnung2;

        /// <summary>
        /// Gets or sets the value of variable Rechnung2.
        /// </summary>
        [TestVariable("5510db21-ea66-4c07-852c-d793bcc9f031")]
        public string Rechnung2
        {
            get { return _Rechnung2; }
            set { _Rechnung2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Artikel1.
        /// </summary>
        [TestVariable("f812b2b7-7e32-48a1-ae94-fcd5f364e3a5")]
        public string Artikel1
        {
            get { return repo.Artikel1; }
            set { repo.Artikel1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Lieferschein1.
        /// </summary>
        [TestVariable("c78f07f1-52fd-43f5-ada4-0499c89eb7bc")]
        public string Lieferschein1
        {
            get { return repo.Lieferschein1; }
            set { repo.Lieferschein1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Rechnung3.
        /// </summary>
        [TestVariable("4cd193a7-9e36-4fe5-9b3a-bc52097221cf")]
        public string Rechnung3
        {
            get { return repo.Rechnung3; }
            set { repo.Rechnung3 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiEInfo.DatumVon' at Center.", repo.MdiEInfo.DatumVonInfo, new RecordItemIndex(0));
            repo.MdiEInfo.DatumVon.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '02.07.2019' with focus on 'MdiEInfo.DatumVon'.", repo.MdiEInfo.DatumVonInfo, new RecordItemIndex(1));
            repo.MdiEInfo.DatumVon.PressKeys("02.07.2019");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MdiEInfo.DatumVon'.", repo.MdiEInfo.DatumVonInfo, new RecordItemIndex(2));
            repo.MdiEInfo.DatumVon.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiEInfo.PbLieferscheinkopf' at Center.", repo.MdiEInfo.PbLieferscheinkopfInfo, new RecordItemIndex(3));
            repo.MdiEInfo.PbLieferscheinkopf.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(4));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Rechnung1) on item 'MdiEInfo.ChildTableWindow1.ColLskNrRow1'.", repo.MdiEInfo.ChildTableWindow1.ColLskNrRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow1.ColLskNrRow1Info, "Text", Rechnung1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferschein1) on item 'MdiEInfo.ChildTableWindow1.ColLskNrRow3'.", repo.MdiEInfo.ChildTableWindow1.ColLskNrRow3Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow1.ColLskNrRow3Info, "Text", Lieferschein1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferschein1) on item 'MdiEInfo.ChildTableWindow1.ColRechNrRow3'.", repo.MdiEInfo.ChildTableWindow1.ColRechNrRow3Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow1.ColRechNrRow3Info, "Text", Lieferschein1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='U') on item 'MdiEInfo.ChildTableWindow1.ColLskStatusRow1'.", repo.MdiEInfo.ChildTableWindow1.ColLskStatusRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow1.ColLskStatusRow1Info, "Text", "U");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MdiEInfo.DatumVon' at Center.", repo.MdiEInfo.DatumVonInfo, new RecordItemIndex(9));
            repo.MdiEInfo.DatumVon.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '16.01.2020' with focus on 'MdiEInfo.DatumVon'.", repo.MdiEInfo.DatumVonInfo, new RecordItemIndex(10));
            repo.MdiEInfo.DatumVon.PressKeys("16.01.2020");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MdiEInfo.DatumVon'.", repo.MdiEInfo.DatumVonInfo, new RecordItemIndex(11));
            repo.MdiEInfo.DatumVon.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiEInfo.PbLieferscheinkopf' at Center.", repo.MdiEInfo.PbLieferscheinkopfInfo, new RecordItemIndex(12));
            repo.MdiEInfo.PbLieferscheinkopf.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='R') on item 'MdiEInfo.ChildTableWindow1.ColLartCdRow4'.", repo.MdiEInfo.ChildTableWindow1.ColLartCdRow4Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow1.ColLartCdRow4Info, "Text", "R");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='-') on item 'MdiEInfo.ChildTableWindow1.ColLartPlusminusRow4'.", repo.MdiEInfo.ChildTableWindow1.ColLartPlusminusRow4Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.MdiEInfo.ChildTableWindow1.ColLartPlusminusRow4Info, "Text", "-");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MdiEInfo.DatumVon' at Center.", repo.MdiEInfo.DatumVonInfo, new RecordItemIndex(15));
            repo.MdiEInfo.DatumVon.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'MdiEInfo.DatumVon'.", repo.MdiEInfo.DatumVonInfo, new RecordItemIndex(16));
            repo.MdiEInfo.DatumVon.EnsureVisible();
            Keyboard.Press("{Delete}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MdiEInfo.DatumVon'.", repo.MdiEInfo.DatumVonInfo, new RecordItemIndex(17));
            repo.MdiEInfo.DatumVon.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'MdiEInfo.TextBis'.", repo.MdiEInfo.TextBisInfo, new RecordItemIndex(18));
            repo.MdiEInfo.TextBis.PressKeys("{Delete}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MdiEInfo.TextBis'.", repo.MdiEInfo.TextBisInfo, new RecordItemIndex(19));
            repo.MdiEInfo.TextBis.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiEInfo.PbLieferscheinpos' at Center.", repo.MdiEInfo.PbLieferscheinposInfo, new RecordItemIndex(20));
            repo.MdiEInfo.PbLieferscheinpos.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(21));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferschein1) on item 'MdiEInfo1.FlexGrid.ColLskNrRow'.", repo.MdiEInfo1.FlexGrid.ColLskNrRowInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.MdiEInfo1.FlexGrid.ColLskNrRowInfo, "Text", Lieferschein1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='5') on item 'MdiEInfo1.FlexGrid.ColLspMatpreisRow'.", repo.MdiEInfo1.FlexGrid.ColLspMatpreisRowInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.MdiEInfo1.FlexGrid.ColLspMatpreisRowInfo, "Text", "5");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kunde) on item 'MdiEInfo1.FlexGrid.ColAufkAdrKunde'.", repo.MdiEInfo1.FlexGrid.ColAufkAdrKundeInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.MdiEInfo1.FlexGrid.ColAufkAdrKundeInfo, "Text", Kunde);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Selected~'True') on item 'MdiEInfo.FlexGrid1.ColLspTeilliefRow1'.", repo.MdiEInfo.FlexGrid1.ColLspTeilliefRow1Info, new RecordItemIndex(25));
            Validate.AttributeRegex(repo.MdiEInfo.FlexGrid1.ColLspTeilliefRow1Info, "Selected", new Regex("True"));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Selected~'False') on item 'MdiEInfo.FlexGrid1.ColLspTeilliefRow4'.", repo.MdiEInfo.FlexGrid1.ColLspTeilliefRow4Info, new RecordItemIndex(26));
            Validate.AttributeRegex(repo.MdiEInfo.FlexGrid1.ColLspTeilliefRow4Info, "Selected", new Regex("False"));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiEInfo.PbRechnungskopf' at Center.", repo.MdiEInfo.PbRechnungskopfInfo, new RecordItemIndex(27));
            repo.MdiEInfo.PbRechnungskopf.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(28));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='F') on item 'MdiEInfo.FlexGrid2.ColRechStatusRow1'.", repo.MdiEInfo.FlexGrid2.ColRechStatusRow1Info, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.MdiEInfo.FlexGrid2.ColRechStatusRow1Info, "Text", "F");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Rechnung2) on item 'MdiEInfo.FlexGrid2.ColRechNrRow3'.", repo.MdiEInfo.FlexGrid2.ColRechNrRow3Info, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.MdiEInfo.FlexGrid2.ColRechNrRow3Info, "Text", Rechnung2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='R') on item 'MdiEInfo.FlexGrid2.ColRechStatusRow3'.", repo.MdiEInfo.FlexGrid2.ColRechStatusRow3Info, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.MdiEInfo.FlexGrid2.ColRechStatusRow3Info, "Text", "R");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='G') on item 'MdiEInfo1.ColReaCdRow9'.", repo.MdiEInfo1.ColReaCdRow9Info, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.MdiEInfo1.ColReaCdRow9Info, "Text", "G");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='16.01.2020') on item 'MdiEInfo.FlexGrid2.ColRechDtfibuRow8'.", repo.MdiEInfo.FlexGrid2.ColRechDtfibuRow8Info, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.MdiEInfo.FlexGrid2.ColRechDtfibuRow8Info, "Text", "16.01.2020");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
