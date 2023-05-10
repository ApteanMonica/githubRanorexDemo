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

namespace K_FIBU_001.Recordings_YPAR
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Parameter_0_pruefen recording.
    /// </summary>
    [TestModule("0126ec6a-3be8-44ca-a707-591beb5b0d3a", ModuleType.Recording, 1)]
    public partial class Parameter_0_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_FIBU_001.K_FIBU_001Repository repository.
        /// </summary>
        public static global::K_FIBU_001.K_FIBU_001Repository repo = global::K_FIBU_001.K_FIBU_001Repository.Instance;

        static Parameter_0_pruefen instance = new Parameter_0_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Parameter_0_pruefen()
        {
            Tagesdatum = "";
            Parameter = "FIBU_SPERRE_100";
            User_RS = "RS";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Parameter_0_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("9439e216-91cb-447e-9e07-94418983bd34")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        string _User_RS;

        /// <summary>
        /// Gets or sets the value of variable User_RS.
        /// </summary>
        [TestVariable("3bff4f6b-aad5-4517-a9b3-1d8dd8ecaaf8")]
        public string User_RS
        {
            get { return _User_RS; }
            set { _User_RS = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Parameter.
        /// </summary>
        [TestVariable("00ab2518-951c-4749-91e6-2cf2ea8b6f35")]
        public string Parameter
        {
            get { return repo.Parameter; }
            set { repo.Parameter = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Verwalten Parameter') on item 'Verwalten_Parameter_521frm_510tbl.TitleBar100VerwaltenParameter'.", repo.Verwalten_Parameter_521frm_510tbl.TitleBar100VerwaltenParameterInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.Verwalten_Parameter_521frm_510tbl.TitleBar100VerwaltenParameterInfo, "Text", "Verwalten Parameter");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Parameter) on item 'Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParCdRow1'.", repo.Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParCdRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParCdRow1Info, "Text", Parameter);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParLfdnrRow1'.", repo.Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParLfdnrRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParLfdnrRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParTextkRow1'.", repo.Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParTextkRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParTextkRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tagesdatum) on item 'Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParTextlRow1'.", repo.Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParTextlRow1Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParTextlRow1Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$User_RS) on item 'Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParTextlRow1'.", repo.Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParTextlRow1Info, new RecordItemIndex(5));
            Validate.AttributeContains(repo.Verwalten_Parameter_521frm_510tbl.FlexGrid_521_510_Pfad_unterschiedlich.ColParTextlRow1Info, "Text", User_RS);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
