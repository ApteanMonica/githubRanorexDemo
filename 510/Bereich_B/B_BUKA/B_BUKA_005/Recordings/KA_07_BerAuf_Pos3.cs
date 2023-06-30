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

namespace B_BUKA_005.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The KA_07_BerAuf_Pos3 recording.
    /// </summary>
    [TestModule("5a77f74e-0edc-4591-a2b6-04736e473f16", ModuleType.Recording, 1)]
    public partial class KA_07_BerAuf_Pos3 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUKA_005.B_BUKA_005Repository repository.
        /// </summary>
        public static global::B_BUKA_005.B_BUKA_005Repository repo = global::B_BUKA_005.B_BUKA_005Repository.Instance;

        static KA_07_BerAuf_Pos3 instance = new KA_07_BerAuf_Pos3();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public KA_07_BerAuf_Pos3()
        {
            Konto_4810 = "4810";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static KA_07_BerAuf_Pos3 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Konto_4810;

        /// <summary>
        /// Gets or sets the value of variable Konto_4810.
        /// </summary>
        [TestVariable("20d0b9f2-601c-466d-b14f-5924b735dfd5")]
        public string Konto_4810
        {
            get { return _Konto_4810; }
            set { _Konto_4810 = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Insert}'.", new RecordItemIndex(0));
            Keyboard.Press("{Insert}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBerAufteilung.FlexGrid1.ColPosRow3' at Center.", repo.TblBerAufteilung.FlexGrid1.ColPosRow3Info, new RecordItemIndex(1));
            repo.TblBerAufteilung.FlexGrid1.ColPosRow3.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='200,00') on item 'TblBerAufteilung.FlexGrid1.ColBetragBRow3'.", repo.TblBerAufteilung.FlexGrid1.ColBetragBRow3Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblBerAufteilung.FlexGrid1.ColBetragBRow3Info, "Text", "200,00");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '400' with focus on 'TblBerAufteilung.FlexGrid1.ColBetragBRow3'.", repo.TblBerAufteilung.FlexGrid1.ColBetragBRow3Info, new RecordItemIndex(4));
            repo.TblBerAufteilung.FlexGrid1.ColBetragBRow3.PressKeys("400");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(5));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Konto_4810'.", new RecordItemIndex(6));
            Keyboard.Press(Konto_4810);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}'.", new RecordItemIndex(7));
            Keyboard.Press("{Tab}{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '30' with focus on 'TblBerAufteilung.FlexGrid1.ColBektNr1Row3'.", repo.TblBerAufteilung.FlexGrid1.ColBektNr1Row3Info, new RecordItemIndex(8));
            repo.TblBerAufteilung.FlexGrid1.ColBektNr1Row3.PressKeys("30");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}{Tab}{Tab}'.", new RecordItemIndex(9));
            Keyboard.Press("{Tab}{Tab}{Tab}{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'M10' with focus on 'TblBerAufteilung.FlexGrid1.ColUstCdRow3'.", repo.TblBerAufteilung.FlexGrid1.ColUstCdRow3Info, new RecordItemIndex(10));
            repo.TblBerAufteilung.FlexGrid1.ColUstCdRow3.PressKeys("M10");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(11));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='M10') on item 'TblBerAufteilung.FlexGrid1.ColUstCdRow3'.", repo.TblBerAufteilung.FlexGrid1.ColUstCdRow3Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblBerAufteilung.FlexGrid1.ColUstCdRow3Info, "Text", "M10");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F12}'.", new RecordItemIndex(13));
            Keyboard.Press("{F12}");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
