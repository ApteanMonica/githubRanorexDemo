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

namespace K_KST_Schnelltest.Recordings_Planvarianten_Codes
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CloseAUT_PLAN recording.
    /// </summary>
    [TestModule("d444c845-418e-4a04-90fe-d44e55c79fe0", ModuleType.Recording, 1)]
    public partial class CloseAUT_PLAN : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_KST_Schnelltest.K_KST_SchnelltestRepository repository.
        /// </summary>
        public static global::K_KST_Schnelltest.K_KST_SchnelltestRepository repo = global::K_KST_Schnelltest.K_KST_SchnelltestRepository.Instance;

        static CloseAUT_PLAN instance = new CloseAUT_PLAN();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseAUT_PLAN()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseAUT_PLAN Instance
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

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'Form100PlanVarianten.TitleBar100PlanVarianten'.", repo.Form100PlanVarianten.TitleBar100PlanVariantenInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.Form100PlanVarianten.TitleBar100PlanVarianten, 1000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}