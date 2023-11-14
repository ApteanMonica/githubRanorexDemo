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
    ///The Einschraenkung_B_EBERF_Spalten_sortieren recording.
    /// </summary>
    [TestModule("f74708a7-deea-4401-a0be-1cfb4c174ad6", ModuleType.Recording, 1)]
    public partial class Einschraenkung_B_EBERF_Spalten_sortieren : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EBUEB_B_EBERF_Schnelltest.B_EBUEB_B_EBERF_300_SchnelltestRepository repository.
        /// </summary>
        public static global::B_EBUEB_B_EBERF_Schnelltest.B_EBUEB_B_EBERF_300_SchnelltestRepository repo = global::B_EBUEB_B_EBERF_Schnelltest.B_EBUEB_B_EBERF_300_SchnelltestRepository.Instance;

        static Einschraenkung_B_EBERF_Spalten_sortieren instance = new Einschraenkung_B_EBERF_Spalten_sortieren();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Einschraenkung_B_EBERF_Spalten_sortieren()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Einschraenkung_B_EBERF_Spalten_sortieren Instance
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

            // Spalte Soll sortieren mit 2 x klick (sonst sind nicht alle Beträge am Bildschirm sichtbar)
            Report.Log(ReportLevel.Info, "Section", "Spalte Soll sortieren mit 2 x klick (sonst sind nicht alle Beträge am Bildschirm sichtbar)", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmEB_erfassen.ColSollRow0' at Center.", repo.FrmEB_erfassen.ColSollRow0Info, new RecordItemIndex(1));
            repo.FrmEB_erfassen.ColSollRow0.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmEB_erfassen.ColSollRow0' at Center.", repo.FrmEB_erfassen.ColSollRow0Info, new RecordItemIndex(3));
            repo.FrmEB_erfassen.ColSollRow0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
