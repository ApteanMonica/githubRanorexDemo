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

namespace B_BUDA_001.Recordings_B_BUCH
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Dauerbuchungsvorlage_erfassen_SA1_Bereichsaufteilung recording.
    /// </summary>
    [TestModule("da38a438-1406-4cfa-afee-73d3636cc22b", ModuleType.Recording, 1)]
    public partial class Dauerbuchungsvorlage_erfassen_SA1_Bereichsaufteilung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUDA_001.B_BUDA_001Repository repository.
        /// </summary>
        public static global::B_BUDA_001.B_BUDA_001Repository repo = global::B_BUDA_001.B_BUDA_001Repository.Instance;

        static Dauerbuchungsvorlage_erfassen_SA1_Bereichsaufteilung instance = new Dauerbuchungsvorlage_erfassen_SA1_Bereichsaufteilung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Dauerbuchungsvorlage_erfassen_SA1_Bereichsaufteilung()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Dauerbuchungsvorlage_erfassen_SA1_Bereichsaufteilung Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Dauerbuchung erfassen') on item 'MdiBuch.TitleBar100Dialogbuchung'.", repo.MdiBuch.TitleBar100DialogbuchungInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.MdiBuch.TitleBar100DialogbuchungInfo, "Text", "Dauerbuchung erfassen");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBuch.PbStandard7' at Center.", repo.MdiBuch.PbStandard7Info, new RecordItemIndex(1));
            repo.MdiBuch.PbStandard7.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'MdiBuch.FlexGrid_Bereichsaufteilung'", repo.MdiBuch.FlexGrid_BereichsaufteilungInfo, new ActionTimeout(180000), new RecordItemIndex(2));
            repo.MdiBuch.FlexGrid_BereichsaufteilungInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'MdiBuch.Row1'", repo.MdiBuch.Row1Info, new ActionTimeout(120000), new RecordItemIndex(3));
            repo.MdiBuch.Row1Info.WaitForExists(120000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MdiBuch.colBube_betragRow1' at Center.", repo.MdiBuch.colBube_betragRow1Info, new RecordItemIndex(4));
            //repo.MdiBuch.colBube_betragRow1.DoubleClick();
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(5));
            //Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '499,99' with focus on 'MdiBuch.colBube_betragRow1'.", repo.MdiBuch.colBube_betragRow1Info, new RecordItemIndex(6));
            repo.MdiBuch.colBube_betragRow1.PressKeys("499,99");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='499,99') on item 'MdiBuch.colBube_betragRow1'.", repo.MdiBuch.colBube_betragRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.MdiBuch.colBube_betragRow1Info, "Text", "499,99");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '30' with focus on 'MdiBuch.ColBubeBektnr1Row1'.", repo.MdiBuch.ColBubeBektnr1Row1Info, new RecordItemIndex(11));
            repo.MdiBuch.ColBubeBektnr1Row1.PressKeys("30");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(12));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='KST 30') on item 'MdiBuch.ColBezRow1'.", repo.MdiBuch.ColBezRow1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.MdiBuch.ColBezRow1Info, "Text", "KST 30");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(14));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='500,01') on item 'MdiBuch.colBube_betragRow2'.", repo.MdiBuch.colBube_betragRow2Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.MdiBuch.colBube_betragRow2Info, "Text", "500,01");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(16));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(17));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(18));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '50' with focus on 'MdiBuch.ColBubeBektnr1Row2'.", repo.MdiBuch.ColBubeBektnr1Row2Info, new RecordItemIndex(19));
            repo.MdiBuch.ColBubeBektnr1Row2.PressKeys("50");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(20));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='KST 50') on item 'MdiBuch.ColBezRow2'.", repo.MdiBuch.ColBezRow2Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.MdiBuch.ColBezRow2Info, "Text", "KST 50");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBuch.PbStandard2' at Center.", repo.MdiBuch.PbStandard2Info, new RecordItemIndex(22));
            repo.MdiBuch.PbStandard2.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBuch.PbStandard2' at Center.", repo.MdiBuch.PbStandard2Info, new RecordItemIndex(23));
            repo.MdiBuch.PbStandard2.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
