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

namespace K_VERR_001.Recordings_K_IBUFE
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The k_ibufe_Stufe_0_Fibu_Daten_pruefen recording.
    /// </summary>
    [TestModule("5f87688b-2966-4263-b52f-f5a0dba4a8cb", ModuleType.Recording, 1)]
    public partial class K_ibufe_Stufe_0_Fibu_Daten_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_VERR_001.K_VERR_001Repository repository.
        /// </summary>
        public static global::K_VERR_001.K_VERR_001Repository repo = global::K_VERR_001.K_VERR_001Repository.Instance;

        static K_ibufe_Stufe_0_Fibu_Daten_pruefen instance = new K_ibufe_Stufe_0_Fibu_Daten_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public K_ibufe_Stufe_0_Fibu_Daten_pruefen()
        {
            KontoB = "B1000";
            KontoE = "E1000";
            Kostenstelle = "10";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static K_ibufe_Stufe_0_Fibu_Daten_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _KontoB;

        /// <summary>
        /// Gets or sets the value of variable KontoB.
        /// </summary>
        [TestVariable("27523636-3096-44ff-a05b-3fa1322052be")]
        public string KontoB
        {
            get { return _KontoB; }
            set { _KontoB = value; }
        }

        string _KontoE;

        /// <summary>
        /// Gets or sets the value of variable KontoE.
        /// </summary>
        [TestVariable("0db7a414-f3b5-41a2-ba28-e3caf0c44060")]
        public string KontoE
        {
            get { return _KontoE; }
            set { _KontoE = value; }
        }

        string _Kostenstelle;

        /// <summary>
        /// Gets or sets the value of variable Kostenstelle.
        /// </summary>
        [TestVariable("a43fea86-5c39-4159-8603-33f1e56feadd")]
        public string Kostenstelle
        {
            get { return _Kostenstelle; }
            set { _Kostenstelle = value; }
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

            // Zeile 1
            Report.Log(ReportLevel.Info, "Section", "Zeile 1", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='6.2020') on item 'TblIbufe.Row_1.ColJahrPeriodeRow1'.", repo.TblIbufe.Row_1.ColJahrPeriodeRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblIbufe.Row_1.ColJahrPeriodeRow1Info, "Text", "6.2020");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'TblIbufe.Row_1.ColVestNrRow1'.", repo.TblIbufe.Row_1.ColVestNrRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblIbufe.Row_1.ColVestNrRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KontoB) on item 'TblIbufe.Row_1.ColKontoRow1'.", repo.TblIbufe.Row_1.ColKontoRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblIbufe.Row_1.ColKontoRow1Info, "Text", KontoB);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='99') on item 'TblIbufe.Row_1.ColKs1NrRow1'.", repo.TblIbufe.Row_1.ColKs1NrRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblIbufe.Row_1.ColKs1NrRow1Info, "Text", "99");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='9999') on item 'TblIbufe.Row_1.ColKs2NrRow1'.", repo.TblIbufe.Row_1.ColKs2NrRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblIbufe.Row_1.ColKs2NrRow1Info, "Text", "9999");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='99999') on item 'TblIbufe.Row_1.ColKs3NrRow1'.", repo.TblIbufe.Row_1.ColKs3NrRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblIbufe.Row_1.ColKs3NrRow1Info, "Text", "99999");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='999') on item 'TblIbufe.Row_1.ColKs4NrRow1'.", repo.TblIbufe.Row_1.ColKs4NrRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblIbufe.Row_1.ColKs4NrRow1Info, "Text", "999");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10.000,00') on item 'TblIbufe.Row_1.ColIbuSollRow1'.", repo.TblIbufe.Row_1.ColIbuSollRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblIbufe.Row_1.ColIbuSollRow1Info, "Text", "10.000,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'TblIbufe.Row_1.ColIbuHabenRow1'.", repo.TblIbufe.Row_1.ColIbuHabenRow1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblIbufe.Row_1.ColIbuHabenRow1Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10.000,00') on item 'TblIbufe.Row_1.ColBetragRow1'.", repo.TblIbufe.Row_1.ColBetragRow1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblIbufe.Row_1.ColBetragRow1Info, "Text", "10.000,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'TblIbufe.Row_1.ColMengeRow1'.", repo.TblIbufe.Row_1.ColMengeRow1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblIbufe.Row_1.ColMengeRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'TblIbufe.Row_1.ColHerkunftRow1'.", repo.TblIbufe.Row_1.ColHerkunftRow1Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblIbufe.Row_1.ColHerkunftRow1Info, "Text", "0");
            
            // Zeile 2
            Report.Log(ReportLevel.Info, "Section", "Zeile 2", new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='6.2020') on item 'TblIbufe.Row_2.ColJahrPeriodeRow2'.", repo.TblIbufe.Row_2.ColJahrPeriodeRow2Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.TblIbufe.Row_2.ColJahrPeriodeRow2Info, "Text", "6.2020");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'TblIbufe.Row_2.ColVestNrRow2'.", repo.TblIbufe.Row_2.ColVestNrRow2Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.TblIbufe.Row_2.ColVestNrRow2Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KontoE) on item 'TblIbufe.Row_2.ColKontoRow2'.", repo.TblIbufe.Row_2.ColKontoRow2Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.TblIbufe.Row_2.ColKontoRow2Info, "Text", KontoE);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kostenstelle) on item 'TblIbufe.Row_2.ColKs1NrRow2'.", repo.TblIbufe.Row_2.ColKs1NrRow2Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.TblIbufe.Row_2.ColKs1NrRow2Info, "Text", Kostenstelle);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='9999') on item 'TblIbufe.Row_2.ColKs2NrRow2'.", repo.TblIbufe.Row_2.ColKs2NrRow2Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.TblIbufe.Row_2.ColKs2NrRow2Info, "Text", "9999");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='99999') on item 'TblIbufe.Row_2.ColKs3NrRow2'.", repo.TblIbufe.Row_2.ColKs3NrRow2Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.TblIbufe.Row_2.ColKs3NrRow2Info, "Text", "99999");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='999') on item 'TblIbufe.Row_2.ColKs4NrRow2'.", repo.TblIbufe.Row_2.ColKs4NrRow2Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.TblIbufe.Row_2.ColKs4NrRow2Info, "Text", "999");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'TblIbufe.Row_2.ColIbuSollRow2'.", repo.TblIbufe.Row_2.ColIbuSollRow2Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.TblIbufe.Row_2.ColIbuSollRow2Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10.000,00') on item 'TblIbufe.Row_2.ColIbuHabenRow2'.", repo.TblIbufe.Row_2.ColIbuHabenRow2Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.TblIbufe.Row_2.ColIbuHabenRow2Info, "Text", "10.000,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10.000,00') on item 'TblIbufe.Row_2.ColBetragRow2'.", repo.TblIbufe.Row_2.ColBetragRow2Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.TblIbufe.Row_2.ColBetragRow2Info, "Text", "10.000,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'TblIbufe.Row_2.ColMengeRow2'.", repo.TblIbufe.Row_2.ColMengeRow2Info, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.TblIbufe.Row_2.ColMengeRow2Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'TblIbufe.Row_2.ColHerkunftRow2'.", repo.TblIbufe.Row_2.ColHerkunftRow2Info, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.TblIbufe.Row_2.ColHerkunftRow2Info, "Text", "0");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
