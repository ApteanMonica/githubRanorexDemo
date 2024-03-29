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

namespace B_BUKA_006.Recordings_B_EXOPS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validation_Buchungen_aus_B_BUKA recording.
    /// </summary>
    [TestModule("ed8c525b-aed6-4a46-a509-0883959a0fc9", ModuleType.Recording, 1)]
    public partial class B_EXOPS_Einschraenkung_Belege_aus_B_BUKA : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUKA_006.B_BUKA_006Repository repository.
        /// </summary>
        public static global::B_BUKA_006.B_BUKA_006Repository repo = global::B_BUKA_006.B_BUKA_006Repository.Instance;

        static B_EXOPS_Einschraenkung_Belege_aus_B_BUKA instance = new B_EXOPS_Einschraenkung_Belege_aus_B_BUKA();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_EXOPS_Einschraenkung_Belege_aus_B_BUKA()
        {
            Jahr = "2020";
            Monat = "01";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_EXOPS_Einschraenkung_Belege_aus_B_BUKA Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("b9a70b35-d3dc-48c0-88f3-9d355877f561")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Monat;

        /// <summary>
        /// Gets or sets the value of variable Monat.
        /// </summary>
        [TestVariable("911e6103-d74e-4e65-bd41-ea773442b67f")]
        public string Monat
        {
            get { return _Monat; }
            set { _Monat = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'FrmBEXOP.Einschraenkungen.ColKlsRow1'.", repo.FrmBEXOP.Einschraenkungen.ColKlsRow1Info, new RecordItemIndex(0));
            Keyboard.PrepareFocus(repo.FrmBEXOP.Einschraenkungen.ColKlsRow1);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmBEXOP.Einschraenkungen.ColKlsRow1' at Center.", repo.FrmBEXOP.Einschraenkungen.ColKlsRow1Info, new RecordItemIndex(1));
            repo.FrmBEXOP.Einschraenkungen.ColKlsRow1.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'B_BUKA' with focus on 'FrmBEXOP.Einschraenkungen.ColHerkunftRow1'.", repo.FrmBEXOP.Einschraenkungen.ColHerkunftRow1Info, new RecordItemIndex(4));
            repo.FrmBEXOP.Einschraenkungen.ColHerkunftRow1.PressKeys("B_BUKA");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}{Tab}'.", new RecordItemIndex(5));
            Keyboard.Press("{Tab}{Tab}{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jahr' with focus on 'FrmBEXOP.Einschraenkungen.ColJahrRow1'.", repo.FrmBEXOP.Einschraenkungen.ColJahrRow1Info, new RecordItemIndex(6));
            repo.FrmBEXOP.Einschraenkungen.ColJahrRow1.PressKeys(Jahr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Monat' with focus on 'FrmBEXOP.Einschraenkungen.ColMonatRow1'.", repo.FrmBEXOP.Einschraenkungen.ColMonatRow1Info, new RecordItemIndex(8));
            repo.FrmBEXOP.Einschraenkungen.ColMonatRow1.PressKeys(Monat);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP.Einschraenkungen.ColStatusRow1'.", repo.FrmBEXOP.Einschraenkungen.ColStatusRow1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmBEXOP.Einschraenkungen.ColStatusRow1Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBEXOP.PbDataAccessLoad' at Center.", repo.FrmBEXOP.PbDataAccessLoadInfo, new RecordItemIndex(11));
            repo.FrmBEXOP.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmBEXOP.Tabelle_Belege.row_1.Row1'", repo.FrmBEXOP.Tabelle_Belege.row_1.Row1Info, new ActionTimeout(120000), new RecordItemIndex(12));
            repo.FrmBEXOP.Tabelle_Belege.row_1.Row1Info.WaitForExists(120000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
