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

namespace B_BUOPPR_001.Recordings_Einschraenkungen
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Einschraenkungen_Salden_Belege_Protokoll recording.
    /// </summary>
    [TestModule("ea124988-916f-4426-861a-0fe6a5c040ff", ModuleType.Recording, 1)]
    public partial class Einschraenkungen_Salden_Belege_Protokoll : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUOPPR_001.B_BUOPPR_001Repository repository.
        /// </summary>
        public static global::B_BUOPPR_001.B_BUOPPR_001Repository repo = global::B_BUOPPR_001.B_BUOPPR_001Repository.Instance;

        static Einschraenkungen_Salden_Belege_Protokoll instance = new Einschraenkungen_Salden_Belege_Protokoll();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Einschraenkungen_Salden_Belege_Protokoll()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Einschraenkungen_Salden_Belege_Protokoll Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.CbDetailCheck' at Center.", repo.FrmMain.CbDetailCheckInfo, new RecordItemIndex(0));
            repo.FrmMain.CbDetailCheck.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.CbDrucken' at Center.", repo.FrmMain.CbDruckenInfo, new RecordItemIndex(1));
            repo.FrmMain.CbDrucken.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmMain.CbSaldo'.", repo.FrmMain.CbSaldoInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmMain.CbSaldoInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmMain.CbDetailCheck'.", repo.FrmMain.CbDetailCheckInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmMain.CbDetailCheckInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'FrmMain.CbAnzeigen'.", repo.FrmMain.CbAnzeigenInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmMain.CbAnzeigenInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmMain.CbDrucken'.", repo.FrmMain.CbDruckenInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmMain.CbDruckenInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.PbShareDrucken' at Center.", repo.FrmMain.PbShareDruckenInfo, new RecordItemIndex(6));
            repo.FrmMain.PbShareDrucken.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
