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

namespace B_KLOPO_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Tabelle_pruefen_Saldo_aktuell_Summenzeilen_Sammelkonto_KI_2000 recording.
    /// </summary>
    [TestModule("bc875ff0-68cc-4977-ae74-18787b579ffa", ModuleType.Recording, 1)]
    public partial class Tabelle_pruefen_Saldo_aktuell_Summenzeilen_Sammelkonto_KI_2000 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KLOPO_001.B_KLOPO_001Repository repository.
        /// </summary>
        public static global::B_KLOPO_001.B_KLOPO_001Repository repo = global::B_KLOPO_001.B_KLOPO_001Repository.Instance;

        static Tabelle_pruefen_Saldo_aktuell_Summenzeilen_Sammelkonto_KI_2000 instance = new Tabelle_pruefen_Saldo_aktuell_Summenzeilen_Sammelkonto_KI_2000();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Tabelle_pruefen_Saldo_aktuell_Summenzeilen_Sammelkonto_KI_2000()
        {
            KU_2030001 = "2030001";
            KU_2030002_DIV = "2030002";
            KU_2030003 = "2030003";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Tabelle_pruefen_Saldo_aktuell_Summenzeilen_Sammelkonto_KI_2000 Instance
        {
            get { return instance; }
        }

#region Variables

        string _KU_2030001;

        /// <summary>
        /// Gets or sets the value of variable KU_2030001.
        /// </summary>
        [TestVariable("21254403-3ecb-4d3c-8597-9aa96197cdaa")]
        public string KU_2030001
        {
            get { return _KU_2030001; }
            set { _KU_2030001 = value; }
        }

        string _KU_2030002_DIV;

        /// <summary>
        /// Gets or sets the value of variable KU_2030002_DIV.
        /// </summary>
        [TestVariable("a3cebfaa-6ed6-43c9-b50a-c56a7fbc7a57")]
        public string KU_2030002_DIV
        {
            get { return _KU_2030002_DIV; }
            set { _KU_2030002_DIV = value; }
        }

        string _KU_2030003;

        /// <summary>
        /// Gets or sets the value of variable KU_2030003.
        /// </summary>
        [TestVariable("4dcd0b9b-17fb-4c14-95c4-af3c7e6210ee")]
        public string KU_2030003
        {
            get { return _KU_2030003; }
            set { _KU_2030003 = value; }
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

            // Summenzeile_2030001
            Report.Log(ReportLevel.Info, "Section", "Summenzeile_2030001", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KU_2030001) on item 'TblKlOp.Tabelle.Zeile_5.ColAdrNrRow5'.", repo.TblKlOp.Tabelle.Zeile_5.ColAdrNrRow5Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblKlOp.Tabelle.Zeile_5.ColAdrNrRow5Info, "Text", KU_2030001);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Summe') on item 'TblKlOp.Tabelle.Zeile_5.ColBuopBelegnrRow5'.", repo.TblKlOp.Tabelle.Zeile_5.ColBuopBelegnrRow5Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblKlOp.Tabelle.Zeile_5.ColBuopBelegnrRow5Info, "Text", "Summe");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.300,00') on item 'TblKlOp.Tabelle.Zeile_5.ColBuopBetragRow5'.", repo.TblKlOp.Tabelle.Zeile_5.ColBuopBetragRow5Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblKlOp.Tabelle.Zeile_5.ColBuopBetragRow5Info, "Text", "1.300,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='957,96') on item 'TblKlOp.Tabelle.Zeile_5.ColBuopOffenRow5'.", repo.TblKlOp.Tabelle.Zeile_5.ColBuopOffenRow5Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblKlOp.Tabelle.Zeile_5.ColBuopOffenRow5Info, "Text", "957,96");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='957,96') on item 'TblKlOp.Tabelle.Zeile_5.ColKlktSaldoRow5'.", repo.TblKlOp.Tabelle.Zeile_5.ColKlktSaldoRow5Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblKlOp.Tabelle.Zeile_5.ColKlktSaldoRow5Info, "Text", "957,96");
            
            // Summenzeile_2030002-DIV
            Report.Log(ReportLevel.Info, "Section", "Summenzeile_2030002-DIV", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KU_2030002_DIV) on item 'TblKlOp.Tabelle.Zeile_10.ColAdrNrRow10'.", repo.TblKlOp.Tabelle.Zeile_10.ColAdrNrRow10Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblKlOp.Tabelle.Zeile_10.ColAdrNrRow10Info, "Text", KU_2030002_DIV);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Summe') on item 'TblKlOp.Tabelle.Zeile_10.ColBuopBelegnrRow10'.", repo.TblKlOp.Tabelle.Zeile_10.ColBuopBelegnrRow10Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblKlOp.Tabelle.Zeile_10.ColBuopBelegnrRow10Info, "Text", "Summe");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3.000,00') on item 'TblKlOp.Tabelle.Zeile_10.ColBuopBetragRow10'.", repo.TblKlOp.Tabelle.Zeile_10.ColBuopBetragRow10Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblKlOp.Tabelle.Zeile_10.ColBuopBetragRow10Info, "Text", "3.000,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.494,00') on item 'TblKlOp.Tabelle.Zeile_10.ColBuopOffenRow10'.", repo.TblKlOp.Tabelle.Zeile_10.ColBuopOffenRow10Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblKlOp.Tabelle.Zeile_10.ColBuopOffenRow10Info, "Text", "1.494,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.494,00') on item 'TblKlOp.Tabelle.Zeile_10.ColKlktSaldoRow10'.", repo.TblKlOp.Tabelle.Zeile_10.ColKlktSaldoRow10Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblKlOp.Tabelle.Zeile_10.ColKlktSaldoRow10Info, "Text", "1.494,00");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
