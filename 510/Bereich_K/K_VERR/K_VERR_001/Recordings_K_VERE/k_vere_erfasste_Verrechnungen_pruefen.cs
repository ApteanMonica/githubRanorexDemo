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

namespace K_VERR_001.Recordings_K_VERE
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The k_vere_erfasste_Verrechnungen_pruefen recording.
    /// </summary>
    [TestModule("1643f4ac-37b8-4a9c-9b97-b1bb9a734456", ModuleType.Recording, 1)]
    public partial class K_vere_erfasste_Verrechnungen_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_VERR_001.K_VERR_001Repository repository.
        /// </summary>
        public static global::K_VERR_001.K_VERR_001Repository repo = global::K_VERR_001.K_VERR_001Repository.Instance;

        static K_vere_erfasste_Verrechnungen_pruefen instance = new K_vere_erfasste_Verrechnungen_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public K_vere_erfasste_Verrechnungen_pruefen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static K_vere_erfasste_Verrechnungen_pruefen Instance
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

            // erfasste Zeile_1 (=row2)
            Report.Log(ReportLevel.Info, "Section", "erfasste Zeile_1 (=row2)", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20') on item 'TblVerr.Row2_Zeile_1_in_Tabelle.ColVestNrRow2'.", repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColVestNrRow2Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColVestNrRow2Info, "Text", "20");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='STS') on item 'TblVerr.Row2_Zeile_1_in_Tabelle.ColVeraCdRow2'.", repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColVeraCdRow2Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColVeraCdRow2Info, "Text", "STS");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='9999999999') on item 'TblVerr.Row2_Zeile_1_in_Tabelle.ColKtoNrVonRow2'.", repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColKtoNrVonRow2Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColKtoNrVonRow2Info, "Text", "9999999999");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10') on item 'TblVerr.Row2_Zeile_1_in_Tabelle.ColKs1NrVonRow2'.", repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColKs1NrVonRow2Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColKs1NrVonRow2Info, "Text", "10");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='9999999999') on item 'TblVerr.Row2_Zeile_1_in_Tabelle.ColKtoNrAnRow2'.", repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColKtoNrAnRow2Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColKtoNrAnRow2Info, "Text", "9999999999");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='*') on item 'TblVerr.Row2_Zeile_1_in_Tabelle.ColKs1NrAnRow2'.", repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColKs1NrAnRow2Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColKs1NrAnRow2Info, "Text", "*");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='120,00') on item 'TblVerr.Row2_Zeile_1_in_Tabelle.ColVerrBetragRow2'.", repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColVerrBetragRow2Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColVerrBetragRow2Info, "Text", "120,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Import Stundenerfassung') on item 'TblVerr.Row2_Zeile_1_in_Tabelle.ColVerrTextRow2'.", repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColVerrTextRow2Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblVerr.Row2_Zeile_1_in_Tabelle.ColVerrTextRow2Info, "Text", "Import Stundenerfassung");
            
            // erfasste Zeile_2 (=row3)
            Report.Log(ReportLevel.Info, "Section", "erfasste Zeile_2 (=row3)", new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='21') on item 'TblVerr.Row3_Zeile_2_in_Tabelle.ColVestNrRow3'.", repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColVestNrRow3Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColVestNrRow3Info, "Text", "21");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='SVE') on item 'TblVerr.Row3_Zeile_2_in_Tabelle.ColVeraCdRow3'.", repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColVeraCdRow3Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColVeraCdRow3Info, "Text", "SVE");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='E1000') on item 'TblVerr.Row3_Zeile_2_in_Tabelle.ColKtoNrVonRow3'.", repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColKtoNrVonRow3Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColKtoNrVonRow3Info, "Text", "E1000");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10') on item 'TblVerr.Row3_Zeile_2_in_Tabelle.ColKs1NrVonRow3'.", repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColKs1NrVonRow3Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColKs1NrVonRow3Info, "Text", "10");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='B1000') on item 'TblVerr.Row3_Zeile_2_in_Tabelle.ColKtoNrAnRow3'.", repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColKtoNrAnRow3Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColKtoNrAnRow3Info, "Text", "B1000");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='60') on item 'TblVerr.Row3_Zeile_2_in_Tabelle.ColKs1NrAnRow3'.", repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColKs1NrAnRow3Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColKs1NrAnRow3Info, "Text", "60");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='150') on item 'TblVerr.Row3_Zeile_2_in_Tabelle.ColVerrMenge1Row3'.", repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColVerrMenge1Row3Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColVerrMenge1Row3Info, "Text", "150");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Verrechnung K_VERR_001 Menge 150 an KST 60') on item 'TblVerr.Row3_Zeile_2_in_Tabelle.ColVerrTextRow3'.", repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColVerrTextRow3Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.TblVerr.Row3_Zeile_2_in_Tabelle.ColVerrTextRow3Info, "Text", "Verrechnung K_VERR_001 Menge 150 an KST 60");
            
            // erfasste Zeile_3 (=row4)
            Report.Log(ReportLevel.Info, "Section", "erfasste Zeile_3 (=row4)", new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='21') on item 'TblVerr.Row4_Zeile_3_in_Tabelle.ColVestNrRow4'.", repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColVestNrRow4Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColVestNrRow4Info, "Text", "21");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='SVE') on item 'TblVerr.Row4_Zeile_3_in_Tabelle.ColVeraCdRow4'.", repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColVeraCdRow4Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColVeraCdRow4Info, "Text", "SVE");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='E1000') on item 'TblVerr.Row4_Zeile_3_in_Tabelle.ColKtoNrVonRow4'.", repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColKtoNrVonRow4Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColKtoNrVonRow4Info, "Text", "E1000");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10') on item 'TblVerr.Row4_Zeile_3_in_Tabelle.ColKs1NrVonRow4'.", repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColKs1NrVonRow4Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColKs1NrVonRow4Info, "Text", "10");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='B1000') on item 'TblVerr.Row4_Zeile_3_in_Tabelle.ColKtoNrAnRow4'.", repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColKtoNrAnRow4Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColKtoNrAnRow4Info, "Text", "B1000");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='80') on item 'TblVerr.Row4_Zeile_3_in_Tabelle.ColKs1NrAnRow4'.", repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColKs1NrAnRow4Info, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColKs1NrAnRow4Info, "Text", "80");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100') on item 'TblVerr.Row4_Zeile_3_in_Tabelle.ColVerrMenge1Row4'.", repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColVerrMenge1Row4Info, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColVerrMenge1Row4Info, "Text", "100");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Verrechnung K_VERR_001 Menge 100 an KST 80') on item 'TblVerr.Row4_Zeile_3_in_Tabelle.ColVerrTextRow4'.", repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColVerrTextRow4Info, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.TblVerr.Row4_Zeile_3_in_Tabelle.ColVerrTextRow4Info, "Text", "Verrechnung K_VERR_001 Menge 100 an KST 80");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
