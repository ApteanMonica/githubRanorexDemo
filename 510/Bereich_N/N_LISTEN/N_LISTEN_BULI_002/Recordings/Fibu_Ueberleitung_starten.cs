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

namespace N_LISTEN_BULI_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Fibu_Ueberleitung_starten recording.
    /// </summary>
    [TestModule("0e9538cf-9a89-4313-af4c-b83fa372e9ab", ModuleType.Recording, 1)]
    public partial class Fibu_Ueberleitung_starten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_LISTEN_BULI_002.N_LISTEN_BULI_002Repository repository.
        /// </summary>
        public static global::N_LISTEN_BULI_002.N_LISTEN_BULI_002Repository repo = global::N_LISTEN_BULI_002.N_LISTEN_BULI_002Repository.Instance;

        static Fibu_Ueberleitung_starten instance = new Fibu_Ueberleitung_starten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Fibu_Ueberleitung_starten()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Fibu_Ueberleitung_starten Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBuchungsliste.PbUEberleitungFibu' at Center.", repo.FrmBuchungsliste.PbUEberleitungFibuInfo, new RecordItemIndex(0));
            repo.FrmBuchungsliste.PbUEberleitungFibu.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
