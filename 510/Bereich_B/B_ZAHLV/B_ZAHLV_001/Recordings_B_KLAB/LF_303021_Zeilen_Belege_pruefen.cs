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

namespace B_ZAHLV_001.Recordings_B_KLAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LF_303021_Zeilen_Belege_pruefen recording.
    /// </summary>
    [TestModule("e4378ae2-4893-4644-a44b-8a1ac64512e5", ModuleType.Recording, 1)]
    public partial class LF_303021_Zeilen_Belege_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHLV_001.B_ZAHLV_001Repository repository.
        /// </summary>
        public static global::B_ZAHLV_001.B_ZAHLV_001Repository repo = global::B_ZAHLV_001.B_ZAHLV_001Repository.Instance;

        static LF_303021_Zeilen_Belege_pruefen instance = new LF_303021_Zeilen_Belege_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LF_303021_Zeilen_Belege_pruefen()
        {
            LF_303021 = "303021";
            LF_303021_Saldo = "98.400,00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LF_303021_Zeilen_Belege_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _LF_303021;

        /// <summary>
        /// Gets or sets the value of variable LF_303021.
        /// </summary>
        [TestVariable("0e7848df-f32c-4206-b253-109ee2e52740")]
        public string LF_303021
        {
            get { return _LF_303021; }
            set { _LF_303021 = value; }
        }

        string _LF_303021_Saldo;

        /// <summary>
        /// Gets or sets the value of variable LF_303021_Saldo.
        /// </summary>
        [TestVariable("b9a11903-7f03-43cd-833b-4dd98335df6e")]
        public string LF_303021_Saldo
        {
            get { return _LF_303021_Saldo; }
            set { _LF_303021_Saldo = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='R') on item 'TblBuop.Tabelle_OPs.ColArtRow1'.", repo.TblBuop.Tabelle_OPs.ColArtRow1Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColArtRow1Info, "Text", "R");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'TblBuop.Tabelle_OPs.ColOffenRow1'.", repo.TblBuop.Tabelle_OPs.ColOffenRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColOffenRow1Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='R') on item 'TblBuop.Tabelle_OPs.ColArtRow2'.", repo.TblBuop.Tabelle_OPs.ColArtRow2Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColArtRow2Info, "Text", "R");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='73.000,00') on item 'TblBuop.ColOffenRow2'.", repo.TblBuop.ColOffenRow2Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblBuop.ColOffenRow2Info, "Text", "73.000,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='G') on item 'TblBuop.Tabelle_OPs.ColArtRow3'.", repo.TblBuop.Tabelle_OPs.ColArtRow3Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColArtRow3Info, "Text", "G");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'TblBuop.Tabelle_OPs.ColOffenRow3'.", repo.TblBuop.Tabelle_OPs.ColOffenRow3Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColOffenRow3Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='R') on item 'TblBuop.Tabelle_OPs.ColArtRow4'.", repo.TblBuop.Tabelle_OPs.ColArtRow4Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColArtRow4Info, "Text", "R");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='25.400,00') on item 'TblBuop.Tabelle_OPs.ColOffenRow4'.", repo.TblBuop.Tabelle_OPs.ColOffenRow4Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColOffenRow4Info, "Text", "25.400,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='R') on item 'TblBuop.Tabelle_OPs.ColArtRow5'.", repo.TblBuop.Tabelle_OPs.ColArtRow5Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColArtRow5Info, "Text", "R");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'TblBuop.Tabelle_OPs.ColOffenRow5'.", repo.TblBuop.Tabelle_OPs.ColOffenRow5Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColOffenRow5Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='A') on item 'TblBuop.Tabelle_OPs.ColArtRow6'.", repo.TblBuop.Tabelle_OPs.ColArtRow6Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColArtRow6Info, "Text", "A");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='T') on item 'TblBuop.Tabelle_OPs.ColArtRow7'.", repo.TblBuop.Tabelle_OPs.ColArtRow7Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColArtRow7Info, "Text", "T");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='A') on item 'TblBuop.Tabelle_OPs.ColArtRow8'.", repo.TblBuop.Tabelle_OPs.ColArtRow8Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColArtRow8Info, "Text", "A");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='A') on item 'TblBuop.Tabelle_OPs.ColArtRow9'.", repo.TblBuop.Tabelle_OPs.ColArtRow9Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColArtRow9Info, "Text", "A");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='A') on item 'TblBuop.Tabelle_OPs.ColArtRow10'.", repo.TblBuop.Tabelle_OPs.ColArtRow10Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColArtRow10Info, "Text", "A");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'1\tER005 B_ZAHL 303021\t\t\t\tEUR\t\t07.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t73.000,00\t73.000,00\t\t\t73.000,00\t73.000,00\t\t\t100.000,00\t\t\t\t73.000,00\t0\tR\t\t\t\t\t21.01.2021\t\t\t\t21.01.2021\t14\t2,00\t\t02.02.2021\t\tER\t\t\t\t\t\t\t\t\t\t\t\t\t\tER005 B_ZAHL prakt. Skonto UST=R20\t\tER005 B_ZAHL prakt. Skonto UST=R20\tMinderzahlung 25% (Skonto lt. Rechnung)\t\t03.01.2021\t\t07.01.2021\t0\t0,00\t26\t\t2.000,00\t0,00\t0,00\t2.000,00\t0,00\t\t0,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t\t21\t1\tRS\tER005 B_ZAHL 303021\t\t\t\t\t\t\t\tER005 B_ZAHL 303021\tEUR\t21\t1\t\tER005 B_ZAHL 3030211161\t2021-01-07-00.00.00.000000ER005 B_ZAHL 3030211161\t73000\t73000\t73000\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t7778\t3300\t100.000,00\tFalse\t0\t\t\t0\t\t100.000,00\t0,00\tH') on item 'TblBuop.Tabelle_OPs.Row1_OP_Tabelle'.", repo.TblBuop.Tabelle_OPs.Row1_OP_TabelleInfo, new RecordItemIndex(15));
            //Validate.AttributeContains(repo.TblBuop.Tabelle_OPs.Row1_OP_TabelleInfo, "Text", "1\tER005 B_ZAHL 303021\t\t\t\tEUR\t\t07.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t73.000,00\t73.000,00\t\t\t73.000,00\t73.000,00\t\t\t100.000,00\t\t\t\t73.000,00\t0\tR\t\t\t\t\t21.01.2021\t\t\t\t21.01.2021\t14\t2,00\t\t02.02.2021\t\tER\t\t\t\t\t\t\t\t\t\t\t\t\t\tER005 B_ZAHL prakt. Skonto UST=R20\t\tER005 B_ZAHL prakt. Skonto UST=R20\tMinderzahlung 25% (Skonto lt. Rechnung)\t\t03.01.2021\t\t07.01.2021\t0\t0,00\t26\t\t2.000,00\t0,00\t0,00\t2.000,00\t0,00\t\t0,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t\t21\t1\tRS\tER005 B_ZAHL 303021\t\t\t\t\t\t\t\tER005 B_ZAHL 303021\tEUR\t21\t1\t\tER005 B_ZAHL 3030211161\t2021-01-07-00.00.00.000000ER005 B_ZAHL 3030211161\t73000\t73000\t73000\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t7778\t3300\t100.000,00\tFalse\t0\t\t\t0\t\t100.000,00\t0,00\tH");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'2\t1001\t\t\t\tEUR\t\t30.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-25.000,00\t\t\t\t\t0\tA\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOBK\t\t\t\t\t\t\t\t\t\t\t303021\t\t\tAusgleich ER005 B_ZAHL 303021\t\tAusgleich ER005 B_ZAHL 303021  \t\t\t\t\t\t\t\t0\t\t-2.000,00\t0,00\t0,00\t-2.000,00\t0,00\t\t100.000,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tER005 B_ZAHL 303021\t116\t1\t\t\t\t\t\t1001\tEUR\t0\t0\t\tER005 B_ZAHL 3030211322\t2021-01-30-00.00.00.000000ER005 B_ZAHL 3030211322\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2833\t3300\t-25.000,00\tFalse\t0\t\t\t\t\t27.000,00\t0,00\tS') on item 'TblBuop.Tabelle_OPs.Row2_OP_Tabelle'.", repo.TblBuop.Tabelle_OPs.Row2_OP_TabelleInfo, new RecordItemIndex(16));
            //Validate.AttributeContains(repo.TblBuop.Tabelle_OPs.Row2_OP_TabelleInfo, "Text", "2\t1001\t\t\t\tEUR\t\t30.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-25.000,00\t\t\t\t\t0\tA\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOBK\t\t\t\t\t\t\t\t\t\t\t303021\t\t\tAusgleich ER005 B_ZAHL 303021\t\tAusgleich ER005 B_ZAHL 303021  \t\t\t\t\t\t\t\t0\t\t-2.000,00\t0,00\t0,00\t-2.000,00\t0,00\t\t100.000,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tER005 B_ZAHL 303021\t116\t1\t\t\t\t\t\t1001\tEUR\t0\t0\t\tER005 B_ZAHL 3030211322\t2021-01-30-00.00.00.000000ER005 B_ZAHL 3030211322\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2833\t3300\t-25.000,00\tFalse\t0\t\t\t\t\t27.000,00\t0,00\tS");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'1\tER006 B_ZAHL 303021\t\t\t\tEUR\t\t08.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t25.400,00\t25.400,00\t\t\t25.400,00\t25.400,00\t\t\t50.000,00\t\t\t\t98.400,00\t0\tR\t\t\t\t\t22.01.2021\t\t\t\t22.01.2021\t14\t2,00\t\t03.02.2021\t\tER\t\t\t\t\t\t\t\t\t\t\t\t\t\tER005 B_ZAHL Skontobasis 10.000 prakt. Skonto\t\tER005 B_ZAHL Skontobasis 10.000 prakt. Skonto\tTeilzahlung 50% (Skontobasis 10.000)\t\t04.01.2021\t\t08.01.2021\t0\t0,00\t26\t\t100,00\t0,00\t0,00\t100,00\t0,00\t\t-14.600,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tER006 B_ZAHL 303021\t\t\t\t\t\t\t\tER006 B_ZAHL 303021\tEUR\t21\t1\t\tER006 B_ZAHL 3030211171\t2021-01-08-00.00.00.000000ER006 B_ZAHL 3030211171\t25400\t25400\t25400\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t7778\t3300\t50.000,00\tFalse\t0\t\t\t0\t\t50.000,00\t0,00\tH\t\t\t\t\t\t\t\t\t\t\t\t') on item 'TblBuop.Tabelle_OPs.Row3_OP_Tabelle'.", repo.TblBuop.Tabelle_OPs.Row3_OP_TabelleInfo, new RecordItemIndex(17));
            //Validate.AttributeContains(repo.TblBuop.Tabelle_OPs.Row3_OP_TabelleInfo, "Text", "1\tER006 B_ZAHL 303021\t\t\t\tEUR\t\t08.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t25.400,00\t25.400,00\t\t\t25.400,00\t25.400,00\t\t\t50.000,00\t\t\t\t98.400,00\t0\tR\t\t\t\t\t22.01.2021\t\t\t\t22.01.2021\t14\t2,00\t\t03.02.2021\t\tER\t\t\t\t\t\t\t\t\t\t\t\t\t\tER005 B_ZAHL Skontobasis 10.000 prakt. Skonto\t\tER005 B_ZAHL Skontobasis 10.000 prakt. Skonto\tTeilzahlung 50% (Skontobasis 10.000)\t\t04.01.2021\t\t08.01.2021\t0\t0,00\t26\t\t100,00\t0,00\t0,00\t100,00\t0,00\t\t-14.600,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tER006 B_ZAHL 303021\t\t\t\t\t\t\t\tER006 B_ZAHL 303021\tEUR\t21\t1\t\tER006 B_ZAHL 3030211171\t2021-01-08-00.00.00.000000ER006 B_ZAHL 3030211171\t25400\t25400\t25400\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t7778\t3300\t50.000,00\tFalse\t0\t\t\t0\t\t50.000,00\t0,00\tH\t\t\t\t\t\t\t\t\t\t\t\t");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'2\t1001\t\t\t\tEUR\t\t30.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-24.500,00\t\t\t\t\t0\tT\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOBK\t\t\t\t\t\t\t\t\t\t\t303021\t\t\tTeilzahlung ER006 B_ZAHL 303021\t\tTeilzahlung ER006 B_ZAHL 303021  \t\t\t\t\t\t\t\t0\t\t-100,00\t0,00\t0,00\t-100,00\t0,00\t\t24.600,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tER006 B_ZAHL 303021\t117\t1\t\t\t\t\t\t1001\tEUR\t0\t0\t\tER006 B_ZAHL 3030211332\t2021-01-30-00.00.00.000000ER006 B_ZAHL 3030211332\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2833\t3300\t-24.500,00\tFalse\t0\t\t\t\t\t24.600,00\t0,00\tS') on item 'TblBuop.Tabelle_OPs.Row4_OP_Tabelle'.", repo.TblBuop.Tabelle_OPs.Row4_OP_TabelleInfo, new RecordItemIndex(18));
            //Validate.AttributeContains(repo.TblBuop.Tabelle_OPs.Row4_OP_TabelleInfo, "Text", "2\t1001\t\t\t\tEUR\t\t30.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-24.500,00\t\t\t\t\t0\tT\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOBK\t\t\t\t\t\t\t\t\t\t\t303021\t\t\tTeilzahlung ER006 B_ZAHL 303021\t\tTeilzahlung ER006 B_ZAHL 303021  \t\t\t\t\t\t\t\t0\t\t-100,00\t0,00\t0,00\t-100,00\t0,00\t\t24.600,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tER006 B_ZAHL 303021\t117\t1\t\t\t\t\t\t1001\tEUR\t0\t0\t\tER006 B_ZAHL 3030211332\t2021-01-30-00.00.00.000000ER006 B_ZAHL 3030211332\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2833\t3300\t-24.500,00\tFalse\t0\t\t\t\t\t24.600,00\t0,00\tS");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'1\tER007 B_ZAHL 303020\t\t\t\tEUR\t\t08.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t0,00\t0,00\t\t\t0,00\t0,00\t\t\t3.000,00\t\t\t\t98.400,00\t0\tR\t\t\t\t\t\t\t\t\t22.01.2021\t14\t2,00\t\t01.02.2021\t\tER\t\t\t\t\t\t\t\t\t\t\t\t\t\tER007 B_ZAHL theor. Skonto UST=R20\t\tER007 B_ZAHL theor. Skonto UST=R20\t\t\t02.01.2021\t\t08.01.2021\t0\t0,00\t24\t\t60,00\t0,00\t0,00\t60,00\t0,00\t\t0,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t\t21\t1\tRS\tER007 B_ZAHL 303020\t\t\t\t\t\t\t\tER007 B_ZAHL 303020\tEUR\t21\t1\t\tER007 B_ZAHL 3030201181\t2021-01-08-00.00.00.000000ER007 B_ZAHL 3030201181\t0\t0\t0\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t7777\t3300\t3.000,00\tFalse\t0\t\t\t0\t\t3.000,00\t0,00\tH') on item 'TblBuop.Tabelle_OPs.Row5_OP_Tabelle'.", repo.TblBuop.Tabelle_OPs.Row5_OP_TabelleInfo, new RecordItemIndex(19));
            //Validate.AttributeContains(repo.TblBuop.Tabelle_OPs.Row5_OP_TabelleInfo, "Text", "1\tER007 B_ZAHL 303020\t\t\t\tEUR\t\t08.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t0,00\t0,00\t\t\t0,00\t0,00\t\t\t3.000,00\t\t\t\t98.400,00\t0\tR\t\t\t\t\t\t\t\t\t22.01.2021\t14\t2,00\t\t01.02.2021\t\tER\t\t\t\t\t\t\t\t\t\t\t\t\t\tER007 B_ZAHL theor. Skonto UST=R20\t\tER007 B_ZAHL theor. Skonto UST=R20\t\t\t02.01.2021\t\t08.01.2021\t0\t0,00\t24\t\t60,00\t0,00\t0,00\t60,00\t0,00\t\t0,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t\t21\t1\tRS\tER007 B_ZAHL 303020\t\t\t\t\t\t\t\tER007 B_ZAHL 303020\tEUR\t21\t1\t\tER007 B_ZAHL 3030201181\t2021-01-08-00.00.00.000000ER007 B_ZAHL 3030201181\t0\t0\t0\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t7777\t3300\t3.000,00\tFalse\t0\t\t\t0\t\t3.000,00\t0,00\tH");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'2\t1001\t\t\t\tEUR\t\t30.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-2.940,00\t\t\t\t\t0\tA\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOBK\t\t\t\t\t\t\t\t\t\t\t303021\t\t\tAusgleich ER007 B_ZAHL 303020\t\tAusgleich ER007 B_ZAHL 303020  \t\t\t\t\t\t\t\t0\t\t-60,00\t0,00\t0,00\t-60,00\t0,00\t\t3.000,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tER007 B_ZAHL 303020\t118\t1\t\t\t\t\t\t1001\tEUR\t0\t0\t\tER007 B_ZAHL 3030201342\t2021-01-30-00.00.00.000000ER007 B_ZAHL 3030201342\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2833\t3300\t-2.940,00\tFalse\t0\t\t\t\t\t3.000,00\t0,00\tS') on item 'TblBuop.Tabelle_OPs.Row6_OP_Tabelle'.", repo.TblBuop.Tabelle_OPs.Row6_OP_TabelleInfo, new RecordItemIndex(20));
            //Validate.AttributeContains(repo.TblBuop.Tabelle_OPs.Row6_OP_TabelleInfo, "Text", "2\t1001\t\t\t\tEUR\t\t30.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-2.940,00\t\t\t\t\t0\tA\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOBK\t\t\t\t\t\t\t\t\t\t\t303021\t\t\tAusgleich ER007 B_ZAHL 303020\t\tAusgleich ER007 B_ZAHL 303020  \t\t\t\t\t\t\t\t0\t\t-60,00\t0,00\t0,00\t-60,00\t0,00\t\t3.000,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tER007 B_ZAHL 303020\t118\t1\t\t\t\t\t\t1001\tEUR\t0\t0\t\tER007 B_ZAHL 3030201342\t2021-01-30-00.00.00.000000ER007 B_ZAHL 3030201342\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2833\t3300\t-2.940,00\tFalse\t0\t\t\t\t\t3.000,00\t0,00\tS");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'1\tER012 B_ZAHL 303021\t\t\t\tEUR\t\t05.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t0,00\t0,00\t\t\t0,00\t0,00\t\t\t1.000,00\t\t\t\t98.400,00\t0\tR\t\t\t\t\t\t\t\t\t04.02.2021\t30\t2,00\t\t04.03.2021\t\tER\t\t\t\t\t\t\t\t\t\t\t\t\t\tER012 B_ZAHL 303021 prakt. Skonto\t\tER012 B_ZAHL 303021 prakt. Skonto\t\t\t02.02.2021\t\t05.01.2021\t0\t0,00\t58\t\t20,00\t0,00\t0,00\t20,00\t0,00\t\t0,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t\t21\t1\tRS\tER012 B_ZAHL 303021\t\t\t\t\t\t\t\tER012 B_ZAHL 303021\tEUR\t21\t1\t\tER012 B_ZAHL 3030211261\t2021-01-05-00.00.00.000000ER012 B_ZAHL 3030211261\t0\t0\t0\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t7778\t3300\t1.000,00\tFalse\t0\t\t\t0\t\t1.000,00\t0,00\tH') on item 'TblBuop.Tabelle_OPs.Row7_OP_Tabelle'.", repo.TblBuop.Tabelle_OPs.Row7_OP_TabelleInfo, new RecordItemIndex(21));
            //Validate.AttributeContains(repo.TblBuop.Tabelle_OPs.Row7_OP_TabelleInfo, "Text", "1\tER012 B_ZAHL 303021\t\t\t\tEUR\t\t05.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t0,00\t0,00\t\t\t0,00\t0,00\t\t\t1.000,00\t\t\t\t98.400,00\t0\tR\t\t\t\t\t\t\t\t\t04.02.2021\t30\t2,00\t\t04.03.2021\t\tER\t\t\t\t\t\t\t\t\t\t\t\t\t\tER012 B_ZAHL 303021 prakt. Skonto\t\tER012 B_ZAHL 303021 prakt. Skonto\t\t\t02.02.2021\t\t05.01.2021\t0\t0,00\t58\t\t20,00\t0,00\t0,00\t20,00\t0,00\t\t0,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t\t21\t1\tRS\tER012 B_ZAHL 303021\t\t\t\t\t\t\t\tER012 B_ZAHL 303021\tEUR\t21\t1\t\tER012 B_ZAHL 3030211261\t2021-01-05-00.00.00.000000ER012 B_ZAHL 3030211261\t0\t0\t0\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t7778\t3300\t1.000,00\tFalse\t0\t\t\t0\t\t1.000,00\t0,00\tH");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'2\t1001\t\t\t\tEUR\t\t30.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-980,00\t\t\t\t\t0\tA\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOBK\t\t\t\t\t\t\t\t\t\t\t303021\t\t\tAusgleich ER012 B_ZAHL 303021\t\tAusgleich ER012 B_ZAHL 303021  \t\t\t\t\t\t\t\t0\t\t-20,00\t0,00\t0,00\t-20,00\t0,00\t\t1.000,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tER012 B_ZAHL 303021\t126\t1\t\t\t\t\t\t1001\tEUR\t0\t0\t\tER012 B_ZAHL 3030211312\t2021-01-30-00.00.00.000000ER012 B_ZAHL 3030211312\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2833\t3300\t-980,00\tFalse\t0\t\t\t\t\t1.000,00\t0,00\tS') on item 'TblBuop.Tabelle_OPs.Row8_OP_Tabelle'.", repo.TblBuop.Tabelle_OPs.Row8_OP_TabelleInfo, new RecordItemIndex(22));
            //Validate.AttributeContains(repo.TblBuop.Tabelle_OPs.Row8_OP_TabelleInfo, "Text", "2\t1001\t\t\t\tEUR\t\t30.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-980,00\t\t\t\t\t0\tA\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOBK\t\t\t\t\t\t\t\t\t\t\t303021\t\t\tAusgleich ER012 B_ZAHL 303021\t\tAusgleich ER012 B_ZAHL 303021  \t\t\t\t\t\t\t\t0\t\t-20,00\t0,00\t0,00\t-20,00\t0,00\t\t1.000,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tER012 B_ZAHL 303021\t126\t1\t\t\t\t\t\t1001\tEUR\t0\t0\t\tER012 B_ZAHL 3030211312\t2021-01-30-00.00.00.000000ER012 B_ZAHL 3030211312\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2833\t3300\t-980,00\tFalse\t0\t\t\t\t\t1.000,00\t0,00\tS");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'1\tGS002 B_ZAHL 303021\t\t\t\tEUR\t\t07.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t0,00\t0,00\t\t\t0,00\t0,00\t\t\t-50.000,00\t\t\t\t98.400,00\t0\tG\t\t\t\t\t\t\t\t\t18.01.2021\t14\t2,00\t\t03.02.2021\t\tERG\t\t\t\t\t\t\t\t\t\t\t\t\t\tGS002 B_ZAHL 303021 prakt. Skonto\t\tGS002 B_ZAHL 303021 prakt. Skonto\t\t\t04.01.2021\t\t04.01.2021\t0\t0,00\t30\t\t-1.000,00\t0,00\t0,00\t-1.000,00\t0,00\t\t0,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t\t21\t1\tRS\tGS002 B_ZAHL 303021\t\t\t\t\t\t\t\tGS002 B_ZAHL 303021\tEUR\t21\t1\t\tGS002 B_ZAHL 3030211241\t2021-01-07-00.00.00.000000GS002 B_ZAHL 3030211241\t0\t0\t0\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t7778\t3300\t-50.000,00\tFalse\t0\t\t\t0\t\t50.000,00\t0,00\tS') on item 'TblBuop.Tabelle_OPs.Row9_OP_Tabelle'.", repo.TblBuop.Tabelle_OPs.Row9_OP_TabelleInfo, new RecordItemIndex(23));
            //Validate.AttributeContains(repo.TblBuop.Tabelle_OPs.Row9_OP_TabelleInfo, "Text", "1\tGS002 B_ZAHL 303021\t\t\t\tEUR\t\t07.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t0,00\t0,00\t\t\t0,00\t0,00\t\t\t-50.000,00\t\t\t\t98.400,00\t0\tG\t\t\t\t\t\t\t\t\t18.01.2021\t14\t2,00\t\t03.02.2021\t\tERG\t\t\t\t\t\t\t\t\t\t\t\t\t\tGS002 B_ZAHL 303021 prakt. Skonto\t\tGS002 B_ZAHL 303021 prakt. Skonto\t\t\t04.01.2021\t\t04.01.2021\t0\t0,00\t30\t\t-1.000,00\t0,00\t0,00\t-1.000,00\t0,00\t\t0,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t\t21\t1\tRS\tGS002 B_ZAHL 303021\t\t\t\t\t\t\t\tGS002 B_ZAHL 303021\tEUR\t21\t1\t\tGS002 B_ZAHL 3030211241\t2021-01-07-00.00.00.000000GS002 B_ZAHL 3030211241\t0\t0\t0\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t7778\t3300\t-50.000,00\tFalse\t0\t\t\t0\t\t50.000,00\t0,00\tS");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'2\t1001\t\t\t\tEUR\t\t30.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t49.000,00\t\t\t\t\t0\tA\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOBK\t\t\t\t\t\t\t\t\t\t\t303021\t\t\tAusgleich GS002 B_ZAHL 303021\t\tAusgleich GS002 B_ZAHL 303021  \t\t\t\t\t\t\t\t0\t\t1.000,00\t0,00\t0,00\t1.000,00\t0,00\t\t-50.000,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tGS002 B_ZAHL 303021\t124\t1\t\t\t\t\t\t1001\tEUR\t0\t0\t\tGS002 B_ZAHL 3030211302\t2021-01-30-00.00.00.000000GS002 B_ZAHL 3030211302\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2833\t3300\t49.000,00\tFalse\t0\t\t\t\t\t-50.000,00\t0,00\tS') on item 'TblBuop.Tabelle_OPs.Row10_OP_Tabelle'.", repo.TblBuop.Tabelle_OPs.Row10_OP_TabelleInfo, new RecordItemIndex(24));
            //Validate.AttributeContains(repo.TblBuop.Tabelle_OPs.Row10_OP_TabelleInfo, "Text", "2\t1001\t\t\t\tEUR\t\t30.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t49.000,00\t\t\t\t\t0\tA\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOBK\t\t\t\t\t\t\t\t\t\t\t303021\t\t\tAusgleich GS002 B_ZAHL 303021\t\tAusgleich GS002 B_ZAHL 303021  \t\t\t\t\t\t\t\t0\t\t1.000,00\t0,00\t0,00\t1.000,00\t0,00\t\t-50.000,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tGS002 B_ZAHL 303021\t124\t1\t\t\t\t\t\t1001\tEUR\t0\t0\t\tGS002 B_ZAHL 3030211302\t2021-01-30-00.00.00.000000GS002 B_ZAHL 3030211302\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2833\t3300\t49.000,00\tFalse\t0\t\t\t\t\t-50.000,00\t0,00\tS");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
