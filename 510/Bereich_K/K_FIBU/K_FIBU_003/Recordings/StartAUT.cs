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

namespace K_FIBU_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT recording.
    /// </summary>
    [TestModule("9d3edd6c-a9b1-4728-8a5d-a2dccf994360", ModuleType.Recording, 1)]
    public partial class StartAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_FIBU_003.K_FIBU_003Repository repository.
        /// </summary>
        public static global::K_FIBU_003.K_FIBU_003Repository repo = global::K_FIBU_003.K_FIBU_003Repository.Instance;

        static StartAUT instance = new StartAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm = "K_FIBU";
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
        [TestVariable("9c58b8fc-ba7c-4dea-aa30-a4cddeeec81d")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm;

        /// <summary>
        /// Gets or sets the value of variable Programm.
        /// </summary>
        [TestVariable("e1252f90-5e94-49e7-b4df-25e08db2b509")]
        public string Programm
        {
            get { return _Programm; }
            set { _Programm = value; }
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TitleBar100BereichsSummierung'", repo.TitleBar100BereichsSummierungInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.TitleBar100BereichsSummierungInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Bereichs-Summierung') on item 'TitleBar100BereichsSummierung'.", repo.TitleBar100BereichsSummierungInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TitleBar100BereichsSummierungInfo, "Text", "Bereichs-Summierung");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
