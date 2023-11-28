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

namespace N_STAMM_Schnelltest.Recordings_N_ANLA
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Start_N_ANLA recording.
    /// </summary>
    [TestModule("a697e3f7-7703-4370-ae77-a811c707e5a9", ModuleType.Recording, 1)]
    public partial class Start_N_ANLA : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_STAMM_Schnelltest.N_STAMM_SchnelltestRepository repository.
        /// </summary>
        public static global::N_STAMM_Schnelltest.N_STAMM_SchnelltestRepository repo = global::N_STAMM_Schnelltest.N_STAMM_SchnelltestRepository.Instance;

        static Start_N_ANLA instance = new Start_N_ANLA();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Start_N_ANLA()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm_N_ANLA = "N_ANLA";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Start_N_ANLA Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("69c1da61-3145-42b5-ad8e-69867a4410d0")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm_N_ANLA;

        /// <summary>
        /// Gets or sets the value of variable Programm_N_ANLA.
        /// </summary>
        [TestVariable("d4c5eb8b-fe53-47b5-b53b-1e91d4c40270")]
        public string Programm_N_ANLA
        {
            get { return _Programm_N_ANLA; }
            set { _Programm_N_ANLA = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm_N_ANLA in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm_N_ANLA, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmAnla.TitleBar100AVZAnlagen'", repo.FrmAnla.TitleBar100AVZAnlagenInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmAnla.TitleBar100AVZAnlagenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'AVZ - Anlagen') on item 'FrmAnla.TitleBar100AVZAnlagen'.", repo.FrmAnla.TitleBar100AVZAnlagenInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmAnla.TitleBar100AVZAnlagenInfo, "Text", "AVZ - Anlagen");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}