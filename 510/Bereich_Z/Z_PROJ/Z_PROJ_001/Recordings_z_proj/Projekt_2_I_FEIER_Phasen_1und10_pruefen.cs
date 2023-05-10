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
    ///The Projekt_2_I_FEIER_Phasen_1und10_pruefen recording.
    /// </summary>
    [TestModule("66a2e7fa-74ba-4e98-b06b-f8820d4f6b65", ModuleType.Recording, 1)]
    public partial class Projekt_2_I_FEIER_Phasen_1und10_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_001.Z_PROJ_001Repository repository.
        /// </summary>
        public static global::Z_PROJ_001.Z_PROJ_001Repository repo = global::Z_PROJ_001.Z_PROJ_001Repository.Instance;

        static Projekt_2_I_FEIER_Phasen_1und10_pruefen instance = new Projekt_2_I_FEIER_Phasen_1und10_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Projekt_2_I_FEIER_Phasen_1und10_pruefen()
        {
            PROJ_NR_2_IP = "";
            Tagesdatum = "";
            bis_Datum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Projekt_2_I_FEIER_Phasen_1und10_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("fd1b1acb-25a2-4d38-9314-8feaef5c5a11")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        string _bis_Datum;

        /// <summary>
        /// Gets or sets the value of variable bis_Datum.
        /// </summary>
        [TestVariable("035fa4df-a23b-46ce-beca-5971264b5672")]
        public string bis_Datum
        {
            get { return _bis_Datum; }
            set { _bis_Datum = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PROJ_NR_2_IP.
        /// </summary>
        [TestVariable("55cc27cd-5ae7-48c6-9143-66ec37b85da6")]
        public string PROJ_NR_2_IP
        {
            get { return repo.PROJ_NR_2_IP; }
            set { repo.PROJ_NR_2_IP = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$PROJ_NR_2_IP) on item 'FrmTabProjekt.Projektnr'.", repo.FrmTabProjekt.ProjektnrInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmTabProjekt.ProjektnrInfo, "Text", PROJ_NR_2_IP);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.TabPagePhasen' at Center.", repo.FrmTabProjekt.TabPagePhasenInfo, new RecordItemIndex(1));
            repo.FrmTabProjekt.TabPagePhasen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasPspCodeRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasPspCodeRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasPspCodeRow1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasCdRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasCdRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasCdRow1Info, "Text", "10");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Projektmanagement') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasBezRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasBezRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasBezRow1Info, "Text", "Projektmanagement");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasArtRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasArtRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasArtRow1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColdtPhasVonRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColdtPhasVonRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColdtPhasVonRow1Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColdtPhasBisRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColdtPhasBisRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColdtPhasBisRow1Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasStatusRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasStatusRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasStatusRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasStatusExtRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasStatusExtRow1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasStatusExtRow1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='True') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasBukzzeitRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasBukzzeitRow1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasBukzzeitRow1Info, "AccessibleValue", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='True') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasKzfortschrittRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasKzfortschrittRow1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasKzfortschrittRow1Info, "AccessibleValue", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasPspCodeRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasPspCodeRow10Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasPspCodeRow10Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasCdRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasCdRow10Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasCdRow10Info, "Text", "20");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Teilnahme an Meetings') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.PhasBezRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.PhasBezRow10Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.PhasBezRow10Info, "Text", "Teilnahme an Meetings");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasArtRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasArtRow10Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasArtRow10Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColdtPhasVonRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColdtPhasVonRow10Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColdtPhasVonRow10Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColdtPhasBisRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColdtPhasBisRow10Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColdtPhasBisRow10Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasStatusRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasStatusRow10Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasStatusRow10Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasStatusExtRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasStatusExtRow10Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasStatusExtRow10Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='True') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasBukzzeitRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasBukzzeitRow10Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasBukzzeitRow10Info, "AccessibleValue", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='True') on item 'FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasKzfortschrittRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasKzfortschrittRow10Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Felder.ColPhasKzfortschrittRow10Info, "AccessibleValue", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
