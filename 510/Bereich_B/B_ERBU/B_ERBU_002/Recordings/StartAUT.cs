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

namespace B_ERBU_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT recording.
    /// </summary>
    [TestModule("d449f2c5-0873-4c11-a7fc-8e8e5b321090", ModuleType.Recording, 1)]
    public partial class StartAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ERBU_002.B_ERBU_002Repository repository.
        /// </summary>
        public static global::B_ERBU_002.B_ERBU_002Repository repo = global::B_ERBU_002.B_ERBU_002Repository.Instance;

        static StartAUT instance = new StartAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT()
        {
            Programm = "B_BUCH PAR3 ERB";
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Jahr = "2022";
            Monat = "12";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartAUT Instance
        {
            get { return instance; }
        }

#region Variables

        string _Programm;

        /// <summary>
        /// Gets or sets the value of variable Programm.
        /// </summary>
        [TestVariable("a7e07c26-8f32-4aba-b812-41b4affca62d")]
        public string Programm
        {
            get { return _Programm; }
            set { _Programm = value; }
        }

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("35ebe0ae-1733-44d1-a810-465bb1f2b430")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("b333772d-3c4f-4a46-99a2-e95caf7e6791")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Monat;

        /// <summary>
        /// Gets or sets the value of variable Monat.
        /// </summary>
        [TestVariable("005ff9f6-59d8-4ff4-976b-693aa08907d8")]
        public string Monat
        {
            get { return _Monat; }
            set { _Monat = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5m to exist. Associated repository item: 'DlgFirmaPeriode.TitleBar100Eingangsrechnungsbuch'", repo.DlgFirmaPeriode.TitleBar100EingangsrechnungsbuchInfo, new ActionTimeout(300000), new RecordItemIndex(1));
            repo.DlgFirmaPeriode.TitleBar100EingangsrechnungsbuchInfo.WaitForExists(300000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Eingangsrechnungsbuch') on item 'DlgFirmaPeriode.TitleBar100Eingangsrechnungsbuch'.", repo.DlgFirmaPeriode.TitleBar100EingangsrechnungsbuchInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.DlgFirmaPeriode.TitleBar100EingangsrechnungsbuchInfo, "Text", "Eingangsrechnungsbuch");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgFirmaPeriode.Jahr' at Center.", repo.DlgFirmaPeriode.JahrInfo, new RecordItemIndex(3));
            repo.DlgFirmaPeriode.Jahr.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(4));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jahr' with focus on 'DlgFirmaPeriode.Jahr'.", repo.DlgFirmaPeriode.JahrInfo, new RecordItemIndex(5));
            repo.DlgFirmaPeriode.Jahr.PressKeys(Jahr);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(8));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Monat' with focus on 'DlgFirmaPeriode.Monat'.", repo.DlgFirmaPeriode.MonatInfo, new RecordItemIndex(9));
            repo.DlgFirmaPeriode.Monat.PressKeys(Monat);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(10));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'DlgFirmaPeriode.Jahr'.", repo.DlgFirmaPeriode.JahrInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.DlgFirmaPeriode.JahrInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Monat) on item 'DlgFirmaPeriode.Monat'.", repo.DlgFirmaPeriode.MonatInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.DlgFirmaPeriode.MonatInfo, "Text", Monat);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgFirmaPeriode.PbOK' at Center.", repo.DlgFirmaPeriode.PbOKInfo, new RecordItemIndex(14));
            repo.DlgFirmaPeriode.PbOK.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5m to exist. Associated repository item: 'TblErbu.TitleBar100ERBuchRSREFDB'", repo.TblErbu.TitleBar100ERBuchRSREFDBInfo, new ActionTimeout(300000), new RecordItemIndex(15));
            repo.TblErbu.TitleBar100ERBuchRSREFDBInfo.WaitForExists(300000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[100]  ER-Buch - RS REFDB') on item 'TblErbu.TitleBar100ERBuchRSREFDB'.", repo.TblErbu.TitleBar100ERBuchRSREFDBInfo, new RecordItemIndex(16));
            Validate.AttributeContains(repo.TblErbu.TitleBar100ERBuchRSREFDBInfo, "Text", "[100]  ER-Buch - RS REFDB");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
