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

namespace B_EXOPV_004.Recordings_B_BUAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The B_BUAB_Einschraenkungen_Buchungen_laden recording.
    /// </summary>
    [TestModule("ea5c84f8-ddd8-449d-a0a1-3b9538491c1f", ModuleType.Recording, 1)]
    public partial class B_BUAB_Einschraenkungen_Buchungen_laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_004.B_EXOPV_004Repository repository.
        /// </summary>
        public static global::B_EXOPV_004.B_EXOPV_004Repository repo = global::B_EXOPV_004.B_EXOPV_004Repository.Instance;

        static B_BUAB_Einschraenkungen_Buchungen_laden instance = new B_BUAB_Einschraenkungen_Buchungen_laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_BUAB_Einschraenkungen_Buchungen_laden()
        {
            Stapel_Herkunft = "B_EXOPV_004";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_BUAB_Einschraenkungen_Buchungen_laden Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Stapel_Herkunft.
        /// </summary>
        [TestVariable("f82b7ea0-9db5-4809-b3b6-77788b71b354")]
        public string Stapel_Herkunft
        {
            get { return repo.Stapel_Herkunft; }
            set { repo.Stapel_Herkunft = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '%' with focus on 'TblB.CDCCTools_Einschraenkungen.Beleg'.", repo.TblB.CDCCTools_Einschraenkungen.BelegInfo, new RecordItemIndex(0));
            repo.TblB.CDCCTools_Einschraenkungen.Beleg.PressKeys("%");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Stapel_Herkunft' with focus on 'TblB.CDCCTools_Einschraenkungen.Beleg'.", repo.TblB.CDCCTools_Einschraenkungen.BelegInfo, new RecordItemIndex(1));
            repo.TblB.CDCCTools_Einschraenkungen.Beleg.PressKeys(Stapel_Herkunft);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '%' with focus on 'TblB.CDCCTools_Einschraenkungen.Beleg'.", repo.TblB.CDCCTools_Einschraenkungen.BelegInfo, new RecordItemIndex(2));
            repo.TblB.CDCCTools_Einschraenkungen.Beleg.PressKeys("%");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Stapel_Herkunft) on item 'TblB.CDCCTools_Einschraenkungen.Beleg'.", repo.TblB.CDCCTools_Einschraenkungen.BelegInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.TblB.CDCCTools_Einschraenkungen.BelegInfo, "Text", Stapel_Herkunft);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'%') on item 'TblB.CDCCTools_Einschraenkungen.Beleg'.", repo.TblB.CDCCTools_Einschraenkungen.BelegInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.TblB.CDCCTools_Einschraenkungen.BelegInfo, "Text", "%");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblB.PbDataAccessLoad' at Center.", repo.TblB.PbDataAccessLoadInfo, new RecordItemIndex(6));
            repo.TblB.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblB.Buchungszeilen_Tabelle.Zeile1.Row1'", repo.TblB.Buchungszeilen_Tabelle.Zeile1.Row1Info, new ActionTimeout(120000), new RecordItemIndex(7));
            repo.TblB.Buchungszeilen_Tabelle.Zeile1.Row1Info.WaitForExists(120000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
