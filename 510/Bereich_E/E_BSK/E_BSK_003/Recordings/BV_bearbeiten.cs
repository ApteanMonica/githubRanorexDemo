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

namespace E_BSK_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BV_bearbeiten recording.
    /// </summary>
    [TestModule("4b3663f0-6cb5-4c33-97b2-00f4eea531a2", ModuleType.Recording, 1)]
    public partial class BV_bearbeiten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_BSK_003.E_BSK_003Repository repository.
        /// </summary>
        public static global::E_BSK_003.E_BSK_003Repository repo = global::E_BSK_003.E_BSK_003Repository.Instance;

        static BV_bearbeiten instance = new BV_bearbeiten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BV_bearbeiten()
        {
            Bestellvorschlag = "BV21/00001";
            Lieferant1 = "300021";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BV_bearbeiten Instance
        {
            get { return instance; }
        }

#region Variables

        string _Bestellvorschlag;

        /// <summary>
        /// Gets or sets the value of variable Bestellvorschlag.
        /// </summary>
        [TestVariable("d24485bb-6585-4209-9377-7e23f971b600")]
        public string Bestellvorschlag
        {
            get { return _Bestellvorschlag; }
            set { _Bestellvorschlag = value; }
        }

        string _Lieferant1;

        /// <summary>
        /// Gets or sets the value of variable Lieferant1.
        /// </summary>
        [TestVariable("acd10053-9c8e-4450-981a-54060d624a48")]
        public string Lieferant1
        {
            get { return _Lieferant1; }
            set { _Lieferant1 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBestellung.PbNew' at Center.", repo.MdiBestellung.PbNewInfo, new RecordItemIndex(0));
            repo.MdiBestellung.PbNew.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBestellung.PbCommonBestellvorschlag' at Center.", repo.MdiBestellung.PbCommonBestellvorschlagInfo, new RecordItemIndex(1));
            repo.MdiBestellung.PbCommonBestellvorschlag.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EBSK.BearbeitenImportieren' at Center.", repo.EBSK.BearbeitenImportierenInfo, new RecordItemIndex(2));
            repo.EBSK.BearbeitenImportieren.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmBsvs.TitleBar100BestellvorschlagBearbeit'.", repo.FrmBsvs.TitleBar100BestellvorschlagBearbeitInfo, new RecordItemIndex(3));
            Validate.Exists(repo.FrmBsvs.TitleBar100BestellvorschlagBearbeitInfo);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute AccessibleValue to '$Bestellvorschlag' on item 'FrmBsvs.Bestellvorschlag'.", repo.FrmBsvs.BestellvorschlagInfo, new RecordItemIndex(4));
            repo.FrmBsvs.Bestellvorschlag.Element.SetAttributeValue("AccessibleValue", Bestellvorschlag);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.PbDataAccessLoad' at Center.", repo.FrmBsvs.PbDataAccessLoadInfo, new RecordItemIndex(5));
            repo.FrmBsvs.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.CbKopfAutomatisch' at Center.", repo.FrmBsvs.CbKopfAutomatischInfo, new RecordItemIndex(6));
            repo.FrmBsvs.CbKopfAutomatisch.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.Row2Column0' at Center.", repo.FrmBsvs.Row2Column0Info, new RecordItemIndex(7));
            repo.FrmBsvs.Row2Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.PbCommonBestellen' at Center.", repo.FrmBsvs.PbCommonBestellenInfo, new RecordItemIndex(8));
            repo.FrmBsvs.PbCommonBestellen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Um Bestellvorschlagspositionen importieren zu können muss ein Lieferant eingetragen sein') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(9));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Um Bestellvorschlagspositionen importieren zu können muss ein Lieferant eingetragen sein");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(10));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.ColAdrNrRow2' at Center.", repo.FrmBsvs.ColAdrNrRow2Info, new RecordItemIndex(11));
            repo.FrmBsvs.ColAdrNrRow2.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Lieferant1' with focus on 'FrmBsvs.ColAdrNrRow2'.", repo.FrmBsvs.ColAdrNrRow2Info, new RecordItemIndex(12));
            repo.FrmBsvs.ColAdrNrRow2.EnsureVisible();
            Keyboard.Press(Lieferant1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmBsvs.ColAdrNrRow2'.", repo.FrmBsvs.ColAdrNrRow2Info, new RecordItemIndex(13));
            repo.FrmBsvs.ColAdrNrRow2.EnsureVisible();
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.Row2Column0' at Center.", repo.FrmBsvs.Row2Column0Info, new RecordItemIndex(14));
            repo.FrmBsvs.Row2Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.PbCommonBestellen' at Center.", repo.FrmBsvs.PbCommonBestellenInfo, new RecordItemIndex(15));
            repo.FrmBsvs.PbCommonBestellen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Sollen die Änderungen gespeichert werden?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(16));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Sollen die Änderungen gespeichert werden?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(17));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'MdiBestellung.Kopf'", repo.MdiBestellung.KopfInfo, new ActionTimeout(10000), new RecordItemIndex(18));
            repo.MdiBestellung.KopfInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferant1) on item 'MdiBestellung.Lieferant'.", repo.MdiBestellung.LieferantInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.MdiBestellung.LieferantInfo, "Text", Lieferant1);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBestellung.PbNavigationBack' at Center.", repo.MdiBestellung.PbNavigationBackInfo, new RecordItemIndex(20));
            repo.MdiBestellung.PbNavigationBack.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Es wurden Daten im Bestellkopf geändert') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(21));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Es wurden Daten im Bestellkopf geändert");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button1' at Center.", repo.DlgMessageBox.Button1Info, new RecordItemIndex(22));
            repo.DlgMessageBox.Button1.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
