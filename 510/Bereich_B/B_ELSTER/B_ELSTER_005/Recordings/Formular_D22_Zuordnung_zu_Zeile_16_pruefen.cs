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

namespace B_ELSTER_005.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Formular_D22_Zuordnung_zu_Zeile_16_pruefen recording.
    /// </summary>
    [TestModule("5ef1eff6-1afb-4fbf-b55d-b11e91820971", ModuleType.Recording, 1)]
    public partial class Formular_D22_Zuordnung_zu_Zeile_16_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_005.B_ELSTER_005Repository repository.
        /// </summary>
        public static global::B_ELSTER_005.B_ELSTER_005Repository repo = global::B_ELSTER_005.B_ELSTER_005Repository.Instance;

        static Formular_D22_Zuordnung_zu_Zeile_16_pruefen instance = new Formular_D22_Zuordnung_zu_Zeile_16_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Formular_D22_Zuordnung_zu_Zeile_16_pruefen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Formular_D22_Zuordnung_zu_Zeile_16_pruefen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblUVAD.ChildTableWindow.Row16Column0' at Center.", repo.TblUVAD.ChildTableWindow.Row16Column0Info, new RecordItemIndex(0));
            repo.TblUVAD.ChildTableWindow.Row16Column0.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgUVAZ.TitleBar300ZuordnungUStCodes'", repo.DlgUVAZ.TitleBar300ZuordnungUStCodesInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.DlgUVAZ.TitleBar300ZuordnungUStCodesInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[300]  Zuordnung USt-Codes') on item 'DlgUVAZ.TitleBar300ZuordnungUStCodes'.", repo.DlgUVAZ.TitleBar300ZuordnungUStCodesInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.DlgUVAZ.TitleBar300ZuordnungUStCodesInfo, "Text", "[300]  Zuordnung USt-Codes");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='E19') on item 'DlgUVAZ.Row1.ColUstCdRow1'.", repo.DlgUVAZ.Row1.ColUstCdRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgUVAZ.Row1.ColUstCdRow1Info, "Text", "E19");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'DlgUVAZ.Row1.ColUvaCdTeil2Row1'.", repo.DlgUVAZ.Row1.ColUvaCdTeil2Row1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgUVAZ.Row1.ColUvaCdTeil2Row1Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='E') on item 'DlgUVAZ.Row1.ColUstArtRow1'.", repo.DlgUVAZ.Row1.ColUstArtRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgUVAZ.Row1.ColUstArtRow1Info, "Text", "E");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='19,00') on item 'DlgUVAZ.Row1.ColUstSatzRow1'.", repo.DlgUVAZ.Row1.ColUstSatzRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.DlgUVAZ.Row1.ColUstSatzRow1Info, "Text", "19,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Erwerbsteuer 19 %') on item 'DlgUVAZ.Row1.ColUstTextRow1'.", repo.DlgUVAZ.Row1.ColUstTextRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgUVAZ.Row1.ColUstTextRow1Info, "Text", "Erwerbsteuer 19 %");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'DlgUVAZ.TitleBar300ZuordnungUStCodes'.", repo.DlgUVAZ.TitleBar300ZuordnungUStCodesInfo, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.DlgUVAZ.TitleBar300ZuordnungUStCodes);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'TblUVAD.TitleBar300UVADetailsUVADeutschl'.", repo.TblUVAD.TitleBar300UVADetailsUVADeutschlInfo, new RecordItemIndex(9));
            Keyboard.PrepareFocus(repo.TblUVAD.TitleBar300UVADetailsUVADeutschl);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
