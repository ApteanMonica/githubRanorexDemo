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

namespace B_BUDA_002.Recordings_B_BUAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Dauerbuchungen_verbucht_pruefen recording.
    /// </summary>
    [TestModule("88d6baa9-499d-404c-a6d4-63fecc350e15", ModuleType.Recording, 1)]
    public partial class Dauerbuchungen_verbucht_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUDA_002.B_BUDA_002Repository repository.
        /// </summary>
        public static global::B_BUDA_002.B_BUDA_002Repository repo = global::B_BUDA_002.B_BUDA_002Repository.Instance;

        static Dauerbuchungen_verbucht_pruefen instance = new Dauerbuchungen_verbucht_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Dauerbuchungen_verbucht_pruefen()
        {
            Tagesdatum = "";
            BUDA_Beleg_NR_1 = "B_BUDA_002-0";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Dauerbuchungen_verbucht_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("71faba42-1239-4e1f-acc7-f946f24d3a99")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        string _BUDA_Beleg_NR_1;

        /// <summary>
        /// Gets or sets the value of variable BUDA_Beleg_NR_1.
        /// </summary>
        [TestVariable("63906cb9-9893-4fd6-8df4-0f7c06ffd5f3")]
        public string BUDA_Beleg_NR_1
        {
            get { return _BUDA_Beleg_NR_1; }
            set { _BUDA_Beleg_NR_1 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tagesdatum) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row1Info, new RecordItemIndex(0));
            Validate.AttributeContains(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row1Info, "Text", Tagesdatum);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row1Info, new RecordItemIndex(1));
            //Validate.AttributeContains(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row1Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColBelegnrRow1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColBelegnrRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColBelegnrRow1Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='DABU') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUserRow1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUserRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUserRow1Info, "Text", "DABU");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='RS') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColBusaUserexopRow1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColBusaUserexopRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColBusaUserexopRow1Info, "Text", "RS");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColTypRow1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColTypRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColTypRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColStatusRow1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColStatusRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColStatusRow1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='22') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColJahrRow1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColJahrRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColJahrRow1Info, "Text", "22");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColPeriRow1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColPeriRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColPeriRow1Info, "Text", "1");
            
            // Kostenstelle
            Report.Log(ReportLevel.Info, "Validation", "Kostenstelle\r\nValidating AttributeEqual (Text='20 +') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColCd1Row1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColCd1Row1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColCd1Row1Info, "Text", "20 +");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2.188,00') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColBetragRow1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColBetragRow1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColBetragRow1Info, "Text", "2.188,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUstbetragRow1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUstbetragRow1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUstbetragRow1Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2.188,00') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColBruttoRow1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColBruttoRow1Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColBruttoRow1Info, "Text", "2.188,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2022-1') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUvaRow1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUvaRow1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUvaRow1Info, "Text", "2022-1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUstcdRow1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUstcdRow1Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUstcdRow1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUstsatzRow1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUstsatzRow1Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUstsatzRow1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUstmvRow1'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUstmvRow1Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_1.ColUstmvRow1Info, "Text", "");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row2'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row2Info, new RecordItemIndex(17));
            //Validate.AttributeContains(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row2Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColBelegnrRow2'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColBelegnrRow2Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColBelegnrRow2Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20 +') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColCd1Row2'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColCd1Row2Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColCd1Row2Info, "Text", "20 +");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='990,00') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColBetragRow2'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColBetragRow2Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColBetragRow2Info, "Text", "990,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='198,00') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUstbetragRow2'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUstbetragRow2Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUstbetragRow2Info, "Text", "198,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.188,00') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColBruttoRow2'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColBruttoRow2Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColBruttoRow2Info, "Text", "1.188,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2022-1') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUvaRow2'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUvaRow2Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUvaRow2Info, "Text", "2022-1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V20') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUstcdRow2'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUstcdRow2Info, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUstcdRow2Info, "Text", "V20");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUstmvRow2'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUstmvRow2Info, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUstmvRow2Info, "Text", "V");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUstsatzRow2'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUstsatzRow2Info, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_2.ColUstsatzRow2Info, "Text", "20");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row3'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row3Info, new RecordItemIndex(27));
            //Validate.AttributeContains(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row3Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColBelegnrRow3'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColBelegnrRow3Info, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColBelegnrRow3Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='40') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColCd1Row3'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColCd1Row3Info, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColCd1Row3Info, "Text", "40");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='990,96') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColBetragRow3'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColBetragRow3Info, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColBetragRow3Info, "Text", "990,96");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='198,19') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUstbetragRow3'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUstbetragRow3Info, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUstbetragRow3Info, "Text", "198,19");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='990,96') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColBruttoRow3'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColBruttoRow3Info, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColBruttoRow3Info, "Text", "990,96");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2022-1') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUvaRow3'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUvaRow3Info, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUvaRow3Info, "Text", "2022-1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='E20') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUstcdRow3'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUstcdRow3Info, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUstcdRow3Info, "Text", "E20");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='E') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUstmvRow3'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUstmvRow3Info, new RecordItemIndex(35));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUstmvRow3Info, "Text", "E");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUstsatzRow3'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUstsatzRow3Info, new RecordItemIndex(36));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_3.ColUstsatzRow3Info, "Text", "20");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row4'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row4Info, new RecordItemIndex(37));
            //Validate.AttributeContains(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row4Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColBelegnrRow4'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColBelegnrRow4Info, new RecordItemIndex(38));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColBelegnrRow4Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColCd1Row4'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColCd1Row4Info, new RecordItemIndex(39));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColCd1Row4Info, "Text", "20");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='9,04') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColBetragRow4'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColBetragRow4Info, new RecordItemIndex(40));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColBetragRow4Info, "Text", "9,04");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1,81') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUstbetragRow4'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUstbetragRow4Info, new RecordItemIndex(41));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUstbetragRow4Info, "Text", "1,81");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='9,04') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColBruttoRow4'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColBruttoRow4Info, new RecordItemIndex(42));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColBruttoRow4Info, "Text", "9,04");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2022-1') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUvaRow4'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUvaRow4Info, new RecordItemIndex(43));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUvaRow4Info, "Text", "2022-1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='E20') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUstcdRow4'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUstcdRow4Info, new RecordItemIndex(44));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUstcdRow4Info, "Text", "E20");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='E') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUstmvRow4'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUstmvRow4Info, new RecordItemIndex(45));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUstmvRow4Info, "Text", "E");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUstsatzRow4'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUstsatzRow4Info, new RecordItemIndex(46));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_4.ColUstsatzRow4Info, "Text", "20");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row5'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row5Info, new RecordItemIndex(47));
            //Validate.AttributeContains(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row5Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColBelegnrRow5'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColBelegnrRow5Info, new RecordItemIndex(48));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColBelegnrRow5Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColStatusRow5'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColStatusRow5Info, new RecordItemIndex(49));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColStatusRow5Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='22') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColJahrRow5'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColJahrRow5Info, new RecordItemIndex(50));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColJahrRow5Info, "Text", "22");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColPeriRow5'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColPeriRow5Info, new RecordItemIndex(51));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColPeriRow5Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2022-2') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColUvaRow5'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColUvaRow5Info, new RecordItemIndex(52));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColUvaRow5Info, "Text", "2022-2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20 +') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColCd1Row5'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColCd1Row5Info, new RecordItemIndex(53));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_5.ColCd1Row5Info, "Text", "20 +");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row6'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row6Info, new RecordItemIndex(54));
            //Validate.AttributeContains(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row6Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_6.ColBelegnrRow6'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_6.ColBelegnrRow6Info, new RecordItemIndex(55));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_6.ColBelegnrRow6Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2022-2') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_6.ColUvaRow6'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_6.ColUvaRow6Info, new RecordItemIndex(56));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_6.ColUvaRow6Info, "Text", "2022-2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20 +') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_6.ColCd1Row6'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_6.ColCd1Row6Info, new RecordItemIndex(57));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_6.ColCd1Row6Info, "Text", "20 +");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row7'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row7Info, new RecordItemIndex(58));
            //Validate.AttributeContains(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row7Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_7.ColBelegnrRow7'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_7.ColBelegnrRow7Info, new RecordItemIndex(59));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_7.ColBelegnrRow7Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2022-2') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_7.ColUvaRow7'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_7.ColUvaRow7Info, new RecordItemIndex(60));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_7.ColUvaRow7Info, "Text", "2022-2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='40') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_7.ColCd1Row7'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_7.ColCd1Row7Info, new RecordItemIndex(61));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_7.ColCd1Row7Info, "Text", "40");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row8'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row8Info, new RecordItemIndex(62));
            //Validate.AttributeContains(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row8Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$BUDA_Beleg_NR_1) on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_8.ColBelegnrRow8'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_8.ColBelegnrRow8Info, new RecordItemIndex(63));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_8.ColBelegnrRow8Info, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2022-2') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_8.ColUvaRow8'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_8.ColUvaRow8Info, new RecordItemIndex(64));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_8.ColUvaRow8Info, "Text", "2022-2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20') on item 'tblB_Form100BuchungenAnzeigen.FlexGrid.Row_8.ColCd1Row8'.", repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_8.ColCd1Row8Info, new RecordItemIndex(65));
            Validate.AttributeEqual(repo.tblB_Form100BuchungenAnzeigen.FlexGrid.Row_8.ColCd1Row8Info, "Text", "20");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
