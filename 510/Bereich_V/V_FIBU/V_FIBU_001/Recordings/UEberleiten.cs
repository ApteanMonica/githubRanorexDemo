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

namespace V_FIBU_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UEberleiten recording.
    /// </summary>
    [TestModule("bcb2a9a0-a6d2-4bc7-8d17-2de80d589f4d", ModuleType.Recording, 1)]
    public partial class UEberleiten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_FIBU_001.V_FIBU_001Repository repository.
        /// </summary>
        public static global::V_FIBU_001.V_FIBU_001Repository repo = global::V_FIBU_001.V_FIBU_001Repository.Instance;

        static UEberleiten instance = new UEberleiten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UEberleiten()
        {
            Tagesdatum = "";
            Rechnung1 = "192000001";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UEberleiten Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Rechnung1.
        /// </summary>
        [TestVariable("9482adf5-2453-433f-b470-5baa2f328966")]
        public string Rechnung1
        {
            get { return repo.Rechnung1; }
            set { repo.Rechnung1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Rechnung2.
        /// </summary>
        [TestVariable("01fdbc99-3d1e-4838-b4c8-dcb70f152d58")]
        public string Rechnung2
        {
            get { return repo.Rechnung2; }
            set { repo.Rechnung2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("2b0928fb-b991-4fb5-a7d7-c3f83d402d36")]
        public string Tagesdatum
        {
            get { return repo.Tagesdatum; }
            set { repo.Tagesdatum = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFIBU.Rechnung1_anklicken' at Center.", repo.TblFIBU.Rechnung1_anklickenInfo, new RecordItemIndex(0));
            repo.TblFIBU.Rechnung1_anklicken.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'LControlKey' Down.", new RecordItemIndex(1));
            Keyboard.Down(System.Windows.Forms.Keys.LControlKey, Keyboard.DefaultScanCode, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFIBU.Rechnung2_anklicken' at Center.", repo.TblFIBU.Rechnung2_anklickenInfo, new RecordItemIndex(2));
            repo.TblFIBU.Rechnung2_anklicken.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'LControlKey' Up.", new RecordItemIndex(3));
            Keyboard.Up(System.Windows.Forms.Keys.LControlKey, Keyboard.DefaultScanCode, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFIBU.PbSpec1Ueberleiten' at Center.", repo.TblFIBU.PbSpec1UeberleitenInfo, new RecordItemIndex(4));
            repo.TblFIBU.PbSpec1Ueberleiten.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Es sind bereits Sätze in der Schnittstelle (b_exop) vorhanden.\r\nMöchten Sie fortfahren und die bestehenden Einträge ergänzen?') on item 'DlgMessageBox.labelMeldungstext'.", repo.DlgMessageBox.labelMeldungstextInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgMessageBox.labelMeldungstextInfo, "Text", "Es sind bereits Sätze in der Schnittstelle (b_exop) vorhanden.\r\nMöchten Sie fortfahren und die bestehenden Einträge ergänzen?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(6));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'1 Rechnung(en) wegen Fehler nicht übergeleitet (siehe Fehlerprotokoll)') on item 'DlgMessageBox.labelMeldungstext'.", repo.DlgMessageBox.labelMeldungstextInfo, new RecordItemIndex(7));
            Validate.AttributeContains(repo.DlgMessageBox.labelMeldungstextInfo, "Text", "1 Rechnung(en) wegen Fehler nicht übergeleitet (siehe Fehlerprotokoll)");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(8));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DruckausgabeSpeichernUnter.Text1001' at Center.", repo.DruckausgabeSpeichernUnter.Text1001Info, new RecordItemIndex(9));
            repo.DruckausgabeSpeichernUnter.Text1001.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\temp\\Fehlerprotokoll' with focus on 'DlgDrucken'.", repo.DlgDrucken.SelfInfo, new RecordItemIndex(10));
            repo.DlgDrucken.Self.EnsureVisible();
            Keyboard.Press("C:\\temp\\Fehlerprotokoll");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'DlgDrucken'.", repo.DlgDrucken.SelfInfo, new RecordItemIndex(11));
            repo.DlgDrucken.Self.EnsureVisible();
            Keyboard.Press("{Return}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DruckausgabeSpeichernUnter.ButtonSpeichern' at Center.", repo.DruckausgabeSpeichernUnter.ButtonSpeichernInfo, new RecordItemIndex(12));
            repo.DruckausgabeSpeichernUnter.ButtonSpeichern.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DruckausgabeSpeichernUnter.Text1001' at Center.", repo.DruckausgabeSpeichernUnter.Text1001Info, new RecordItemIndex(13));
            repo.DruckausgabeSpeichernUnter.Text1001.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\temp\\Protokoll' with focus on 'DlgDrucken'.", repo.DlgDrucken.SelfInfo, new RecordItemIndex(14));
            repo.DlgDrucken.Self.EnsureVisible();
            Keyboard.Press("C:\\temp\\Protokoll");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'DlgDrucken'.", repo.DlgDrucken.SelfInfo, new RecordItemIndex(15));
            repo.DlgDrucken.Self.EnsureVisible();
            Keyboard.Press("{Return}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFIBU.RbRechUebergeleitet' at Center.", repo.TblFIBU.RbRechUebergeleitetInfo, new RecordItemIndex(16));
            repo.TblFIBU.RbRechUebergeleitet.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(17));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
