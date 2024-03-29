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

namespace B_ERBU_002.Recordings_B_EXOPS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ERs_in_Schnittstelle_pruefen recording.
    /// </summary>
    [TestModule("4fb484e2-bfba-4df1-9441-30cf71b55e15", ModuleType.Recording, 1)]
    public partial class ERs_in_Schnittstelle_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ERBU_002.B_ERBU_002Repository repository.
        /// </summary>
        public static global::B_ERBU_002.B_ERBU_002Repository repo = global::B_ERBU_002.B_ERBU_002Repository.Instance;

        static ERs_in_Schnittstelle_pruefen instance = new ERs_in_Schnittstelle_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ERs_in_Schnittstelle_pruefen()
        {
            ER_1 = "2200005";
            ER_2 = "2200006";
            ER_3 = "2200007";
            ER_4 = "2200008";
            ER_5 = "2200009";
            Tagesdatum = "";
            LF_303101 = "303101";
            LF_303102_DIV = "303102";
            LF_303103 = "303103";
            Jahr = "2022";
            Monat = "12";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ERs_in_Schnittstelle_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _ER_1;

        /// <summary>
        /// Gets or sets the value of variable ER_1.
        /// </summary>
        [TestVariable("d45c1c02-e13a-42a8-b95e-80391f975d0e")]
        public string ER_1
        {
            get { return _ER_1; }
            set { _ER_1 = value; }
        }

        string _ER_2;

        /// <summary>
        /// Gets or sets the value of variable ER_2.
        /// </summary>
        [TestVariable("af0084a8-4390-410a-aa44-aa2624a444fe")]
        public string ER_2
        {
            get { return _ER_2; }
            set { _ER_2 = value; }
        }

        string _ER_3;

        /// <summary>
        /// Gets or sets the value of variable ER_3.
        /// </summary>
        [TestVariable("66c81dc5-4168-4af0-a0d5-cdc147b2cef6")]
        public string ER_3
        {
            get { return _ER_3; }
            set { _ER_3 = value; }
        }

        string _ER_4;

        /// <summary>
        /// Gets or sets the value of variable ER_4.
        /// </summary>
        [TestVariable("d1c1089e-165b-45a6-9283-bac675e45061")]
        public string ER_4
        {
            get { return _ER_4; }
            set { _ER_4 = value; }
        }

        string _ER_5;

        /// <summary>
        /// Gets or sets the value of variable ER_5.
        /// </summary>
        [TestVariable("89c4c173-5849-4a4a-9c41-7e055f947081")]
        public string ER_5
        {
            get { return _ER_5; }
            set { _ER_5 = value; }
        }

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("595a2f0c-7525-41b9-b64a-e23c5d1cfee2")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        string _LF_303101;

        /// <summary>
        /// Gets or sets the value of variable LF_303101.
        /// </summary>
        [TestVariable("6a886a91-3b5a-4c3a-a534-521834f963f7")]
        public string LF_303101
        {
            get { return _LF_303101; }
            set { _LF_303101 = value; }
        }

        string _LF_303102_DIV;

        /// <summary>
        /// Gets or sets the value of variable LF_303102_DIV.
        /// </summary>
        [TestVariable("b79bc227-4042-4343-803d-fbe9d3c94af9")]
        public string LF_303102_DIV
        {
            get { return _LF_303102_DIV; }
            set { _LF_303102_DIV = value; }
        }

        string _LF_303103;

        /// <summary>
        /// Gets or sets the value of variable LF_303103.
        /// </summary>
        [TestVariable("af3c9611-67fc-4824-82a5-21eeb8711d93")]
        public string LF_303103
        {
            get { return _LF_303103; }
            set { _LF_303103 = value; }
        }

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("6ebefc2b-e19b-4584-8305-d6a57f02cef7")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Monat;

        /// <summary>
        /// Gets or sets the value of variable Monat.
        /// </summary>
        [TestVariable("0ff45ca9-a742-4b22-955f-a790b260f108")]
        public string Monat
        {
            get { return _Monat; }
            set { _Monat = value; }
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

            // Zeile_1
            Report.Log(ReportLevel.Info, "Section", "Zeile_1", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ER_1) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBelegnrRow1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBelegnrRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBelegnrRow1Info, "Text", ER_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$LF_303101) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColAdrNrRow1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColAdrNrRow1Info, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColAdrNrRow1Info, "Text", LF_303101);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tagesdatum) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopDtherkunftRow1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopDtherkunftRow1Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopDtherkunftRow1Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'R') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopArtRow1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopArtRow1Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopArtRow1Info, "Text", "R");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'ER') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBusyRow1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBusyRow1Info, new RecordItemIndex(5));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBusyRow1Info, "Text", "ER");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'1') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColKlbkNrRow1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColKlbkNrRow1Info, new RecordItemIndex(6));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColKlbkNrRow1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Jahr) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopJahrRow1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopJahrRow1Info, new RecordItemIndex(7));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopJahrRow1Info, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Monat) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopPeriodeRow1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopPeriodeRow1Info, new RecordItemIndex(8));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopPeriodeRow1Info, "Text", Monat);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'2.300,00') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBetragRow1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBetragRow1Info, new RecordItemIndex(9));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBetragRow1Info, "Text", "2.300,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'5701+') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExsaKtoNrRow1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExsaKtoNrRow1Info, new RecordItemIndex(10));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExsaKtoNrRow1Info, "Text", "5701+");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'30+') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExsaBektNr1Row1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExsaBektNr1Row1Info, new RecordItemIndex(11));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExsaBektNr1Row1Info, "Text", "30+");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'31.12.2022') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopDtfaelligRow1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopDtfaelligRow1Info, new RecordItemIndex(12));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopDtfaelligRow1Info, "Text", "31.12.2022");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'14') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopTage1Row1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopTage1Row1Info, new RecordItemIndex(13));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopTage1Row1Info, "Text", "14");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'2,00') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopSkonto1Row1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopSkonto1Row1Info, new RecordItemIndex(14));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopSkonto1Row1Info, "Text", "2,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'30') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopTagenettoRow1'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopTagenettoRow1Info, new RecordItemIndex(15));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopTagenettoRow1Info, "Text", "30");
            
            // Zeile_2
            Report.Log(ReportLevel.Info, "Section", "Zeile_2", new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ER_2) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBelegnrRow2'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBelegnrRow2Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBelegnrRow2Info, "Text", ER_2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$LF_303102_DIV) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColAdrNrRow2'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColAdrNrRow2Info, new RecordItemIndex(18));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColAdrNrRow2Info, "Text", LF_303102_DIV);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'2') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColKldvNrRow2'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColKldvNrRow2Info, new RecordItemIndex(19));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColKldvNrRow2Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'3') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColKlbkNrRow2'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColKlbkNrRow2Info, new RecordItemIndex(20));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColKlbkNrRow2Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'600,00') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBetragRow2'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBetragRow2Info, new RecordItemIndex(21));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBetragRow2Info, "Text", "600,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'5702') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExsaKtoNrRow2'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExsaKtoNrRow2Info, new RecordItemIndex(22));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExsaKtoNrRow2Info, "Text", "5702");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'30+') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExsaBektNr1Row2'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExsaBektNr1Row2Info, new RecordItemIndex(23));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExsaBektNr1Row2Info, "Text", "30+");
            
            // Zeile_3
            Report.Log(ReportLevel.Info, "Section", "Zeile_3", new RecordItemIndex(24));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ER_3) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBelegnrRow3'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBelegnrRow3Info, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBelegnrRow3Info, "Text", ER_3);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$LF_303103) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColAdrNrRow3'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColAdrNrRow3Info, new RecordItemIndex(26));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColAdrNrRow3Info, "Text", LF_303103);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'2') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColKlbkNrRow3'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColKlbkNrRow3Info, new RecordItemIndex(27));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColKlbkNrRow3Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'12.000,00') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBetragRow3'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBetragRow3Info, new RecordItemIndex(28));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBetragRow3Info, "Text", "12.000,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'5703') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExsaKtoNrRow3'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExsaKtoNrRow3Info, new RecordItemIndex(29));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExsaKtoNrRow3Info, "Text", "5703");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'50') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExsaBektNr1Row3'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExsaBektNr1Row3Info, new RecordItemIndex(30));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExsaBektNr1Row3Info, "Text", "50");
            
            // Zeile_4
            Report.Log(ReportLevel.Info, "Section", "Zeile_4", new RecordItemIndex(31));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ER_4) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopBelegnrRow4'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopBelegnrRow4Info, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopBelegnrRow4Info, "Text", ER_4);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$LF_303103) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColAdrNrRow4'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColAdrNrRow4Info, new RecordItemIndex(33));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColAdrNrRow4Info, "Text", LF_303103);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'2.400,00') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopBetragRow4'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopBetragRow4Info, new RecordItemIndex(34));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopBetragRow4Info, "Text", "2.400,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'5703') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExsaKtoNrRow4'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExsaKtoNrRow4Info, new RecordItemIndex(35));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExsaKtoNrRow4Info, "Text", "5703");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'50') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExsaBektNr1Row4'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExsaBektNr1Row4Info, new RecordItemIndex(36));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExsaBektNr1Row4Info, "Text", "50");
            
            // Zeile_5
            Report.Log(ReportLevel.Info, "Section", "Zeile_5", new RecordItemIndex(37));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ER_5) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBelegnrRow5'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBelegnrRow5Info, new RecordItemIndex(38));
            Validate.AttributeEqual(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBelegnrRow5Info, "Text", ER_5);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$LF_303103) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColAdrNrRow5'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColAdrNrRow5Info, new RecordItemIndex(39));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColAdrNrRow5Info, "Text", LF_303103);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tagesdatum) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopDtherkunftRow5'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopDtherkunftRow5Info, new RecordItemIndex(40));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopDtherkunftRow5Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'G') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopArtRow5'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopArtRow5Info, new RecordItemIndex(41));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopArtRow5Info, "Text", "G");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'ERG') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBusyRow5'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBusyRow5Info, new RecordItemIndex(42));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBusyRow5Info, "Text", "ERG");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Jahr) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopJahrRow5'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopJahrRow5Info, new RecordItemIndex(43));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopJahrRow5Info, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Monat) on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopPeriodeRow5'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopPeriodeRow5Info, new RecordItemIndex(44));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopPeriodeRow5Info, "Text", Monat);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'3.600,00') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBetragRow5'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBetragRow5Info, new RecordItemIndex(45));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBetragRow5Info, "Text", "3.600,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'5703') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExsaKtoNrRow5'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExsaKtoNrRow5Info, new RecordItemIndex(46));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExsaKtoNrRow5Info, "Text", "5703");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'50') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExsaBektNr1Row5'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExsaBektNr1Row5Info, new RecordItemIndex(47));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExsaBektNr1Row5Info, "Text", "50");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'04.01.2023') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopDtfaelligRow5'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopDtfaelligRow5Info, new RecordItemIndex(48));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopDtfaelligRow5Info, "Text", "04.01.2023");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopTage1Row5'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopTage1Row5Info, new RecordItemIndex(49));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopTage1Row5Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopSkonto1Row5'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopSkonto1Row5Info, new RecordItemIndex(50));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopSkonto1Row5Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'30') on item 'FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopTagenettoRow5'.", repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopTagenettoRow5Info, new RecordItemIndex(51));
            Validate.AttributeContains(repo.FrmBEXOP.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopTagenettoRow5Info, "Text", "30");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
