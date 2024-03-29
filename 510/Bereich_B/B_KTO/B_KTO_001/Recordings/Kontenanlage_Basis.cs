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

namespace B_KTO_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kontenanlage_Basis recording.
    /// </summary>
    [TestModule("8518630c-ca85-468a-9d54-5c06b42d6699", ModuleType.Recording, 1)]
    public partial class Kontenanlage_Basis : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KTO_001.B_KTO_001Repository repository.
        /// </summary>
        public static global::B_KTO_001.B_KTO_001Repository repo = global::B_KTO_001.B_KTO_001Repository.Instance;

        static Kontenanlage_Basis instance = new Kontenanlage_Basis();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kontenanlage_Basis()
        {
            Konto = "2431";
            KontoName = "QSB-KTO";
            Kontonummer = "12345";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kontenanlage_Basis Instance
        {
            get { return instance; }
        }

#region Variables

        string _Konto;

        /// <summary>
        /// Gets or sets the value of variable Konto.
        /// </summary>
        [TestVariable("7331115d-01d2-4639-a096-3648ce023c81")]
        public string Konto
        {
            get { return _Konto; }
            set { _Konto = value; }
        }

        string _KontoName;

        /// <summary>
        /// Gets or sets the value of variable KontoName.
        /// </summary>
        [TestVariable("70b86041-c7e6-4a5a-ba0d-f50d4678c653")]
        public string KontoName
        {
            get { return _KontoName; }
            set { _KontoName = value; }
        }

        string _Kontonummer;

        /// <summary>
        /// Gets or sets the value of variable Kontonummer.
        /// </summary>
        [TestVariable("0db89922-383b-42ad-9bc6-2f4b50202792")]
        public string Kontonummer
        {
            get { return _Kontonummer; }
            set { _Kontonummer = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKto.PbNew' at Center.", repo.FrmKto.PbNewInfo, new RecordItemIndex(0));
            repo.FrmKto.PbNew.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmKto.Konto'", repo.FrmKto.KontoInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmKto.KontoInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Kontonummer' with focus on 'FrmKto.Konto'.", repo.FrmKto.KontoInfo, new RecordItemIndex(2));
            repo.FrmKto.Konto.EnsureVisible();
            Keyboard.Press(Kontonummer);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(120000), new RecordItemIndex(5));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Länge der Kontonummer ist nicht 4 Stellen -\r\nOK?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Länge der Kontonummer ist nicht 4 Stellen -\r\nOK?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button1' at Center.", repo.DlgMessageBox.Button1Info, new RecordItemIndex(7));
            repo.DlgMessageBox.Button1.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'FrmKto.Konto'.", repo.FrmKto.KontoInfo, new RecordItemIndex(8));
            repo.FrmKto.Konto.EnsureVisible();
            Keyboard.Press("{Back}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Konto' with focus on 'FrmKto.Konto'.", repo.FrmKto.KontoInfo, new RecordItemIndex(9));
            repo.FrmKto.Konto.EnsureVisible();
            Keyboard.Press(Konto);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(10));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Konto) on item 'FrmKto.Konto'.", repo.FrmKto.KontoInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmKto.KontoInfo, "Text", Konto);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKto.Bezeichnung' at Center.", repo.FrmKto.BezeichnungInfo, new RecordItemIndex(12));
            repo.FrmKto.Bezeichnung.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$KontoName' with focus on 'FrmKto.Bezeichnung'.", repo.FrmKto.BezeichnungInfo, new RecordItemIndex(13));
            repo.FrmKto.Bezeichnung.PressKeys(KontoName);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(14));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KontoName) on item 'FrmKto.Bezeichnung'.", repo.FrmKto.BezeichnungInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmKto.BezeichnungInfo, "Text", KontoName);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmKto.Tab_Allgemein.CbKtoSkonto'.", repo.FrmKto.Tab_Allgemein.CbKtoSkontoInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.FrmKto.Tab_Allgemein.CbKtoSkontoInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKto.PbDataAccessSave' at Center.", repo.FrmKto.PbDataAccessSaveInfo, new RecordItemIndex(17));
            repo.FrmKto.PbDataAccessSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
