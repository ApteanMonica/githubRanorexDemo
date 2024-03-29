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

namespace B_EXOPV_001.Recordings_B_EXOPS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validierung_Status_F_Buchungen recording.
    /// </summary>
    [TestModule("c7bc3819-6d68-40dd-b426-4cff87d04764", ModuleType.Recording, 1)]
    public partial class Validierung_Status_F_Buchungen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_001.B_EXOPV_001Repository repository.
        /// </summary>
        public static global::B_EXOPV_001.B_EXOPV_001Repository repo = global::B_EXOPV_001.B_EXOPV_001Repository.Instance;

        static Validierung_Status_F_Buchungen instance = new Validierung_Status_F_Buchungen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validierung_Status_F_Buchungen()
        {
            Beleg1 = "00001";
            Beleg3 = "1900005";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validierung_Status_F_Buchungen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Beleg1.
        /// </summary>
        [TestVariable("4fd0d110-02d0-4c27-b953-a96453776045")]
        public string Beleg1
        {
            get { return repo.Beleg1; }
            set { repo.Beleg1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Beleg3.
        /// </summary>
        [TestVariable("dc6a8130-5f65-43d7-bce2-00a9155a0f1b")]
        public string Beleg3
        {
            get { return repo.Beleg3; }
            set { repo.Beleg3 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='F') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopStatus_in_Zeile_mit_Beleg1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopStatus_in_Zeile_mit_Beleg1Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopStatus_in_Zeile_mit_Beleg1Info, "Text", "F");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg1) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopBelegnr_in_Zeile_mit_Beleg1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopBelegnr_in_Zeile_mit_Beleg1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopBelegnr_in_Zeile_mit_Beleg1Info, "Text", Beleg1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='B_BUKA') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopHerkunft_in_Zeile_mit_Beleg1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopHerkunft_in_Zeile_mit_Beleg1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopHerkunft_in_Zeile_mit_Beleg1Info, "Text", "B_BUKA");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='F') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopStatus_in_Zeile_mit_Beleg3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopStatus_in_Zeile_mit_Beleg3Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopStatus_in_Zeile_mit_Beleg3Info, "Text", "F");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg3) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopBelegnr_in_Zeile_mit_Beleg3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopBelegnr_in_Zeile_mit_Beleg3Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopBelegnr_in_Zeile_mit_Beleg3Info, "Text", Beleg3);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER-BUCH') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopHerkunft_in_Zeile_mit_Beleg3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopHerkunft_in_Zeile_mit_Beleg3Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopHerkunft_in_Zeile_mit_Beleg3Info, "Text", "ER-BUCH");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
