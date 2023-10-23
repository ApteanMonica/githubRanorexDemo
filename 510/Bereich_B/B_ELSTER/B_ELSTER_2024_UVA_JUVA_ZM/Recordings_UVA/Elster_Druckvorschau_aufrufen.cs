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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordings_UVA
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Elster_Druckvorschau recording.
    /// </summary>
    [TestModule("6fe42314-4014-4b30-bf54-e416757b7644", ModuleType.Recording, 1)]
    public partial class Elster_Druckvorschau_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_004Repository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_004Repository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_004Repository.Instance;

        static Elster_Druckvorschau_aufrufen instance = new Elster_Druckvorschau_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Elster_Druckvorschau_aufrufen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Elster_Druckvorschau_aufrufen Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'FrmMain.ClientArea.PbDrucken'.", repo.FrmMain.ClientArea.PbDruckenInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmMain.ClientArea.PbDruckenInfo, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.ClientArea.PbDrucken' at Center.", repo.FrmMain.ClientArea.PbDruckenInfo, new RecordItemIndex(1));
            repo.FrmMain.ClientArea.PbDrucken.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
