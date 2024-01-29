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

namespace S_FUGR_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT_FUGR recording.
    /// </summary>
    [TestModule("77431d34-c536-4adc-8db1-e8b8eff65264", ModuleType.Recording, 1)]
    public partial class StartAUT_FUGR : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_FUGR_Schnelltest.S_FUGR_SchnelltestRepository repository.
        /// </summary>
        public static global::S_FUGR_Schnelltest.S_FUGR_SchnelltestRepository repo = global::S_FUGR_Schnelltest.S_FUGR_SchnelltestRepository.Instance;

        static StartAUT_FUGR instance = new StartAUT_FUGR();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT_FUGR()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm_FUGR = "S_FUGR AUFRUFART=FUGR";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartAUT_FUGR Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("629ad0d7-7b29-4470-919d-c9293256a7df")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm_FUGR;

        /// <summary>
        /// Gets or sets the value of variable Programm_FUGR.
        /// </summary>
        [TestVariable("b2efb230-a89a-47cc-976e-f991daa8137e")]
        public string Programm_FUGR
        {
            get { return _Programm_FUGR; }
            set { _Programm_FUGR = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm_FUGR in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm_FUGR, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblSFugr.TitleBar100Funktionsgruppen'", repo.TblSFugr.TitleBar100FunktionsgruppenInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.TblSFugr.TitleBar100FunktionsgruppenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Funktionsgruppen') on item 'TblSFugr.TitleBar100Funktionsgruppen'.", repo.TblSFugr.TitleBar100FunktionsgruppenInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblSFugr.TitleBar100FunktionsgruppenInfo, "Text", "Funktionsgruppen");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}