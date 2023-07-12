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

namespace N_LISTEN_BULI_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Ueberpruefung_gerechnete_AfA recording.
    /// </summary>
    [TestModule("26efc609-81a4-473b-ad6f-4c9af1f4156c", ModuleType.Recording, 1)]
    public partial class Ueberpruefung_gerechnete_AfA : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository repository.
        /// </summary>
        public static global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository repo = global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository.Instance;

        static Ueberpruefung_gerechnete_AfA instance = new Ueberpruefung_gerechnete_AfA();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ueberpruefung_gerechnete_AfA()
        {
            Afa_Konto = "0660";
            AfA_Gegenkonto = "0660";
            Kostenstelle_10 = "10";
            GWG_AfA_Konto = "7010";
            GWG_AfA_Gegenkonto = "0680";
            Kostenstelle_20 = "20";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ueberpruefung_gerechnete_AfA Instance
        {
            get { return instance; }
        }

#region Variables

        string _Afa_Konto;

        /// <summary>
        /// Gets or sets the value of variable Afa_Konto.
        /// </summary>
        [TestVariable("61e70350-6d97-43c3-be07-222da33d4a75")]
        public string Afa_Konto
        {
            get { return _Afa_Konto; }
            set { _Afa_Konto = value; }
        }

        string _AfA_Gegenkonto;

        /// <summary>
        /// Gets or sets the value of variable AfA_Gegenkonto.
        /// </summary>
        [TestVariable("165314ee-fb09-42e2-9599-7bf70697f753")]
        public string AfA_Gegenkonto
        {
            get { return _AfA_Gegenkonto; }
            set { _AfA_Gegenkonto = value; }
        }

        string _Kostenstelle_10;

        /// <summary>
        /// Gets or sets the value of variable Kostenstelle_10.
        /// </summary>
        [TestVariable("17a21ed9-add6-4d98-bc2e-6d131770a33d")]
        public string Kostenstelle_10
        {
            get { return _Kostenstelle_10; }
            set { _Kostenstelle_10 = value; }
        }

        string _GWG_AfA_Konto;

        /// <summary>
        /// Gets or sets the value of variable GWG_AfA_Konto.
        /// </summary>
        [TestVariable("216db4fc-4b7e-4edc-8e9f-c8fc04be0769")]
        public string GWG_AfA_Konto
        {
            get { return _GWG_AfA_Konto; }
            set { _GWG_AfA_Konto = value; }
        }

        string _GWG_AfA_Gegenkonto;

        /// <summary>
        /// Gets or sets the value of variable GWG_AfA_Gegenkonto.
        /// </summary>
        [TestVariable("0ba1bae1-41f7-49ef-8c43-11f42992546e")]
        public string GWG_AfA_Gegenkonto
        {
            get { return _GWG_AfA_Gegenkonto; }
            set { _GWG_AfA_Gegenkonto = value; }
        }

        string _Kostenstelle_20;

        /// <summary>
        /// Gets or sets the value of variable Kostenstelle_20.
        /// </summary>
        [TestVariable("1f2a0ed4-ef5d-4925-9c35-68324f2a6a86")]
        public string Kostenstelle_20
        {
            get { return _Kostenstelle_20; }
            set { _Kostenstelle_20 = value; }
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

            // Überprüfung Zeile 2
            Report.Log(ReportLevel.Info, "Section", "Überprüfung Zeile 2", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='AfA') on item 'FrmBuchungsliste.ColTypRow2'.", repo.FrmBuchungsliste.ColTypRow2Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmBuchungsliste.ColTypRow2Info, "Text", "AfA");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Afa_Konto) on item 'FrmBuchungsliste.ColKtoNrRow2'.", repo.FrmBuchungsliste.ColKtoNrRow2Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmBuchungsliste.ColKtoNrRow2Info, "Text", Afa_Konto);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$AfA_Gegenkonto) on item 'FrmBuchungsliste.ColGktoNrRow2'.", repo.FrmBuchungsliste.ColGktoNrRow2Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmBuchungsliste.ColGktoNrRow2Info, "Text", AfA_Gegenkonto);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kostenstelle_10) on item 'FrmBuchungsliste.ColBektNr1Row2'.", repo.FrmBuchungsliste.ColBektNr1Row2Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmBuchungsliste.ColBektNr1Row2Info, "Text", Kostenstelle_10);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='208,33') on item 'FrmBuchungsliste.ColBetragRow2'.", repo.FrmBuchungsliste.ColBetragRow2Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmBuchungsliste.ColBetragRow2Info, "Text", "208,33");
            
            // Überprüfung Zeile 4
            Report.Log(ReportLevel.Info, "Section", "Überprüfung Zeile 4", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='AfA') on item 'FrmBuchungsliste.ColTypRow4'.", repo.FrmBuchungsliste.ColTypRow4Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmBuchungsliste.ColTypRow4Info, "Text", "AfA");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$GWG_AfA_Konto) on item 'FrmBuchungsliste.ColKtoNrRow4'.", repo.FrmBuchungsliste.ColKtoNrRow4Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmBuchungsliste.ColKtoNrRow4Info, "Text", GWG_AfA_Konto);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$GWG_AfA_Gegenkonto) on item 'FrmBuchungsliste.ColGktoNrRow4'.", repo.FrmBuchungsliste.ColGktoNrRow4Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmBuchungsliste.ColGktoNrRow4Info, "Text", GWG_AfA_Gegenkonto);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kostenstelle_20) on item 'FrmBuchungsliste.ColBektNr1Row4'.", repo.FrmBuchungsliste.ColBektNr1Row4Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmBuchungsliste.ColBektNr1Row4Info, "Text", Kostenstelle_20);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='291,67') on item 'FrmBuchungsliste.ColBetragRow4'.", repo.FrmBuchungsliste.ColBetragRow4Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmBuchungsliste.ColBetragRow4Info, "Text", "291,67");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100AVZAuswertungenBuchungslist.WindowsForms10BUTTONApp02804c64R6A' at Center.", repo.Form100AVZAuswertungenBuchungslist.WindowsForms10BUTTONApp02804c64R6AInfo, new RecordItemIndex(12));
            repo.Form100AVZAuswertungenBuchungslist.WindowsForms10BUTTONApp02804c64R6A.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
