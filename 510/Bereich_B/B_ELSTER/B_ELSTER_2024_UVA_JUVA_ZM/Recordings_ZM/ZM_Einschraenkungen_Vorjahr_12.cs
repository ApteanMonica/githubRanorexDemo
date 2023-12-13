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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordings_ZM
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ZM_Eingabedaten recording.
    /// </summary>
    [TestModule("f700983a-2c2c-498e-9019-f2adcb96c6cf", ModuleType.Recording, 1)]
    public partial class ZM_Einschraenkungen_VORJAHR_12 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static ZM_Einschraenkungen_VORJAHR_12 instance = new ZM_Einschraenkungen_VORJAHR_12();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ZM_Einschraenkungen_VORJAHR_12()
        {
            Firma = "300";
            VORJAHR = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ZM_Einschraenkungen_VORJAHR_12 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Firma;

        /// <summary>
        /// Gets or sets the value of variable Firma.
        /// </summary>
        [TestVariable("13fa8a9e-c426-4018-b241-6097808e5353")]
        public string Firma
        {
            get { return _Firma; }
            set { _Firma = value; }
        }

        string _VORJAHR;

        /// <summary>
        /// Gets or sets the value of variable VORJAHR.
        /// </summary>
        [TestVariable("e130069d-7dcc-4379-a617-e0009829a3ef")]
        public string VORJAHR
        {
            get { return _VORJAHR; }
            set { _VORJAHR = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Firma) on item 'FrmMain_B_ZM.ClientArea.Firma'.", repo.FrmMain_B_ZM.ClientArea.FirmaInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmMain_B_ZM.ClientArea.FirmaInfo, "Text", Firma);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='DE_ELSTER') on item 'FrmMain_B_ZM.ClientArea.DfFirmKbez'.", repo.FrmMain_B_ZM.ClientArea.DfFirmKbezInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmMain_B_ZM.ClientArea.DfFirmKbezInfo, "Text", "DE_ELSTER");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='DE') on item 'FrmMain_B_ZM.ClientArea.Land'.", repo.FrmMain_B_ZM.ClientArea.LandInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmMain_B_ZM.ClientArea.LandInfo, "Text", "DE");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Deutschland') on item 'FrmMain_B_ZM.ClientArea.CmbLandBez'.", repo.FrmMain_B_ZM.ClientArea.CmbLandBezInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmMain_B_ZM.ClientArea.CmbLandBezInfo, "Text", "Deutschland");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmMain_B_ZM.PbElster'.", repo.FrmMain_B_ZM.PbElsterInfo, new RecordItemIndex(4));
            Validate.Exists(repo.FrmMain_B_ZM.PbElsterInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'FrmMain_B_ZM.PbElster'.", repo.FrmMain_B_ZM.PbElsterInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmMain_B_ZM.PbElsterInfo, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$VORJAHR' with focus on 'FrmMain_B_ZM.ClientArea.Jahr'.", repo.FrmMain_B_ZM.ClientArea.JahrInfo, new RecordItemIndex(6));
            repo.FrmMain_B_ZM.ClientArea.Jahr.PressKeys(VORJAHR);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain_B_ZM.ClientArea.CmbQuartale' at Center.", repo.FrmMain_B_ZM.ClientArea.CmbQuartaleInfo, new RecordItemIndex(8));
            repo.FrmMain_B_ZM.ClientArea.CmbQuartale.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.Dezember' at Center.", repo.List1000.DezemberInfo, new RecordItemIndex(9));
            repo.List1000.Dezember.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$VORJAHR) on item 'FrmMain_B_ZM.ClientArea.Jahr'.", repo.FrmMain_B_ZM.ClientArea.JahrInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmMain_B_ZM.ClientArea.JahrInfo, "Text", VORJAHR);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Dezember') on item 'FrmMain_B_ZM.ClientArea.CmbQuartale'.", repo.FrmMain_B_ZM.ClientArea.CmbQuartaleInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmMain_B_ZM.ClientArea.CmbQuartaleInfo, "Text", "Dezember");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
