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

namespace B_EXOPV_003.Recordings_B_EXOPS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Belege_in_Schnittstelle_pruefen_B_nach_UEberleitung recording.
    /// </summary>
    [TestModule("c150558c-ff75-42c1-8afb-15785852754b", ModuleType.Recording, 1)]
    public partial class Belege_in_Schnittstelle_pruefen_B_nach_Ueberleitung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_003.B_EXOPV_003Repository repository.
        /// </summary>
        public static global::B_EXOPV_003.B_EXOPV_003Repository repo = global::B_EXOPV_003.B_EXOPV_003Repository.Instance;

        static Belege_in_Schnittstelle_pruefen_B_nach_Ueberleitung instance = new Belege_in_Schnittstelle_pruefen_B_nach_Ueberleitung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Belege_in_Schnittstelle_pruefen_B_nach_Ueberleitung()
        {
            Beleg1 = "R20/0009";
            Beleg2 = "R20/0010";
            Tagesdatum = "";
            Text_Beleg2 = "B_EXOPV_003_R20/0010";
            Text_Beleg1 = "B_EXOPV_003_R20/0009";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Belege_in_Schnittstelle_pruefen_B_nach_Ueberleitung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("4a042956-00e2-46be-8c41-948d32111870")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        string _Text_Beleg2;

        /// <summary>
        /// Gets or sets the value of variable Text_Beleg2.
        /// </summary>
        [TestVariable("badc1f7b-7897-412f-88b7-420e8fc20a83")]
        public string Text_Beleg2
        {
            get { return _Text_Beleg2; }
            set { _Text_Beleg2 = value; }
        }

        string _Text_Beleg1;

        /// <summary>
        /// Gets or sets the value of variable Text_Beleg1.
        /// </summary>
        [TestVariable("f6fbd8ca-2aaf-4b64-9f74-b320a8e38db2")]
        public string Text_Beleg1
        {
            get { return _Text_Beleg1; }
            set { _Text_Beleg1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Beleg1.
        /// </summary>
        [TestVariable("0863d439-e09a-4e82-9e83-b2d3f40ff9a8")]
        public string Beleg1
        {
            get { return repo.Beleg1; }
            set { repo.Beleg1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Beleg2.
        /// </summary>
        [TestVariable("c72d6c28-acae-4b49-a51a-9da7dddff7fd")]
        public string Beleg2
        {
            get { return repo.Beleg2; }
            set { repo.Beleg2 = value; }
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

            // Zeile_1 Beleg1b
            Report.Log(ReportLevel.Info, "Section", "Zeile_1 Beleg1b", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopStatusRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopStatusRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopStatusRow1Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg1) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBelegnrRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBelegnrRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBelegnrRow1Info, "Text", Beleg1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2.400,00') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBetragRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBetragRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopBetragRow1Info, "Text", "2.400,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopText1Row1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopText1Row1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopText1Row1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='RS\\2-Verkauf') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopHerkunftRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopHerkunftRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_1.ColExopHerkunftRow1Info, "Text", "RS\\2-Verkauf");
            
            // Zeile_2 Beleg2c
            Report.Log(ReportLevel.Info, "Section", "Zeile_2 Beleg2c", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopStatusRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopStatusRow2Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopStatusRow2Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg2) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBelegnrRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBelegnrRow2Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBelegnrRow2Info, "Text", Beleg2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='-1.200,00') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBetragRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBetragRow2Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopBetragRow2Info, "Text", "-1.200,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Text_Beleg2) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopText1Row2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopText1Row2Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopText1Row2Info, "Text", Text_Beleg2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='RS\\2-Verkauf') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopHerkunftRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopHerkunftRow2Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_2.ColExopHerkunftRow2Info, "Text", "RS\\2-Verkauf");
            
            // Zeile_3
            Report.Log(ReportLevel.Info, "Section", "Zeile_3", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopStatusRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopStatusRow3Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopStatusRow3Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg2) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBelegnrRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBelegnrRow3Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBelegnrRow3Info, "Text", Beleg2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3.600,00') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBetragRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBetragRow3Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopBetragRow3Info, "Text", "3.600,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopText1Row3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopText1Row3Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopText1Row3Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='RS\\2-Verkauf') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopHerkunftRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopHerkunftRow3Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_3.ColExopHerkunftRow3Info, "Text", "RS\\2-Verkauf");
            
            // Zeile_4 auf Status S geändert
            Report.Log(ReportLevel.Info, "Section", "Zeile_4 auf Status S geändert", new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='S') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopStatusRow4'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopStatusRow4Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopStatusRow4Info, "Text", "S");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg1) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopBelegnrRow4'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopBelegnrRow4Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopBelegnrRow4Info, "Text", Beleg1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.200,00') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopBetragRow4'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopBetragRow4Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopBetragRow4Info, "Text", "1.200,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Text_Beleg1) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopText1Row4'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopText1Row4Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopText1Row4Info, "Text", Text_Beleg1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='RS\\2-Verkauf') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopHerkunftRow4'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopHerkunftRow4Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_4.ColExopHerkunftRow4Info, "Text", "RS\\2-Verkauf");
            
            // Zeile_5 Status V (unverändert)
            Report.Log(ReportLevel.Info, "Section", "Zeile_5 Status V (unverändert)", new RecordItemIndex(24));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopStatusRow5'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopStatusRow5Info, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopStatusRow5Info, "Text", "V");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg2) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBelegnrRow5'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBelegnrRow5Info, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBelegnrRow5Info, "Text", Beleg2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.200,00') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBetragRow5'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBetragRow5Info, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopBetragRow5Info, "Text", "1.200,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Text_Beleg2) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopText1Row5'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopText1Row5Info, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopText1Row5Info, "Text", Text_Beleg2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='RS\\2-Verkauf') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopHerkunftRow5'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopHerkunftRow5Info, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Row_5.ColExopHerkunftRow5Info, "Text", "RS\\2-Verkauf");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
