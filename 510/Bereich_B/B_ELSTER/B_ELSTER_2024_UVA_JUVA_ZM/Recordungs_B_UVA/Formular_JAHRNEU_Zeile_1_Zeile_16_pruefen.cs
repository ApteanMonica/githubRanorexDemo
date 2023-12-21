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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordungs_B_UVA
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Formular_JAHRNEU_Zeile_1_Zeile_16_pruefen recording.
    /// </summary>
    [TestModule("d0cb8165-4856-4e0d-80c9-81e39ea7cc6f", ModuleType.Recording, 1)]
    public partial class Formular_JAHRNEU_Zeile_1_Zeile_16_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static Formular_JAHRNEU_Zeile_1_Zeile_16_pruefen instance = new Formular_JAHRNEU_Zeile_1_Zeile_16_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Formular_JAHRNEU_Zeile_1_Zeile_16_pruefen()
        {
            UVA_JAHRNEU_Form_Name = "UVA-Deutschland 2023 Elster";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Formular_JAHRNEU_Zeile_1_Zeile_16_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable UVA_JAHRNEU_Form_Name.
        /// </summary>
        [TestVariable("23c69af7-c5f7-4c48-8b2c-79dcbd6b0c51")]
        public string UVA_JAHRNEU_Form_Name
        {
            get { return repo.UVA_JAHRNEU_Form_Name; }
            set { repo.UVA_JAHRNEU_Form_Name = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(0));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblUVAF.PageDown' at Center.", repo.TblUVAF.PageDownInfo, new RecordItemIndex(1));
            repo.TblUVAF.PageDown.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblUVAF.Tabelle_mit_Variable_UVA_JAHRNEU_Form_Name.Column0_in_Zeile_mit_Variable_UVA_JAHRNEU_Form_Name' at Center.", repo.TblUVAF.Tabelle_mit_Variable_UVA_JAHRNEU_Form_Name.Column0_in_Zeile_mit_Variable_UVA_JAHRNEU_Form_NameInfo, new RecordItemIndex(2));
            repo.TblUVAF.Tabelle_mit_Variable_UVA_JAHRNEU_Form_Name.Column0_in_Zeile_mit_Variable_UVA_JAHRNEU_Form_Name.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'TblUVAD.TitleBar300UVADetailsUVADeutschl'", repo.TblUVAD.TitleBar300UVADetailsUVADeutschlInfo, new ActionTimeout(60000), new RecordItemIndex(3));
            repo.TblUVAD.TitleBar300UVADetailsUVADeutschlInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[300]  UVA-Details: ') on item 'TblUVAD.TitleBar300UVADetailsUVADeutschl'.", repo.TblUVAD.TitleBar300UVADetailsUVADeutschlInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.TblUVAD.TitleBar300UVADetailsUVADeutschlInfo, "Text", "[300]  UVA-Details: ");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$UVA_JAHRNEU_Form_Name) on item 'TblUVAD.TitleBar300UVADetailsUVADeutschl'.", repo.TblUVAD.TitleBar300UVADetailsUVADeutschlInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.TblUVAD.TitleBar300UVADetailsUVADeutschlInfo, "Text", UVA_JAHRNEU_Form_Name);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'TblUVAD.ChildTableWindow.ColUvaDZeileRow1'.", repo.TblUVAD.ChildTableWindow.ColUvaDZeileRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblUVAD.ChildTableWindow.ColUvaDZeileRow1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='41') on item 'TblUVAD.ChildTableWindow.ColUvaDFormnrRow1'.", repo.TblUVAD.ChildTableWindow.ColUvaDFormnrRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblUVAD.ChildTableWindow.ColUvaDFormnrRow1Info, "Text", "41");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Innergemeinschaftliche Lieferungen') on item 'TblUVAD.ChildTableWindow.ColUvaDBezRow1'.", repo.TblUVAD.ChildTableWindow.ColUvaDBezRow1Info, new RecordItemIndex(8));
            Validate.AttributeContains(repo.TblUVAD.ChildTableWindow.ColUvaDBezRow1Info, "Text", "Innergemeinschaftliche Lieferungen");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'USt-Bemessung') on item 'TblUVAD.ChildTableWindow.ColUvaDTypEditRow1'.", repo.TblUVAD.ChildTableWindow.ColUvaDTypEditRow1Info, new RecordItemIndex(9));
            Validate.AttributeContains(repo.TblUVAD.ChildTableWindow.ColUvaDTypEditRow1Info, "Text", "USt-Bemessung");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='16') on item 'TblUVAD.ChildTableWindow.ColUvaDZeileRow16'.", repo.TblUVAD.ChildTableWindow.ColUvaDZeileRow16Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblUVAD.ChildTableWindow.ColUvaDZeileRow16Info, "Text", "16");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='89') on item 'TblUVAD.ChildTableWindow.ColUvaDFormnrRow16'.", repo.TblUVAD.ChildTableWindow.ColUvaDFormnrRow16Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblUVAD.ChildTableWindow.ColUvaDFormnrRow16Info, "Text", "89");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Innergem. Erwerb steuerpflichtig zum Steuersatz von 19 v.H.') on item 'TblUVAD.ChildTableWindow.ColUvaDBezRow16'.", repo.TblUVAD.ChildTableWindow.ColUvaDBezRow16Info, new RecordItemIndex(12));
            Validate.AttributeContains(repo.TblUVAD.ChildTableWindow.ColUvaDBezRow16Info, "Text", "Innergem. Erwerb steuerpflichtig zum Steuersatz von 19 v.H.");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='USt-Bemessung') on item 'TblUVAD.ChildTableWindow.ColUvaDTypEditRow16'.", repo.TblUVAD.ChildTableWindow.ColUvaDTypEditRow16Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TblUVAD.ChildTableWindow.ColUvaDTypEditRow16Info, "Text", "USt-Bemessung");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
