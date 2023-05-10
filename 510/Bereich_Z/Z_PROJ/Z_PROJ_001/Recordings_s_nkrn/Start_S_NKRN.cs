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

namespace Z_PROJ_001.Recordings_s_nkrn
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Start_S_NKRN recording.
    /// </summary>
    [TestModule("942b3610-a677-4f33-a4fd-8ada4d18a9b5", ModuleType.Recording, 1)]
    public partial class Start_S_NKRN : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_001.Z_PROJ_001Repository repository.
        /// </summary>
        public static global::Z_PROJ_001.Z_PROJ_001Repository repo = global::Z_PROJ_001.Z_PROJ_001Repository.Instance;

        static Start_S_NKRN instance = new Start_S_NKRN();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Start_S_NKRN()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm2 = "S_NKRN AUFRUFART=NKR";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Start_S_NKRN Instance
        {
            get { return instance; }
        }

#region Variables

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("ccf9c4cb-46ea-46a2-920b-874f99ebef45")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm2;

        /// <summary>
        /// Gets or sets the value of variable Programm2.
        /// </summary>
        [TestVariable("a0948866-a849-4427-8f26-27993f72635a")]
        public string Programm2
        {
            get { return _Programm2; }
            set { _Programm2 = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm2 in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm2, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmNkr.TitleBar100Nummernkreisverwaltung'", repo.FrmNkr.TitleBar100NummernkreisverwaltungInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmNkr.TitleBar100NummernkreisverwaltungInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Nummernkreisverwaltung') on item 'FrmNkr.TitleBar100Nummernkreisverwaltung'.", repo.FrmNkr.TitleBar100NummernkreisverwaltungInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmNkr.TitleBar100NummernkreisverwaltungInfo, "Text", "Nummernkreisverwaltung");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
