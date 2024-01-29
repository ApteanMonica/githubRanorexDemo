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

namespace AEKOOE_B_KTO.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Workplace_Ausfuehren_B_KTO recording.
    /// </summary>
    [TestModule("c9b5f3e0-437a-4b32-a79b-b36ca5ad71bf", ModuleType.Recording, 1)]
    public partial class Workplace_Ausfuehren_B_KTO : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AEKOOE_B_KTO.AEKOOE_B_KTORepository repository.
        /// </summary>
        public static global::AEKOOE_B_KTO.AEKOOE_B_KTORepository repo = global::AEKOOE_B_KTO.AEKOOE_B_KTORepository.Instance;

        static Workplace_Ausfuehren_B_KTO instance = new Workplace_Ausfuehren_B_KTO();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Workplace_Ausfuehren_B_KTO()
        {
            Mandant = "WFK";
            Programm = "B_KTO";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Workplace_Ausfuehren_B_KTO Instance
        {
            get { return instance; }
        }

#region Variables

        string _Mandant;

        /// <summary>
        /// Gets or sets the value of variable Mandant.
        /// </summary>
        [TestVariable("f461b4ea-132e-4692-9f6b-55486a3fbb6f")]
        public string Mandant
        {
            get { return _Mandant; }
            set { _Mandant = value; }
        }

        string _Programm;

        /// <summary>
        /// Gets or sets the value of variable Programm.
        /// </summary>
        [TestVariable("ab7c7c60-9946-4914-b1f4-4b72ef9712ca")]
        public string Programm
        {
            get { return _Programm; }
            set { _Programm = value; }
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

            // davor: Aufruf Workplace manuell mit Mandant WFK User RS_RANOREX Kw=rano mit aktivem Licenceservice; Programmaufruf mit Ausführen:
            Report.Log(ReportLevel.Info, "Section", "davor: Aufruf Workplace manuell mit Mandant WFK User RS_RANOREX Kw=rano mit aktivem Licenceservice; Programmaufruf mit Ausführen:", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FormWorkplace.TitleBar_Workplace'.", repo.FormWorkplace.TitleBar_WorkplaceInfo, new RecordItemIndex(1));
            Validate.Exists(repo.FormWorkplace.TitleBar_WorkplaceInfo);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Mandant) on item 'FormWorkplace.TitleBar_Workplace'.", repo.FormWorkplace.TitleBar_WorkplaceInfo, new RecordItemIndex(2));
            //Validate.AttributeContains(repo.FormWorkplace.TitleBar_WorkplaceInfo, "Text", Mandant);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormWorkplace.TitleBar_Workplace' at Center.", repo.FormWorkplace.TitleBar_WorkplaceInfo, new RecordItemIndex(3));
            repo.FormWorkplace.TitleBar_Workplace.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+R' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgAusfuehren.TitleBarWFKAusfuehren'", repo.DlgAusfuehren.TitleBarWFKAusfuehrenInfo, new ActionTimeout(60000), new RecordItemIndex(5));
            repo.DlgAusfuehren.TitleBarWFKAusfuehrenInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Ausführen') on item 'DlgAusfuehren.TitleBarWFKAusfuehren'.", repo.DlgAusfuehren.TitleBarWFKAusfuehrenInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.DlgAusfuehren.TitleBarWFKAusfuehrenInfo, "Text", "Ausführen");
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgAusfuehren.Text1001' at Center.", repo.DlgAusfuehren.Text1001Info, new RecordItemIndex(7));
            //repo.DlgAusfuehren.Text1001.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '@'.", new RecordItemIndex(8));
            Keyboard.Press("@");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Programm'.", new RecordItemIndex(9));
            Keyboard.Press(Programm);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}'.", new RecordItemIndex(10));
            Keyboard.Press("{LControlKey down}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgAusfuehren.PbOk' at Center.", repo.DlgAusfuehren.PbOkInfo, new RecordItemIndex(11));
            repo.DlgAusfuehren.PbOk.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey up}'.", new RecordItemIndex(12));
            Keyboard.Press("{LControlKey up}");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmKto.TitleBarWFKSachkontenVerwalten'", repo.FrmKto.TitleBarWFKSachkontenVerwaltenInfo, new ActionTimeout(120000), new RecordItemIndex(13));
            repo.FrmKto.TitleBarWFKSachkontenVerwaltenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Sachkonten verwalten') on item 'FrmKto.TitleBarWFKSachkontenVerwalten'.", repo.FrmKto.TitleBarWFKSachkontenVerwaltenInfo, new RecordItemIndex(14));
            Validate.AttributeContains(repo.FrmKto.TitleBarWFKSachkontenVerwaltenInfo, "Text", "Sachkonten verwalten");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Mandant) on item 'FrmKto.TitleBarWFKSachkontenVerwalten'.", repo.FrmKto.TitleBarWFKSachkontenVerwaltenInfo, new RecordItemIndex(15));
            Validate.AttributeContains(repo.FrmKto.TitleBarWFKSachkontenVerwaltenInfo, "Text", Mandant);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}