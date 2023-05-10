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

namespace B_KLOPO_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kunden_einschraenken recording.
    /// </summary>
    [TestModule("5a0f4a8c-5947-472e-821d-2567c1b9d73f", ModuleType.Recording, 1)]
    public partial class NEU_Kunden_einschraenken : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KLOPO_002.B_KLOPO_002Repository repository.
        /// </summary>
        public static global::B_KLOPO_002.B_KLOPO_002Repository repo = global::B_KLOPO_002.B_KLOPO_002Repository.Instance;

        static NEU_Kunden_einschraenken instance = new NEU_Kunden_einschraenken();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NEU_Kunden_einschraenken()
        {
            KU_2030001 = "2030001";
            KU_2030003 = "2030003";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NEU_Kunden_einschraenken Instance
        {
            get { return instance; }
        }

#region Variables

        string _KU_2030001;

        /// <summary>
        /// Gets or sets the value of variable KU_2030001.
        /// </summary>
        [TestVariable("b0c26d4b-2ee1-482f-926c-f59068544bd7")]
        public string KU_2030001
        {
            get { return _KU_2030001; }
            set { _KU_2030001 = value; }
        }

        string _KU_2030003;

        /// <summary>
        /// Gets or sets the value of variable KU_2030003.
        /// </summary>
        [TestVariable("833a6c5d-9818-41b3-9a68-fb1a5cf0240d")]
        public string KU_2030003
        {
            get { return _KU_2030003; }
            set { _KU_2030003 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKlOp.PbCommonNeu' at Center.", repo.FrmKlOp.PbCommonNeuInfo, new RecordItemIndex(0));
            repo.FrmKlOp.PbCommonNeu.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$KU_2030001' with focus on 'FrmKlOp.Einschraenkungen.NummerVon'.", repo.FrmKlOp.Einschraenkungen.NummerVonInfo, new RecordItemIndex(1));
            repo.FrmKlOp.Einschraenkungen.NummerVon.PressKeys(KU_2030001);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$KU_2030003' with focus on 'FrmKlOp.Einschraenkungen.TextBis'.", repo.FrmKlOp.Einschraenkungen.TextBisInfo, new RecordItemIndex(3));
            repo.FrmKlOp.Einschraenkungen.TextBis.PressKeys(KU_2030003);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KU_2030001) on item 'FrmKlOp.Einschraenkungen.NummerVon'.", repo.FrmKlOp.Einschraenkungen.NummerVonInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmKlOp.Einschraenkungen.NummerVonInfo, "Text", KU_2030001);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KU_2030003) on item 'FrmKlOp.Einschraenkungen.TextBis'.", repo.FrmKlOp.Einschraenkungen.TextBisInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmKlOp.Einschraenkungen.TextBisInfo, "Text", KU_2030003);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
