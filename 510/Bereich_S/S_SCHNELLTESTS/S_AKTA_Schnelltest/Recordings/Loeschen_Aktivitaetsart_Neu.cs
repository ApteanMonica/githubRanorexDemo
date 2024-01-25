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

namespace S_AKTA_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Loeschen_Aktivitaetsart_Neu recording.
    /// </summary>
    [TestModule("c2469c06-6a52-4ea2-b4ca-59f3f60fe465", ModuleType.Recording, 1)]
    public partial class Loeschen_Aktivitaetsart_Neu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_AKTA_Schnelltest.S_AKTA_SchnelltestRepository repository.
        /// </summary>
        public static global::S_AKTA_Schnelltest.S_AKTA_SchnelltestRepository repo = global::S_AKTA_Schnelltest.S_AKTA_SchnelltestRepository.Instance;

        static Loeschen_Aktivitaetsart_Neu instance = new Loeschen_Aktivitaetsart_Neu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Loeschen_Aktivitaetsart_Neu()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Loeschen_Aktivitaetsart_Neu Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Aktivitaet_Typ_Neu.
        /// </summary>
        [TestVariable("9ef6fbfd-bfcc-4ae8-a715-0ccfffb90776")]
        public string Aktivitaet_Typ_Neu
        {
            get { return repo.Aktivitaet_Typ_Neu; }
            set { repo.Aktivitaet_Typ_Neu = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormAktArten.RibbonBar.PbToolBarItemsLoeschen' at Center.", repo.FormAktArten.RibbonBar.PbToolBarItemsLoeschenInfo, new RecordItemIndex(0));
            repo.FormAktArten.RibbonBar.PbToolBarItemsLoeschen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.Aktivitaetsarten'", repo.DlgMessageBox.AktivitaetsartenInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.DlgMessageBox.AktivitaetsartenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Wollen Sie die Aktivitätsart\r\n\r\n<XX - >\r\n\r\nwirklich löschen?\r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Wollen Sie die Aktivitätsart\r\n\r\n<XX - >\r\n\r\nwirklich löschen?\r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(3));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FormAktArten.TitleBar100VerwaltenAktivitaetsarte'", repo.FormAktArten.TitleBar100VerwaltenAktivitaetsarteInfo, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.FormAktArten.TitleBar100VerwaltenAktivitaetsarteInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at {X=0,Y=0}.", new RecordItemIndex(5));
            Mouse.MoveTo(0, 0);
            Mouse.Click(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormAktArten.PbPerformSimpleSearch' at Center.", repo.FormAktArten.PbPerformSimpleSearchInfo, new RecordItemIndex(6));
            repo.FormAktArten.PbPerformSimpleSearch.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'FormAktArten.FlexGrid.Row_mit_Variable_Aktivitaetstyp_Neu'.", repo.FormAktArten.FlexGrid.Row_mit_Variable_Aktivitaetstyp_Neu.SelfInfo, new RecordItemIndex(8));
            Validate.NotExists(repo.FormAktArten.FlexGrid.Row_mit_Variable_Aktivitaetstyp_Neu.SelfInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}