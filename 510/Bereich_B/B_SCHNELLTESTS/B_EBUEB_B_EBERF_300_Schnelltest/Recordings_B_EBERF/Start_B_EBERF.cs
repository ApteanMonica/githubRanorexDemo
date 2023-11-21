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

namespace B_EBUEB_B_EBERF_Schnelltest.Recordings_B_EBERF
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Start_B_EBERF recording.
    /// </summary>
    [TestModule("00eab060-9c2f-40a1-a6d7-0643c65c04a7", ModuleType.Recording, 1)]
    public partial class Start_B_EBERF : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EBUEB_B_EBERF_Schnelltest.B_EBUEB_B_EBERF_300_SchnelltestRepository repository.
        /// </summary>
        public static global::B_EBUEB_B_EBERF_Schnelltest.B_EBUEB_B_EBERF_300_SchnelltestRepository repo = global::B_EBUEB_B_EBERF_Schnelltest.B_EBUEB_B_EBERF_300_SchnelltestRepository.Instance;

        static Start_B_EBERF instance = new Start_B_EBERF();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Start_B_EBERF()
        {
            Programm_B_EBERF = "B_EBERF x x x 300";
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Start_B_EBERF Instance
        {
            get { return instance; }
        }

#region Variables

        string _Programm_B_EBERF;

        /// <summary>
        /// Gets or sets the value of variable Programm_B_EBERF.
        /// </summary>
        [TestVariable("c145d292-2d1c-4164-a5b0-86114662e43d")]
        public string Programm_B_EBERF
        {
            get { return _Programm_B_EBERF; }
            set { _Programm_B_EBERF = value; }
        }

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("2336dbe1-837b-4ff0-be58-a311dbc07b2b")]
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm_B_EBERF in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm_B_EBERF, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmEB_erfassen.TitleBar100ErfassungEroeffnungsbila'", repo.FrmEB_erfassen.TitleBar100ErfassungEroeffnungsbilaInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmEB_erfassen.TitleBar100ErfassungEroeffnungsbilaInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Erfassung Eröffnungsbilanz') on item 'FrmEB_erfassen.TitleBar100ErfassungEroeffnungsbila'.", repo.FrmEB_erfassen.TitleBar100ErfassungEroeffnungsbilaInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmEB_erfassen.TitleBar100ErfassungEroeffnungsbilaInfo, "Text", "Erfassung Eröffnungsbilanz");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}