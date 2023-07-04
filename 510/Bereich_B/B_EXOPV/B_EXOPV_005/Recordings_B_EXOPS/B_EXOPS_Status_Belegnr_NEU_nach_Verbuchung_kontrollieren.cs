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

namespace B_EXOPV_005.Recordings_B_EXOPS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The B_EXOPS_Status_Belegnr_NEU_nach_Verbuchung_kontrollieren recording.
    /// </summary>
    [TestModule("3f436bc6-50d1-42fc-bc76-13c3c726a568", ModuleType.Recording, 1)]
    public partial class B_EXOPS_Status_Belegnr_NEU_nach_Verbuchung_kontrollieren : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_005.B_EXOPV_005Repository repository.
        /// </summary>
        public static global::B_EXOPV_005.B_EXOPV_005Repository repo = global::B_EXOPV_005.B_EXOPV_005Repository.Instance;

        static B_EXOPS_Status_Belegnr_NEU_nach_Verbuchung_kontrollieren instance = new B_EXOPS_Status_Belegnr_NEU_nach_Verbuchung_kontrollieren();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_EXOPS_Status_Belegnr_NEU_nach_Verbuchung_kontrollieren()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_EXOPS_Status_Belegnr_NEU_nach_Verbuchung_kontrollieren Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='F') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1Info, "Text", "F");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopStatusRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopStatusRow2Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopStatusRow2Info, "Text", "V");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopStatusRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopStatusRow3Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopStatusRow3Info, "Text", "V");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopStatusRow4'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopStatusRow4Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopStatusRow4Info, "Text", "V");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopStatusRow5'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopStatusRow5Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopStatusRow5Info, "Text", "V");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopStatusRow6'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopStatusRow6Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopStatusRow6Info, "Text", "V");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopStatusRow7'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopStatusRow7Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopStatusRow7Info, "Text", "V");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopStatusRow8'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopStatusRow8Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopStatusRow8Info, "Text", "V");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER03_B_EXOPV_005_NEU') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopBelegnrRow7'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopBelegnrRow7Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopBelegnrRow7Info, "Text", "ER03_B_EXOPV_005_NEU");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='FB03_B_EXOPV_005_NEU') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopNrfremdbelegRow7'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopNrfremdbelegRow7Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopNrfremdbelegRow7Info, "Text", "FB03_B_EXOPV_005_NEU");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
