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

namespace B_ZAHL_007.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Bankbeleg_Detailzeilen_pruefen recording.
    /// </summary>
    [TestModule("35a49aca-2c99-4a1d-9576-ce59c5c2430a", ModuleType.Recording, 1)]
    public partial class Bankbeleg_Detailzeilen_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_007.B_ZAHL_007Repository repository.
        /// </summary>
        public static global::B_ZAHL_007.B_ZAHL_007Repository repo = global::B_ZAHL_007.B_ZAHL_007Repository.Instance;

        static Bankbeleg_Detailzeilen_pruefen instance = new Bankbeleg_Detailzeilen_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Bankbeleg_Detailzeilen_pruefen()
        {
            LF_303072 = "303072";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Bankbeleg_Detailzeilen_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _LF_303072;

        /// <summary>
        /// Gets or sets the value of variable LF_303072.
        /// </summary>
        [TestVariable("148e0824-168c-4c64-b4f0-44f2d817c8dd")]
        public string LF_303072
        {
            get { return _LF_303072; }
            set { _LF_303072 = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmZlvsAEndern.TitleBar100LieferantenZahlvorschl'", repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschlInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschlInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Bankbeleg bearbeiten') on item 'FrmZlvsAEndern.TitleBar100LieferantenZahlvorschl'.", repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschlInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschlInfo, "Text", "Bankbeleg bearbeiten");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColAdrNrRow1'", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColAdrNrRow1Info, new ActionTimeout(120000), new RecordItemIndex(2));
            repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColAdrNrRow1Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$LF_303072) on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColAdrNrRow1'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColAdrNrRow1Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColAdrNrRow1Info, "Text", LF_303072);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'ER_072B_B_ZAHL_007') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColBelegRow1'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColBelegRow1Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColBelegRow1Info, "Text", "ER_072B_B_ZAHL_007");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColZahlsperreRow1'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColZahlsperreRow1Info, new RecordItemIndex(5));
            Validate.AttributeContains(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColZahlsperreRow1Info, "Text", "");
            
            // Tagesdatum (NICHT Abschnitt 12.05.2021	)
            Report.Log(ReportLevel.Info, "Validation", "Tagesdatum (NICHT Abschnitt 12.05.2021\t)\r\nValidating AttributeContains (Text>'588,00') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColZBetragZRow1'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColZBetragZRow1Info, new RecordItemIndex(6));
            Validate.AttributeContains(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_1.ColZBetragZRow1Info, "Text", "588,00");
            
            // Search timeout reduziert
            Report.Log(ReportLevel.Info, "Validation", "Search timeout reduziert\r\nValidating NotExists on item 'FrmZlvsAEndern.Row2'.", repo.FrmZlvsAEndern.Row2Info, new RecordItemIndex(7));
            Validate.NotExists(repo.FrmZlvsAEndern.Row2Info);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'FrmZlvsAEndern.TitleBar100LieferantenZahlvorschl'.", repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschlInfo, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschl);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
