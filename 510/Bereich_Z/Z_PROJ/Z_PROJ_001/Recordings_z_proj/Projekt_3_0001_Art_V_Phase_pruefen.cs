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

namespace Z_PROJ_001.Recordings_z_proj
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Projekt_3_0001_Art_V_Phase_pruefen recording.
    /// </summary>
    [TestModule("2fb4a643-981e-43d9-8c2f-f9f8f31c8a29", ModuleType.Recording, 1)]
    public partial class Projekt_3_0001_Art_V_Phase_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_001.Z_PROJ_001Repository repository.
        /// </summary>
        public static global::Z_PROJ_001.Z_PROJ_001Repository repo = global::Z_PROJ_001.Z_PROJ_001Repository.Instance;

        static Projekt_3_0001_Art_V_Phase_pruefen instance = new Projekt_3_0001_Art_V_Phase_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Projekt_3_0001_Art_V_Phase_pruefen()
        {
            Tagesdatum = "";
            bis_Datum = "31.12.2099";
            PROJ_NR_3_V = "0001";
            PROJ_BEZ_3_V = "PAPAMONAT";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Projekt_3_0001_Art_V_Phase_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("794d05e7-e7e2-4eb8-a14f-5375f09b27c2")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        string _bis_Datum;

        /// <summary>
        /// Gets or sets the value of variable bis_Datum.
        /// </summary>
        [TestVariable("726f6566-ddd9-4318-9e53-5d557562465b")]
        public string bis_Datum
        {
            get { return _bis_Datum; }
            set { _bis_Datum = value; }
        }

        string _PROJ_BEZ_3_V;

        /// <summary>
        /// Gets or sets the value of variable PROJ_BEZ_3_V.
        /// </summary>
        [TestVariable("746d87bd-1c27-487b-b322-4cb0c8afa90d")]
        public string PROJ_BEZ_3_V
        {
            get { return _PROJ_BEZ_3_V; }
            set { _PROJ_BEZ_3_V = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PROJ_NR_3_V.
        /// </summary>
        [TestVariable("2817b0bb-2277-4f7f-8e4c-df589b777131")]
        public string PROJ_NR_3_V
        {
            get { return repo.PROJ_NR_3_V; }
            set { repo.PROJ_NR_3_V = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.Phasen_Tab_regex_Sonderzeichen' at Center.", repo.FrmTabProjekt.Phasen_Tab_regex_SonderzeichenInfo, new RecordItemIndex(0));
            repo.FrmTabProjekt.Phasen_Tab_regex_Sonderzeichen.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$PROJ_NR_3_V) on item 'FrmTabProjekt.Projektnr'.", repo.FrmTabProjekt.ProjektnrInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmTabProjekt.ProjektnrInfo, "Text", PROJ_NR_3_V);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.Phasen_Tab_regex_Sonderzeichen' at Center.", repo.FrmTabProjekt.Phasen_Tab_regex_SonderzeichenInfo, new RecordItemIndex(3));
            repo.FrmTabProjekt.Phasen_Tab_regex_Sonderzeichen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasPspCodeRow1'", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasPspCodeRow1Info, new ActionTimeout(60000), new RecordItemIndex(4));
            repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasPspCodeRow1Info.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasPspCodeRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasPspCodeRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasPspCodeRow1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='*') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasCdRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasCdRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasCdRow1Info, "Text", "*");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$PROJ_BEZ_3_V) on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBezRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBezRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBezRow1Info, "Text", PROJ_BEZ_3_V);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasArtRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasArtRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasArtRow1Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='KA') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColZtypCdRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColZtypCdRow1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColZtypCdRow1Info, "Text", "KA");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasVonRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasVonRow1Info, new RecordItemIndex(10));
            //Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasVonRow1Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasBisRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasBisRow1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasBisRow1Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusRow1Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusExtRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusExtRow1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusExtRow1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='False') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBukzzeitRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBukzzeitRow1Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBukzzeitRow1Info, "AccessibleValue", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='False') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasKzfortschrittRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasKzfortschrittRow1Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasKzfortschrittRow1Info, "AccessibleValue", "False");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
