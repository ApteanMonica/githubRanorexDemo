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

namespace B_KTO_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Konto_laden recording.
    /// </summary>
    [TestModule("08585799-3074-477e-9a14-67469fa06126", ModuleType.Recording, 1)]
    public partial class Konto_laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KTO_003.B_KTO_003Repository repository.
        /// </summary>
        public static global::B_KTO_003.B_KTO_003Repository repo = global::B_KTO_003.B_KTO_003Repository.Instance;

        static Konto_laden instance = new Konto_laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Konto_laden()
        {
            Konto = "2341";
            Kontoname = "QS Konto kopieren";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Konto_laden Instance
        {
            get { return instance; }
        }

#region Variables

        string _Konto;

        /// <summary>
        /// Gets or sets the value of variable Konto.
        /// </summary>
        [TestVariable("242cf869-b048-4498-bc70-c8fdc4ec7057")]
        public string Konto
        {
            get { return _Konto; }
            set { _Konto = value; }
        }

        string _Kontoname;

        /// <summary>
        /// Gets or sets the value of variable Kontoname.
        /// </summary>
        [TestVariable("1ed7dfc4-0b58-470e-8d4a-60a9af433006")]
        public string Kontoname
        {
            get { return _Kontoname; }
            set { _Kontoname = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKto.FrmSearchPage.Suchtext_Eingabe' at Center.", repo.FrmKto.FrmSearchPage.Suchtext_EingabeInfo, new RecordItemIndex(0));
            repo.FrmKto.FrmSearchPage.Suchtext_Eingabe.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Konto' with focus on 'FrmKto.FrmSearchPage.Suchtext_Eingabe'.", repo.FrmKto.FrmSearchPage.Suchtext_EingabeInfo, new RecordItemIndex(1));
            repo.FrmKto.FrmSearchPage.Suchtext_Eingabe.PressKeys(Konto);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmKto.FrmSearchPage.Suchtext_Eingabe'.", repo.FrmKto.FrmSearchPage.Suchtext_EingabeInfo, new RecordItemIndex(2));
            repo.FrmKto.FrmSearchPage.Suchtext_Eingabe.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmKto.FrmSearchPage.Row1Column0' at Center.", repo.FrmKto.FrmSearchPage.Row1Column0Info, new RecordItemIndex(3));
            repo.FrmKto.FrmSearchPage.Row1Column0.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Konto) on item 'FrmKto.DfKtoNr'.", repo.FrmKto.DfKtoNrInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmKto.DfKtoNrInfo, "Text", Konto);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kontoname) on item 'FrmKto.Bezeichnung'.", repo.FrmKto.BezeichnungInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmKto.BezeichnungInfo, "Text", Kontoname);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='P') on item 'FrmKto.PicTabs.Verwendung'.", repo.FrmKto.PicTabs.VerwendungInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmKto.PicTabs.VerwendungInfo, "Text", "P");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKto.PicTabs.TabPageGruppen' at Center.", repo.FrmKto.PicTabs.TabPageGruppenInfo, new RecordItemIndex(7));
            repo.FrmKto.PicTabs.TabPageGruppen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0125') on item 'FrmKto.PicTabs.ColKtgrCdRow1'.", repo.FrmKto.PicTabs.ColKtgrCdRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmKto.PicTabs.ColKtgrCdRow1Info, "Text", "0125");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
