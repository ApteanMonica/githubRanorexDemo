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

namespace B_UVA_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Druck_Tabelle_schliessen recording.
    /// </summary>
    [TestModule("a2d9b0b4-034a-456d-83d4-e34f42bbbdf8", ModuleType.Recording, 1)]
    public partial class Druck_Tabelle_schliessen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_003.B_UVA_003Repository repository.
        /// </summary>
        public static global::B_UVA_003.B_UVA_003Repository repo = global::B_UVA_003.B_UVA_003Repository.Instance;

        static Druck_Tabelle_schliessen instance = new Druck_Tabelle_schliessen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Druck_Tabelle_schliessen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Druck_Tabelle_schliessen Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TblDrucken.TitleBar200UVAFormular'.", repo.TblDrucken.TitleBar200UVAFormularInfo, new RecordItemIndex(0));
            Validate.Exists(repo.TblDrucken.TitleBar200UVAFormularInfo);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'TblDrucken.TitleBar200UVAFormular'.", repo.TblDrucken.TitleBar200UVAFormularInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.TblDrucken.TitleBar200UVAFormular);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
