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

namespace S_NKRN_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT recording.
    /// </summary>
    [TestModule("9f39942d-0b90-4413-a98b-ec396824b7b6", ModuleType.Recording, 1)]
    public partial class StartAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_NKRN_Schnelltest.S_NKRN_SchnelltestRepository repository.
        /// </summary>
        public static global::S_NKRN_Schnelltest.S_NKRN_SchnelltestRepository repo = global::S_NKRN_Schnelltest.S_NKRN_SchnelltestRepository.Instance;

        static StartAUT instance = new StartAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT()
        {
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Programm_NKR = "S_NKRN AUFRUFART=NKR";
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
        [TestVariable("58ffe0ac-b86b-4f24-a7d7-86644ac12588")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Programm_NKR;

        /// <summary>
        /// Gets or sets the value of variable Programm_NKR.
        /// </summary>
        [TestVariable("08b67f0a-a76b-407f-8016-9f8b626fd020")]
        public string Programm_NKR
        {
            get { return _Programm_NKR; }
            set { _Programm_NKR = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm_NKR in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm_NKR, "", false);
            
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