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

namespace L_LAGS_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Lager_Neu_Allgemein recording.
    /// </summary>
    [TestModule("f26acd35-1ec9-49c4-b38e-39e50e964a81", ModuleType.Recording, 1)]
    public partial class Lager_Neu_Allgemein : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::L_LAGS_001.L_LAGS_001Repository repository.
        /// </summary>
        public static global::L_LAGS_001.L_LAGS_001Repository repo = global::L_LAGS_001.L_LAGS_001Repository.Instance;

        static Lager_Neu_Allgemein instance = new Lager_Neu_Allgemein();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Lager_Neu_Allgemein()
        {
            Lager_nr = "500";
            Kundennummer = "200500";
            LGPL_Struktur_1 = "1";
            LGPL_Struktur_2 = "2";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Lager_Neu_Allgemein Instance
        {
            get { return instance; }
        }

#region Variables

        string _Lager_nr;

        /// <summary>
        /// Gets or sets the value of variable Lager_nr.
        /// </summary>
        [TestVariable("e24e8ada-859b-4700-937f-b6541b599f8a")]
        public string Lager_nr
        {
            get { return _Lager_nr; }
            set { _Lager_nr = value; }
        }

        string _Kundennummer;

        /// <summary>
        /// Gets or sets the value of variable Kundennummer.
        /// </summary>
        [TestVariable("05f7fb6a-b612-40ed-9315-2432400b39ec")]
        public string Kundennummer
        {
            get { return _Kundennummer; }
            set { _Kundennummer = value; }
        }

        string _LGPL_Struktur_1;

        /// <summary>
        /// Gets or sets the value of variable LGPL_Struktur_1.
        /// </summary>
        [TestVariable("3b55c48e-59d0-4eef-8f0c-28563058d84b")]
        public string LGPL_Struktur_1
        {
            get { return _LGPL_Struktur_1; }
            set { _LGPL_Struktur_1 = value; }
        }

        string _LGPL_Struktur_2;

        /// <summary>
        /// Gets or sets the value of variable LGPL_Struktur_2.
        /// </summary>
        [TestVariable("576c10f1-5e14-404c-b3b4-348a93c768d8")]
        public string LGPL_Struktur_2
        {
            get { return _LGPL_Struktur_2; }
            set { _LGPL_Struktur_2 = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLag.PbPerformSimpleSearch' at 16;8.", repo.MdiLag.PbPerformSimpleSearchInfo, new RecordItemIndex(0));
            //repo.MdiLag.PbPerformSimpleSearch.Click("16;8");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLag.PbNew' at Center.", repo.MdiLag.PbNewInfo, new RecordItemIndex(1));
            repo.MdiLag.PbNew.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLag.ClientArea.Text' at Center.", repo.MdiLag.ClientArea.TextInfo, new RecordItemIndex(2));
            repo.MdiLag.ClientArea.Text.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Lager_nr' with focus on 'MdiLag.ClientArea.Text'.", repo.MdiLag.ClientArea.TextInfo, new RecordItemIndex(3));
            repo.MdiLag.ClientArea.Text.PressKeys(Lager_nr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MdiLag.ClientArea.Text'.", repo.MdiLag.ClientArea.TextInfo, new RecordItemIndex(4));
            repo.MdiLag.ClientArea.Text.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLag.ClientArea.DateiKSMeldung' at Center.", repo.MdiLag.ClientArea.DateiKSMeldungInfo, new RecordItemIndex(5));
            repo.MdiLag.ClientArea.DateiKSMeldung.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'at{Tab}' with focus on 'MdiLag.ClientArea.DateiKSMeldung'.", repo.MdiLag.ClientArea.DateiKSMeldungInfo, new RecordItemIndex(6));
            repo.MdiLag.ClientArea.DateiKSMeldung.PressKeys("at{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLag.ClientArea.Text1' at Center.", repo.MdiLag.ClientArea.Text1Info, new RecordItemIndex(7));
            repo.MdiLag.ClientArea.Text1.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Lager mit Lagerplätzen' with focus on 'MdiLag.ClientArea.Text1'.", repo.MdiLag.ClientArea.Text1Info, new RecordItemIndex(8));
            repo.MdiLag.ClientArea.Text1.PressKeys("Lager mit Lagerplätzen");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLag.ClientArea.Text2' at Center.", repo.MdiLag.ClientArea.Text2Info, new RecordItemIndex(9));
            repo.MdiLag.ClientArea.Text2.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad5}{NumPad0}{NumPad2}{NumPad0}{Tab}' with focus on 'MdiLag.ClientArea.Text2'.", repo.MdiLag.ClientArea.Text2Info, new RecordItemIndex(10));
            repo.MdiLag.ClientArea.Text2.PressKeys("{NumPad5}{NumPad0}{NumPad2}{NumPad0}{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLag.Kundennummer' at Center.", repo.MdiLag.KundennummerInfo, new RecordItemIndex(11));
            repo.MdiLag.Kundennummer.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Kundennummer' with focus on 'MdiLag.Kundennummer'.", repo.MdiLag.KundennummerInfo, new RecordItemIndex(12));
            repo.MdiLag.Kundennummer.EnsureVisible();
            Keyboard.Press(Kundennummer);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MdiLag.Kundennummer'.", repo.MdiLag.KundennummerInfo, new RecordItemIndex(13));
            repo.MdiLag.Kundennummer.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLag.Lagerplaetze' at Center.", repo.MdiLag.LagerplaetzeInfo, new RecordItemIndex(14));
            repo.MdiLag.Lagerplaetze.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1{Tab}' with focus on 'MdiLag.Lagerplaetze'.", repo.MdiLag.LagerplaetzeInfo, new RecordItemIndex(15));
            repo.MdiLag.Lagerplaetze.PressKeys("1{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'MdiLag.TpAllgemein.Text'.", repo.MdiLag.TpAllgemein.TextInfo, new RecordItemIndex(16));
            repo.MdiLag.TpAllgemein.Text.EnsureVisible();
            Keyboard.Press("1");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MdiLag.TpAllgemein.Text'.", repo.MdiLag.TpAllgemein.TextInfo, new RecordItemIndex(17));
            repo.MdiLag.TpAllgemein.Text.EnsureVisible();
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Ja') on item 'MdiLag.TpAllgemein.DfLagKzlgplBez'.", repo.MdiLag.TpAllgemein.DfLagKzlgplBezInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.MdiLag.TpAllgemein.DfLagKzlgplBezInfo, "Text", "Ja");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Filiale+Zentrale') on item 'MdiLag.TpAllgemein.DfLagKzfilialeBez'.", repo.MdiLag.TpAllgemein.DfLagKzfilialeBezInfo, new RecordItemIndex(19));
            Validate.AttributeContains(repo.MdiLag.TpAllgemein.DfLagKzfilialeBezInfo, "Text", "Filiale+Zentrale");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLag.TpAllgemein.Text1' at CenterRight.", repo.MdiLag.TpAllgemein.Text1Info, new RecordItemIndex(20));
            repo.MdiLag.TpAllgemein.Text1.Click(Location.CenterRight);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LLAGS.DropDown' at UpperCenter.", repo.LLAGS.DropDownInfo, new RecordItemIndex(21));
            repo.LLAGS.DropDown.Click(Location.UpperCenter);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLag.TpAllgemein.Text2' at CenterRight.", repo.MdiLag.TpAllgemein.Text2Info, new RecordItemIndex(22));
            repo.MdiLag.TpAllgemein.Text2.Click(Location.CenterRight);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LLAGS.DropDown' at .2;.2.", repo.LLAGS.DropDownInfo, new RecordItemIndex(23));
            repo.LLAGS.DropDown.Click(".2;.2");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MdiLag.TpAllgemein.Text2'.", repo.MdiLag.TpAllgemein.Text2Info, new RecordItemIndex(24));
            repo.MdiLag.TpAllgemein.Text2.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LGPL_Struktur_1) on item 'MdiLag.TpAllgemein.Text1'.", repo.MdiLag.TpAllgemein.Text1Info, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.MdiLag.TpAllgemein.Text1Info, "Text", LGPL_Struktur_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'MdiLag.TpAllgemein.CmbLagSnr1'.", repo.MdiLag.TpAllgemein.CmbLagSnr1Info, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.MdiLag.TpAllgemein.CmbLagSnr1Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LGPL_Struktur_2) on item 'MdiLag.TpAllgemein.Text2'.", repo.MdiLag.TpAllgemein.Text2Info, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.MdiLag.TpAllgemein.Text2Info, "Text", LGPL_Struktur_2);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLag.TpAllgemein.CmbLagSnr2' at CenterRight.", repo.MdiLag.TpAllgemein.CmbLagSnr2Info, new RecordItemIndex(28));
            repo.MdiLag.TpAllgemein.CmbLagSnr2.Click(Location.CenterRight);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ListItem3' at LowerCenter.", repo.List1000.ListItem3Info, new RecordItemIndex(29));
            repo.List1000.ListItem3.Click(Location.LowerCenter);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
