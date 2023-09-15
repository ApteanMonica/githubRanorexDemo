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

namespace K_VERE_001.Recordings_K_VEST
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verr_Stamm_pruefen_obere_Tabelle_Default recording.
    /// </summary>
    [TestModule("ce563591-e7af-4be1-8905-9d7b0e545e05", ModuleType.Recording, 1)]
    public partial class Verr_Stamm_pruefen_obere_Tabelle_Default : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_VERE_001.K_VERE_001Repository repository.
        /// </summary>
        public static global::K_VERE_001.K_VERE_001Repository repo = global::K_VERE_001.K_VERE_001Repository.Instance;

        static Verr_Stamm_pruefen_obere_Tabelle_Default instance = new Verr_Stamm_pruefen_obere_Tabelle_Default();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verr_Stamm_pruefen_obere_Tabelle_Default()
        {
            Art_STS = "STS";
            Art_SVE = "SVE";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verr_Stamm_pruefen_obere_Tabelle_Default Instance
        {
            get { return instance; }
        }

#region Variables

        string _Art_STS;

        /// <summary>
        /// Gets or sets the value of variable Art_STS.
        /// </summary>
        [TestVariable("c4cb0dc7-2376-442f-8b7f-44e597217330")]
        public string Art_STS
        {
            get { return _Art_STS; }
            set { _Art_STS = value; }
        }

        string _Art_SVE;

        /// <summary>
        /// Gets or sets the value of variable Art_SVE.
        /// </summary>
        [TestVariable("42c1a24d-d5a4-4316-99f1-33bb3084167e")]
        public string Art_SVE
        {
            get { return _Art_SVE; }
            set { _Art_SVE = value; }
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

            // Zeile 1
            Report.Log(ReportLevel.Info, "Section", "Zeile 1", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Art_STS) on item 'MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraCdRow1'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraCdRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraCdRow1Info, "Text", Art_STS);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Stundensatz erfassen') on item 'MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraBezRow1'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraBezRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraBezRow1Info, "Text", "Stundensatz erfassen");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraFormelRow1'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraFormelRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraFormelRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='keine Verrechnung') on item 'MdiMain_K_VEST.Obere_Tabelle.Row1.ColFormelBezRow1'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColFormelBezRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColFormelBezRow1Info, "Text", "keine Verrechnung");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKzleRow1'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKzleRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKzleRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKzsatzRow1'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKzsatzRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKzsatzRow1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Fixer Kostensatz aus Betrag') on item 'MdiMain_K_VEST.Obere_Tabelle.Row1.ColSatzBezRow1'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColSatzBezRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColSatzBezRow1Info, "Text", "Fixer Kostensatz aus Betrag");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKzabgrenzungRow1'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKzabgrenzungRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKzabgrenzungRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKzperiRow1'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKzperiRow1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKzperiRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraSatznrRow1'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraSatznrRow1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraSatznrRow1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraSatzartRow1'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraSatzartRow1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraSatzartRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKs1satzRow1'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKs1satzRow1Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row1.ColVeraKs1satzRow1Info, "Text", "2");
            
            // Zeile 1
            Report.Log(ReportLevel.Info, "Section", "Zeile 1", new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Art_SVE) on item 'MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraCdRow2'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraCdRow2Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraCdRow2Info, "Text", Art_SVE);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Stunden verrechnen') on item 'MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraBezRow2'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraBezRow2Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraBezRow2Info, "Text", "Stunden verrechnen");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraFormelRow2'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraFormelRow2Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraFormelRow2Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Menge * Kostensatz') on item 'MdiMain_K_VEST.Obere_Tabelle.Row2.ColFormelBezRow2'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColFormelBezRow2Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColFormelBezRow2Info, "Text", "Menge * Kostensatz");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKzleRow2'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKzleRow2Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKzleRow2Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKzsatzRow2'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKzsatzRow2Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKzsatzRow2Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='keine Ermittlung Kostensatz') on item 'MdiMain_K_VEST.Obere_Tabelle.Row2.ColSatzBezRow2'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColSatzBezRow2Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColSatzBezRow2Info, "Text", "keine Ermittlung Kostensatz");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKzabgrenzungRow2'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKzabgrenzungRow2Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKzabgrenzungRow2Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKzperiRow2'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKzperiRow2Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKzperiRow2Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraSatznrRow2'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraSatznrRow2Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraSatznrRow2Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraSatzartRow2'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraSatzartRow2Info, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraSatzartRow2Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKs1satzRow2'.", repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKs1satzRow2Info, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.MdiMain_K_VEST.Obere_Tabelle.Row2.ColVeraKs1satzRow2Info, "Text", "2");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}