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

namespace B_MNDR_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Ueberpruefung_Endergebnis_Teil_1 recording.
    /// </summary>
    [TestModule("22ecceb2-4dd8-45c7-8d4b-f322be5bd652", ModuleType.Recording, 1)]
    public partial class Ueberpruefung_Endergebnis_Teil_1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_MNDR_004.B_MNDR_004Repository repository.
        /// </summary>
        public static global::B_MNDR_004.B_MNDR_004Repository repo = global::B_MNDR_004.B_MNDR_004Repository.Instance;

        static Ueberpruefung_Endergebnis_Teil_1 instance = new Ueberpruefung_Endergebnis_Teil_1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ueberpruefung_Endergebnis_Teil_1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ueberpruefung_Endergebnis_Teil_1 Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='200024') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColAdrNrRow1'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColAdrNrRow1Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColAdrNrRow1Info, "Text", "200024");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='B_MNDR_004_01') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColBelegRow1'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColBelegRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColBelegRow1Info, "Text", "B_MNDR_004_01");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColSperreRow1'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColSperreRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColSperreRow1Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='KLAGE') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColOpspCdRow1'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColOpspCdRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColOpspCdRow1Info, "Text", "KLAGE");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='keine Mahnung wegen Klage') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColOpspBezRow1'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColOpspBezRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row1.ColOpspBezRow1Info, "Text", "keine Mahnung wegen Klage");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='200024') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row2.ColAdrNrRow2'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row2.ColAdrNrRow2Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row2.ColAdrNrRow2Info, "Text", "200024");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='B_MNDR_004_02') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row2.ColBelegRow2'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row2.ColBelegRow2Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row2.ColBelegRow2Info, "Text", "B_MNDR_004_02");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='J') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row2.ColSperreRow2'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row2.ColSperreRow2Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row2.ColSperreRow2Info, "Text", "J");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='200024') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColAdrNrRow3'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColAdrNrRow3Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColAdrNrRow3Info, "Text", "200024");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='B_MNDR_004_03') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColBelegRow3'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColBelegRow3Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColBelegRow3Info, "Text", "B_MNDR_004_03");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3Info, "Text", "N");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
