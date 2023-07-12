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
    ///The B_EXOPS_Belegnummern_vor_Pruefung_kontrollieren recording.
    /// </summary>
    [TestModule("1a7d0a79-c1fb-4c03-ac7e-8692e9bf99f8", ModuleType.Recording, 1)]
    public partial class B_EXOPS_Belegnummern_vor_Pruefung_kontrollieren : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_005.B_EXOPV_005Repository repository.
        /// </summary>
        public static global::B_EXOPV_005.B_EXOPV_005Repository repo = global::B_EXOPV_005.B_EXOPV_005Repository.Instance;

        static B_EXOPS_Belegnummern_vor_Pruefung_kontrollieren instance = new B_EXOPS_Belegnummern_vor_Pruefung_kontrollieren();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_EXOPS_Belegnummern_vor_Pruefung_kontrollieren()
        {
            LF_01 = "303201";
            LF_02 = "303202";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_EXOPS_Belegnummern_vor_Pruefung_kontrollieren Instance
        {
            get { return instance; }
        }

#region Variables

        string _LF_01;

        /// <summary>
        /// Gets or sets the value of variable LF_01.
        /// </summary>
        [TestVariable("3cbf3947-cb6e-49df-89e0-4fbee6a9f670")]
        public string LF_01
        {
            get { return _LF_01; }
            set { _LF_01 = value; }
        }

        string _LF_02;

        /// <summary>
        /// Gets or sets the value of variable LF_02.
        /// </summary>
        [TestVariable("39bfb608-9139-4e12-9768-64871bc4265e")]
        public string LF_02
        {
            get { return _LF_02; }
            set { _LF_02 = value; }
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

            // Beleg1
            Report.Log(ReportLevel.Info, "Section", "Beleg1", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_01) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColAdrNrRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColAdrNrRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColAdrNrRow1Info, "Text", LF_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER01_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopBelegnrRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopBelegnrRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopBelegnrRow1Info, "Text", "ER01_B_EXOPV_005");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='FB01_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopNrfremdbelegRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopNrfremdbelegRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopNrfremdbelegRow1Info, "Text", "FB01_B_EXOPV_005");
            
            // Beleg2
            Report.Log(ReportLevel.Info, "Section", "Beleg2", new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopStatusRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopStatusRow2Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopStatusRow2Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_01) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColAdrNrRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColAdrNrRow2Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColAdrNrRow2Info, "Text", LF_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER03_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopBelegnrRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopBelegnrRow2Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopBelegnrRow2Info, "Text", "ER03_B_EXOPV_005");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='FB02_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopNrfremdbelegRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopNrfremdbelegRow2Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopNrfremdbelegRow2Info, "Text", "FB02_B_EXOPV_005");
            
            // Beleg3
            Report.Log(ReportLevel.Info, "Section", "Beleg3", new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopStatusRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopStatusRow3Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopStatusRow3Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_01) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColAdrNrRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColAdrNrRow3Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColAdrNrRow3Info, "Text", LF_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER04_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopBelegnrRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopBelegnrRow3Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopBelegnrRow3Info, "Text", "ER04_B_EXOPV_005");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='FB04_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopNrfremdbelegRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopNrfremdbelegRow3Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopNrfremdbelegRow3Info, "Text", "FB04_B_EXOPV_005");
            
            // Beleg4
            Report.Log(ReportLevel.Info, "Section", "Beleg4", new RecordItemIndex(15));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopStatusRow4'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopStatusRow4Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopStatusRow4Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_01) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColAdrNrRow4'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColAdrNrRow4Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColAdrNrRow4Info, "Text", LF_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER04_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopBelegnrRow4'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopBelegnrRow4Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopBelegnrRow4Info, "Text", "ER04_B_EXOPV_005");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='FB05_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopNrfremdbelegRow4'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopNrfremdbelegRow4Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopNrfremdbelegRow4Info, "Text", "FB05_B_EXOPV_005");
            
            // Beleg5
            Report.Log(ReportLevel.Info, "Section", "Beleg5", new RecordItemIndex(20));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopStatusRow5'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopStatusRow5Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopStatusRow5Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_01) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColAdrNrRow5'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColAdrNrRow5Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColAdrNrRow5Info, "Text", LF_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER06_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopBelegnrRow5'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopBelegnrRow5Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopBelegnrRow5Info, "Text", "ER06_B_EXOPV_005");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='FB04_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopNrfremdbelegRow5'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopNrfremdbelegRow5Info, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopNrfremdbelegRow5Info, "Text", "FB04_B_EXOPV_005");
            
            // Beleg6
            Report.Log(ReportLevel.Info, "Section", "Beleg6", new RecordItemIndex(25));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopStatusRow6'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopStatusRow6Info, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopStatusRow6Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_02) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColAdrNrRow6'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColAdrNrRow6Info, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColAdrNrRow6Info, "Text", LF_02);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER02_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopBelegnrRow6'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopBelegnrRow6Info, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopBelegnrRow6Info, "Text", "ER02_B_EXOPV_005");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='FB02_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopNrfremdbelegRow6'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopNrfremdbelegRow6Info, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopNrfremdbelegRow6Info, "Text", "FB02_B_EXOPV_005");
            
            // Beleg7
            Report.Log(ReportLevel.Info, "Section", "Beleg7", new RecordItemIndex(30));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopStatusRow7'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopStatusRow7Info, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopStatusRow7Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_02) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColAdrNrRow7'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColAdrNrRow7Info, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColAdrNrRow7Info, "Text", LF_02);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER03_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopBelegnrRow7'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopBelegnrRow7Info, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopBelegnrRow7Info, "Text", "ER03_B_EXOPV_005");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='FB03_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopNrfremdbelegRow7'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopNrfremdbelegRow7Info, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopNrfremdbelegRow7Info, "Text", "FB03_B_EXOPV_005");
            
            // Beleg8
            Report.Log(ReportLevel.Info, "Section", "Beleg8", new RecordItemIndex(35));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopStatusRow8'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopStatusRow8Info, new RecordItemIndex(36));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopStatusRow8Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_02) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColAdrNrRow8'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColAdrNrRow8Info, new RecordItemIndex(37));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColAdrNrRow8Info, "Text", LF_02);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER05_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopBelegnrRow8'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopBelegnrRow8Info, new RecordItemIndex(38));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopBelegnrRow8Info, "Text", "ER05_B_EXOPV_005");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='FB05_B_EXOPV_005') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopNrfremdbelegRow8'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopNrfremdbelegRow8Info, new RecordItemIndex(39));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopNrfremdbelegRow8Info, "Text", "FB05_B_EXOPV_005");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
