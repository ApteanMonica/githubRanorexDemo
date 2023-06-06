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

namespace N_ANLA_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Ueberpruefung_afa recording.
    /// </summary>
    [TestModule("412d000f-7064-4ede-b8ae-667916b8f8c7", ModuleType.Recording, 1)]
    public partial class Ueberpruefung_afa : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_ANLA_002.N_ANLA_002Repository repository.
        /// </summary>
        public static global::N_ANLA_002.N_ANLA_002Repository repo = global::N_ANLA_002.N_ANLA_002Repository.Instance;

        static Ueberpruefung_afa instance = new Ueberpruefung_afa();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ueberpruefung_afa()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ueberpruefung_afa Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'FrmAnla.TitleBar100AVZAnlagen'", repo.FrmAnla.TitleBar100AVZAnlagenInfo, new ActionTimeout(5000), new RecordItemIndex(0));
            repo.FrmAnla.TitleBar100AVZAnlagenInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'AVZ - Anlagen') on item 'FrmAnla.TitleBar100AVZAnlagen'.", repo.FrmAnla.TitleBar100AVZAnlagenInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.FrmAnla.TitleBar100AVZAnlagenInfo, "Text", "AVZ - Anlagen");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnla.PbCommonNew' at Center.", repo.FrmAnla.PbCommonNewInfo, new RecordItemIndex(2));
            repo.FrmAnla.PbCommonNew.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'N_ANLA_002_07{Tab}' with focus on 'FrmAnla.DfAnlaNr'.", repo.FrmAnla.DfAnlaNrInfo, new RecordItemIndex(3));
            repo.FrmAnla.DfAnlaNr.PressKeys("N_ANLA_002_07{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnla.Steuer' at Center.", repo.FrmAnla.SteuerInfo, new RecordItemIndex(4));
            repo.FrmAnla.Steuer.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Jahres-AfA') on item 'FrmAnla.Label561'.", repo.FrmAnla.Label561Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmAnla.Label561Info, "Text", "Jahres-AfA");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='460,00') on item 'FrmAnla.DfAnwe1Afabetrag'.", repo.FrmAnla.DfAnwe1AfabetragInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmAnla.DfAnwe1AfabetragInfo, "Text", "460,00");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}