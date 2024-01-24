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

namespace V_CAA_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Art_aendern recording.
    /// </summary>
    [TestModule("33801b79-3667-46d8-8e94-3dc7c5193fa2", ModuleType.Recording, 1)]
    public partial class Art_aendern : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_CAA_Schnelltest.V_CAA_SchnelltestRepository repository.
        /// </summary>
        public static global::V_CAA_Schnelltest.V_CAA_SchnelltestRepository repo = global::V_CAA_Schnelltest.V_CAA_SchnelltestRepository.Instance;

        static Art_aendern instance = new Art_aendern();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Art_aendern()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Art_aendern Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmMain.Row1Column0' at Center.", repo.FrmMain.Row1Column0Info, new RecordItemIndex(0));
            repo.FrmMain.Row1Column0.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.Buchungskennz_.TabPageBuchungskennz' at Center.", repo.FrmMain.Buchungskennz_.TabPageBuchungskennzInfo, new RecordItemIndex(1));
            repo.FrmMain.Buchungskennz_.TabPageBuchungskennz.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'FrmMain.Buchungskennz_.DfCaaBukz2Inh'.", repo.FrmMain.Buchungskennz_.DfCaaBukz2InhInfo, new RecordItemIndex(2));
            repo.FrmMain.Buchungskennz_.DfCaaBukz2Inh.PressKeys("1");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'FrmMain.Buchungskennz_.DfCaaBukz6Inh'.", repo.FrmMain.Buchungskennz_.DfCaaBukz6InhInfo, new RecordItemIndex(3));
            repo.FrmMain.Buchungskennz_.DfCaaBukz6Inh.PressKeys("1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.PbCommonSave' at Center.", repo.FrmMain.PbCommonSaveInfo, new RecordItemIndex(4));
            repo.FrmMain.PbCommonSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
