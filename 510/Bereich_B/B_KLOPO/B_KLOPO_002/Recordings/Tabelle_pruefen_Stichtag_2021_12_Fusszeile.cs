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

namespace B_KLOPO_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Tabelle_pruefen_Stichtag_2021_12_Fusszeile recording.
    /// </summary>
    [TestModule("aa0198d3-9e77-4f66-a36a-7aee151ec301", ModuleType.Recording, 1)]
    public partial class Tabelle_pruefen_Stichtag_2021_12_Fusszeile : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KLOPO_002.B_KLOPO_002Repository repository.
        /// </summary>
        public static global::B_KLOPO_002.B_KLOPO_002Repository repo = global::B_KLOPO_002.B_KLOPO_002Repository.Instance;

        static Tabelle_pruefen_Stichtag_2021_12_Fusszeile instance = new Tabelle_pruefen_Stichtag_2021_12_Fusszeile();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Tabelle_pruefen_Stichtag_2021_12_Fusszeile()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Tabelle_pruefen_Stichtag_2021_12_Fusszeile Instance
        {
            get { return instance; }
        }

#region Variables

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

            // Fußzeile
            Report.Log(ReportLevel.Info, "Section", "Fußzeile", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='GESAMTSUMME') on item 'TblKlOp.Fusszeile_Summen.ColAdrNameRow0'.", repo.TblKlOp.Fusszeile_Summen.ColAdrNameRow0Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblKlOp.Fusszeile_Summen.ColAdrNameRow0Info, "Text", "GESAMTSUMME");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='5.100,00') on item 'TblKlOp.Fusszeile_Summen.ColBuopBetragRow0'.", repo.TblKlOp.Fusszeile_Summen.ColBuopBetragRow0Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblKlOp.Fusszeile_Summen.ColBuopBetragRow0Info, "Text", "5.100,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3.677,96') on item 'TblKlOp.Fusszeile_Summen.ColBuopOffenRow0'.", repo.TblKlOp.Fusszeile_Summen.ColBuopOffenRow0Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblKlOp.Fusszeile_Summen.ColBuopOffenRow0Info, "Text", "3.677,96");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.831,55') on item 'TblKlOp.Fusszeile_Summen.ColKlktSaldoRow0'.", repo.TblKlOp.Fusszeile_Summen.ColKlktSaldoRow0Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblKlOp.Fusszeile_Summen.ColKlktSaldoRow0Info, "Text", "1.831,55");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
