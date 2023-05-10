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

namespace B_KLSALD_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Option_aktivieren_Saldo_aus_OP_Liste_lesen recording.
    /// </summary>
    [TestModule("407803d3-f4b0-4499-8a4e-537174955d5a", ModuleType.Recording, 1)]
    public partial class Option_aktivieren_Saldo_aus_OP_Liste_lesen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KLSALD_001.B_KLSALD_001Repository repository.
        /// </summary>
        public static global::B_KLSALD_001.B_KLSALD_001Repository repo = global::B_KLSALD_001.B_KLSALD_001Repository.Instance;

        static Option_aktivieren_Saldo_aus_OP_Liste_lesen instance = new Option_aktivieren_Saldo_aus_OP_Liste_lesen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Option_aktivieren_Saldo_aus_OP_Liste_lesen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Option_aktivieren_Saldo_aus_OP_Liste_lesen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKLSL.PbOptionenExtras' at Center.", repo.FrmKLSL.PbOptionenExtrasInfo, new RecordItemIndex(0));
            repo.FrmKLSL.PbOptionenExtras.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BKLSALD.SaldoAusOPListeLesen1' at Center.", repo.BKLSALD.SaldoAusOPListeLesen1Info, new RecordItemIndex(1));
            repo.BKLSALD.SaldoAusOPListeLesen1.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
