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

namespace AEKOOE_B_KLAB_Kunden.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Workplace_Ausfuehren_B_KLAB_K_Aufrufparameter recording.
    /// </summary>
    [TestModule("46366b59-7107-49e5-8dc3-0dd8b7cd4e1e", ModuleType.Recording, 1)]
    public partial class Workplace_Ausfuehren_B_KLAB_K_Aufrufparameter : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AEKOOE_B_KLAB_Kunden.AEKOOE_B_KLAB_KundenRepository repository.
        /// </summary>
        public static global::AEKOOE_B_KLAB_Kunden.AEKOOE_B_KLAB_KundenRepository repo = global::AEKOOE_B_KLAB_Kunden.AEKOOE_B_KLAB_KundenRepository.Instance;

        static Workplace_Ausfuehren_B_KLAB_K_Aufrufparameter instance = new Workplace_Ausfuehren_B_KLAB_K_Aufrufparameter();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Workplace_Ausfuehren_B_KLAB_K_Aufrufparameter()
        {
            Mandant = "WFK";
            Programm_RS_Aufrufparameter = "@B_KLAB /KL=L Benutzer=RS_RANO_1 Kennwort=rano ";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Workplace_Ausfuehren_B_KLAB_K_Aufrufparameter Instance
        {
            get { return instance; }
        }

#region Variables

        string _Mandant;

        /// <summary>
        /// Gets or sets the value of variable Mandant.
        /// </summary>
        [TestVariable("40be7197-802d-4e69-83d7-5302bf9df950")]
        public string Mandant
        {
            get { return _Mandant; }
            set { _Mandant = value; }
        }

        string _Programm_RS_Aufrufparameter;

        /// <summary>
        /// Gets or sets the value of variable Programm_RS_Aufrufparameter.
        /// </summary>
        [TestVariable("18e71c18-c400-4ec3-a64a-bf321370b48b")]
        public string Programm_RS_Aufrufparameter
        {
            get { return _Programm_RS_Aufrufparameter; }
            set { _Programm_RS_Aufrufparameter = value; }
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

            // davor: Aufruf Workplace manuell mit beliebigem Mandant. User RS_RANOREX Kw=rano mit aktivem Licenceservice; Programmaufruf mit Ausführen und Aufrufparameter
            Report.Log(ReportLevel.Info, "Section", "davor: Aufruf Workplace manuell mit beliebigem Mandant. User RS_RANOREX Kw=rano mit aktivem Licenceservice; Programmaufruf mit Ausführen und Aufrufparameter", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FormWorkplace.TitleBar_Workplace'.", repo.FormWorkplace.TitleBar_WorkplaceInfo, new RecordItemIndex(1));
            Validate.Exists(repo.FormWorkplace.TitleBar_WorkplaceInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormWorkplace.TitleBar_Workplace' at Center.", repo.FormWorkplace.TitleBar_WorkplaceInfo, new RecordItemIndex(2));
            repo.FormWorkplace.TitleBar_Workplace.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+R' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgAusfuehren.TitleBarWFKAusfuehren'", repo.DlgAusfuehren.TitleBarWFKAusfuehrenInfo, new ActionTimeout(60000), new RecordItemIndex(4));
            repo.DlgAusfuehren.TitleBarWFKAusfuehrenInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Ausführen') on item 'DlgAusfuehren.TitleBarWFKAusfuehren'.", repo.DlgAusfuehren.TitleBarWFKAusfuehrenInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.DlgAusfuehren.TitleBarWFKAusfuehrenInfo, "Text", "Ausführen");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Programm_RS_Aufrufparameter'.", new RecordItemIndex(6));
            Keyboard.Press(Programm_RS_Aufrufparameter);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}'.", new RecordItemIndex(7));
            Keyboard.Press("{LControlKey down}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgAusfuehren.PbOk' at Center.", repo.DlgAusfuehren.PbOkInfo, new RecordItemIndex(8));
            repo.DlgAusfuehren.PbOk.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey up}'.", new RecordItemIndex(9));
            Keyboard.Press("{LControlKey up}");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmKlAb.TitleBarWFKKundenKonto'", repo.FrmKlAb.TitleBarWFKKundenKontoInfo, new ActionTimeout(120000), new RecordItemIndex(10));
            repo.FrmKlAb.TitleBarWFKKundenKontoInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Kunden-Konto') on item 'FrmKlAb.TitleBarWFKKundenKonto'.", repo.FrmKlAb.TitleBarWFKKundenKontoInfo, new RecordItemIndex(11));
            Validate.AttributeContains(repo.FrmKlAb.TitleBarWFKKundenKontoInfo, "Text", "Kunden-Konto");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Mandant) on item 'FrmKlAb.TitleBarWFKKundenKonto'.", repo.FrmKlAb.TitleBarWFKKundenKontoInfo, new RecordItemIndex(12));
            Validate.AttributeContains(repo.FrmKlAb.TitleBarWFKKundenKontoInfo, "Text", Mandant);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
