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

namespace Z_UHR_003.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Zeile_5 recording.
    /// </summary>
    [TestModule("1541049d-8663-4d99-86c5-e1386cff86d1", ModuleType.Recording, 1)]
    public partial class Zeile_5 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_UHR_003.Z_UHR_003Repository repository.
        /// </summary>
        public static global::Z_UHR_003.Z_UHR_003Repository repo = global::Z_UHR_003.Z_UHR_003Repository.Instance;

        static Zeile_5 instance = new Zeile_5();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Zeile_5()
        {
            AZ_inkl_Pause = "08:30";
            Datum = "01.07.2022";
            Pausen_Gesamt = "00:30";
            Uhrzeit_Ende_Pause = "13:30";
            Gesamt_AZ_Beginn = "08:00";
            Gesamt_AZ_Ende = "16:30";
            Soll_AZ_Gesamt = "08:00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Zeile_5 Instance
        {
            get { return instance; }
        }

#region Variables

        string _AZ_inkl_Pause;

        /// <summary>
        /// Gets or sets the value of variable AZ_inkl_Pause.
        /// </summary>
        [TestVariable("b7308137-3aff-4ed7-826b-4187c8f9214a")]
        public string AZ_inkl_Pause
        {
            get { return _AZ_inkl_Pause; }
            set { _AZ_inkl_Pause = value; }
        }

        string _Datum;

        /// <summary>
        /// Gets or sets the value of variable Datum.
        /// </summary>
        [TestVariable("e45df3b3-bd78-4c32-9115-75ee5eb7c464")]
        public string Datum
        {
            get { return _Datum; }
            set { _Datum = value; }
        }

        string _Pausen_Gesamt;

        /// <summary>
        /// Gets or sets the value of variable Pausen_Gesamt.
        /// </summary>
        [TestVariable("094a4f35-d4cf-4124-81d2-d5fc18edae54")]
        public string Pausen_Gesamt
        {
            get { return _Pausen_Gesamt; }
            set { _Pausen_Gesamt = value; }
        }

        string _Uhrzeit_Ende_Pause;

        /// <summary>
        /// Gets or sets the value of variable Uhrzeit_Ende_Pause.
        /// </summary>
        [TestVariable("60c8581e-77c2-48cf-bd2b-0bfae5c2f787")]
        public string Uhrzeit_Ende_Pause
        {
            get { return _Uhrzeit_Ende_Pause; }
            set { _Uhrzeit_Ende_Pause = value; }
        }

        string _Gesamt_AZ_Beginn;

        /// <summary>
        /// Gets or sets the value of variable Gesamt_AZ_Beginn.
        /// </summary>
        [TestVariable("aeacc015-1cdb-438d-8b4b-6b1e160eff7b")]
        public string Gesamt_AZ_Beginn
        {
            get { return _Gesamt_AZ_Beginn; }
            set { _Gesamt_AZ_Beginn = value; }
        }

        string _Gesamt_AZ_Ende;

        /// <summary>
        /// Gets or sets the value of variable Gesamt_AZ_Ende.
        /// </summary>
        [TestVariable("158807af-7845-455a-83b7-949d14ab9ba0")]
        public string Gesamt_AZ_Ende
        {
            get { return _Gesamt_AZ_Ende; }
            set { _Gesamt_AZ_Ende = value; }
        }

        string _Soll_AZ_Gesamt;

        /// <summary>
        /// Gets or sets the value of variable Soll_AZ_Gesamt.
        /// </summary>
        [TestVariable("27326b3b-b658-41cc-a829-6fcf0c7ac5ad")]
        public string Soll_AZ_Gesamt
        {
            get { return _Soll_AZ_Gesamt; }
            set { _Soll_AZ_Gesamt = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Fr') on item 'TblAuswertungZeit.Zeile_5.ColTagRow5'.", repo.TblAuswertungZeit.Zeile_5.ColTagRow5Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.TblAuswertungZeit.Zeile_5.ColTagRow5Info, "Text", "Fr");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum) on item 'TblAuswertungZeit.Zeile_5.ColDatumRow5'.", repo.TblAuswertungZeit.Zeile_5.ColDatumRow5Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblAuswertungZeit.Zeile_5.ColDatumRow5Info, "Text", Datum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Gesamt_AZ_Beginn) on item 'TblAuswertungZeit.Zeile_5.ColUhrDtbeginnRow5'.", repo.TblAuswertungZeit.Zeile_5.ColUhrDtbeginnRow5Info, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblAuswertungZeit.Zeile_5.ColUhrDtbeginnRow5Info, "Text", Gesamt_AZ_Beginn);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Gesamt_AZ_Ende) on item 'TblAuswertungZeit.Zeile_5.ColUhrDtendeRow5'.", repo.TblAuswertungZeit.Zeile_5.ColUhrDtendeRow5Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.TblAuswertungZeit.Zeile_5.ColUhrDtendeRow5Info, "Text", Gesamt_AZ_Ende);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$AZ_inkl_Pause) on item 'TblAuswertungZeit.Zeile_5.ColAZGesamtRow5'.", repo.TblAuswertungZeit.Zeile_5.ColAZGesamtRow5Info, new RecordItemIndex(4));
            //Validate.AttributeEqual(repo.TblAuswertungZeit.Zeile_5.ColAZGesamtRow5Info, "Text", AZ_inkl_Pause);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Pausen_Gesamt) on item 'TblAuswertungZeit.Zeile_5.ColPausenRow5'.", repo.TblAuswertungZeit.Zeile_5.ColPausenRow5Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblAuswertungZeit.Zeile_5.ColPausenRow5Info, "Text", Pausen_Gesamt);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Soll_AZ_Gesamt) on item 'TblAuswertungZeit.Zeile_5.ColDauerRow5'.", repo.TblAuswertungZeit.Zeile_5.ColDauerRow5Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblAuswertungZeit.Zeile_5.ColDauerRow5Info, "Text", Soll_AZ_Gesamt);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblAuswertungZeit.ColUEberzeitRow5'.", repo.TblAuswertungZeit.ColUEberzeitRow5Info, new RecordItemIndex(7));
            //Validate.AttributeEqual(repo.TblAuswertungZeit.ColUEberzeitRow5Info, "Text", "");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
