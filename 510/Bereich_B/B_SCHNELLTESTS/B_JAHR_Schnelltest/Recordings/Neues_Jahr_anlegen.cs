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

namespace B_JAHR_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Neues_Jahr_anlegen recording.
    /// </summary>
    [TestModule("33010b07-4535-424f-aa72-b9c5e05f82ee", ModuleType.Recording, 1)]
    public partial class Neues_Jahr_anlegen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_JAHR_Schnelltest.B_JAHR_SchnelltestRepository repository.
        /// </summary>
        public static global::B_JAHR_Schnelltest.B_JAHR_SchnelltestRepository repo = global::B_JAHR_Schnelltest.B_JAHR_SchnelltestRepository.Instance;

        static Neues_Jahr_anlegen instance = new Neues_Jahr_anlegen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Neues_Jahr_anlegen()
        {
            Jahr_NEU = "2099";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Neues_Jahr_anlegen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Jahr_NEU.
        /// </summary>
        [TestVariable("49f64bfd-2790-4bda-8f48-901fd43feebb")]
        public string Jahr_NEU
        {
            get { return repo.Jahr_NEU; }
            set { repo.Jahr_NEU = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Main_530_tblMain_510_frmMain.PbCommonNeues' at Center.", repo.Main_530_tblMain_510_frmMain.PbCommonNeuesInfo, new RecordItemIndex(0));
            repo.Main_530_tblMain_510_frmMain.PbCommonNeues.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgJahr.TitleBar100NeuesJahr'", repo.DlgJahr.TitleBar100NeuesJahrInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.DlgJahr.TitleBar100NeuesJahrInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jahr_NEU' with focus on 'DlgJahr.Text'.", repo.DlgJahr.TextInfo, new RecordItemIndex(2));
            repo.DlgJahr.Text.PressKeys(Jahr_NEU);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr_NEU) on item 'DlgJahr.Text'.", repo.DlgJahr.TextInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgJahr.TextInfo, "Text", Jahr_NEU);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgJahr.PbOk' at Center.", repo.DlgJahr.PbOkInfo, new RecordItemIndex(5));
            repo.DlgJahr.PbOk.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}