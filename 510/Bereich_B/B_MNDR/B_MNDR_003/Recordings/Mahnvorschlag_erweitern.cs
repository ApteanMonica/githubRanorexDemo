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

namespace B_MNDR_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Mahnvorschlag_erweitern recording.
    /// </summary>
    [TestModule("78509451-e25a-47ef-a0a5-b735456aeafb", ModuleType.Recording, 1)]
    public partial class Mahnvorschlag_erweitern : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_MNDR_003.B_MNDR_003Repository repository.
        /// </summary>
        public static global::B_MNDR_003.B_MNDR_003Repository repo = global::B_MNDR_003.B_MNDR_003Repository.Instance;

        static Mahnvorschlag_erweitern instance = new Mahnvorschlag_erweitern();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Mahnvorschlag_erweitern()
        {
            Beschreibung = "B_MNDR_003";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Mahnvorschlag_erweitern Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Beschreibung.
        /// </summary>
        [TestVariable("a341d48a-e072-4868-a5ed-5e5a958ee89a")]
        public string Beschreibung
        {
            get { return repo.Beschreibung; }
            set { repo.Beschreibung = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblMndt.FlexGrid_Tabelle.Column0_Zeile_mit_Beschreibung' at Center.", repo.TblMndt.FlexGrid_Tabelle.Column0_Zeile_mit_BeschreibungInfo, new RecordItemIndex(0));
            repo.TblMndt.FlexGrid_Tabelle.Column0_Zeile_mit_Beschreibung.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblMndt.PbCommonErweitern' at Center.", repo.TblMndt.PbCommonErweiternInfo, new RecordItemIndex(1));
            repo.TblMndt.PbCommonErweitern.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmVorschlagErstellen.TitleBar1003BMNDR003Mahnvorschla'", repo.FrmVorschlagErstellen.TitleBar1003BMNDR003MahnvorschlaInfo, new ActionTimeout(120000), new RecordItemIndex(2));
            repo.FrmVorschlagErstellen.TitleBar1003BMNDR003MahnvorschlaInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Beschreibung) on item 'FrmVorschlagErstellen.TitleBar1003BMNDR003Mahnvorschla'.", repo.FrmVorschlagErstellen.TitleBar1003BMNDR003MahnvorschlaInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.FrmVorschlagErstellen.TitleBar1003BMNDR003MahnvorschlaInfo, "Text", Beschreibung);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Mahnvorschlag erweitern Kunden') on item 'FrmVorschlagErstellen.TitleBar1003BMNDR003Mahnvorschla'.", repo.FrmVorschlagErstellen.TitleBar1003BMNDR003MahnvorschlaInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.FrmVorschlagErstellen.TitleBar1003BMNDR003MahnvorschlaInfo, "Text", "Mahnvorschlag erweitern Kunden");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
