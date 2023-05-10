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

namespace B_ZAHL_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OPs_in_Zahlungsvorschlag_B_ZAHL_001_pruefen recording.
    /// </summary>
    [TestModule("045d0d4c-0270-404b-b975-27acf563d262", ModuleType.Recording, 1)]
    public partial class OPs_in_Zahlungsvorschlag_B_ZAHL_001_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_001.B_ZAHL_001Repository repository.
        /// </summary>
        public static global::B_ZAHL_001.B_ZAHL_001Repository repo = global::B_ZAHL_001.B_ZAHL_001Repository.Instance;

        static OPs_in_Zahlungsvorschlag_B_ZAHL_001_pruefen instance = new OPs_in_Zahlungsvorschlag_B_ZAHL_001_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OPs_in_Zahlungsvorschlag_B_ZAHL_001_pruefen()
        {
            LF_303040 = "303040";
            LF_303041_DIV = "303041";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OPs_in_Zahlungsvorschlag_B_ZAHL_001_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _LF_303040;

        /// <summary>
        /// Gets or sets the value of variable LF_303040.
        /// </summary>
        [TestVariable("a9e1b270-b1cf-4e35-a169-9574c7af3d74")]
        public string LF_303040
        {
            get { return _LF_303040; }
            set { _LF_303040 = value; }
        }

        string _LF_303041_DIV;

        /// <summary>
        /// Gets or sets the value of variable LF_303041_DIV.
        /// </summary>
        [TestVariable("287f1f00-79ac-46c2-9291-4ad38573e6f9")]
        public string LF_303041_DIV
        {
            get { return _LF_303041_DIV; }
            set { _LF_303041_DIV = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColAdrNrRow1'", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColAdrNrRow1Info, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColAdrNrRow1Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_303040) on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColAdrNrRow1'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColAdrNrRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColAdrNrRow1Info, "Text", LF_303040);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColKldvNrRow1'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColKldvNrRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColKldvNrRow1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER042 B_ZAHL_001') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColBelegRow1'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColBelegRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColBelegRow1Info, "Text", "ER042 B_ZAHL_001");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.176,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColZBetragZRow1'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColZBetragZRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColZBetragZRow1Info, "Text", "1.176,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='24,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColSBetragZRow1'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColSBetragZRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColSBetragZRow1Info, "Text", "24,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColSProzRow1'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColSProzRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColSProzRow1Info, "Text", "2,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.200,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColOffenZRow1'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColOffenZRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColOffenZRow1Info, "Text", "1.200,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColKlbkNrZahlungRow1'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColKlbkNrZahlungRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColKlbkNrZahlungRow1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Überweisungstext 303040') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColText1Row1'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColText1Row1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColText1Row1Info, "Text", "Überweisungstext 303040");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_303040) on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColAdrNrRow2'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColAdrNrRow2Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColAdrNrRow2Info, "Text", LF_303040);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColKldvNrRow2'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColKldvNrRow2Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColKldvNrRow2Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER044 B_ZAHL_001') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColBelegRow2'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColBelegRow2Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColBelegRow2Info, "Text", "ER044 B_ZAHL_001");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.800,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColZBetragZRow2'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColZBetragZRow2Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColZBetragZRow2Info, "Text", "1.800,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColSBetragZRow2'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColSBetragZRow2Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColSBetragZRow2Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColSProzRow2'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColSProzRow2Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColSProzRow2Info, "Text", "2,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.800,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColOffenZRow2'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColOffenZRow2Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColOffenZRow2Info, "Text", "1.800,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColKlbkNrZahlungRow2'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColKlbkNrZahlungRow2Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_2.ColKlbkNrZahlungRow2Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_303040) on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColAdrNrRow3'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColAdrNrRow3Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColAdrNrRow3Info, "Text", LF_303040);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColKldvNrRow3'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColKldvNrRow3Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColKldvNrRow3Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER043 B_ZAHL_001') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColBelegRow3'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColBelegRow3Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColBelegRow3Info, "Text", "ER043 B_ZAHL_001");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='588,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColZBetragZRow3'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColZBetragZRow3Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColZBetragZRow3Info, "Text", "588,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='12,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColSBetragZRow3'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColSBetragZRow3Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColSBetragZRow3Info, "Text", "12,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColSProzRow3'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColSProzRow3Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColSProzRow3Info, "Text", "2,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='600,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColOffenZRow3'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColOffenZRow3Info, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColOffenZRow3Info, "Text", "600,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColKlbkNrZahlungRow3'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColKlbkNrZahlungRow3Info, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColKlbkNrZahlungRow3Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_303040) on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColAdrNrRow3'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColAdrNrRow3Info, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColAdrNrRow3Info, "Text", LF_303040);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColKldvNrRow3'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColKldvNrRow3Info, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_3.ColKldvNrRow3Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='GS008 B_ZAHL_001') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColBelegRow4'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColBelegRow4Info, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColBelegRow4Info, "Text", "GS008 B_ZAHL_001");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='-120,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColZBetragZRow4'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColZBetragZRow4Info, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColZBetragZRow4Info, "Text", "-120,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColSBetragZRow4'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColSBetragZRow4Info, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColSBetragZRow4Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColSProzRow4'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColSProzRow4Info, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColSProzRow4Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='-120,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColOffenZRow4'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColOffenZRow4Info, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColOffenZRow4Info, "Text", "-120,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColKlbkNrZahlungRow4'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColKlbkNrZahlungRow4Info, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_4.ColKlbkNrZahlungRow4Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_303041_DIV) on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColAdrNrRow5'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColAdrNrRow5Info, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColAdrNrRow5Info, "Text", LF_303041_DIV);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColKldvNrRow5'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColKldvNrRow5Info, new RecordItemIndex(35));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColKldvNrRow5Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER045 B_ZAHL_001') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColBelegRow5'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColBelegRow5Info, new RecordItemIndex(36));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColBelegRow5Info, "Text", "ER045 B_ZAHL_001");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2.376,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColZBetragZRow5'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColZBetragZRow5Info, new RecordItemIndex(37));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColZBetragZRow5Info, "Text", "2.376,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='24,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColSBetragZRow5'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColSBetragZRow5Info, new RecordItemIndex(38));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColSBetragZRow5Info, "Text", "24,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColSProzRow5'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColSProzRow5Info, new RecordItemIndex(39));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColSProzRow5Info, "Text", "2,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2.400,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColOffenZRow5'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColOffenZRow5Info, new RecordItemIndex(40));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColOffenZRow5Info, "Text", "2.400,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColKlbkNrZahlungRow5'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColKlbkNrZahlungRow5Info, new RecordItemIndex(41));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColKlbkNrZahlungRow5Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='AT61 1904 3002 3457 3201') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColKlbkIbanRow5'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColKlbkIbanRow5Info, new RecordItemIndex(42));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_5.ColKlbkIbanRow5Info, "Text", "AT61 1904 3002 3457 3201");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_303041_DIV) on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColAdrNrRow6'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColAdrNrRow6Info, new RecordItemIndex(43));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColAdrNrRow6Info, "Text", LF_303041_DIV);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColKldvNrRow6'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColKldvNrRow6Info, new RecordItemIndex(44));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColKldvNrRow6Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='GS009 B_ZAHL_001') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColBelegRow6'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColBelegRow6Info, new RecordItemIndex(45));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColBelegRow6Info, "Text", "GS009 B_ZAHL_001");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='-1.800,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColZBetragZRow6'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColZBetragZRow6Info, new RecordItemIndex(46));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColZBetragZRow6Info, "Text", "-1.800,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColSBetragZRow6'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColSBetragZRow6Info, new RecordItemIndex(47));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColSBetragZRow6Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColSProzRow6'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColSProzRow6Info, new RecordItemIndex(48));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColSProzRow6Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='-1.800,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColOffenZRow6'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColOffenZRow6Info, new RecordItemIndex(49));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColOffenZRow6Info, "Text", "-1.800,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColKlbkNrZahlungRow6'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColKlbkNrZahlungRow6Info, new RecordItemIndex(50));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColKlbkNrZahlungRow6Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='DE02 5001 0517 0137 0750 30') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColKlbkIbanRow6'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColKlbkIbanRow6Info, new RecordItemIndex(51));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColKlbkIbanRow6Info, "Text", "DE02 5001 0517 0137 0750 30");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Überweisungstext 303041 DIV-2') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColText1Row6'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColText1Row6Info, new RecordItemIndex(52));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_6.ColText1Row6Info, "Text", "Überweisungstext 303041 DIV-2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_303041_DIV) on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColAdrNrRow7'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColAdrNrRow7Info, new RecordItemIndex(53));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColAdrNrRow7Info, "Text", LF_303041_DIV);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColKldvNrRow7'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColKldvNrRow7Info, new RecordItemIndex(54));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColKldvNrRow7Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER046 B_ZAHL_001') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColBelegRow7'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColBelegRow7Info, new RecordItemIndex(55));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColBelegRow7Info, "Text", "ER046 B_ZAHL_001");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.764,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColZBetragZRow7'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColZBetragZRow7Info, new RecordItemIndex(56));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColZBetragZRow7Info, "Text", "1.764,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='36,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColSBetragZRow7'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColSBetragZRow7Info, new RecordItemIndex(57));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColSBetragZRow7Info, "Text", "36,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColSProzRow7'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColSProzRow7Info, new RecordItemIndex(58));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColSProzRow7Info, "Text", "2,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.800,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColOffenZRow7'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColOffenZRow7Info, new RecordItemIndex(59));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColOffenZRow7Info, "Text", "1.800,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColKlbkNrZahlungRow7'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColKlbkNrZahlungRow7Info, new RecordItemIndex(60));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColKlbkNrZahlungRow7Info, "Text", "3");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
