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

namespace Z_PROJ_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Projekt_I_FORUM_Aenderung_A_Phasen_pruefen recording.
    /// </summary>
    [TestModule("9bbd0ea3-6d6e-4d34-93f2-8adbec1725b9", ModuleType.Recording, 1)]
    public partial class Projekt_I_FORUM_Aenderung_A_Phasen_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_003.Z_PROJ_003Repository repository.
        /// </summary>
        public static global::Z_PROJ_003.Z_PROJ_003Repository repo = global::Z_PROJ_003.Z_PROJ_003Repository.Instance;

        static Projekt_I_FORUM_Aenderung_A_Phasen_pruefen instance = new Projekt_I_FORUM_Aenderung_A_Phasen_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Projekt_I_FORUM_Aenderung_A_Phasen_pruefen()
        {
            bis_Datum = "31.12.2099";
            PROJ_NR_I_FORUM_IP = "I-FORUM";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Projekt_I_FORUM_Aenderung_A_Phasen_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _bis_Datum;

        /// <summary>
        /// Gets or sets the value of variable bis_Datum.
        /// </summary>
        [TestVariable("bb300b6b-667e-42d2-b64d-2a1fd84b4f98")]
        public string bis_Datum
        {
            get { return _bis_Datum; }
            set { _bis_Datum = value; }
        }

        string _PROJ_NR_I_FORUM_IP;

        /// <summary>
        /// Gets or sets the value of variable PROJ_NR_I_FORUM_IP.
        /// </summary>
        [TestVariable("d4cc9ef7-1be7-4c21-8b4c-45322092ffe2")]
        public string PROJ_NR_I_FORUM_IP
        {
            get { return _PROJ_NR_I_FORUM_IP; }
            set { _PROJ_NR_I_FORUM_IP = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.TabPagePhasen' at Center.", repo.FrmTabProjekt.TabPagePhasenInfo, new RecordItemIndex(0));
            repo.FrmTabProjekt.TabPagePhasen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$PROJ_NR_I_FORUM_IP) on item 'FrmTabProjekt.Projektnr'.", repo.FrmTabProjekt.ProjektnrInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmTabProjekt.ProjektnrInfo, "Text", PROJ_NR_I_FORUM_IP);
            
            // Fenster maximieren
            Report.Log(ReportLevel.Info, "Keyboard", "Fenster maximieren\r\nKey sequence '{LWin down}{Up}{LWin up}' with focus on 'FrmTabProjekt.TitleBar100ProjektVerwalten'.", repo.FrmTabProjekt.TitleBar100ProjektVerwaltenInfo, new RecordItemIndex(2));
            repo.FrmTabProjekt.TitleBar100ProjektVerwalten.PressKeys("{LWin down}{Up}{LWin up}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColdtPhasBisRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColdtPhasBisRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColdtPhasBisRow1Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColPhasStatusExtRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColPhasStatusExtRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColPhasStatusExtRow1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColdtPhasBisRow2'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColdtPhasBisRow2Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColdtPhasBisRow2Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColPhasStatusExtRow2'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColPhasStatusExtRow2Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColPhasStatusExtRow2Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColdtPhasBisRow3'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColdtPhasBisRow3Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColdtPhasBisRow3Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColPhasStatusExtRow3'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColPhasStatusExtRow3Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColPhasStatusExtRow3Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColdtPhasBisRow4'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColdtPhasBisRow4Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColdtPhasBisRow4Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColPhasStatusExtRow4'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColPhasStatusExtRow4Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColPhasStatusExtRow4Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColdtPhasBisRow5'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColdtPhasBisRow5Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColdtPhasBisRow5Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColPhasStatusExtRow5'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColPhasStatusExtRow5Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColPhasStatusExtRow5Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColdtPhasBisRow6'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColdtPhasBisRow6Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColdtPhasBisRow6Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColPhasStatusExtRow6'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColPhasStatusExtRow6Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColPhasStatusExtRow6Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColdtPhasBisRow7'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColdtPhasBisRow7Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColdtPhasBisRow7Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColPhasStatusExtRow7'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColPhasStatusExtRow7Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColPhasStatusExtRow7Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColdtPhasBisRow8'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColdtPhasBisRow8Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColdtPhasBisRow8Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColPhasStatusExtRow8'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColPhasStatusExtRow8Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColPhasStatusExtRow8Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColdtPhasBisRow9'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColdtPhasBisRow9Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColdtPhasBisRow9Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColPhasStatusExtRow9'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColPhasStatusExtRow9Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColPhasStatusExtRow9Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColdtPhasBisRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColdtPhasBisRow10Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColdtPhasBisRow10Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColPhasStatusExtRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColPhasStatusExtRow10Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColPhasStatusExtRow10Info, "Text", "");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
