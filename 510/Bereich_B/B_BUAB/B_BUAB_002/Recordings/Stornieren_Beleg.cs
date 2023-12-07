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

namespace B_BUAB_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Stornieren_Beleg recording.
    /// </summary>
    [TestModule("27a2af8b-4017-4347-8fce-2e1d7f7db00c", ModuleType.Recording, 1)]
    public partial class Stornieren_Beleg : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUAB_002.B_BUAB_002Repository repository.
        /// </summary>
        public static global::B_BUAB_002.B_BUAB_002Repository repo = global::B_BUAB_002.B_BUAB_002Repository.Instance;

        static Stornieren_Beleg instance = new Stornieren_Beleg();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Stornieren_Beleg()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Stornieren_Beleg Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB.FlexGrid_Tabelle.Row1Column0' at Center.", repo.TblB.FlexGrid_Tabelle.Row1Column0Info, new RecordItemIndex(0));
            repo.TblB.FlexGrid_Tabelle.Row1Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB.PbExtrasStornieren' at CenterRight.", repo.TblB.PbExtrasStornierenInfo, new RecordItemIndex(1));
            repo.TblB.PbExtrasStornieren.Click(Location.CenterRight);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
