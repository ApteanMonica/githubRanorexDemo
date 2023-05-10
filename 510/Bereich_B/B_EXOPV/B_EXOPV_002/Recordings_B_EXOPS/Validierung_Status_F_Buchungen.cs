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

namespace B_EXOPV_002.Recordings_B_EXOPS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validierung_Status_F_Buchungen recording.
    /// </summary>
    [TestModule("c78901a6-1b8c-4d43-bfd6-b6cb53191a27", ModuleType.Recording, 1)]
    public partial class Validierung_Status_F_Buchungen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_002.B_EXOPV_002Repository repository.
        /// </summary>
        public static global::B_EXOPV_002.B_EXOPV_002Repository repo = global::B_EXOPV_002.B_EXOPV_002Repository.Instance;

        static Validierung_Status_F_Buchungen instance = new Validierung_Status_F_Buchungen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validierung_Status_F_Buchungen()
        {
            Beleg1 = "R20/0001";
            Beleg3 = "R20/0003";
            Beleg_Lager = "2020-01";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validierung_Status_F_Buchungen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Beleg_Lager;

        /// <summary>
        /// Gets or sets the value of variable Beleg_Lager.
        /// </summary>
        [TestVariable("102c9c09-b1e9-494d-ab79-48dc8ff860f2")]
        public string Beleg_Lager
        {
            get { return _Beleg_Lager; }
            set { _Beleg_Lager = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Beleg1.
        /// </summary>
        [TestVariable("41802574-2ba4-4a57-b5e8-735f3e5049bb")]
        public string Beleg1
        {
            get { return repo.Beleg1; }
            set { repo.Beleg1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Beleg3.
        /// </summary>
        [TestVariable("16fc424a-1fcf-400f-92fa-5c77d6ab96af")]
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='F') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopStatusRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopStatusRow1Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopStatusRow1Info, "Text", "F");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg1) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBelegnrRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBelegnrRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBelegnrRow1Info, "Text", Beleg1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='RS\\2-Verkauf') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopHerkunftRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopHerkunftRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopHerkunftRow1Info, "Text", "RS\\2-Verkauf");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='F') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopStatusRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopStatusRow2Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopStatusRow2Info, "Text", "F");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg3) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBelegnrRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBelegnrRow2Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBelegnrRow2Info, "Text", Beleg3);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='RS\\2-Verkauf') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopHerkunftRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopHerkunftRow2Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopHerkunftRow2Info, "Text", "RS\\2-Verkauf");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='F') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopStatusRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopStatusRow3Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopStatusRow3Info, "Text", "F");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg_Lager) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBelegnrRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBelegnrRow3Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBelegnrRow3Info, "Text", Beleg_Lager);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='RS\\2-Lager') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopHerkunftRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopHerkunftRow3Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopHerkunftRow3Info, "Text", "RS\\2-Lager");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
