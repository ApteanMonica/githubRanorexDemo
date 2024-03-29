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
    ///The LF_303022_DIV_1_Zeilen_Belege_pruefen recording.
    /// </summary>
    [TestModule("2e344167-6d56-4a50-b8f4-a78b4d4ebbcf", ModuleType.Recording, 1)]
    public partial class LF_303022_DIV_1_Zeilen_Belege_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHLV_001.B_ZAHLV_001Repository repository.
        /// </summary>
        public static global::B_ZAHLV_001.B_ZAHLV_001Repository repo = global::B_ZAHLV_001.B_ZAHLV_001Repository.Instance;

        static LF_303022_DIV_1_Zeilen_Belege_pruefen instance = new LF_303022_DIV_1_Zeilen_Belege_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LF_303022_DIV_1_Zeilen_Belege_pruefen()
        {
            LF_303022 = "303022";
            LF_303022_DIV_1_Saldo = "0,00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LF_303022_DIV_1_Zeilen_Belege_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _LF_303022;

        /// <summary>
        /// Gets or sets the value of variable LF_303022.
        /// </summary>
        [TestVariable("c1f1858a-b586-4873-8a45-ddf3ca7203a8")]
        public string LF_303022
        {
            get { return _LF_303022; }
            set { _LF_303022 = value; }
        }

        string _LF_303022_DIV_1_Saldo;

        /// <summary>
        /// Gets or sets the value of variable LF_303022_DIV_1_Saldo.
        /// </summary>
        [TestVariable("d64a1c95-4a79-4566-b094-d6e1a00230a8")]
        public string LF_303022_DIV_1_Saldo
        {
            get { return _LF_303022_DIV_1_Saldo; }
            set { _LF_303022_DIV_1_Saldo = value; }
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'TblBuop.ColOffenRow2'.", repo.TblBuop.ColOffenRow2Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblBuop.ColOffenRow2Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='A') on item 'TblBuop.Tabelle_OPs.ColArtRow3'.", repo.TblBuop.Tabelle_OPs.ColArtRow3Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColArtRow3Info, "Text", "A");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='A') on item 'TblBuop.Tabelle_OPs.ColArtRow4'.", repo.TblBuop.Tabelle_OPs.ColArtRow4Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblBuop.Tabelle_OPs.ColArtRow4Info, "Text", "A");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'1\tER008 B_ZAHL 303022/1\t\t\t\tEUR\t\t07.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t0,00\t0,00\t\t\t0,00\t0,00\t\t\t700,00\t\t\t\t0,00\t0\tR\t\t\t\t\t\t\t\t\t02.01.2021\t0\t0,00\t\t01.02.2021\t\tER\t\t\t\t\t\t\t\t\t\t\t\t\t\tLF-22 DIV_1 INLAND B_ZAHL ER008 B_ZAHL 303022/DIV1 kein Skonto (theor)\t\tLF-22 DIV_1 INLAND B_ZAHL  ER008 B_ZAHL 303022/DIV1 kein Skonto (theor)\t\t\t02.01.2021\t\t02.01.2021\t0\t0,00\t30\t\t0,00\t0,00\t0,00\t0,00\t0,00\t\t0,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t\t21\t1\tRS\tER008 B_ZAHL 303022/1\t\t\t\t\t\t\t\tER008 B_ZAHL 303022/1\tEUR\t21\t1\t\tER008 B_ZAHL 303022/11191\t2021-01-07-00.00.00.000000ER008 B_ZAHL 303022/11191\t0\t0\t0\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t7777\t3300\t700,00\tFalse\t0\t\t\t0\t\t700,00\t0,00\tH') on item 'TblBuop.Tabelle_OPs.Row1_OP_Tabelle'.", repo.TblBuop.Tabelle_OPs.Row1_OP_TabelleInfo, new RecordItemIndex(6));
            //Validate.AttributeContains(repo.TblBuop.Tabelle_OPs.Row1_OP_TabelleInfo, "Text", "1\tER008 B_ZAHL 303022/1\t\t\t\tEUR\t\t07.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t0,00\t0,00\t\t\t0,00\t0,00\t\t\t700,00\t\t\t\t0,00\t0\tR\t\t\t\t\t\t\t\t\t02.01.2021\t0\t0,00\t\t01.02.2021\t\tER\t\t\t\t\t\t\t\t\t\t\t\t\t\tLF-22 DIV_1 INLAND B_ZAHL ER008 B_ZAHL 303022/DIV1 kein Skonto (theor)\t\tLF-22 DIV_1 INLAND B_ZAHL  ER008 B_ZAHL 303022/DIV1 kein Skonto (theor)\t\t\t02.01.2021\t\t02.01.2021\t0\t0,00\t30\t\t0,00\t0,00\t0,00\t0,00\t0,00\t\t0,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t\t21\t1\tRS\tER008 B_ZAHL 303022/1\t\t\t\t\t\t\t\tER008 B_ZAHL 303022/1\tEUR\t21\t1\t\tER008 B_ZAHL 303022/11191\t2021-01-07-00.00.00.000000ER008 B_ZAHL 303022/11191\t0\t0\t0\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t7777\t3300\t700,00\tFalse\t0\t\t\t0\t\t700,00\t0,00\tH");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'2\t1001\t\t\t\tEUR\t\t30.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-700,00\t\t\t\t\t0\tA\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOBK\t\t\t\t\t\t\t\t\t\t\t303022\t1\t\tLF-22 DIV_1 INLAND B_ZAHL Ausgleich ER008 B_ZAHL 303022/1\t\tLF-22 DIV_1 INLAND B_ZAHL  Ausgleich ER008 B_ZAHL 303022/1  \t\t\t\t\t\t\t\t0\t\t0,00\t0,00\t0,00\t0,00\t0,00\t\t700,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tER008 B_ZAHL 303022/1\t119\t1\t\t\t\t\t\t1001\tEUR\t0\t0\t\tER008 B_ZAHL 303022/11352\t2021-01-30-00.00.00.000000ER008 B_ZAHL 303022/11352\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2833\t3300\t-700,00\tFalse\t0\t\t\t\t\t700,00\t0,00\tS') on item 'TblBuop.Tabelle_OPs.Row2_OP_Tabelle'.", repo.TblBuop.Tabelle_OPs.Row2_OP_TabelleInfo, new RecordItemIndex(7));
            //Validate.AttributeContains(repo.TblBuop.Tabelle_OPs.Row2_OP_TabelleInfo, "Text", "2\t1001\t\t\t\tEUR\t\t30.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-700,00\t\t\t\t\t0\tA\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOBK\t\t\t\t\t\t\t\t\t\t\t303022\t1\t\tLF-22 DIV_1 INLAND B_ZAHL Ausgleich ER008 B_ZAHL 303022/1\t\tLF-22 DIV_1 INLAND B_ZAHL  Ausgleich ER008 B_ZAHL 303022/1  \t\t\t\t\t\t\t\t0\t\t0,00\t0,00\t0,00\t0,00\t0,00\t\t700,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tER008 B_ZAHL 303022/1\t119\t1\t\t\t\t\t\t1001\tEUR\t0\t0\t\tER008 B_ZAHL 303022/11352\t2021-01-30-00.00.00.000000ER008 B_ZAHL 303022/11352\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2833\t3300\t-700,00\tFalse\t0\t\t\t\t\t700,00\t0,00\tS");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'1\tER009 B_ZAHL 303022/1\t\t\t\tEUR\t\t09.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t0,00\t0,00\t\t\t0,00\t0,00\t\t\t500,00\t\t\t\t0,00\t0\tR\t\t\t\t\t\t\t\t\t16.01.2021\t14\t2,00\t\t01.02.2021\t\tER\t\t\t\t\t\t\t\t\t\t\t\t\t\tLF-22 DIV_1 INLAND B_ZAHL ER009 B_ZAHL 303022/DIV1 theor. Skonto\t\tLF-22 DIV_1 INLAND B_ZAHL  ER009 B_ZAHL 303022/DIV1 theor. Skonto\t\t\t02.01.2021\t\t02.01.2021\t0\t0,00\t30\t\t10,00\t0,00\t0,00\t10,00\t0,00\t\t0,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t\t21\t1\tRS\tER009 B_ZAHL 303022/1\t\t\t\t\t\t\t\tER009 B_ZAHL 303022/1\tEUR\t21\t1\t\tER009 B_ZAHL 303022/11201\t2021-01-09-00.00.00.000000ER009 B_ZAHL 303022/11201\t0\t0\t0\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t7777\t3300\t500,00\tFalse\t0\t\t\t0\t\t500,00\t0,00\tH') on item 'TblBuop.Tabelle_OPs.Row3_OP_Tabelle'.", repo.TblBuop.Tabelle_OPs.Row3_OP_TabelleInfo, new RecordItemIndex(8));
            //Validate.AttributeContains(repo.TblBuop.Tabelle_OPs.Row3_OP_TabelleInfo, "Text", "1\tER009 B_ZAHL 303022/1\t\t\t\tEUR\t\t09.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t0,00\t0,00\t\t\t0,00\t0,00\t\t\t500,00\t\t\t\t0,00\t0\tR\t\t\t\t\t\t\t\t\t16.01.2021\t14\t2,00\t\t01.02.2021\t\tER\t\t\t\t\t\t\t\t\t\t\t\t\t\tLF-22 DIV_1 INLAND B_ZAHL ER009 B_ZAHL 303022/DIV1 theor. Skonto\t\tLF-22 DIV_1 INLAND B_ZAHL  ER009 B_ZAHL 303022/DIV1 theor. Skonto\t\t\t02.01.2021\t\t02.01.2021\t0\t0,00\t30\t\t10,00\t0,00\t0,00\t10,00\t0,00\t\t0,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t\t21\t1\tRS\tER009 B_ZAHL 303022/1\t\t\t\t\t\t\t\tER009 B_ZAHL 303022/1\tEUR\t21\t1\t\tER009 B_ZAHL 303022/11201\t2021-01-09-00.00.00.000000ER009 B_ZAHL 303022/11201\t0\t0\t0\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t7777\t3300\t500,00\tFalse\t0\t\t\t0\t\t500,00\t0,00\tH");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'2\t1001\t\t\t\tEUR\t\t30.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-490,00\t\t\t\t\t0\tA\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOBK\t\t\t\t\t\t\t\t\t\t\t303022\t1\t\tLF-22 DIV_1 INLAND B_ZAHL Ausgleich ER009 B_ZAHL 303022/1\t\tLF-22 DIV_1 INLAND B_ZAHL  Ausgleich ER009 B_ZAHL 303022/1  \t\t\t\t\t\t\t\t0\t\t-10,00\t0,00\t0,00\t-10,00\t0,00\t\t500,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tER009 B_ZAHL 303022/1\t120\t1\t\t\t\t\t\t1001\tEUR\t0\t0\t\tER009 B_ZAHL 303022/11362\t2021-01-30-00.00.00.000000ER009 B_ZAHL 303022/11362\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2833\t3300\t-490,00\tFalse\t0\t\t\t\t\t500,00\t0,00\tS') on item 'TblBuop.Tabelle_OPs.Row4_OP_Tabelle'.", repo.TblBuop.Tabelle_OPs.Row4_OP_TabelleInfo, new RecordItemIndex(9));
            //Validate.AttributeContains(repo.TblBuop.Tabelle_OPs.Row4_OP_TabelleInfo, "Text", "2\t1001\t\t\t\tEUR\t\t30.01.2021\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t-490,00\t\t\t\t\t0\tA\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOBK\t\t\t\t\t\t\t\t\t\t\t303022\t1\t\tLF-22 DIV_1 INLAND B_ZAHL Ausgleich ER009 B_ZAHL 303022/1\t\tLF-22 DIV_1 INLAND B_ZAHL  Ausgleich ER009 B_ZAHL 303022/1  \t\t\t\t\t\t\t\t0\t\t-10,00\t0,00\t0,00\t-10,00\t0,00\t\t500,00\t0,00\t0,00\t1\t0,00\t1\tS\t1\t1\t21\t1\tRS\tER009 B_ZAHL 303022/1\t120\t1\t\t\t\t\t\t1001\tEUR\t0\t0\t\tER009 B_ZAHL 303022/11362\t2021-01-30-00.00.00.000000ER009 B_ZAHL 303022/11362\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t2833\t3300\t-490,00\tFalse\t0\t\t\t\t\t500,00\t0,00\tS");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
