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
    ///The LF_303023_Saldo_Summen_pruefen recording.
    /// </summary>
    [TestModule("8a280b5a-e071-4f44-b545-674b573dd64f", ModuleType.Recording, 1)]
    public partial class LF_303023_Saldo_Summen_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHLV_001.B_ZAHLV_001Repository repository.
        /// </summary>
        public static global::B_ZAHLV_001.B_ZAHLV_001Repository repo = global::B_ZAHLV_001.B_ZAHLV_001Repository.Instance;

        static LF_303023_Saldo_Summen_pruefen instance = new LF_303023_Saldo_Summen_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LF_303023_Saldo_Summen_pruefen()
        {
            LF_303023 = "303023";
            LF_303023_Saldo = "0,00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LF_303023_Saldo_Summen_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _LF_303023;

        /// <summary>
        /// Gets or sets the value of variable LF_303023.
        /// </summary>
        [TestVariable("55852b4c-069f-4cd8-8914-ee7f2d8dde83")]
        public string LF_303023
        {
            get { return _LF_303023; }
            set { _LF_303023 = value; }
        }

        string _LF_303023_Saldo;

        /// <summary>
        /// Gets or sets the value of variable LF_303023_Saldo.
        /// </summary>
        [TestVariable("dede5647-1043-4c7e-b828-70c16be49595")]
        public string LF_303023_Saldo
        {
            get { return _LF_303023_Saldo; }
            set { _LF_303023_Saldo = value; }
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$LF_303023) on item 'TblBuop.TitleBar100OPs303021LF21INLANDB'.", repo.TblBuop.TitleBar100OPs303021LF21INLANDBInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.TblBuop.TitleBar100OPs303021LF21INLANDBInfo, "Text", LF_303023);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$LF_303023_Saldo) on item 'TblBuop.TitleBar100OPs303021LF21INLANDB'.", repo.TblBuop.TitleBar100OPs303021LF21INLANDBInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblBuop.TitleBar100OPs303021LF21INLANDBInfo, "Text", LF_303023_Saldo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_303023_Saldo) on item 'TblBuop.Fusszeile_Summen.Summe_Offen_ColOffenRow0_Fusszeile1'.", repo.TblBuop.Fusszeile_Summen.Summe_Offen_ColOffenRow0_Fusszeile1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblBuop.Fusszeile_Summen.Summe_Offen_ColOffenRow0_Fusszeile1Info, "Text", LF_303023_Saldo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_303023_Saldo) on item 'TblBuop.Fusszeile_Summen.Summe_RgBetrag_ColBetragRow0_Fusszeile1'.", repo.TblBuop.Fusszeile_Summen.Summe_RgBetrag_ColBetragRow0_Fusszeile1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblBuop.Fusszeile_Summen.Summe_RgBetrag_ColBetragRow0_Fusszeile1Info, "Text", LF_303023_Saldo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
