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

namespace L_KMSM_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The KoSchein_laden recording.
    /// </summary>
    [TestModule("1be0824c-bf69-44bb-b524-01c8cbfbace3", ModuleType.Recording, 1)]
    public partial class KoSchein_laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::L_KMSM_001.L_KMSM_001Repository repository.
        /// </summary>
        public static global::L_KMSM_001.L_KMSM_001Repository repo = global::L_KMSM_001.L_KMSM_001Repository.Instance;

        static KoSchein_laden instance = new KoSchein_laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public KoSchein_laden()
        {
            Lieferdatum = "";
            Lager = "";
            KoSchein = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static KoSchein_laden Instance
        {
            get { return instance; }
        }

#region Variables

        string _Lieferdatum;

        /// <summary>
        /// Gets or sets the value of variable Lieferdatum.
        /// </summary>
        [TestVariable("90b95f31-1d8a-41f6-8174-a4a534bbb257")]
        public string Lieferdatum
        {
            get { return _Lieferdatum; }
            set { _Lieferdatum = value; }
        }

        string _Lager;

        /// <summary>
        /// Gets or sets the value of variable Lager.
        /// </summary>
        [TestVariable("fef4270c-f8bd-42cc-8ab1-c2fc222352b0")]
        public string Lager
        {
            get { return _Lager; }
            set { _Lager = value; }
        }

        string _KoSchein;

        /// <summary>
        /// Gets or sets the value of variable KoSchein.
        /// </summary>
        [TestVariable("fcabfe07-1d6b-46f9-ab75-4be77bafce28")]
        public string KoSchein
        {
            get { return _KoSchein; }
            set { _KoSchein = value; }
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKMSM.Lager' at Center.", repo.TblKMSM.LagerInfo, new RecordItemIndex(0));
            repo.TblKMSM.Lager.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute AccessibleValue to '$Lager' on item 'TblKMSM.Lager'.", repo.TblKMSM.LagerInfo, new RecordItemIndex(1));
            repo.TblKMSM.Lager.Element.SetAttributeValue("AccessibleValue", Lager);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lager) on item 'TblKMSM.Lager'.", repo.TblKMSM.LagerInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblKMSM.LagerInfo, "Text", Lager);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKMSM.KoScheinNr' at Center.", repo.TblKMSM.KoScheinNrInfo, new RecordItemIndex(4));
            repo.TblKMSM.KoScheinNr.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$KoSchein'.", new RecordItemIndex(5));
            Keyboard.Press(KoSchein);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KoSchein) on item 'TblKMSM.KoScheinNr'.", repo.TblKMSM.KoScheinNrInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblKMSM.KoScheinNrInfo, "Text", KoSchein);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKMSM.LDatum' at Center.", repo.TblKMSM.LDatumInfo, new RecordItemIndex(8));
            repo.TblKMSM.LDatum.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute AccessibleValue to '$Lieferdatum' on item 'TblKMSM.LDatum'.", repo.TblKMSM.LDatumInfo, new RecordItemIndex(9));
            repo.TblKMSM.LDatum.Element.SetAttributeValue("AccessibleValue", Lieferdatum);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferdatum) on item 'TblKMSM.LDatum'.", repo.TblKMSM.LDatumInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblKMSM.LDatumInfo, "Text", Lieferdatum);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKMSM.PbCommonAlle0' at Center.", repo.TblKMSM.PbCommonAlle0Info, new RecordItemIndex(12));
            repo.TblKMSM.PbCommonAlle0.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'TblKMSM.ColKmspMgistRow1'.", repo.TblKMSM.ColKmspMgistRow1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TblKMSM.ColKmspMgistRow1Info, "Text", "0,00");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblKMSM.PbDataAccessZwischenspeichern' at Center.", repo.TblKMSM.PbDataAccessZwischenspeichernInfo, new RecordItemIndex(14));
            repo.TblKMSM.PbDataAccessZwischenspeichern.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
