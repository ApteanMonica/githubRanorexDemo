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
    ///The Zuordnungen_Form_KZ000_pruefen recording.
    /// </summary>
    [TestModule("d52987ce-1c64-41f0-9922-0a1249531959", ModuleType.Recording, 1)]
    public partial class Zuordnungen_Form_KZ000_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository repository.
        /// </summary>
        public static global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository repo = global::B_UVA_2024_U30_2023_U1.B_UVA_004Repository.Instance;

        static Zuordnungen_Form_KZ000_pruefen instance = new Zuordnungen_Form_KZ000_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Zuordnungen_Form_KZ000_pruefen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Zuordnungen_Form_KZ000_pruefen Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgUVAZ.TitleBar200ZuordnungUStCodes'.", repo.DlgUVAZ.TitleBar200ZuordnungUStCodesInfo, new RecordItemIndex(0));
            Validate.Exists(repo.DlgUVAZ.TitleBar200ZuordnungUStCodesInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'EX3') on item 'DlgUVAZ.FlexGrid.ColUstCdRow1'.", repo.DlgUVAZ.FlexGrid.ColUstCdRow1Info, new RecordItemIndex(1));
            Validate.AttributeContains(repo.DlgUVAZ.FlexGrid.ColUstCdRow1Info, "Text", "EX3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'IGB') on item 'DlgUVAZ.FlexGrid.ColUstCdRow2'.", repo.DlgUVAZ.FlexGrid.ColUstCdRow2Info, new RecordItemIndex(2));
            Validate.AttributeContains(repo.DlgUVAZ.FlexGrid.ColUstCdRow2Info, "Text", "IGB");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'IGL') on item 'DlgUVAZ.FlexGrid.ColUstCdRow3'.", repo.DlgUVAZ.FlexGrid.ColUstCdRow3Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.DlgUVAZ.FlexGrid.ColUstCdRow3Info, "Text", "IGL");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'U10') on item 'DlgUVAZ.FlexGrid.ColUstCdRow4'.", repo.DlgUVAZ.FlexGrid.ColUstCdRow4Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.DlgUVAZ.FlexGrid.ColUstCdRow4Info, "Text", "U10");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'U13') on item 'DlgUVAZ.FlexGrid.ColUstCdRow5'.", repo.DlgUVAZ.FlexGrid.ColUstCdRow5Info, new RecordItemIndex(5));
            Validate.AttributeContains(repo.DlgUVAZ.FlexGrid.ColUstCdRow5Info, "Text", "U13");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'U20') on item 'DlgUVAZ.FlexGrid.ColUstCdRow6'.", repo.DlgUVAZ.FlexGrid.ColUstCdRow6Info, new RecordItemIndex(6));
            Validate.AttributeContains(repo.DlgUVAZ.FlexGrid.ColUstCdRow6Info, "Text", "U20");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
