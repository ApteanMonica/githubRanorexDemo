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

namespace E_LIST_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ProgStart recording.
    /// </summary>
    [TestModule("53ecdbe3-4689-4799-8fd2-143b38530b6f", ModuleType.Recording, 1)]
    public partial class ProgStart : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_LIST_001.E_LIST_001Repository repository.
        /// </summary>
        public static global::E_LIST_001.E_LIST_001Repository repo = global::E_LIST_001.E_LIST_001Repository.Instance;

        static ProgStart instance = new ProgStart();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ProgStart()
        {
            Startfile = "";
            Programm = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ProgStart Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("647ea076-9148-45da-8933-48fbbcb4a262")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm;

        /// <summary>
        /// Gets or sets the value of variable Programm.
        /// </summary>
        [TestVariable("fe0724af-1113-4aa5-9680-b5fd70d8e1a6")]
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'E_LIST.Titel_E_LIST'", repo.E_LIST.Titel_E_LISTInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.E_LIST.Titel_E_LISTInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (AccessibleValue~'Leere LS/RE/BS anzeigen') on item 'E_LIST.Titel_E_LIST'.", repo.E_LIST.Titel_E_LISTInfo, new RecordItemIndex(2));
            Validate.AttributeRegex(repo.E_LIST.Titel_E_LISTInfo, "AccessibleValue", new Regex("Leere LS/RE/BS anzeigen"));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
