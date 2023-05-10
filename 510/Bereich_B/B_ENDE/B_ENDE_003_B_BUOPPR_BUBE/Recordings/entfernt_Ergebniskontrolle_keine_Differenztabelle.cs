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

namespace B_ENDE_003_B_BUOPPR_BUBE.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The entfernt_Ergebniskontrolle_keine_Differenztabelle recording.
    /// </summary>
    [TestModule("dd2f40a4-c511-45a7-9c2b-ea31fc38791b", ModuleType.Recording, 1)]
    public partial class Entfernt_Ergebniskontrolle_keine_Differenztabelle : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ENDE_003_B_BUOPPR_BUBE.B_ENDE_003_B_BUOPPR_BUBERepository repository.
        /// </summary>
        public static global::B_ENDE_003_B_BUOPPR_BUBE.B_ENDE_003_B_BUOPPR_BUBERepository repo = global::B_ENDE_003_B_BUOPPR_BUBE.B_ENDE_003_B_BUOPPR_BUBERepository.Instance;

        static Entfernt_Ergebniskontrolle_keine_Differenztabelle instance = new Entfernt_Ergebniskontrolle_keine_Differenztabelle();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Entfernt_Ergebniskontrolle_keine_Differenztabelle()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Entfernt_Ergebniskontrolle_keine_Differenztabelle Instance
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

            // Set Search Timeout: Search Time 2s -> Eff Time 32s
            Report.Log(ReportLevel.Info, "Validation", "Set Search Timeout: Search Time 2s -> Eff Time 32s\r\nValidating NotExists on item 'TblDiff.TitleBar100PruefenBetragBuchungs'.", repo.TblDiff.TitleBar100PruefenBetragBuchungsInfo, new RecordItemIndex(0));
            Validate.NotExists(repo.TblDiff.TitleBar100PruefenBetragBuchungsInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
