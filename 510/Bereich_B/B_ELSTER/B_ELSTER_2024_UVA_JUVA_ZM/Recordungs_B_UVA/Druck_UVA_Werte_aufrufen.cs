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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordungs_B_UVA
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Druck_UVA_Werte_aufrufen recording.
    /// </summary>
    [TestModule("10fbe8a3-a701-427b-b3d6-f2ceacc8f16b", ModuleType.Recording, 1)]
    public partial class Druck_UVA_Werte_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static Druck_UVA_Werte_aufrufen instance = new Druck_UVA_Werte_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Druck_UVA_Werte_aufrufen()
        {
            Firma = "300";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Druck_UVA_Werte_aufrufen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Firma;

        /// <summary>
        /// Gets or sets the value of variable Firma.
        /// </summary>
        [TestVariable("f152e868-125f-4bae-bc5c-22254123939a")]
        public string Firma
        {
            get { return _Firma; }
            set { _Firma = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Firma) on item 'TblUVAF.TitleBar100VerwaltenUVAFormulare'.", repo.TblUVAF.TitleBar100VerwaltenUVAFormulareInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.TblUVAF.TitleBar100VerwaltenUVAFormulareInfo, "Text", Firma);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblUVAF.PbCommonDrucken' at Center.", repo.TblUVAF.PbCommonDruckenInfo, new RecordItemIndex(1));
            repo.TblUVAF.PbCommonDrucken.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgUVADruck.TitleBar300DruckUVAWerte'", repo.DlgUVADruck.TitleBar300DruckUVAWerteInfo, new ActionTimeout(120000), new RecordItemIndex(2));
            repo.DlgUVADruck.TitleBar300DruckUVAWerteInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[300]  Druck UVA-Werte') on item 'DlgUVADruck.TitleBar300DruckUVAWerte'.", repo.DlgUVADruck.TitleBar300DruckUVAWerteInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.DlgUVADruck.TitleBar300DruckUVAWerteInfo, "Text", "[300]  Druck UVA-Werte");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='DE') on item 'DlgUVADruck.Land'.", repo.DlgUVADruck.LandInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgUVADruck.LandInfo, "Text", "DE");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgUVADruck.PbElster'.", repo.DlgUVADruck.PbElsterInfo, new RecordItemIndex(5));
            Validate.Exists(repo.DlgUVADruck.PbElsterInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
