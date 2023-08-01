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

namespace N_ANLA_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kontrolle_Abgang recording.
    /// </summary>
    [TestModule("e6682aa3-c111-4ae2-9cd7-80afbd22b55c", ModuleType.Recording, 1)]
    public partial class Kontrolle_Abgang : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_ANLA_004.N_ANLA_004Repository repository.
        /// </summary>
        public static global::N_ANLA_004.N_ANLA_004Repository repo = global::N_ANLA_004.N_ANLA_004Repository.Instance;

        static Kontrolle_Abgang instance = new Kontrolle_Abgang();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kontrolle_Abgang()
        {
            Anlagennr = "N_ANLA_004_01";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kontrolle_Abgang Instance
        {
            get { return instance; }
        }

#region Variables

        string _Anlagennr;

        /// <summary>
        /// Gets or sets the value of variable Anlagennr.
        /// </summary>
        [TestVariable("b6361b1d-a98c-4d96-99c0-76f539745aff")]
        public string Anlagennr
        {
            get { return _Anlagennr; }
            set { _Anlagennr = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmAnla.TitleBar100AVZAnlagen'", repo.FrmAnla.TitleBar100AVZAnlagenInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.FrmAnla.TitleBar100AVZAnlagenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnla.PbNew' at Center.", repo.FrmAnla.PbNewInfo, new RecordItemIndex(1));
            repo.FrmAnla.PbNew.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anlagennr' with focus on 'FrmAnla.Aktuell_Anlagennr'.", repo.FrmAnla.Aktuell_AnlagennrInfo, new RecordItemIndex(2));
            repo.FrmAnla.Aktuell_Anlagennr.PressKeys(Anlagennr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmAnla.Aktuell_Anlagennr'.", repo.FrmAnla.Aktuell_AnlagennrInfo, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.FrmAnla.Aktuell_Anlagennr);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Anlagennr) on item 'FrmAnla.Aktuell_Anlagennr'.", repo.FrmAnla.Aktuell_AnlagennrInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmAnla.Aktuell_AnlagennrInfo, "Text", Anlagennr);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAnla.Steuer' at Center.", repo.FrmAnla.SteuerInfo, new RecordItemIndex(5));
            repo.FrmAnla.Steuer.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
