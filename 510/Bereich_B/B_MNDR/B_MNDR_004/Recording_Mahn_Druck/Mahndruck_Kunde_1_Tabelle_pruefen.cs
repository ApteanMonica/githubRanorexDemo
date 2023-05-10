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

namespace B_MNDR_004.Recording_Mahn_Druck
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Mahndruck_Kunde_1_Tabelle_pruefen recording.
    /// </summary>
    [TestModule("1c2ad743-0ab0-4a57-9dd6-23b8db9c7132", ModuleType.Recording, 1)]
    public partial class Mahndruck_Kunde_1_Tabelle_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_MNDR_004.B_MNDR_004Repository repository.
        /// </summary>
        public static global::B_MNDR_004.B_MNDR_004Repository repo = global::B_MNDR_004.B_MNDR_004Repository.Instance;

        static Mahndruck_Kunde_1_Tabelle_pruefen instance = new Mahndruck_Kunde_1_Tabelle_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Mahndruck_Kunde_1_Tabelle_pruefen()
        {
            Kunde_1 = "200024";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Mahndruck_Kunde_1_Tabelle_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Kunde_1;

        /// <summary>
        /// Gets or sets the value of variable Kunde_1.
        /// </summary>
        [TestVariable("3f3af39e-fbc8-4c18-938d-7f1082536364")]
        public string Kunde_1
        {
            get { return _Kunde_1; }
            set { _Kunde_1 = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblDrucken.TitleBar100Vorschau200024QSKUND'", repo.TblDrucken.TitleBar100Vorschau200024QSKUNDInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.TblDrucken.TitleBar100Vorschau200024QSKUNDInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Vorschau') on item 'TblDrucken.TitleBar100Vorschau200024QSKUND'.", repo.TblDrucken.TitleBar100Vorschau200024QSKUNDInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.TblDrucken.TitleBar100Vorschau200024QSKUNDInfo, "Text", "Vorschau");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Kunde_1) on item 'TblDrucken.TitleBar100Vorschau200024QSKUND'.", repo.TblDrucken.TitleBar100Vorschau200024QSKUNDInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblDrucken.TitleBar100Vorschau200024QSKUNDInfo, "Text", Kunde_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Kunde_1) on item 'TblDrucken.Row1'.", repo.TblDrucken.Row1Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.TblDrucken.Row1Info, "Text", Kunde_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'B_MNDR_004_02') on item 'TblDrucken.Row1'.", repo.TblDrucken.Row1Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.TblDrucken.Row1Info, "Text", "B_MNDR_004_02");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'06.02.2021\t16.02.2021') on item 'TblDrucken.Row1'.", repo.TblDrucken.Row1Info, new RecordItemIndex(5));
            Validate.AttributeContains(repo.TblDrucken.Row1Info, "Text", "06.02.2021\t16.02.2021");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'86\t86\tEUR') on item 'TblDrucken.Row1'.", repo.TblDrucken.Row1Info, new RecordItemIndex(6));
            Validate.AttributeContains(repo.TblDrucken.Row1Info, "Text", "86\t86\tEUR");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Zahlungserinnerung') on item 'TblDrucken.Row1'.", repo.TblDrucken.Row1Info, new RecordItemIndex(7));
            Validate.AttributeContains(repo.TblDrucken.Row1Info, "Text", "Zahlungserinnerung");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Re.Nr. B_MNDR_004_02 Datum: 2021-02-06\tRe.Betrag 86,00.-  Mahnstufe 1') on item 'TblDrucken.Row1'.", repo.TblDrucken.Row1Info, new RecordItemIndex(8));
            Validate.AttributeContains(repo.TblDrucken.Row1Info, "Text", "Re.Nr. B_MNDR_004_02 Datum: 2021-02-06\tRe.Betrag 86,00.-  Mahnstufe 1");
            
            // search timeout auf 30s gesetzt
            Report.Log(ReportLevel.Info, "Validation", "search timeout auf 30s gesetzt\r\nValidating NotExists on item 'TblDrucken.Row2'.", repo.TblDrucken.Row2Info, new RecordItemIndex(9));
            Validate.NotExists(repo.TblDrucken.Row2Info);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
