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

namespace B_BUCH_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validation_row_2 recording.
    /// </summary>
    [TestModule("d3df8d47-ebe5-4246-a066-f7632bce7672", ModuleType.Recording, 1)]
    public partial class Validation_row_2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_001.B_BUCH_001Repository repository.
        /// </summary>
        public static global::B_BUCH_001.B_BUCH_001Repository repo = global::B_BUCH_001.B_BUCH_001Repository.Instance;

        static Validation_row_2 instance = new Validation_row_2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validation_row_2()
        {
            Lieferant = "300011";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validation_row_2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Lieferant;

        /// <summary>
        /// Gets or sets the value of variable Lieferant.
        /// </summary>
        [TestVariable("943e2896-498c-4a8c-a19c-ef141eb09cd8")]
        public string Lieferant
        {
            get { return _Lieferant; }
            set { _Lieferant = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='01.2020') on item 'TblB_b_buab.FlexGrid_b_buab.ColJahrPeriRow2'.", repo.TblB_b_buab.FlexGrid_b_buab.ColJahrPeriRow2Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColJahrPeriRow2Info, "Text", "01.2020");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='5010') on item 'TblB_b_buab.FlexGrid_b_buab.ColKtoNrRow2'.", repo.TblB_b_buab.FlexGrid_b_buab.ColKtoNrRow2Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColKtoNrRow2Info, "Text", "5010");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='S') on item 'TblB_b_buab.FlexGrid_b_buab.ColArtRow2'.", repo.TblB_b_buab.FlexGrid_b_buab.ColArtRow2Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColArtRow2Info, "Text", "S");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3300') on item 'TblB_b_buab.FlexGrid_b_buab.ColGKtoNrRow2'.", repo.TblB_b_buab.FlexGrid_b_buab.ColGKtoNrRow2Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColGKtoNrRow2Info, "Text", "3300");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferant) on item 'TblB_b_buab.FlexGrid_b_buab.ColAdrNrRow2'.", repo.TblB_b_buab.FlexGrid_b_buab.ColAdrNrRow2Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColAdrNrRow2Info, "Text", Lieferant);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='81,66') on item 'TblB_b_buab.FlexGrid_b_buab.ColBetragRow2'.", repo.TblB_b_buab.FlexGrid_b_buab.ColBetragRow2Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColBetragRow2Info, "Text", "81,66");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V20') on item 'TblB_b_buab.FlexGrid_b_buab.ColUstcdRow2'.", repo.TblB_b_buab.FlexGrid_b_buab.ColUstcdRow2Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColUstcdRow2Info, "Text", "V20");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V') on item 'TblB_b_buab.FlexGrid_b_buab.ColUstmvRow2'.", repo.TblB_b_buab.FlexGrid_b_buab.ColUstmvRow2Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColUstmvRow2Info, "Text", "V");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20') on item 'TblB_b_buab.FlexGrid_b_buab.ColUstsatzRow2'.", repo.TblB_b_buab.FlexGrid_b_buab.ColUstsatzRow2Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColUstsatzRow2Info, "Text", "20");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='16,34') on item 'TblB_b_buab.FlexGrid_b_buab.ColUstbetragRow2'.", repo.TblB_b_buab.FlexGrid_b_buab.ColUstbetragRow2Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColUstbetragRow2Info, "Text", "16,34");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='98,00') on item 'TblB_b_buab.FlexGrid_b_buab.ColBruttoRow2'.", repo.TblB_b_buab.FlexGrid_b_buab.ColBruttoRow2Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColBruttoRow2Info, "Text", "98,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2020-1') on item 'TblB_b_buab.FlexGrid_b_buab.ColUvaRow2'.", repo.TblB_b_buab.FlexGrid_b_buab.ColUvaRow2Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColUvaRow2Info, "Text", "2020-1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20') on item 'TblB_b_buab.FlexGrid_b_buab.ColCd1Row2'.", repo.TblB_b_buab.FlexGrid_b_buab.ColCd1Row2Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblB_b_buab.FlexGrid_b_buab.ColCd1Row2Info, "Text", "20");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
