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

namespace B_UVA_2024_U30_2023_U1.Recordings_Formular
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Zuordnungen_Form_NEU_KZ000_aufrufen recording.
    /// </summary>
    [TestModule("c5b9ae90-e41a-4090-8b07-de6d3b33beb7", ModuleType.Recording, 1)]
    public partial class Zuordnungen_Form_NEU_KZ000_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository repository.
        /// </summary>
        public static global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository repo = global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository.Instance;

        static Zuordnungen_Form_NEU_KZ000_aufrufen instance = new Zuordnungen_Form_NEU_KZ000_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Zuordnungen_Form_NEU_KZ000_aufrufen()
        {
            Form_Name_NEU = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Zuordnungen_Form_NEU_KZ000_aufrufen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Form_Name_NEU.
        /// </summary>
        [TestVariable("9b448cda-75c8-488b-b47a-7d79e56f3d23")]
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Form_Name_NEU) on item 'TblUVAD.TitleBar200UVADetailsUVAOEsterre'.", repo.TblUVAD.TitleBar200UVADetailsUVAOEsterreInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.TblUVAD.TitleBar200UVADetailsUVAOEsterreInfo, "Text", Form_Name_NEU);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='000') on item 'TblUVAD.Row11.ColUvaDFormnrRow1'.", repo.TblUVAD.Row11.ColUvaDFormnrRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblUVAD.Row11.ColUvaDFormnrRow1Info, "Text", "000");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblUVAD.Row11.Col1_Row1' at Center.", repo.TblUVAD.Row11.Col1_Row1Info, new RecordItemIndex(2));
            repo.TblUVAD.Row11.Col1_Row1.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgUVAZ.TitleBar200ZuordnungUStCodes'", repo.DlgUVAZ.TitleBar200ZuordnungUStCodesInfo, new ActionTimeout(120000), new RecordItemIndex(3));
            repo.DlgUVAZ.TitleBar200ZuordnungUStCodesInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgUVAZ.TitleBar200ZuordnungUStCodes'.", repo.DlgUVAZ.TitleBar200ZuordnungUStCodesInfo, new RecordItemIndex(4));
            Validate.Exists(repo.DlgUVAZ.TitleBar200ZuordnungUStCodesInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
