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
    ///The Projekt_I_FORUM_nach_Speichern_Phasen_pruefen recording.
    /// </summary>
    [TestModule("e941eb11-a4bf-4730-b01e-f4113b8fc0c2", ModuleType.Recording, 1)]
    public partial class Projekt_I_FORUM_nach_Speichern_Phasen_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_003.Z_PROJ_003Repository repository.
        /// </summary>
        public static global::Z_PROJ_003.Z_PROJ_003Repository repo = global::Z_PROJ_003.Z_PROJ_003Repository.Instance;

        static Projekt_I_FORUM_nach_Speichern_Phasen_pruefen instance = new Projekt_I_FORUM_nach_Speichern_Phasen_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Projekt_I_FORUM_nach_Speichern_Phasen_pruefen()
        {
            bis_Datum = "31.12.2099";
            PROJ_NR_I_FORUM_IP = "I-FORUM";
            bis_Datum2 = "31.12.2050";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Projekt_I_FORUM_nach_Speichern_Phasen_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _bis_Datum;

        /// <summary>
        /// Gets or sets the value of variable bis_Datum.
        /// </summary>
        [TestVariable("31d50f41-739d-48a2-8871-a367fe732336")]
        public string bis_Datum
        {
            get { return _bis_Datum; }
            set { _bis_Datum = value; }
        }

        string _PROJ_NR_I_FORUM_IP;

        /// <summary>
        /// Gets or sets the value of variable PROJ_NR_I_FORUM_IP.
        /// </summary>
        [TestVariable("8eda2ab8-bd86-4338-b2c4-3b9a5155b41a")]
        public string PROJ_NR_I_FORUM_IP
        {
            get { return _PROJ_NR_I_FORUM_IP; }
            set { _PROJ_NR_I_FORUM_IP = value; }
        }

        string _bis_Datum2;

        /// <summary>
        /// Gets or sets the value of variable bis_Datum2.
        /// </summary>
        [TestVariable("4c9ab48e-6d3d-43e8-a972-370a31b12c01")]
        public string bis_Datum2
        {
            get { return _bis_Datum2; }
            set { _bis_Datum2 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$PROJ_NR_I_FORUM_IP) on item 'FrmTabProjekt.Projektnr'.", repo.FrmTabProjekt.ProjektnrInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmTabProjekt.ProjektnrInfo, "Text", PROJ_NR_I_FORUM_IP);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.PbDataAccessReload' at Center.", repo.FrmTabProjekt.PbDataAccessReloadInfo, new RecordItemIndex(1));
            repo.FrmTabProjekt.PbDataAccessReload.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Row1'", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Row1Info, new ActionTimeout(60000), new RecordItemIndex(2));
            repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Row1Info.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColPhasCdRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColPhasCdRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColPhasCdRow1Info, "Text", "10");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColdtPhasBisRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColdtPhasBisRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColdtPhasBisRow1Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColPhasStatusExtRow1'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColPhasStatusExtRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_1.ColPhasStatusExtRow1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColPhasCdRow2'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColPhasCdRow2Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColPhasCdRow2Info, "Text", "100");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum2) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColdtPhasBisRow2'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColdtPhasBisRow2Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColdtPhasBisRow2Info, "Text", bis_Datum2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColPhasStatusExtRow2'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColPhasStatusExtRow2Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_2.ColPhasStatusExtRow2Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='101') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColPhasCdRow3'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColPhasCdRow3Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColPhasCdRow3Info, "Text", "101");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum2) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColdtPhasBisRow3'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColdtPhasBisRow3Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColdtPhasBisRow3Info, "Text", bis_Datum2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColPhasStatusExtRow3'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColPhasStatusExtRow3Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_3.ColPhasStatusExtRow3Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1011') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColPhasCdRow4'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColPhasCdRow4Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColPhasCdRow4Info, "Text", "1011");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum2) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColdtPhasBisRow4'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColdtPhasBisRow4Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColdtPhasBisRow4Info, "Text", bis_Datum2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColPhasStatusExtRow4'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColPhasStatusExtRow4Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_4.ColPhasStatusExtRow4Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='102') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColPhasCdRow5'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColPhasCdRow5Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColPhasCdRow5Info, "Text", "102");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum2) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColdtPhasBisRow5'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColdtPhasBisRow5Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColdtPhasBisRow5Info, "Text", bis_Datum2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColPhasStatusExtRow5'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColPhasStatusExtRow5Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_5.ColPhasStatusExtRow5Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='200') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColPhasCdRow6'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColPhasCdRow6Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColPhasCdRow6Info, "Text", "200");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum2) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColdtPhasBisRow6'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColdtPhasBisRow6Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColdtPhasBisRow6Info, "Text", bis_Datum2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColPhasStatusExtRow6'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColPhasStatusExtRow6Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_6.ColPhasStatusExtRow6Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='201') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColPhasCdRow7'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColPhasCdRow7Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColPhasCdRow7Info, "Text", "201");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum2) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColdtPhasBisRow7'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColdtPhasBisRow7Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColdtPhasBisRow7Info, "Text", bis_Datum2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColPhasStatusExtRow7'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColPhasStatusExtRow7Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_7.ColPhasStatusExtRow7Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='202') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColPhasCdRow8'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColPhasCdRow8Info, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColPhasCdRow8Info, "Text", "202");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum2) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColdtPhasBisRow8'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColdtPhasBisRow8Info, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColdtPhasBisRow8Info, "Text", bis_Datum2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColPhasStatusExtRow8'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColPhasStatusExtRow8Info, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_8.ColPhasStatusExtRow8Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='300') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColPhasCdRow9'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColPhasCdRow9Info, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColPhasCdRow9Info, "Text", "300");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColdtPhasBisRow9'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColdtPhasBisRow9Info, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColdtPhasBisRow9Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColPhasStatusExtRow9'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColPhasStatusExtRow9Info, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_9.ColPhasStatusExtRow9Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColPhasCdRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColPhasCdRow10Info, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColPhasCdRow10Info, "Text", "20");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$bis_Datum) on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColdtPhasBisRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColdtPhasBisRow10Info, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColdtPhasBisRow10Info, "Text", bis_Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColPhasStatusExtRow10'.", repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColPhasStatusExtRow10Info, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Phasen.Phasen_Zeilen.Zeile_10.ColPhasStatusExtRow10Info, "Text", "0");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
