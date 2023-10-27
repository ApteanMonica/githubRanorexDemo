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

namespace B_ELSTER_005.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UVA_Drucken_aufrufen recording.
    /// </summary>
    [TestModule("0e5bbe66-3453-4dc4-b2bc-6c3754f94f60", ModuleType.Recording, 1)]
    public partial class UVA_Drucken_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_005.B_ELSTER_005Repository repository.
        /// </summary>
        public static global::B_ELSTER_005.B_ELSTER_005Repository repo = global::B_ELSTER_005.B_ELSTER_005Repository.Instance;

        static UVA_Drucken_aufrufen instance = new UVA_Drucken_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UVA_Drucken_aufrufen()
        {
            Firma = "300";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UVA_Drucken_aufrufen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Firma;

        /// <summary>
        /// Gets or sets the value of variable Firma.
        /// </summary>
        [TestVariable("5e7cb53e-ce0f-432a-a5e1-353d42714c61")]
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgUVADruck.TitleBar300DruckUVAWerte'", repo.DlgUVADruck.TitleBar300DruckUVAWerteInfo, new ActionTimeout(60000), new RecordItemIndex(2));
            repo.DlgUVADruck.TitleBar300DruckUVAWerteInfo.WaitForExists(60000);
            
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