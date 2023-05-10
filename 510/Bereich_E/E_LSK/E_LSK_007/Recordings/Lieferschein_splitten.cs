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

namespace E_LSK_007.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Lieferschein_splitten recording.
    /// </summary>
    [TestModule("f4d74214-22d6-43cb-924d-1d7be7b528a7", ModuleType.Recording, 1)]
    public partial class Lieferschein_splitten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_LSK_007.E_LSK_007Repository repository.
        /// </summary>
        public static global::E_LSK_007.E_LSK_007Repository repo = global::E_LSK_007.E_LSK_007Repository.Instance;

        static Lieferschein_splitten instance = new Lieferschein_splitten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Lieferschein_splitten()
        {
            Lieferschein = "E_LSK_007";
            Artikel3 = "100027";
            Artikel2 = "100029";
            Lieferschein2 = "E_LSK_007-2";
            MengeAlt1 = "5,00";
            MengeAlt2 = "0,00";
            MengeNeu1 = "10,00";
            LagerMenge = "6,00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Lieferschein_splitten Instance
        {
            get { return instance; }
        }

#region Variables

        string _Lieferschein;

        /// <summary>
        /// Gets or sets the value of variable Lieferschein.
        /// </summary>
        [TestVariable("d712d37b-e05c-4169-ad4e-17dd21c6dd5d")]
        public string Lieferschein
        {
            get { return _Lieferschein; }
            set { _Lieferschein = value; }
        }

        string _Artikel3;

        /// <summary>
        /// Gets or sets the value of variable Artikel3.
        /// </summary>
        [TestVariable("f6ea4c60-e304-42bd-9fb1-9916148c654b")]
        public string Artikel3
        {
            get { return _Artikel3; }
            set { _Artikel3 = value; }
        }

        string _Artikel2;

        /// <summary>
        /// Gets or sets the value of variable Artikel2.
        /// </summary>
        [TestVariable("33e4bc65-1d9c-42ce-a633-e01bc4e5055d")]
        public string Artikel2
        {
            get { return _Artikel2; }
            set { _Artikel2 = value; }
        }

        string _Lieferschein2;

        /// <summary>
        /// Gets or sets the value of variable Lieferschein2.
        /// </summary>
        [TestVariable("5a8820c8-61bb-4882-b345-562f60fa30a9")]
        public string Lieferschein2
        {
            get { return _Lieferschein2; }
            set { _Lieferschein2 = value; }
        }

        string _MengeAlt1;

        /// <summary>
        /// Gets or sets the value of variable MengeAlt1.
        /// </summary>
        [TestVariable("e2029601-f67d-42ad-aa71-bfe4ee330e3e")]
        public string MengeAlt1
        {
            get { return _MengeAlt1; }
            set { _MengeAlt1 = value; }
        }

        string _MengeAlt2;

        /// <summary>
        /// Gets or sets the value of variable MengeAlt2.
        /// </summary>
        [TestVariable("7f4a479f-0e79-4e3b-847c-8f942fdfe82c")]
        public string MengeAlt2
        {
            get { return _MengeAlt2; }
            set { _MengeAlt2 = value; }
        }

        string _MengeNeu1;

        /// <summary>
        /// Gets or sets the value of variable MengeNeu1.
        /// </summary>
        [TestVariable("25ba997c-71bf-444b-a972-c7fe787c4071")]
        public string MengeNeu1
        {
            get { return _MengeNeu1; }
            set { _MengeNeu1 = value; }
        }

        string _LagerMenge;

        /// <summary>
        /// Gets or sets the value of variable LagerMenge.
        /// </summary>
        [TestVariable("b767450d-fa0c-48ea-8c74-9c4e7b24e576")]
        public string LagerMenge
        {
            get { return _LagerMenge; }
            set { _LagerMenge = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.PbPositionLieferschein' at Center.", repo.MdiLSR.PbPositionLieferscheinInfo, new RecordItemIndex(0));
            repo.MdiLSR.PbPositionLieferschein.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferschein) on item 'DlgLskSplitten.DfLskNr'.", repo.DlgLskSplitten.DfLskNrInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.DlgLskSplitten.DfLskNrInfo, "Text", Lieferschein);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgLskSplitten.TitleBar100LieferscheinSplitten'.", repo.DlgLskSplitten.TitleBar100LieferscheinSplittenInfo, new RecordItemIndex(2));
            Validate.Exists(repo.DlgLskSplitten.TitleBar100LieferscheinSplittenInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='E_LSK_007-2') on item 'DlgLskSplitten.NeueLSNummer'.", repo.DlgLskSplitten.NeueLSNummerInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgLskSplitten.NeueLSNummerInfo, "Text", "E_LSK_007-2");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgLskSplitten.FlexGrid.Row2Column0' at Center.", repo.DlgLskSplitten.FlexGrid.Row2Column0Info, new RecordItemIndex(4));
            repo.DlgLskSplitten.FlexGrid.Row2Column0.DoubleClick();
            
            Validate_ColLspMengeAltRow1(repo.DlgLskSplitten.FlexGrid.ColLspMengeAltRow1Info);
            
            Validate1_ColLspMengeAltRow2(repo.DlgLskSplitten.FlexGrid.ColLspMengeAltRow2Info);
            
            Validate2_ColLspMengeNeuRow2(repo.DlgLskSplitten.FlexGrid.ColLspMengeNeuRow2Info);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel3) on item 'DlgLskSplitten.FlexGrid.ColArtNrRow3'.", repo.DlgLskSplitten.FlexGrid.ColArtNrRow3Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.DlgLskSplitten.FlexGrid.ColArtNrRow3Info, "Text", Artikel3);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgLskSplitten.FlexGrid.ColLspMengeNeuRow3' at Center.", repo.DlgLskSplitten.FlexGrid.ColLspMengeNeuRow3Info, new RecordItemIndex(9));
            repo.DlgLskSplitten.FlexGrid.ColLspMengeNeuRow3.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgLskSplitten.FlexGrid.ColLspMengeNeuRow3' at Center.", repo.DlgLskSplitten.FlexGrid.ColLspMengeNeuRow3Info, new RecordItemIndex(10));
            repo.DlgLskSplitten.FlexGrid.ColLspMengeNeuRow3.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad4}{Tab}' with focus on 'DlgLskSplitten.FlexGrid.ColLspMengeNeuRow3'.", repo.DlgLskSplitten.FlexGrid.ColLspMengeNeuRow3Info, new RecordItemIndex(11));
            repo.DlgLskSplitten.FlexGrid.ColLspMengeNeuRow3.EnsureVisible();
            Keyboard.Press("{NumPad4}{Tab}");
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgLskSplitten.PbChargen' at Center.", repo.DlgLskSplitten.PbChargenInfo, new RecordItemIndex(12));
            //repo.DlgLskSplitten.PbChargen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Chargen-/Seriennummer festlegen') on item 'DlgChgAuswahl.TitleBar100ChargenSeriennummerFes'.", repo.DlgChgAuswahl.TitleBar100ChargenSeriennummerFesInfo, new RecordItemIndex(13));
            Validate.AttributeContains(repo.DlgChgAuswahl.TitleBar100ChargenSeriennummerFesInfo, "Text", "Chargen-/Seriennummer festlegen");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgChgAuswahl.FlexGrid.ColChgMengeNeuRow2' at Center.", repo.DlgChgAuswahl.FlexGrid.ColChgMengeNeuRow2Info, new RecordItemIndex(14));
            repo.DlgChgAuswahl.FlexGrid.ColChgMengeNeuRow2.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgChgAuswahl.FlexGrid.ColChgMengeNeuRow2' at Center.", repo.DlgChgAuswahl.FlexGrid.ColChgMengeNeuRow2Info, new RecordItemIndex(15));
            repo.DlgChgAuswahl.FlexGrid.ColChgMengeNeuRow2.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad4}{Tab}' with focus on 'DlgChgAuswahl.FlexGrid.ColChgMengeNeuRow2'.", repo.DlgChgAuswahl.FlexGrid.ColChgMengeNeuRow2Info, new RecordItemIndex(16));
            repo.DlgChgAuswahl.FlexGrid.ColChgMengeNeuRow2.EnsureVisible();
            Keyboard.Press("{NumPad4}{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgChgAuswahl.FlexGrid.ColChgMengeAltRow1' at 48;4.", repo.DlgChgAuswahl.FlexGrid.ColChgMengeAltRow1Info, new RecordItemIndex(17));
            repo.DlgChgAuswahl.FlexGrid.ColChgMengeAltRow1.Click("48;4");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgChgAuswahl.FlexGrid.ColChgMengeAltRow1' at Center.", repo.DlgChgAuswahl.FlexGrid.ColChgMengeAltRow1Info, new RecordItemIndex(18));
            repo.DlgChgAuswahl.FlexGrid.ColChgMengeAltRow1.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad6}{Tab}' with focus on 'DlgChgAuswahl.FlexGrid.ColChgMengeAltRow1'.", repo.DlgChgAuswahl.FlexGrid.ColChgMengeAltRow1Info, new RecordItemIndex(19));
            repo.DlgChgAuswahl.FlexGrid.ColChgMengeAltRow1.EnsureVisible();
            Keyboard.Press("{NumPad6}{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PbOk' at Center.", repo.PbOkInfo, new RecordItemIndex(20));
            repo.PbOk.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgLskSplitten.PbSpeichern' at Center.", repo.DlgLskSplitten.PbSpeichernInfo, new RecordItemIndex(21));
            repo.DlgLskSplitten.PbSpeichern.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Lieferscheinsplittung erfolgreich abgeschlossen!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Lieferscheinsplittung erfolgreich abgeschlossen!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(23));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel3) on item 'MdiLSR.FrmKopf.ColArtNrRow2'.", repo.MdiLSR.FrmKopf.ColArtNrRow2Info, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.ColArtNrRow2Info, "Text", Artikel3);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MdiLSR.FrmKopf.ColArtNrRow2' at Center.", repo.MdiLSR.FrmKopf.ColArtNrRow2Info, new RecordItemIndex(25));
            repo.MdiLSR.FrmKopf.ColArtNrRow2.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.FrmKopf.TabPageLager' at Center.", repo.MdiLSR.FrmKopf.TabPageLagerInfo, new RecordItemIndex(26));
            repo.MdiLSR.FrmKopf.TabPageLager.Click();
            
            Validate_ColLslgMengeRow11(repo.MdiLSR.FrmKopf.ColLslgMengeRow1Info);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.PbNavigationBack' at Center.", repo.MdiLSR.PbNavigationBackInfo, new RecordItemIndex(28));
            repo.MdiLSR.PbNavigationBack.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferschein) on item 'MdiLSR.FrmSearchPage.Text'.", repo.MdiLSR.FrmSearchPage.TextInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.MdiLSR.FrmSearchPage.TextInfo, "Text", Lieferschein);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.PbPerformSimpleSearch' at Center.", repo.MdiLSR.PbPerformSimpleSearchInfo, new RecordItemIndex(30));
            repo.MdiLSR.PbPerformSimpleSearch.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MdiLSR.FrmSearchPage.CellTmpColS2Row2' at Center.", repo.MdiLSR.FrmSearchPage.CellTmpColS2Row2Info, new RecordItemIndex(31));
            repo.MdiLSR.FrmSearchPage.CellTmpColS2Row2.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferschein2) on item 'MdiLSR.FrmKopf.Lieferscheinnummer'.", repo.MdiLSR.FrmKopf.LieferscheinnummerInfo, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.LieferscheinnummerInfo, "Text", Lieferschein2);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.FrmKopf.TabPagePositionen' at 48;8.", repo.MdiLSR.FrmKopf.TabPagePositionenInfo, new RecordItemIndex(33));
            repo.MdiLSR.FrmKopf.TabPagePositionen.Click("48;8");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel2) on item 'MdiLSR.FrmKopf.ColArtNrRow1'.", repo.MdiLSR.FrmKopf.ColArtNrRow1Info, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.ColArtNrRow1Info, "Text", Artikel2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel3) on item 'MdiLSR.FrmKopf.ColArtNrRow2'.", repo.MdiLSR.FrmKopf.ColArtNrRow2Info, new RecordItemIndex(35));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.ColArtNrRow2Info, "Text", Artikel3);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
