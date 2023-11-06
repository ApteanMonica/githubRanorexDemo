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

namespace B_KTGR_Schnelltest.Recordings_KTGR
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Close_KTGR recording.
    /// </summary>
    [TestModule("cb2aed51-82f4-429c-8688-e1dfd010aec1", ModuleType.Recording, 1)]
    public partial class Close_KTGR : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KTGR_Schnelltest.B_KTGR_SchnelltestRepository repository.
        /// </summary>
        public static global::B_KTGR_Schnelltest.B_KTGR_SchnelltestRepository repo = global::B_KTGR_Schnelltest.B_KTGR_SchnelltestRepository.Instance;

        static Close_KTGR instance = new Close_KTGR();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Close_KTGR()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Close_KTGR Instance
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

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'TblKtgr.TitleBar100VerwaltenKontengruppen'.", repo.TblKtgr.TitleBar100VerwaltenKontengruppenInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.TblKtgr.TitleBar100VerwaltenKontengruppen, 1000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
