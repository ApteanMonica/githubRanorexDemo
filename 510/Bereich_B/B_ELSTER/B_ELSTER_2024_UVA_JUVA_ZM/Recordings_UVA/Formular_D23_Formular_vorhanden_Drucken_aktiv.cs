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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordings_UVA
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Formular_D23_Formular_vorhanden_Drucken_aktiv recording.
    /// </summary>
    [TestModule("e409184a-dad1-4326-968a-8fe36694dcf2", ModuleType.Recording, 1)]
    public partial class Formular_D23_Formular_vorhanden_Drucken_aktiv : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_004Repository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_004Repository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_004Repository.Instance;

        static Formular_D23_Formular_vorhanden_Drucken_aktiv instance = new Formular_D23_Formular_vorhanden_Drucken_aktiv();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Formular_D23_Formular_vorhanden_Drucken_aktiv()
        {
            UVA_D23_Form_Code = "D23";
            UVA_D23_Form_Name = "UVA-Deutschland 2023 Elster";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Formular_D23_Formular_vorhanden_Drucken_aktiv Instance
        {
            get { return instance; }
        }

#region Variables

        string _UVA_D23_Form_Code;

        /// <summary>
        /// Gets or sets the value of variable UVA_D23_Form_Code.
        /// </summary>
        [TestVariable("52477e55-87af-4559-b0f7-7bc4c097aa0f")]
        public string UVA_D23_Form_Code
        {
            get { return _UVA_D23_Form_Code; }
            set { _UVA_D23_Form_Code = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable UVA_D23_Form_Name.
        /// </summary>
        [TestVariable("8dbdf37e-bc89-494d-bdce-3e940116728c")]
        public string UVA_D23_Form_Name
        {
            get { return repo.UVA_D23_Form_Name; }
            set { repo.UVA_D23_Form_Name = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblUVAF.PageDown' at Center.", repo.TblUVAF.PageDownInfo, new RecordItemIndex(0));
            repo.TblUVAF.PageDown.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_D23_Form_Code) on item 'TblUVAF.Tabelle_flexgrid.ColUvaCdin_Zeile_mit_Variable_UVA_D23_Form_Name'.", repo.TblUVAF.Tabelle_flexgrid.ColUvaCdin_Zeile_mit_Variable_UVA_D23_Form_NameInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblUVAF.Tabelle_flexgrid.ColUvaCdin_Zeile_mit_Variable_UVA_D23_Form_NameInfo, "Text", UVA_D23_Form_Code);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='True') on item 'TblUVAF.Tabelle_flexgrid.ColUvaDruckenRowmit_Variable_UVA_D23_Form_Name'.", repo.TblUVAF.Tabelle_flexgrid.ColUvaDruckenRowmit_Variable_UVA_D23_Form_NameInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblUVAF.Tabelle_flexgrid.ColUvaDruckenRowmit_Variable_UVA_D23_Form_NameInfo, "AccessibleValue", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
