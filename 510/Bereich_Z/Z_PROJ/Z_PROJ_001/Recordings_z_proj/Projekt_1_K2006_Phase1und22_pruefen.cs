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
    ///The Projekt_1_K2006_Phase1und22_pruefen recording.
    /// </summary>
    [TestModule("b41378bb-fcde-419f-bb3b-655b0641b4ed", ModuleType.Recording, 1)]
    public partial class Projekt_1_K2006_Phase1und22_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_001.Z_PROJ_001Repository repository.
        /// </summary>
        public static global::Z_PROJ_001.Z_PROJ_001Repository repo = global::Z_PROJ_001.Z_PROJ_001Repository.Instance;

        static Projekt_1_K2006_Phase1und22_pruefen instance = new Projekt_1_K2006_Phase1und22_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Projekt_1_K2006_Phase1und22_pruefen()
        {
            Tagesdatum = "";
            bis_Datum = "";
            PROJ_NR_1_K = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Projekt_1_K2006_Phase1und22_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("3a8b919b-8bf0-4422-8782-3bf2df27e2a0")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        string _bis_Datum;

        /// <summary>
        /// Gets or sets the value of variable bis_Datum.
        /// </summary>
        [TestVariable("0baffe9a-fb33-4ed3-935f-a07469dd9515")]
        public string bis_Datum
        {
            get { return _bis_Datum; }
            set { _bis_Datum = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PROJ_NR_1_K.
        /// </summary>
        [TestVariable("1850148b-0899-4871-b273-0d8c2bcac546")]
        public string PROJ_NR_1_K
        {
            get { return repo.PROJ_NR_1_K; }
            set { repo.PROJ_NR_1_K = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$PROJ_NR_1_K) on item 'FrmTabProjekt.Projektnr'.", repo.FrmTabProjekt.ProjektnrInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmTabProjekt.ProjektnrInfo, "Text", PROJ_NR_1_K);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.Phasen_Tab_regex_Sonderzeichen' at Center.", repo.FrmTabProjekt.Phasen_Tab_regex_SonderzeichenInfo, new RecordItemIndex(1));
            repo.FrmTabProjekt.Phasen_Tab_regex_Sonderzeichen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasPspCodeRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasPspCodeRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasPspCodeRow1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasCdRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasCdRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasCdRow1Info, "Text", "10");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Projektleitung') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBezRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBezRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBezRow1Info, "Text", "Projektleitung");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasArtRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasArtRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasArtRow1Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasVonRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasVonRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasVonRow1Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasBisRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasBisRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasBisRow1Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusExtRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusExtRow1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusExtRow1Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='True') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBukzzeitRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBukzzeitRow1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBukzzeitRow1Info, "AccessibleValue", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='False') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasKzfortschrittRow1'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasKzfortschrittRow1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasKzfortschrittRow1Info, "AccessibleValue", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='6.2') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasPspCodeRow22'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasPspCodeRow22Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasPspCodeRow22Info, "Text", "6.2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='RP2') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasCdRow22'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasCdRow22Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasCdRow22Info, "Text", "RP2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='RP - Angebot') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBezRow22'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBezRow22Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBezRow22Info, "Text", "RP - Angebot");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasArtRow22'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasArtRow22Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasArtRow22Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasVonRow22'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasVonRow22Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasVonRow22Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasBisRow22'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasBisRow22Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColdtPhasBisRow22Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusRow22'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusRow22Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusRow22Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusExtRow22'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusExtRow22Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasStatusExtRow22Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='True') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBukzzeitRow22'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBukzzeitRow22Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasBukzzeitRow22Info, "AccessibleValue", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='False') on item 'FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasKzfortschrittRow22'.", repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasKzfortschrittRow22Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Register_Phasen_Felder.ColPhasKzfortschrittRow22Info, "AccessibleValue", "False");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
