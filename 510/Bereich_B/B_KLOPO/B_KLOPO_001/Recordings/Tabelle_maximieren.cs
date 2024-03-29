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

namespace B_KLOPO_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Tabelle_maximieren recording.
    /// </summary>
    [TestModule("4bdcfa2f-4e4f-44d7-87d3-1d933efe559c", ModuleType.Recording, 1)]
    public partial class Tabelle_maximieren : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KLOPO_001.B_KLOPO_001Repository repository.
        /// </summary>
        public static global::B_KLOPO_001.B_KLOPO_001Repository repo = global::B_KLOPO_001.B_KLOPO_001Repository.Instance;

        static Tabelle_maximieren instance = new Tabelle_maximieren();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Tabelle_maximieren()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Tabelle_maximieren Instance
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LWin down}{Up}{LWin up}' with focus on 'TblKlOp.TitleBar100OPListeKunden'.", repo.TblKlOp.TitleBar100OPListeKundenInfo, new RecordItemIndex(0));
            repo.TblKlOp.TitleBar100OPListeKunden.PressKeys("{LWin down}{Up}{LWin up}");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
