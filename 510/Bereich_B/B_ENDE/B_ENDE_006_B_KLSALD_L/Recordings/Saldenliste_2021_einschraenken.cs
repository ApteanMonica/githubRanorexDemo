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

namespace B_ENDE_006_B_KLSALD_L.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Saldenliste_2021_einschraenken recording.
    /// </summary>
    [TestModule("bfd93175-16ff-42e1-af05-9aa9679d32e9", ModuleType.Recording, 1)]
    public partial class Saldenliste_2021_einschraenken : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ENDE_006_B_KLSALD_L.B_ENDE_006_B_KLSALD_LRepository repository.
        /// </summary>
        public static global::B_ENDE_006_B_KLSALD_L.B_ENDE_006_B_KLSALD_LRepository repo = global::B_ENDE_006_B_KLSALD_L.B_ENDE_006_B_KLSALD_LRepository.Instance;

        static Saldenliste_2021_einschraenken instance = new Saldenliste_2021_einschraenken();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Saldenliste_2021_einschraenken()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Saldenliste_2021_einschraenken Instance
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2021' with focus on 'FrmKLSL.DfKJahrbez'.", repo.FrmKLSL.DfKJahrbezInfo, new RecordItemIndex(0));
            repo.FrmKLSL.DfKJahrbez.PressKeys("2021");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '12' with focus on 'FrmKLSL.DfMonat'.", repo.FrmKLSL.DfMonatInfo, new RecordItemIndex(2));
            repo.FrmKLSL.DfMonat.PressKeys("12");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2021') on item 'FrmKLSL.DfKJahrbez'.", repo.FrmKLSL.DfKJahrbezInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmKLSL.DfKJahrbezInfo, "Text", "2021");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='12') on item 'FrmKLSL.DfMonat'.", repo.FrmKLSL.DfMonatInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmKLSL.DfMonatInfo, "Text", "12");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKLSL.PbTabelle' at Center.", repo.FrmKLSL.PbTabelleInfo, new RecordItemIndex(6));
            repo.FrmKLSL.PbTabelle.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
