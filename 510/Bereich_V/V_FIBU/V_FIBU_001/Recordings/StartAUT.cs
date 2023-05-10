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

namespace V_FIBU_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT recording.
    /// </summary>
    [TestModule("c0e6f0cf-22d2-42a7-9318-1bbbb1e24f87", ModuleType.Recording, 1)]
    public partial class StartAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_FIBU_001.V_FIBU_001Repository repository.
        /// </summary>
        public static global::V_FIBU_001.V_FIBU_001Repository repo = global::V_FIBU_001.V_FIBU_001Repository.Instance;

        static StartAUT instance = new StartAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT()
        {
            Programm = "V_FIBU";
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
        [TestVariable("2d41a241-8786-45e2-a3d0-d9b6cb6101e4")]
        public string Programm
        {
            get { return _Programm; }
            set { _Programm = value; }
        }

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("b72d8a69-3ca4-4360-87fd-4137e93d0451")]
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'TblFIBU.TitleBar100FIBUUEberleitung'", repo.TblFIBU.TitleBar100FIBUUEberleitungInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.TblFIBU.TitleBar100FIBUUEberleitungInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'FIBU-Überleitung') on item 'TblFIBU.TitleBar100FIBUUEberleitung'.", repo.TblFIBU.TitleBar100FIBUUEberleitungInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblFIBU.TitleBar100FIBUUEberleitungInfo, "Text", "FIBU-Überleitung");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
