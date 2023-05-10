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

namespace K_AUSW_001.Recordings_B_KTAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Sachkontoabfrage_aufrufen recording.
    /// </summary>
    [TestModule("de1d7bcc-b0c9-44e1-9580-07b3fe74dba5", ModuleType.Recording, 1)]
    public partial class Sachkontoabfrage_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_AUSW_001.K_AUSW_001Repository repository.
        /// </summary>
        public static global::K_AUSW_001.K_AUSW_001Repository repo = global::K_AUSW_001.K_AUSW_001Repository.Instance;

        static Sachkontoabfrage_aufrufen instance = new Sachkontoabfrage_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Sachkontoabfrage_aufrufen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Sachkontoabfrage_aufrufen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblAnzeige.ChildTableWindow.Row3Column0' at Center.", repo.TblAnzeige.ChildTableWindow.Row3Column0Info, new RecordItemIndex(0));
            repo.TblAnzeige.ChildTableWindow.Row3Column0.DoubleClick();
            
            // Set Timeout +2m
            Report.Log(ReportLevel.Info, "Wait", "Set Timeout +2m\r\nWaiting 4m to exist. Associated repository item: 'TblKtAb.TitleBar100Kontenabfrage'", repo.TblKtAb.TitleBar100KontenabfrageInfo, new ActionTimeout(240000), new RecordItemIndex(1));
            repo.TblKtAb.TitleBar100KontenabfrageInfo.WaitForExists(240000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Kontenabfrage') on item 'TblKtAb.TitleBar100Kontenabfrage'.", repo.TblKtAb.TitleBar100KontenabfrageInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblKtAb.TitleBar100KontenabfrageInfo, "Text", "Kontenabfrage");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
