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

namespace S_ADRL_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Lieferant_kopieren recording.
    /// </summary>
    [TestModule("2cc6fc31-3910-4a62-ba14-ff9275376a57", ModuleType.Recording, 1)]
    public partial class Lieferant_kopieren : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ADRL_002.S_ADRL_002Repository repository.
        /// </summary>
        public static global::S_ADRL_002.S_ADRL_002Repository repo = global::S_ADRL_002.S_ADRL_002Repository.Instance;

        static Lieferant_kopieren instance = new Lieferant_kopieren();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Lieferant_kopieren()
        {
            Lieferant = "300001";
            neuer_Lieferant = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Lieferant_kopieren Instance
        {
            get { return instance; }
        }

#region Variables

        string _neuer_Lieferant;

        /// <summary>
        /// Gets or sets the value of variable neuer_Lieferant.
        /// </summary>
        [TestVariable("85a1243e-04ac-409d-acb4-970c33a9a600")]
        public string neuer_Lieferant
        {
            get { return _neuer_Lieferant; }
            set { _neuer_Lieferant = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Lieferant.
        /// </summary>
        [TestVariable("48fc8613-66ec-4788-93c3-0ef839a4ab99")]
        public string Lieferant
        {
            get { return repo.Lieferant; }
            set { repo.Lieferant = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.FrmSearchPage.Suche' at Center.", repo.FrmAdr.FrmSearchPage.SucheInfo, new RecordItemIndex(0));
            repo.FrmAdr.FrmSearchPage.Suche.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Lieferant' with focus on 'FrmAdr.FrmSearchPage.Suche'.", repo.FrmAdr.FrmSearchPage.SucheInfo, new RecordItemIndex(1));
            repo.FrmAdr.FrmSearchPage.Suche.PressKeys(Lieferant);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferant) on item 'FrmAdr.FrmSearchPage.CellTmpColS1Row1'.", repo.FrmAdr.FrmSearchPage.CellTmpColS1Row1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmAdr.FrmSearchPage.CellTmpColS1Row1Info, "Text", Lieferant);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmAdr.FrmSearchPage.Row1Column0' at Center.", repo.FrmAdr.FrmSearchPage.Row1Column0Info, new RecordItemIndex(3));
            repo.FrmAdr.FrmSearchPage.Row1Column0.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferant) on item 'FrmAdr.Lieferantennummer'.", repo.FrmAdr.LieferantennummerInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmAdr.LieferantennummerInfo, "Text", Lieferant);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.PbCommonKopieren' at Center.", repo.FrmAdr.PbCommonKopierenInfo, new RecordItemIndex(5));
            repo.FrmAdr.PbCommonKopieren.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dlgcopyadr.PbNummer' at Center.", repo.Dlgcopyadr.PbNummerInfo, new RecordItemIndex(6));
            repo.Dlgcopyadr.PbNummer.Click();
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'AccessibleValue' from item 'Dlgcopyadr.neuer_Lieferant' and assigning its value to variable 'neuer_Lieferant'.", repo.Dlgcopyadr.neuer_LieferantInfo, new RecordItemIndex(7));
            neuer_Lieferant = repo.Dlgcopyadr.neuer_Lieferant.Element.GetAttributeValueText("AccessibleValue");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Dlgcopyadr.Pbok' at Center.", repo.Dlgcopyadr.PbokInfo, new RecordItemIndex(8));
            repo.Dlgcopyadr.Pbok.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$neuer_Lieferant) on item 'FrmAdr.Lieferantennummer'.", repo.FrmAdr.LieferantennummerInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmAdr.LieferantennummerInfo, "Text", neuer_Lieferant);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Button0' at Center.", repo.Button0Info, new RecordItemIndex(10));
            repo.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
