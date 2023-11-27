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

namespace N_STAMM_Schnelltest.Recordings_N_ANLA
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Close_N_ANLA recording.
    /// </summary>
    [TestModule("0f8e19b1-aa1d-4fce-88ee-7331373e1db8", ModuleType.Recording, 1)]
    public partial class Close_N_ANLA : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_STAMM_Schnelltest.N_STAMM_SchnelltestRepository repository.
        /// </summary>
        public static global::N_STAMM_Schnelltest.N_STAMM_SchnelltestRepository repo = global::N_STAMM_Schnelltest.N_STAMM_SchnelltestRepository.Instance;

        static Close_N_ANLA instance = new Close_N_ANLA();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Close_N_ANLA()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Close_N_ANLA Instance
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

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'FrmAnla.TitleBar100AVZAnlagen'.", repo.FrmAnla.TitleBar100AVZAnlagenInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.FrmAnla.TitleBar100AVZAnlagen, 1000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
