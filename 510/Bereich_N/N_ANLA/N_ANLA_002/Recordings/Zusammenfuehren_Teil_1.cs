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

namespace N_ANLA_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Zusammenfuehren_Teil_1 recording.
    /// </summary>
    [TestModule("db4958b8-6a43-4f3a-911b-1c177c84cc1a", ModuleType.Recording, 1)]
    public partial class Zusammenfuehren_Teil_1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_ANLA_002.N_ANLA_002Repository repository.
        /// </summary>
        public static global::N_ANLA_002.N_ANLA_002Repository repo = global::N_ANLA_002.N_ANLA_002Repository.Instance;

        static Zusammenfuehren_Teil_1 instance = new Zusammenfuehren_Teil_1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Zusammenfuehren_Teil_1()
        {
            GJ = "2022";
            Buchungsdatum = "31.12.2022";
            Anlage_C = "N_ANLA_002_03";
            Anlage_G = "N_ANLA_002_07";
            Bezeichnung_Anlage_7 = "Anlage G";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Zusammenfuehren_Teil_1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _GJ;

        /// <summary>
        /// Gets or sets the value of variable GJ.
        /// </summary>
        [TestVariable("752c8c51-1a0f-4204-83cd-4f518409f688")]
        public string GJ
        {
            get { return _GJ; }
            set { _GJ = value; }
        }

        string _Buchungsdatum;

        /// <summary>
        /// Gets or sets the value of variable Buchungsdatum.
        /// </summary>
        [TestVariable("dae83eb5-03de-42db-930d-413bef9c2ca7")]
        public string Buchungsdatum
        {
            get { return _Buchungsdatum; }
            set { _Buchungsdatum = value; }
        }

        string _Anlage_C;

        /// <summary>
        /// Gets or sets the value of variable Anlage_C.
        /// </summary>
        [TestVariable("3b3edb15-5480-411c-a408-a24bf1a9eb59")]
        public string Anlage_C
        {
            get { return _Anlage_C; }
            set { _Anlage_C = value; }
        }

        string _Anlage_G;

        /// <summary>
        /// Gets or sets the value of variable Anlage_G.
        /// </summary>
        [TestVariable("e186a3f0-f9d9-48e2-9448-5c4f23b98108")]
        public string Anlage_G
        {
            get { return _Anlage_G; }
            set { _Anlage_G = value; }
        }

        string _Bezeichnung_Anlage_7;

        /// <summary>
        /// Gets or sets the value of variable Bezeichnung_Anlage_7.
        /// </summary>
        [TestVariable("081fde8e-6e0c-40cf-b5c1-efea2ac71322")]
        public string Bezeichnung_Anlage_7
        {
            get { return _Bezeichnung_Anlage_7; }
            set { _Bezeichnung_Anlage_7 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnla.PbNew' at Center.", repo.FrmAnla.PbNewInfo, new RecordItemIndex(0));
            repo.FrmAnla.PbNew.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+Shift+Z' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Z | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmZuauf.TitleBar100AVZAnlagenZusammenfuehr'", repo.FrmZuauf.TitleBar100AVZAnlagenZusammenfuehrInfo, new ActionTimeout(120000), new RecordItemIndex(2));
            repo.FrmZuauf.TitleBar100AVZAnlagenZusammenfuehrInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'  AVZ-Anlagen zusammenführen') on item 'FrmZuauf.TitleBar100AVZAnlagenZusammenfuehr'.", repo.FrmZuauf.TitleBar100AVZAnlagenZusammenfuehrInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.FrmZuauf.TitleBar100AVZAnlagenZusammenfuehrInfo, "Text", "  AVZ-Anlagen zusammenführen");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$GJ) on item 'FrmZuauf.Geschaeftsjahr'.", repo.FrmZuauf.GeschaeftsjahrInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmZuauf.GeschaeftsjahrInfo, "Text", GJ);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Buchungsdatum' with focus on 'FrmZuauf.DfAnbuDtbuchung'.", repo.FrmZuauf.DfAnbuDtbuchungInfo, new RecordItemIndex(5));
            repo.FrmZuauf.DfAnbuDtbuchung.PressKeys(Buchungsdatum);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anlage_G' with focus on 'FrmZuauf.TabPageTp1.ColAnlaNrRow1'.", repo.FrmZuauf.TabPageTp1.ColAnlaNrRow1Info, new RecordItemIndex(7));
            repo.FrmZuauf.TabPageTp1.ColAnlaNrRow1.PressKeys(Anlage_G);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmZuauf.TabPageTp1.ColAnlaNrRow3'.", repo.FrmZuauf.TabPageTp1.ColAnlaNrRow3Info, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.FrmZuauf.TabPageTp1.ColAnlaNrRow3);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmZuauf.TabPageTp1.ColAnlaNrRow1'.", repo.FrmZuauf.TabPageTp1.ColAnlaNrRow1Info, new RecordItemIndex(9));
            Keyboard.PrepareFocus(repo.FrmZuauf.TabPageTp1.ColAnlaNrRow1);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Bezeichnung_Anlage_7' with focus on 'FrmZuauf.TabPageTp1.ColAnlaBezRow1'.", repo.FrmZuauf.TabPageTp1.ColAnlaBezRow1Info, new RecordItemIndex(10));
            repo.FrmZuauf.TabPageTp1.ColAnlaBezRow1.PressKeys(Bezeichnung_Anlage_7);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmZuauf.TabPageTp1.ColAnlaBezRow1'.", repo.FrmZuauf.TabPageTp1.ColAnlaBezRow1Info, new RecordItemIndex(11));
            Keyboard.PrepareFocus(repo.FrmZuauf.TabPageTp1.ColAnlaBezRow1);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Insert' Press with focus on 'FrmZuauf.FlexGrid'.", repo.FrmZuauf.FlexGridInfo, new RecordItemIndex(12));
            Keyboard.PrepareFocus(repo.FrmZuauf.FlexGrid);
            Keyboard.Press(System.Windows.Forms.Keys.Insert, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anlage_C' with focus on 'FrmZuauf.TabPageTp1.ColAnlaNrRow2'.", repo.FrmZuauf.TabPageTp1.ColAnlaNrRow2Info, new RecordItemIndex(13));
            repo.FrmZuauf.TabPageTp1.ColAnlaNrRow2.PressKeys(Anlage_C);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZuauf.TabPageTp1.ColAnlaPos1Row2' at Center.", repo.FrmZuauf.TabPageTp1.ColAnlaPos1Row2Info, new RecordItemIndex(14));
            repo.FrmZuauf.TabPageTp1.ColAnlaPos1Row2.Click();
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmZuauf.TabPageTp1.ColAnlaNrRow2'.", repo.FrmZuauf.TabPageTp1.ColAnlaNrRow2Info, new RecordItemIndex(15));
            //repo.FrmZuauf.TabPageTp1.ColAnlaNrRow2.PressKeys("{Tab}");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
