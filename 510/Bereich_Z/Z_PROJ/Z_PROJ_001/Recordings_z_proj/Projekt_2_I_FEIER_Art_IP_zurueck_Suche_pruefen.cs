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
    ///The Projekt_2_I_FEIER_Art_IP_zurueck_Suche_pruefen recording.
    /// </summary>
    [TestModule("2a54e202-63ca-429f-b48c-5ff6ea2004c2", ModuleType.Recording, 1)]
    public partial class Projekt_2_I_FEIER_Art_IP_zurueck_Suche_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_001.Z_PROJ_001Repository repository.
        /// </summary>
        public static global::Z_PROJ_001.Z_PROJ_001Repository repo = global::Z_PROJ_001.Z_PROJ_001Repository.Instance;

        static Projekt_2_I_FEIER_Art_IP_zurueck_Suche_pruefen instance = new Projekt_2_I_FEIER_Art_IP_zurueck_Suche_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Projekt_2_I_FEIER_Art_IP_zurueck_Suche_pruefen()
        {
            bis_Datum = "";
            Tagesdatum = "";
            PROJ_NR_2_IP = "";
            PROJ_BEZ_2_IP = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Projekt_2_I_FEIER_Art_IP_zurueck_Suche_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _bis_Datum;

        /// <summary>
        /// Gets or sets the value of variable bis_Datum.
        /// </summary>
        [TestVariable("2e0b753e-f7ff-451e-96c9-e0b706b668f1")]
        public string bis_Datum
        {
            get { return _bis_Datum; }
            set { _bis_Datum = value; }
        }

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("7c273643-dc15-450f-874f-f85e8c5148e1")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        string _PROJ_BEZ_2_IP;

        /// <summary>
        /// Gets or sets the value of variable PROJ_BEZ_2_IP.
        /// </summary>
        [TestVariable("68eb58f5-ce97-4d72-a0de-0938b0f07d4b")]
        public string PROJ_BEZ_2_IP
        {
            get { return _PROJ_BEZ_2_IP; }
            set { _PROJ_BEZ_2_IP = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PROJ_NR_2_IP.
        /// </summary>
        [TestVariable("b7141760-7e86-4c17-897c-aa7c96a88297")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt_alt.PbNavigationBack' at Center.", repo.FrmTabProjekt_alt.PbNavigationBackInfo, new RecordItemIndex(0));
            repo.FrmTabProjekt_alt.PbNavigationBack.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmTabProjekt_alt.Text_Suchmaske' at Center.", repo.FrmTabProjekt_alt.Text_SuchmaskeInfo, new RecordItemIndex(1));
            repo.FrmTabProjekt_alt.Text_Suchmaske.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt_alt.PbPerformSimpleSearch_Lupe_Suche' at Center.", repo.FrmTabProjekt_alt.PbPerformSimpleSearch_Lupe_SucheInfo, new RecordItemIndex(3));
            repo.FrmTabProjekt_alt.PbPerformSimpleSearch_Lupe_Suche.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt_alt.Text_Suchmaske'.", repo.FrmTabProjekt_alt.Text_SuchmaskeInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmTabProjekt_alt.Text_SuchmaskeInfo, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$PROJ_NR_2_IP) on item 'FrmTabProjekt_alt.Zeilen_Suche.Row_mit_PROJ_NR_2_Art_IP'.", repo.FrmTabProjekt_alt.Zeilen_Suche.Row_mit_PROJ_NR_2_Art_IPInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.FrmTabProjekt_alt.Zeilen_Suche.Row_mit_PROJ_NR_2_Art_IPInfo, "Text", PROJ_NR_2_IP);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$PROJ_BEZ_2_IP) on item 'FrmTabProjekt_alt.Zeilen_Suche.Row_mit_PROJ_NR_2_Art_IP'.", repo.FrmTabProjekt_alt.Zeilen_Suche.Row_mit_PROJ_NR_2_Art_IPInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.FrmTabProjekt_alt.Zeilen_Suche.Row_mit_PROJ_NR_2_Art_IPInfo, "Text", PROJ_BEZ_2_IP);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tagesdatum) on item 'FrmTabProjekt_alt.Zeilen_Suche.Row_mit_PROJ_NR_2_Art_IP'.", repo.FrmTabProjekt_alt.Zeilen_Suche.Row_mit_PROJ_NR_2_Art_IPInfo, new RecordItemIndex(7));
            Validate.AttributeContains(repo.FrmTabProjekt_alt.Zeilen_Suche.Row_mit_PROJ_NR_2_Art_IPInfo, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$bis_Datum) on item 'FrmTabProjekt_alt.Zeilen_Suche.Row_mit_PROJ_NR_2_Art_IP'.", repo.FrmTabProjekt_alt.Zeilen_Suche.Row_mit_PROJ_NR_2_Art_IPInfo, new RecordItemIndex(8));
            Validate.AttributeContains(repo.FrmTabProjekt_alt.Zeilen_Suche.Row_mit_PROJ_NR_2_Art_IPInfo, "Text", bis_Datum);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
