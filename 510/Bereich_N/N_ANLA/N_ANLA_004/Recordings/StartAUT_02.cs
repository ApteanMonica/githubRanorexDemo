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

namespace N_ANLA_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT_02 recording.
    /// </summary>
    [TestModule("927c0ae5-86d5-4480-86f0-626057fb538b", ModuleType.Recording, 1)]
    public partial class StartAUT_02 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_ANLA_004.N_ANLA_004Repository repository.
        /// </summary>
        public static global::N_ANLA_004.N_ANLA_004Repository repo = global::N_ANLA_004.N_ANLA_004Repository.Instance;

        static StartAUT_02 instance = new StartAUT_02();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT_02()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm_1 = "N_ANLA";
            Programm_2 = "N_STAMM Aufrufart ANFI";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartAUT_02 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("f13b14d1-41f3-4174-8fa6-08d13646d63e")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm_1;

        /// <summary>
        /// Gets or sets the value of variable Programm_1.
        /// </summary>
        [TestVariable("bbb31ef7-4db2-4621-b960-94e219f2797b")]
        public string Programm_1
        {
            get { return _Programm_1; }
            set { _Programm_1 = value; }
        }

        string _Programm_2;

        /// <summary>
        /// Gets or sets the value of variable Programm_2.
        /// </summary>
        [TestVariable("4fb707f9-c999-4c5c-bcf3-86adca103d42")]
        public string Programm_2
        {
            get { return _Programm_2; }
            set { _Programm_2 = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm_2 in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm_2, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmAnfi.TitleBar100AVZFirmenstamm'", repo.FrmAnfi.TitleBar100AVZFirmenstammInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmAnfi.TitleBar100AVZFirmenstammInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'AVZ-Firmenstamm') on item 'FrmAnfi.TitleBar100AVZFirmenstamm'.", repo.FrmAnfi.TitleBar100AVZFirmenstammInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmAnfi.TitleBar100AVZFirmenstammInfo, "Text", "AVZ-Firmenstamm");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}