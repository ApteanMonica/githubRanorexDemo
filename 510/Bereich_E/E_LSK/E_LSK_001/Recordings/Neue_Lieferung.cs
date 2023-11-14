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

namespace E_LSK_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Neue_Lieferung recording.
    /// </summary>
    [TestModule("f25ca1d9-861b-4e76-8296-19476e90ff33", ModuleType.Recording, 1)]
    public partial class Neue_Lieferung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_LSK_001.E_LSK_001Repository repository.
        /// </summary>
        public static global::E_LSK_001.E_LSK_001Repository repo = global::E_LSK_001.E_LSK_001Repository.Instance;

        static Neue_Lieferung instance = new Neue_Lieferung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Neue_Lieferung()
        {
            Bestellnr_Lieferscheinnr = "";
            Lieferant = "";
            Lieferscheinart = "";
            Lager = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Neue_Lieferung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Bestellnr_Lieferscheinnr;

        /// <summary>
        /// Gets or sets the value of variable Bestellnr_Lieferscheinnr.
        /// </summary>
        [TestVariable("4e11310e-a945-48e3-9ba0-9a00fb5c9cd9")]
        public string Bestellnr_Lieferscheinnr
        {
            get { return _Bestellnr_Lieferscheinnr; }
            set { _Bestellnr_Lieferscheinnr = value; }
        }

        string _Lieferant;

        /// <summary>
        /// Gets or sets the value of variable Lieferant.
        /// </summary>
        [TestVariable("e678583f-b13f-457e-a406-1a903b0d8b13")]
        public string Lieferant
        {
            get { return _Lieferant; }
            set { _Lieferant = value; }
        }

        string _Lieferscheinart;

        /// <summary>
        /// Gets or sets the value of variable Lieferscheinart.
        /// </summary>
        [TestVariable("b068e05a-0313-4ce3-a90a-9ca61bd4ea27")]
        public string Lieferscheinart
        {
            get { return _Lieferscheinart; }
            set { _Lieferscheinart = value; }
        }

        string _Lager;

        /// <summary>
        /// Gets or sets the value of variable Lager.
        /// </summary>
        [TestVariable("daa28e66-52a7-41aa-920e-6122e8c26b38")]
        public string Lager
        {
            get { return _Lager; }
            set { _Lager = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.PbNew' at Center.", repo.MdiLSR.PbNewInfo, new RecordItemIndex(0));
            repo.MdiLSR.PbNew.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.Bestellung' at Center.", repo.MdiLSR.BestellungInfo, new RecordItemIndex(1));
            repo.MdiLSR.Bestellung.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Bestellnr_Lieferscheinnr' with focus on 'MdiLSR.Bestellung'.", repo.MdiLSR.BestellungInfo, new RecordItemIndex(2));
            repo.MdiLSR.Bestellung.PressKeys(Bestellnr_Lieferscheinnr);
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute AccessibleValue to '$Bestellnr_Lieferscheinnr' on item 'MdiLSR.Bestellung'.", repo.MdiLSR.BestellungInfo, new RecordItemIndex(3));
            //repo.MdiLSR.Bestellung.Element.SetAttributeValue("AccessibleValue", Bestellnr_Lieferscheinnr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferant) on item 'MdiLSR.Lieferant'.", repo.MdiLSR.LieferantInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.MdiLSR.LieferantInfo, "Text", Lieferant);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.Lieferscheinnummer' at Center.", repo.MdiLSR.LieferscheinnummerInfo, new RecordItemIndex(6));
            repo.MdiLSR.Lieferscheinnummer.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Bestellnr_Lieferscheinnr' with focus on 'MdiLSR.Lieferscheinnummer'.", repo.MdiLSR.LieferscheinnummerInfo, new RecordItemIndex(7));
            repo.MdiLSR.Lieferscheinnummer.PressKeys(Bestellnr_Lieferscheinnr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute AccessibleValue to '$Bestellnr_Lieferscheinnr' on item 'MdiLSR.Lieferscheinnummer'.", repo.MdiLSR.LieferscheinnummerInfo, new RecordItemIndex(9));
            //repo.MdiLSR.Lieferscheinnummer.Element.SetAttributeValue("AccessibleValue", Bestellnr_Lieferscheinnr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue=$Bestellnr_Lieferscheinnr) on item 'MdiLSR.Bestellung'.", repo.MdiLSR.BestellungInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.MdiLSR.BestellungInfo, "AccessibleValue", Bestellnr_Lieferscheinnr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferscheinart) on item 'MdiLSR.Lieferscheinart'.", repo.MdiLSR.LieferscheinartInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.MdiLSR.LieferscheinartInfo, "Text", Lieferscheinart);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bestellnr_Lieferscheinnr) on item 'MdiLSR.Lieferscheinnummer'.", repo.MdiLSR.LieferscheinnummerInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.MdiLSR.LieferscheinnummerInfo, "Text", Bestellnr_Lieferscheinnr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lager) on item 'MdiLSR.Lager'.", repo.MdiLSR.LagerInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.MdiLSR.LagerInfo, "Text", Lager);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
