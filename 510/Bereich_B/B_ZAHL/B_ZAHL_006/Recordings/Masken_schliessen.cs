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

namespace B_ZAHL_006.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Masken_schliessen recording.
    /// </summary>
    [TestModule("2dd98558-31e7-4291-b6c1-1bca49ccd48e", ModuleType.Recording, 1)]
    public partial class Masken_schliessen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_006.B_ZAHL_006Repository repository.
        /// </summary>
        public static global::B_ZAHL_006.B_ZAHL_006Repository repo = global::B_ZAHL_006.B_ZAHL_006Repository.Instance;

        static Masken_schliessen instance = new Masken_schliessen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Masken_schliessen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Masken_schliessen Instance
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'TblNichtUebernommene.TitleBar100NichtUebernommeneZahlun'.", repo.TblNichtUebernommene.TitleBar100NichtUebernommeneZahlunInfo, new RecordItemIndex(0));
            Keyboard.PrepareFocus(repo.TblNichtUebernommene.TitleBar100NichtUebernommeneZahlun);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'FrmBankbeleg.Bankbeleg'.", repo.FrmBankbeleg.BankbelegInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.FrmBankbeleg.Bankbeleg);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
