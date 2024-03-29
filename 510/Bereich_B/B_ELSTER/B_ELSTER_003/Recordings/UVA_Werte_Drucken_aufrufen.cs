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

namespace B_ELSTER_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UVA_Werte_Drucken_aufrufen recording.
    /// </summary>
    [TestModule("5473de78-b5e2-4e00-b4c6-cc75a9f09c3c", ModuleType.Recording, 1)]
    public partial class UVA_Werte_Drucken_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_003.B_ELSTER_003Repository repository.
        /// </summary>
        public static global::B_ELSTER_003.B_ELSTER_003Repository repo = global::B_ELSTER_003.B_ELSTER_003Repository.Instance;

        static UVA_Werte_Drucken_aufrufen instance = new UVA_Werte_Drucken_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UVA_Werte_Drucken_aufrufen()
        {
            Firma = "300";
            Jahr = "2022";
            Monat_1 = "1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UVA_Werte_Drucken_aufrufen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Firma;

        /// <summary>
        /// Gets or sets the value of variable Firma.
        /// </summary>
        [TestVariable("79946385-aa9b-470c-b6f5-9c5f71cd1c29")]
        public string Firma
        {
            get { return _Firma; }
            set { _Firma = value; }
        }

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("d62dfbe1-bef1-4eb9-b016-e4b1f89ea3bb")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Monat_1;

        /// <summary>
        /// Gets or sets the value of variable Monat_1.
        /// </summary>
        [TestVariable("c3605af5-cfa4-4ab9-8c3b-1880c280de14")]
        public string Monat_1
        {
            get { return _Monat_1; }
            set { _Monat_1 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Firma) on item 'FrmUVAW.TitleBar300UVAWerte'.", repo.FrmUVAW.TitleBar300UVAWerteInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.FrmUVAW.TitleBar300UVAWerteInfo, "Text", Firma);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmUVAW.PbCommonDrucken' at Center.", repo.FrmUVAW.PbCommonDruckenInfo, new RecordItemIndex(1));
            repo.FrmUVAW.PbCommonDrucken.Click();
            
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
