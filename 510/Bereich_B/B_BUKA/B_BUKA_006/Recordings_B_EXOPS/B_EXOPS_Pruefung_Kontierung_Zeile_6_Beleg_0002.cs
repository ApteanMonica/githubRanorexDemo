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
    ///The B_EXOPS_Pruefung_Kontierung_Zeile_6_Beleg_0002 recording.
    /// </summary>
    [TestModule("dcd310b6-088c-4650-83e4-52427cb42094", ModuleType.Recording, 1)]
    public partial class B_EXOPS_Pruefung_Kontierung_Zeile_6_Beleg_0002 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUKA_006.B_BUKA_006Repository repository.
        /// </summary>
        public static global::B_BUKA_006.B_BUKA_006Repository repo = global::B_BUKA_006.B_BUKA_006Repository.Instance;

        static B_EXOPS_Pruefung_Kontierung_Zeile_6_Beleg_0002 instance = new B_EXOPS_Pruefung_Kontierung_Zeile_6_Beleg_0002();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_EXOPS_Pruefung_Kontierung_Zeile_6_Beleg_0002()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_EXOPS_Pruefung_Kontierung_Zeile_6_Beleg_0002 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmBEXOP.Tabelle_Belege.row_6.Row6Column0' at Center.", repo.FrmBEXOP.Tabelle_Belege.row_6.Row6Column0Info, new RecordItemIndex(0));
            repo.FrmBEXOP.Tabelle_Belege.row_6.Row6Column0.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'frmBEXSA.TitleBar100VerwaltenSchnittstelleE'", repo.frmBEXSA.TitleBar100VerwaltenSchnittstelleEInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.frmBEXSA.TitleBar100VerwaltenSchnittstelleEInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0002') on item 'frmBEXSA.Belegnummer'.", repo.frmBEXSA.BelegnummerInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.frmBEXSA.BelegnummerInfo, "Text", "0002");
            
            // Zeile_1
            Report.Log(ReportLevel.Info, "Section", "Zeile_1", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='7390') on item 'frmBEXSA.Row1.ColExsaKtonrRow1'.", repo.frmBEXSA.Row1.ColExsaKtonrRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.frmBEXSA.Row1.ColExsaKtonrRow1Info, "Text", "7390");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='S') on item 'frmBEXSA.Row1.ColExsaShRow1'.", repo.frmBEXSA.Row1.ColExsaShRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.frmBEXSA.Row1.ColExsaShRow1Info, "Text", "S");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='90,91') on item 'frmBEXSA.Row1.ColExsaBetragRow1'.", repo.frmBEXSA.Row1.ColExsaBetragRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.frmBEXSA.Row1.ColExsaBetragRow1Info, "Text", "90,91");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V10') on item 'frmBEXSA.Row1.ColUstCdRow1'.", repo.frmBEXSA.Row1.ColUstCdRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.frmBEXSA.Row1.ColUstCdRow1Info, "Text", "V10");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='V') on item 'frmBEXSA.Row1.ColExsaUstmvRow1'.", repo.frmBEXSA.Row1.ColExsaUstmvRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.frmBEXSA.Row1.ColExsaUstmvRow1Info, "Text", "V");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='9,09') on item 'frmBEXSA.Row1.ColExsaUstbetragRow1'.", repo.frmBEXSA.Row1.ColExsaUstbetragRow1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.frmBEXSA.Row1.ColExsaUstbetragRow1Info, "Text", "9,09");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'frmBEXSA.Row1.ColExsaBerCd1Row1'.", repo.frmBEXSA.Row1.ColExsaBerCd1Row1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.frmBEXSA.Row1.ColExsaBerCd1Row1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10') on item 'frmBEXSA.Row1.ColExsaBektNr1Row1'.", repo.frmBEXSA.Row1.ColExsaBektNr1Row1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.frmBEXSA.Row1.ColExsaBektNr1Row1Info, "Text", "10");
            
            // Zeile_2
            Report.Log(ReportLevel.Info, "Section", "Zeile_2", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2701') on item 'frmBEXSA.Row2.ColExsaKtonrRow2'.", repo.frmBEXSA.Row2.ColExsaKtonrRow2Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.frmBEXSA.Row2.ColExsaKtonrRow2Info, "Text", "2701");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='H') on item 'frmBEXSA.Row2.ColExsaShRow2'.", repo.frmBEXSA.Row2.ColExsaShRow2Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.frmBEXSA.Row2.ColExsaShRow2Info, "Text", "H");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,00') on item 'frmBEXSA.Row2.ColExsaBetragRow2'.", repo.frmBEXSA.Row2.ColExsaBetragRow2Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.frmBEXSA.Row2.ColExsaBetragRow2Info, "Text", "100,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'frmBEXSA.Row2.ColExsaBerCd1Row2'.", repo.frmBEXSA.Row2.ColExsaBerCd1Row2Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.frmBEXSA.Row2.ColExsaBerCd1Row2Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10') on item 'frmBEXSA.Row2.ColExsaBektNr1Row2'.", repo.frmBEXSA.Row2.ColExsaBektNr1Row2Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.frmBEXSA.Row2.ColExsaBektNr1Row2Info, "Text", "10");
            
            // Maske schließen
            Report.Log(ReportLevel.Info, "Section", "Maske schließen", new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'frmBEXSA.TitleBar100VerwaltenSchnittstelleE'.", repo.frmBEXSA.TitleBar100VerwaltenSchnittstelleEInfo, new RecordItemIndex(19));
            Keyboard.PrepareFocus(repo.frmBEXSA.TitleBar100VerwaltenSchnittstelleE);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(20));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}