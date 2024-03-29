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

namespace B_KLOPO_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Einschraenkung_Sammelkonto_KI_2000 recording.
    /// </summary>
    [TestModule("e4e20595-cf69-4461-beed-06cc725505f9", ModuleType.Recording, 1)]
    public partial class Einschraenkung_Sammelkonto_KI_2000 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KLOPO_001.B_KLOPO_001Repository repository.
        /// </summary>
        public static global::B_KLOPO_001.B_KLOPO_001Repository repo = global::B_KLOPO_001.B_KLOPO_001Repository.Instance;

        static Einschraenkung_Sammelkonto_KI_2000 instance = new Einschraenkung_Sammelkonto_KI_2000();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Einschraenkung_Sammelkonto_KI_2000()
        {
            SAMK_KI = "2000";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Einschraenkung_Sammelkonto_KI_2000 Instance
        {
            get { return instance; }
        }

#region Variables

        string _SAMK_KI;

        /// <summary>
        /// Gets or sets the value of variable SAMK_KI.
        /// </summary>
        [TestVariable("4cae1047-da18-4204-8519-3c9301ead814")]
        public string SAMK_KI
        {
            get { return _SAMK_KI; }
            set { _SAMK_KI = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SAMK_KI' with focus on 'FrmKlOp.Einschraenkungen.Sammelkonto'.", repo.FrmKlOp.Einschraenkungen.SammelkontoInfo, new RecordItemIndex(0));
            repo.FrmKlOp.Einschraenkungen.Sammelkonto.PressKeys(SAMK_KI);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$SAMK_KI) on item 'FrmKlOp.Einschraenkungen.Sammelkonto'.", repo.FrmKlOp.Einschraenkungen.SammelkontoInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmKlOp.Einschraenkungen.SammelkontoInfo, "Text", SAMK_KI);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
