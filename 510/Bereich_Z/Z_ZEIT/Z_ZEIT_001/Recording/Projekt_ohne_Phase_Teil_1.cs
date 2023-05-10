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

namespace Z_ZEIT_001.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Projekt_ohne_Phase_Teil_1 recording.
    /// </summary>
    [TestModule("c90ff73a-df6b-4f73-b8c8-dd6dc8c3e5c5", ModuleType.Recording, 1)]
    public partial class Projekt_ohne_Phase_Teil_1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_ZEIT_001.Z_ZEIT_001Repository repository.
        /// </summary>
        public static global::Z_ZEIT_001.Z_ZEIT_001Repository repo = global::Z_ZEIT_001.Z_ZEIT_001Repository.Instance;

        static Projekt_ohne_Phase_Teil_1 instance = new Projekt_ohne_Phase_Teil_1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Projekt_ohne_Phase_Teil_1()
        {
            Projekt_1 = "ZEIT_001";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Projekt_ohne_Phase_Teil_1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Projekt_1;

        /// <summary>
        /// Gets or sets the value of variable Projekt_1.
        /// </summary>
        [TestVariable("a3369dbd-a98c-4404-974f-6ed1a5bb959e")]
        public string Projekt_1
        {
            get { return _Projekt_1; }
            set { _Projekt_1 = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Projekt_1' with focus on 'MdiZeit.Tabelle.ColProjNrRow5'.", repo.MdiZeit.Tabelle.ColProjNrRow5Info, new RecordItemIndex(0));
            repo.MdiZeit.Tabelle.ColProjNrRow5.PressKeys(Projekt_1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'MdiZeit.Tabelle.Row_5'.", repo.MdiZeit.Tabelle.Row_5Info, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.MdiZeit.Tabelle.Row_5);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiZeit.PbDataAccessSpeichern' at Center.", repo.MdiZeit.PbDataAccessSpeichernInfo, new RecordItemIndex(2));
            repo.MdiZeit.PbDataAccessSpeichern.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
