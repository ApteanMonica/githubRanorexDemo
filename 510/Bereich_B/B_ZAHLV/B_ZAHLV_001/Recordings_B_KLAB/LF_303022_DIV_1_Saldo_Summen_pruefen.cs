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
    ///The LF_303022_DIV_1_Saldo_Summen_pruefen recording.
    /// </summary>
    [TestModule("6c443d7f-6b48-425c-9a46-7273a3eb5358", ModuleType.Recording, 1)]
    public partial class LF_303022_DIV_1_Saldo_Summen_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHLV_001.B_ZAHLV_001Repository repository.
        /// </summary>
        public static global::B_ZAHLV_001.B_ZAHLV_001Repository repo = global::B_ZAHLV_001.B_ZAHLV_001Repository.Instance;

        static LF_303022_DIV_1_Saldo_Summen_pruefen instance = new LF_303022_DIV_1_Saldo_Summen_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LF_303022_DIV_1_Saldo_Summen_pruefen()
        {
            LF_303022 = "303022";
            LF_303022_DIV_1_Saldo = "0,00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LF_303022_DIV_1_Saldo_Summen_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _LF_303022;

        /// <summary>
        /// Gets or sets the value of variable LF_303022.
        /// </summary>
        [TestVariable("2cf5da45-b1cf-47a8-aace-9b87568ce555")]
        public string LF_303022
        {
            get { return _LF_303022; }
            set { _LF_303022 = value; }
        }

        string _LF_303022_DIV_1_Saldo;

        /// <summary>
        /// Gets or sets the value of variable LF_303022_DIV_1_Saldo.
        /// </summary>
        [TestVariable("c012ebfe-d0e5-4469-9b64-2b41947b8d45")]
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

            //Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TblBuop.TitleBar100OPs303021LF21INLANDB'.", repo.TblBuop.TitleBar100OPs303021LF21INLANDBInfo, new RecordItemIndex(0));
            //Validate.Exists(repo.TblBuop.TitleBar100OPs303021LF21INLANDBInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$LF_303022) on item 'TblBuop.TitleBar100OPs303021LF21INLANDB'.", repo.TblBuop.TitleBar100OPs303021LF21INLANDBInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.TblBuop.TitleBar100OPs303021LF21INLANDBInfo, "Text", LF_303022);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'1.000,00') on item 'TblBuop.TitleBar100OPs303021LF21INLANDB'.", repo.TblBuop.TitleBar100OPs303021LF21INLANDBInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblBuop.TitleBar100OPs303021LF21INLANDBInfo, "Text", "1.000,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_303022_DIV_1_Saldo) on item 'TblBuop.Fusszeile_Summen.Summe_Offen_ColOffenRow0_Fusszeile1'.", repo.TblBuop.Fusszeile_Summen.Summe_Offen_ColOffenRow0_Fusszeile1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblBuop.Fusszeile_Summen.Summe_Offen_ColOffenRow0_Fusszeile1Info, "Text", LF_303022_DIV_1_Saldo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10,00') on item 'TblBuop.Fusszeile_Summen.Summe_RgBetrag_ColBetragRow0_Fusszeile1'.", repo.TblBuop.Fusszeile_Summen.Summe_RgBetrag_ColBetragRow0_Fusszeile1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblBuop.Fusszeile_Summen.Summe_RgBetrag_ColBetragRow0_Fusszeile1Info, "Text", "10,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='-10,00') on item 'TblBuop.Fusszeile_Summen.Summe_Abzuege_ColBetragRow1'.", repo.TblBuop.Fusszeile_Summen.Summe_Abzuege_ColBetragRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblBuop.Fusszeile_Summen.Summe_Abzuege_ColBetragRow1Info, "Text", "-10,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_303022_DIV_1_Saldo) on item 'TblBuop.Fusszeile_Summen.Summe_RgBetrag_Abzuege_ColBetragRow2_Fusszeile3'.", repo.TblBuop.Fusszeile_Summen.Summe_RgBetrag_Abzuege_ColBetragRow2_Fusszeile3Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblBuop.Fusszeile_Summen.Summe_RgBetrag_Abzuege_ColBetragRow2_Fusszeile3Info, "Text", LF_303022_DIV_1_Saldo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
