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

namespace B_JAHR_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Neues_Jahr_aendern recording.
    /// </summary>
    [TestModule("e53cc44b-43db-4c9c-ace2-41a510dbded3", ModuleType.Recording, 1)]
    public partial class Neues_Jahr_aendern : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_JAHR_Schnelltest.B_JAHR_SchnelltestRepository repository.
        /// </summary>
        public static global::B_JAHR_Schnelltest.B_JAHR_SchnelltestRepository repo = global::B_JAHR_Schnelltest.B_JAHR_SchnelltestRepository.Instance;

        static Neues_Jahr_aendern instance = new Neues_Jahr_aendern();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Neues_Jahr_aendern()
        {
            Jahr_NEU = "2099";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Neues_Jahr_aendern Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Jahr_NEU.
        /// </summary>
        [TestVariable("6bf11a9f-c841-4ec2-986d-1ffeb454e2ca")]
        public string Jahr_NEU
        {
            get { return repo.Jahr_NEU; }
            set { repo.Jahr_NEU = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPerivon_in_Zeile_mit_Jahr_NEU' at Center.", repo.Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPerivon_in_Zeile_mit_Jahr_NEUInfo, new RecordItemIndex(0));
            repo.Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPerivon_in_Zeile_mit_Jahr_NEU.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0'.", new RecordItemIndex(2));
            Keyboard.Press("0");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1'.", new RecordItemIndex(6));
            Keyboard.Press("1");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(9));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPerivon_in_Zeile_mit_Jahr_NEU'.", repo.Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPerivon_in_Zeile_mit_Jahr_NEUInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPerivon_in_Zeile_mit_Jahr_NEUInfo, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPeribis_in_Zeile_mit_Jahr_NEU'.", repo.Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPeribis_in_Zeile_mit_Jahr_NEUInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPeribis_in_Zeile_mit_Jahr_NEUInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0'.", new RecordItemIndex(12));
            Keyboard.Press("0");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(13));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(14));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(15));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1'.", new RecordItemIndex(16));
            Keyboard.Press("1");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(17));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(18));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(19));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPerivonKore_in_Zeile_mit_Jahr_NEU'.", repo.Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPerivonKore_in_Zeile_mit_Jahr_NEUInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPerivonKore_in_Zeile_mit_Jahr_NEUInfo, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPeribisKore_in_Zeile_mit_Jahr_NEU'.", repo.Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPeribisKore_in_Zeile_mit_Jahr_NEUInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPeribisKore_in_Zeile_mit_Jahr_NEUInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Main_530_tblMain_510_frmMain.PbStandard1' at Center.", repo.Main_530_tblMain_510_frmMain.PbStandard1Info, new RecordItemIndex(22));
            repo.Main_530_tblMain_510_frmMain.PbStandard1.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPerivonKore_in_Zeile_mit_Jahr_NEU'.", repo.Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPerivonKore_in_Zeile_mit_Jahr_NEUInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPerivonKore_in_Zeile_mit_Jahr_NEUInfo, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPeribisKore_in_Zeile_mit_Jahr_NEU'.", repo.Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPeribisKore_in_Zeile_mit_Jahr_NEUInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.Main_530_tblMain_510_frmMain.Tabelle_510_530.ColGjhrPeribisKore_in_Zeile_mit_Jahr_NEUInfo, "Text", "1");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
