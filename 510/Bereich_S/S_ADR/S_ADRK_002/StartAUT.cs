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

namespace S_ADRK_002
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT recording.
    /// </summary>
    [TestModule("9afc2856-2e1c-44ee-b918-50df6244f09a", ModuleType.Recording, 1)]
    public partial class StartAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the S_ADRK_002Repository repository.
        /// </summary>
        public static S_ADRK_002Repository repo = S_ADRK_002Repository.Instance;

        static StartAUT instance = new StartAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT()
        {
            Programm = "s_adr KL K";
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
        [TestVariable("42de56a6-12f5-4e6e-80b9-53d55e3efdf9")]
        public string Programm
        {
            get { return _Programm; }
            set { _Programm = value; }
        }

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("4f6cbcbb-c7a4-4287-9e83-35f2631e5715")]
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
            
            // BAR: wait for erhöht auf 4 Minuten von 1 Minute
            Report.Log(ReportLevel.Info, "Wait", "BAR: wait for erhöht auf 4 Minuten von 1 Minute\r\nWaiting 4m to exist. Associated repository item: 'FrmAdr.TitleBar100Kundenstamm'", repo.FrmAdr.TitleBar100KundenstammInfo, new ActionTimeout(240000), new RecordItemIndex(1));
            repo.FrmAdr.TitleBar100KundenstammInfo.WaitForExists(240000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'Kundenstamm') on item 'FrmAdr.TitleBar100Kundenstamm'.", repo.FrmAdr.TitleBar100KundenstammInfo, new RecordItemIndex(2));
            Validate.AttributeRegex(repo.FrmAdr.TitleBar100KundenstammInfo, "Text", new Regex("Kundenstamm"));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
