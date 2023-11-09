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

namespace E_BSKB_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT recording.
    /// </summary>
    [TestModule("6237b18e-552d-4acc-8dac-23132ce136bb", ModuleType.Recording, 1)]
    public partial class StartAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_BSKB_001.E_BSKB_001Repository repository.
        /// </summary>
        public static global::E_BSKB_001.E_BSKB_001Repository repo = global::E_BSKB_001.E_BSKB_001Repository.Instance;

        static StartAUT instance = new StartAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm = "E_BSKB";
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
        [TestVariable("cc7270e5-ab6b-4218-9b42-cd470b65c1da")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Programm.
        /// </summary>
        [TestVariable("99c66ad0-a3c1-48bc-acd5-6fa0d34efe0b")]
        public string Programm
        {
            get { return repo.Programm; }
            set { repo.Programm = value; }
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'TitleBar100BestellungenBestaetigen'", repo.TitleBar100BestellungenBestaetigenInfo, new ActionTimeout(180000), new RecordItemIndex(1));
            repo.TitleBar100BestellungenBestaetigenInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Bestellungen bestätigen') on item 'TitleBar100BestellungenBestaetigen'.", repo.TitleBar100BestellungenBestaetigenInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TitleBar100BestellungenBestaetigenInfo, "Text", "Bestellungen bestätigen");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
