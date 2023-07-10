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

namespace B_BUCH_002.Recordings_B_BUAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Beleg_laden recording.
    /// </summary>
    [TestModule("672272ae-12ba-4137-81b5-ee33827e79fd", ModuleType.Recording, 1)]
    public partial class Beleg_laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_002.B_BUCH_002Repository repository.
        /// </summary>
        public static global::B_BUCH_002.B_BUCH_002Repository repo = global::B_BUCH_002.B_BUCH_002Repository.Instance;

        static Beleg_laden instance = new Beleg_laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Beleg_laden()
        {
            Beleg1 = "B_BUCH_002_A";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Beleg_laden Instance
        {
            get { return instance; }
        }

#region Variables

        string _Beleg1;

        /// <summary>
        /// Gets or sets the value of variable Beleg1.
        /// </summary>
        [TestVariable("99cbdb56-3997-407e-aa73-4c066f9bfc3f")]
        public string Beleg1
        {
            get { return _Beleg1; }
            set { _Beleg1 = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Beleg1' with focus on 'B_BUAB_TblB.Beleg'.", repo.B_BUAB_TblB.BelegInfo, new RecordItemIndex(0));
            repo.B_BUAB_TblB.Beleg.PressKeys(Beleg1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'B_BUAB_TblB.PbDataAccessLoad' at Center.", repo.B_BUAB_TblB.PbDataAccessLoadInfo, new RecordItemIndex(2));
            repo.B_BUAB_TblB.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'B_BUAB_TblB.Tabelle_FlexGrid.Row1'", repo.B_BUAB_TblB.Tabelle_FlexGrid.Row1Info, new ActionTimeout(120000), new RecordItemIndex(3));
            repo.B_BUAB_TblB.Tabelle_FlexGrid.Row1Info.WaitForExists(120000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
