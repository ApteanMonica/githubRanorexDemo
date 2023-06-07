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

namespace X_MUSTER_007.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT recording.
    /// </summary>
    [TestModule("a4b525da-f80c-4177-957d-f8ffdc1b2c98", ModuleType.Recording, 1)]
    public partial class StartAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::X_MUSTER_007.X_MUSTER_007Repository repository.
        /// </summary>
        public static global::X_MUSTER_007.X_MUSTER_007Repository repo = global::X_MUSTER_007.X_MUSTER_007Repository.Instance;

        static StartAUT instance = new StartAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT()
        {
            startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            programm = "B_KTO";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartAUT Instance
        {
            get { return instance; }
        }

#region Variables

        string _startfile;

        /// <summary>
        /// Gets or sets the value of variable startfile.
        /// </summary>
        [TestVariable("cfeb6ea9-56c5-435e-a808-e322d550953e")]
        public string startfile
        {
            get { return _startfile; }
            set { _startfile = value; }
        }

        string _programm;

        /// <summary>
        /// Gets or sets the value of variable programm.
        /// </summary>
        [TestVariable("5c489f40-74be-4e23-aa2c-62d95de8f7f6")]
        public string programm
        {
            get { return _programm; }
            set { _programm = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $startfile with arguments from variable $programm in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(startfile, programm, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'FrmKto.TitleBar100SachkontenVerwalten'", repo.FrmKto.TitleBar100SachkontenVerwaltenInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.FrmKto.TitleBar100SachkontenVerwaltenInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Sachkonten verwalten') on item 'FrmKto.TitleBar100SachkontenVerwalten'.", repo.FrmKto.TitleBar100SachkontenVerwaltenInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmKto.TitleBar100SachkontenVerwaltenInfo, "Text", "Sachkonten verwalten");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
