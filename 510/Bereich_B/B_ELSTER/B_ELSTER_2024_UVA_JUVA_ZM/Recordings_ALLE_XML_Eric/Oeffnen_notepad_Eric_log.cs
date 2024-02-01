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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordings_ALLE_XML_Eric
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Oeffnen_notepad_Eric_log recording.
    /// </summary>
    [TestModule("64f64ba9-b64c-4582-bd7c-76c6f8db9ae4", ModuleType.Recording, 1)]
    public partial class Oeffnen_notepad_Eric_log : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static Oeffnen_notepad_Eric_log instance = new Oeffnen_notepad_Eric_log();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Oeffnen_notepad_Eric_log()
        {
            Programm_2 = "notepad.exe";
            Eric_log_Pfad_Datei = "C:\\temp\\eric.log";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Oeffnen_notepad_Eric_log Instance
        {
            get { return instance; }
        }

#region Variables

        string _Programm_2;

        /// <summary>
        /// Gets or sets the value of variable Programm_2.
        /// </summary>
        [TestVariable("0d99413d-3d4b-4d78-9251-d18ca89271c1")]
        public string Programm_2
        {
            get { return _Programm_2; }
            set { _Programm_2 = value; }
        }

        string _Eric_log_Pfad_Datei;

        /// <summary>
        /// Gets or sets the value of variable Eric_log_Pfad_Datei.
        /// </summary>
        [TestVariable("a845503a-1abf-4c29-83c1-f8c78cd040ca")]
        public string Eric_log_Pfad_Datei
        {
            get { return _Eric_log_Pfad_Datei; }
            set { _Eric_log_Pfad_Datei = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Eric_log_Pfad_Datei with arguments from variable $Programm_2 in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Eric_log_Pfad_Datei, Programm_2, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'Editor_EricLog'", repo.Editor_EricLog.SelfInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.Editor_EricLog.SelfInfo.WaitForExists(120000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
