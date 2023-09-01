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

namespace K_VERE_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Stufe_21_2_Zeile_einfuegen_sichtbare_Spalten_pruefen recording.
    /// </summary>
    [TestModule("232ee0ad-5af9-4d96-af3c-121d05060f5c", ModuleType.Recording, 1)]
    public partial class Stufe_21_2_Zeile_einfuegen_sichtbare_Spalten_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_VERE_001.K_VERE_001Repository repository.
        /// </summary>
        public static global::K_VERE_001.K_VERE_001Repository repo = global::K_VERE_001.K_VERE_001Repository.Instance;

        static Stufe_21_2_Zeile_einfuegen_sichtbare_Spalten_pruefen instance = new Stufe_21_2_Zeile_einfuegen_sichtbare_Spalten_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Stufe_21_2_Zeile_einfuegen_sichtbare_Spalten_pruefen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Stufe_21_2_Zeile_einfuegen_sichtbare_Spalten_pruefen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'TblVerr_K_VERE.FlexGrid' at Center.", repo.TblVerr_K_VERE.FlexGridInfo, new RecordItemIndex(0));
            repo.TblVerr_K_VERE.FlexGrid.Click(System.Windows.Forms.MouseButtons.Right);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Insert}' with focus on 'TblVerr_K_VERE.FlexGrid'.", repo.TblVerr_K_VERE.FlexGridInfo, new RecordItemIndex(2));
            repo.TblVerr_K_VERE.FlexGrid.PressKeys("{Insert}");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'TblVerr_K_VERE.Row3_zweite_Erfassungszeile.Row3_zweite_Erfassungszeile'", repo.TblVerr_K_VERE.Row3_zweite_Erfassungszeile.Row3_zweite_ErfassungszeileInfo, new ActionTimeout(60000), new RecordItemIndex(3));
            repo.TblVerr_K_VERE.Row3_zweite_Erfassungszeile.Row3_zweite_ErfassungszeileInfo.WaitForExists(60000);
            
            // nicht für die Einschränkung relevante Felder müssen ausgeblendet sein
            Report.Log(ReportLevel.Info, "Section", "nicht für die Einschränkung relevante Felder müssen ausgeblendet sein", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='False') on item 'TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKs1NrVonRow2'.", repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKs1NrVonRow2Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKs1NrVonRow2Info, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKs1NrAnRow2'.", repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKs1NrAnRow2Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKs1NrAnRow2Info, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrMenge1Row2'.", repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrMenge1Row2Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrMenge1Row2Info, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrTextRow2'.", repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrTextRow2Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrTextRow2Info, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='False') on item 'TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKtoNrVonRow2'.", repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKtoNrVonRow2Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKtoNrVonRow2Info, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='False') on item 'TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKtoNrAnRow2'.", repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKtoNrAnRow2Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKtoNrAnRow2Info, "Visible", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='False') on item 'TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrBetragRow2'.", repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrBetragRow2Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrBetragRow2Info, "Visible", "False");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
