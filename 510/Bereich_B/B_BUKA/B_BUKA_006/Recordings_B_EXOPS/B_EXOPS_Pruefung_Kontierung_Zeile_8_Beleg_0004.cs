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

namespace B_BUKA_006.Recordings_B_EXOPS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The B_EXOPS_Pruefung_Kontierung_Zeile_8_Beleg_0004 recording.
    /// </summary>
    [TestModule("752349ef-2e23-47da-bae2-b76d6db9a32d", ModuleType.Recording, 1)]
    public partial class B_EXOPS_Pruefung_Kontierung_Zeile_8_Beleg_0004 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUKA_006.B_BUKA_006Repository repository.
        /// </summary>
        public static global::B_BUKA_006.B_BUKA_006Repository repo = global::B_BUKA_006.B_BUKA_006Repository.Instance;

        static B_EXOPS_Pruefung_Kontierung_Zeile_8_Beleg_0004 instance = new B_EXOPS_Pruefung_Kontierung_Zeile_8_Beleg_0004();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_EXOPS_Pruefung_Kontierung_Zeile_8_Beleg_0004()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_EXOPS_Pruefung_Kontierung_Zeile_8_Beleg_0004 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmBEXOP.Tabelle_Belege.row_8.Row8Column0' at Center.", repo.FrmBEXOP.Tabelle_Belege.row_8.Row8Column0Info, new RecordItemIndex(0));
            repo.FrmBEXOP.Tabelle_Belege.row_8.Row8Column0.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'frmBEXSA.TitleBar100VerwaltenSchnittstelleE'", repo.frmBEXSA.TitleBar100VerwaltenSchnittstelleEInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.frmBEXSA.TitleBar100VerwaltenSchnittstelleEInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0004') on item 'frmBEXSA.Belegnummer'.", repo.frmBEXSA.BelegnummerInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.frmBEXSA.BelegnummerInfo, "Text", "0004");
            
            // Zeile_1
            Report.Log(ReportLevel.Info, "Section", "Zeile_1", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2701') on item 'frmBEXSA.Row1.ColExsaKtonrRow1'.", repo.frmBEXSA.Row1.ColExsaKtonrRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.frmBEXSA.Row1.ColExsaKtonrRow1Info, "Text", "2701");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='H') on item 'frmBEXSA.Row1.ColExsaShRow1'.", repo.frmBEXSA.Row1.ColExsaShRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.frmBEXSA.Row1.ColExsaShRow1Info, "Text", "H");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,00') on item 'frmBEXSA.Row1.ColExsaBetragRow1'.", repo.frmBEXSA.Row1.ColExsaBetragRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.frmBEXSA.Row1.ColExsaBetragRow1Info, "Text", "100,00");
            
            // Maske schließen
            Report.Log(ReportLevel.Info, "Section", "Maske schließen", new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'frmBEXSA.TitleBar100VerwaltenSchnittstelleE'.", repo.frmBEXSA.TitleBar100VerwaltenSchnittstelleEInfo, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.frmBEXSA.TitleBar100VerwaltenSchnittstelleE);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}