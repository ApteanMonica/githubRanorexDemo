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

namespace S_MAZ_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT recording.
    /// </summary>
    [TestModule("5a994935-fc0b-474b-86fe-847cb6b700ff", ModuleType.Recording, 1)]
    public partial class StartAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_MAZ_Schnelltest.S_MAZ_SchnelltestRepository repository.
        /// </summary>
        public static global::S_MAZ_Schnelltest.S_MAZ_SchnelltestRepository repo = global::S_MAZ_Schnelltest.S_MAZ_SchnelltestRepository.Instance;

        static StartAUT instance = new StartAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm_MAZ = "S_MAZ";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartAUT Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("5e1ab856-1ea3-4e7a-a1cd-ac92e01adb5f")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm_MAZ;

        /// <summary>
        /// Gets or sets the value of variable Programm_MAZ.
        /// </summary>
        [TestVariable("2e47c438-e49e-41d6-9b54-a06f2c5f77d5")]
        public string Programm_MAZ
        {
            get { return _Programm_MAZ; }
            set { _Programm_MAZ = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm_MAZ in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm_MAZ, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblMaza.TitleBar100MaterialZuschlagsarten'", repo.TblMaza.TitleBar100MaterialZuschlagsartenInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.TblMaza.TitleBar100MaterialZuschlagsartenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Material Zuschlagsarten') on item 'TblMaza.TitleBar100MaterialZuschlagsarten'.", repo.TblMaza.TitleBar100MaterialZuschlagsartenInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblMaza.TitleBar100MaterialZuschlagsartenInfo, "Text", "Material Zuschlagsarten");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}