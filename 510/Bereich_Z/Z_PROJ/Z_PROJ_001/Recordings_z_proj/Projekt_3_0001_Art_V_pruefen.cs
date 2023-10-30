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
    ///The Projekt_3_0001_Art_V_pruefen recording.
    /// </summary>
    [TestModule("f0d2b8fe-2b69-4aea-aec0-0a8dd90f1bba", ModuleType.Recording, 1)]
    public partial class Projekt_3_0001_Art_V_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_001.Z_PROJ_001Repository repository.
        /// </summary>
        public static global::Z_PROJ_001.Z_PROJ_001Repository repo = global::Z_PROJ_001.Z_PROJ_001Repository.Instance;

        static Projekt_3_0001_Art_V_pruefen instance = new Projekt_3_0001_Art_V_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Projekt_3_0001_Art_V_pruefen()
        {
            PROJ_NR_3_V = "0001";
            bis_Datum = "31.12.2099";
            Tagesdatum = "";
            User_RSX = "RSX";
            User_RS = "RS";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Projekt_3_0001_Art_V_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _bis_Datum;

        /// <summary>
        /// Gets or sets the value of variable bis_Datum.
        /// </summary>
        [TestVariable("c3d978a6-2703-4eb6-ab8b-c794812bf357")]
        public string bis_Datum
        {
            get { return _bis_Datum; }
            set { _bis_Datum = value; }
        }

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("20eec8ce-2059-4f5d-9faa-18280b772270")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        string _User_RSX;

        /// <summary>
        /// Gets or sets the value of variable User_RSX.
        /// </summary>
        [TestVariable("18d1a7a6-e1d5-4cf7-89a2-36b553833a37")]
        public string User_RSX
        {
            get { return _User_RSX; }
            set { _User_RSX = value; }
        }

        string _User_RS;

        /// <summary>
        /// Gets or sets the value of variable User_RS.
        /// </summary>
        [TestVariable("e1de90a8-7ca7-446a-93c4-d09c610e90c9")]
        public string User_RS
        {
            get { return _User_RS; }
            set { _User_RS = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PROJ_NR_3_V.
        /// </summary>
        [TestVariable("46fae0b3-4b7a-44c3-acb8-bdf24bbb5ede")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt_alt.Projekt_Tab_regex_Sonderzeichen' at Center.", repo.FrmTabProjekt_alt.Projekt_Tab_regex_SonderzeichenInfo, new RecordItemIndex(0));
            repo.FrmTabProjekt_alt.Projekt_Tab_regex_Sonderzeichen.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$PROJ_NR_3_V) on item 'FrmTabProjekt_alt.Projektnr'.", repo.FrmTabProjekt_alt.ProjektnrInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.ProjektnrInfo, "Text", PROJ_NR_3_V);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V') on item 'FrmTabProjekt_alt.TextArt'.", repo.FrmTabProjekt_alt.TextArtInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.TextArtInfo, "Text", "V");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt_alt.VorlageProjektnr'.", repo.FrmTabProjekt_alt.VorlageProjektnrInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.VorlageProjektnrInfo, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'FrmTabProjekt_alt.Register_Projekt.Zeitraum'.", repo.FrmTabProjekt_alt.Register_Projekt.ZeitraumInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.Register_Projekt.ZeitraumInfo, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt_alt.Register_Projekt.TextBis'.", repo.FrmTabProjekt_alt.Register_Projekt.TextBisInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.Register_Projekt.TextBisInfo, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Aktiv') on item 'FrmTabProjekt_alt.CmbStatus'.", repo.FrmTabProjekt_alt.CmbStatusInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.CmbStatusInfo, "Text", "Aktiv");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt_alt.Register_Projekt.DfProjStatusExt'.", repo.FrmTabProjekt_alt.Register_Projekt.DfProjStatusExtInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.Register_Projekt.DfProjStatusExtInfo, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$User_RSX) on item 'FrmTabProjekt_alt.Register_Projekt.ColPersNrRow1'.", repo.FrmTabProjekt_alt.Register_Projekt.ColPersNrRow1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.Register_Projekt.ColPersNrRow1Info, "Text", User_RSX);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$User_RS) on item 'FrmTabProjekt_alt.Register_Projekt.ColPersNrRow2'.", repo.FrmTabProjekt_alt.Register_Projekt.ColPersNrRow2Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.Register_Projekt.ColPersNrRow2Info, "Text", User_RS);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt_alt.Allgemein_Tab_regex_Sonderzeichen' at Center.", repo.FrmTabProjekt_alt.Allgemein_Tab_regex_SonderzeichenInfo, new RecordItemIndex(11));
            repo.FrmTabProjekt_alt.Allgemein_Tab_regex_Sonderzeichen.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(12));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='KA') on item 'FrmTabProjekt_alt.Register_Allgemein.Text_Zeittyp'.", repo.FrmTabProjekt_alt.Register_Allgemein.Text_ZeittypInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.Register_Allgemein.Text_ZeittypInfo, "Text", "KA");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'FrmTabProjekt_alt.Register_Allgemein.CbProjBukzzeit'.", repo.FrmTabProjekt_alt.Register_Allgemein.CbProjBukzzeitInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.Register_Allgemein.CbProjBukzzeitInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'FrmTabProjekt_alt.Register_Allgemein.CbProjKzuhr'.", repo.FrmTabProjekt_alt.Register_Allgemein.CbProjKzuhrInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.Register_Allgemein.CbProjKzuhrInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmTabProjekt_alt.Register_Allgemein.CbProjKzdauer'.", repo.FrmTabProjekt_alt.Register_Allgemein.CbProjKzdauerInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.Register_Allgemein.CbProjKzdauerInfo, "Checked", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
