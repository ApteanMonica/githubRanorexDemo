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

namespace B_KTBL_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT recording.
    /// </summary>
    [TestModule("160590e4-89a7-42a6-bfe9-81dae486ca2a", ModuleType.Recording, 1)]
    public partial class StartAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KTBL_Schnelltest.B_KTBL_SchnelltestRepository repository.
        /// </summary>
        public static global::B_KTBL_Schnelltest.B_KTBL_SchnelltestRepository repo = global::B_KTBL_Schnelltest.B_KTBL_SchnelltestRepository.Instance;

        static StartAUT instance = new StartAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT()
        {
            Programm = "B_KTBL";
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
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
        [TestVariable("835b1bcc-83ab-4426-ad10-5ce8c61b4da0")]
        public string Programm
        {
            get { return _Programm; }
            set { _Programm = value; }
        }

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("a46ee50c-4ed6-429d-ad1d-e5f2531dcaeb")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmKtBl.TitleBar100KontoblaetterDrucken'", repo.FrmKtBl.TitleBar100KontoblaetterDruckenInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmKtBl.TitleBar100KontoblaetterDruckenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Kontoblätter drucken') on item 'FrmKtBl.TitleBar100KontoblaetterDrucken'.", repo.FrmKtBl.TitleBar100KontoblaetterDruckenInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmKtBl.TitleBar100KontoblaetterDruckenInfo, "Text", "Kontoblätter drucken");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
