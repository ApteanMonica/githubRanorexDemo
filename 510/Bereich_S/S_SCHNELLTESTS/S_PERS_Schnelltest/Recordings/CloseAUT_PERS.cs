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

namespace S_PERS_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CloseAUT_PERS recording.
    /// </summary>
    [TestModule("64329767-f49c-4799-b020-d1ba354fd863", ModuleType.Recording, 1)]
    public partial class CloseAUT_PERS : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_PERS_Schnelltest.S_PERS_SchnelltestRepository repository.
        /// </summary>
        public static global::S_PERS_Schnelltest.S_PERS_SchnelltestRepository repo = global::S_PERS_Schnelltest.S_PERS_SchnelltestRepository.Instance;

        static CloseAUT_PERS instance = new CloseAUT_PERS();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseAUT_PERS()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseAUT_PERS Instance
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

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'FrmPers.TitleBar100Mitarbeiterstamm'.", repo.FrmPers.TitleBar100MitarbeiterstammInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.FrmPers.TitleBar100Mitarbeiterstamm, 1000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
