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

namespace S_GFG.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT recording.
    /// </summary>
    [TestModule("c9848d27-2cb1-4079-8963-a715a7e98e79", ModuleType.Recording, 1)]
    public partial class StartAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_GFG.S_GFGRepository repository.
        /// </summary>
        public static global::S_GFG.S_GFGRepository repo = global::S_GFG.S_GFGRepository.Instance;

        static StartAUT instance = new StartAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm_GFG = "S_GFG";
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
        [TestVariable("72f06229-b5b7-4d34-b5c1-d73c151dc619")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm_GFG;

        /// <summary>
        /// Gets or sets the value of variable Programm_GFG.
        /// </summary>
        [TestVariable("f4ff4013-47eb-4d0b-b8c5-4610c2568ba9")]
        public string Programm_GFG
        {
            get { return _Programm_GFG; }
            set { _Programm_GFG = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm_GFG in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm_GFG, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblGefahrengutstoffe.TitleBar100GefahrengutStoffe'", repo.TblGefahrengutstoffe.TitleBar100GefahrengutStoffeInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.TblGefahrengutstoffe.TitleBar100GefahrengutStoffeInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Gefahrengut-Stoffe') on item 'TblGefahrengutstoffe.TitleBar100GefahrengutStoffe'.", repo.TblGefahrengutstoffe.TitleBar100GefahrengutStoffeInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblGefahrengutstoffe.TitleBar100GefahrengutStoffeInfo, "Text", "Gefahrengut-Stoffe");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}