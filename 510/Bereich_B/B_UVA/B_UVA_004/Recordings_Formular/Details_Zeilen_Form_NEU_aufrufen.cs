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

namespace B_UVA_004.Recordings_Formular
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Details_Zeilen_Form_NEU_aufrufen recording.
    /// </summary>
    [TestModule("715dea6d-0d32-47ea-8e79-2412337182b8", ModuleType.Recording, 1)]
    public partial class Details_Zeilen_Form_NEU_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_004.B_UVA_004Repository repository.
        /// </summary>
        public static global::B_UVA_004.B_UVA_004Repository repo = global::B_UVA_004.B_UVA_004Repository.Instance;

        static Details_Zeilen_Form_NEU_aufrufen instance = new Details_Zeilen_Form_NEU_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Details_Zeilen_Form_NEU_aufrufen()
        {
            Firma_2 = "200";
            Form_Name_NEU = "UVA-Österreich 2023";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Details_Zeilen_Form_NEU_aufrufen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Firma_2;

        /// <summary>
        /// Gets or sets the value of variable Firma_2.
        /// </summary>
        [TestVariable("1585f0a5-729c-4531-8cb9-265801058f7b")]
        public string Firma_2
        {
            get { return _Firma_2; }
            set { _Firma_2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Form_Name_NEU.
        /// </summary>
        [TestVariable("3677a99c-fd12-4125-a79a-69548c855386")]
        public string Form_Name_NEU
        {
            get { return repo.Form_Name_NEU; }
            set { repo.Form_Name_NEU = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Firma_2) on item 'TblUVAF.TitleBar200VerwaltenUVAFormulare'.", repo.TblUVAF.TitleBar200VerwaltenUVAFormulareInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.TblUVAF.TitleBar200VerwaltenUVAFormulareInfo, "Text", Firma_2);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblUVAF.FlexGrid.ColUvaDrucken_Zeile_mit_Form_Name_NEU'", repo.TblUVAF.FlexGrid.ColUvaDrucken_Zeile_mit_Form_Name_NEUInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.TblUVAF.FlexGrid.ColUvaDrucken_Zeile_mit_Form_Name_NEUInfo.WaitForExists(120000);
            
            // TODO: variabel Zeile mit A21 elektieren
            Report.Log(ReportLevel.Info, "Validation", "TODO: variabel Zeile mit A21 elektieren\r\nValidating AttributeEqual (Text=$Form_Name_NEU) on item 'TblUVAF.FlexGrid.UVA_Form_Bez_in_zeile_mit_Form_Name_NEU'.", repo.TblUVAF.FlexGrid.UVA_Form_Bez_in_zeile_mit_Form_Name_NEUInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblUVAF.FlexGrid.UVA_Form_Bez_in_zeile_mit_Form_Name_NEUInfo, "Text", Form_Name_NEU);
            
            // TODO: variabel Zeile mit A21_ selektieren
            Report.Log(ReportLevel.Info, "Validation", "TODO: variabel Zeile mit A21_ selektieren\r\nValidating AttributeEqual (AccessibleValue='True') on item 'TblUVAF.FlexGrid.ColUvaDrucken_Zeile_mit_Form_Name_NEU'.", repo.TblUVAF.FlexGrid.ColUvaDrucken_Zeile_mit_Form_Name_NEUInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblUVAF.FlexGrid.ColUvaDrucken_Zeile_mit_Form_Name_NEUInfo, "AccessibleValue", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblUVAF.FlexGrid.UVA_Form_Bez_in_zeile_mit_Form_Name_NEU' at Center.", repo.TblUVAF.FlexGrid.UVA_Form_Bez_in_zeile_mit_Form_Name_NEUInfo, new RecordItemIndex(4));
            repo.TblUVAF.FlexGrid.UVA_Form_Bez_in_zeile_mit_Form_Name_NEU.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblUVAD.TitleBar200UVADetailsUVAOEsterre'", repo.TblUVAD.TitleBar200UVADetailsUVAOEsterreInfo, new ActionTimeout(120000), new RecordItemIndex(5));
            repo.TblUVAD.TitleBar200UVADetailsUVAOEsterreInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Form_Name_NEU) on item 'TblUVAD.TitleBar200UVADetailsUVAOEsterre'.", repo.TblUVAD.TitleBar200UVADetailsUVAOEsterreInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.TblUVAD.TitleBar200UVADetailsUVAOEsterreInfo, "Text", Form_Name_NEU);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Firma_2) on item 'TblUVAD.TitleBar200UVADetailsUVAOEsterre'.", repo.TblUVAD.TitleBar200UVADetailsUVAOEsterreInfo, new RecordItemIndex(7));
            Validate.AttributeContains(repo.TblUVAD.TitleBar200UVADetailsUVAOEsterreInfo, "Text", Firma_2);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
