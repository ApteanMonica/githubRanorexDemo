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

namespace V_AUF_006.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Positionen_kopieren recording.
    /// </summary>
    [TestModule("90a52435-acb4-46aa-a799-22cb4521ac36", ModuleType.Recording, 1)]
    public partial class Positionen_kopieren : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_AUF_006.V_AUF_006Repository repository.
        /// </summary>
        public static global::V_AUF_006.V_AUF_006Repository repo = global::V_AUF_006.V_AUF_006Repository.Instance;

        static Positionen_kopieren instance = new Positionen_kopieren();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Positionen_kopieren()
        {
            Art_Nr_Kreditlimit = "100015";
            AufpMenge_1 = "";
            AufpMenge_2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Positionen_kopieren Instance
        {
            get { return instance; }
        }

#region Variables

        string _Art_Nr_Kreditlimit;

        /// <summary>
        /// Gets or sets the value of variable Art_Nr_Kreditlimit.
        /// </summary>
        [TestVariable("e0905cae-4df9-436a-9d36-3e77990af51d")]
        public string Art_Nr_Kreditlimit
        {
            get { return _Art_Nr_Kreditlimit; }
            set { _Art_Nr_Kreditlimit = value; }
        }

        string _AufpMenge_1;

        /// <summary>
        /// Gets or sets the value of variable AufpMenge_1.
        /// </summary>
        [TestVariable("77899f60-880d-4d49-a6ad-b7d1e0393500")]
        public string AufpMenge_1
        {
            get { return _AufpMenge_1; }
            set { _AufpMenge_1 = value; }
        }

        string _AufpMenge_2;

        /// <summary>
        /// Gets or sets the value of variable AufpMenge_2.
        /// </summary>
        [TestVariable("8fd9a196-79d9-4634-8c33-d1b8e18bd61d")]
        public string AufpMenge_2
        {
            get { return _AufpMenge_2; }
            set { _AufpMenge_2 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.ArtNr' at Center.", repo.FrmAufk.ArtNrInfo, new RecordItemIndex(0));
            repo.FrmAufk.ArtNr.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Art_Nr_Kreditlimit' with focus on 'FrmAufk.ArtNr'.", repo.FrmAufk.ArtNrInfo, new RecordItemIndex(1));
            repo.FrmAufk.ArtNr.PressKeys(Art_Nr_Kreditlimit);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.Menge' at Center.", repo.FrmAufk.MengeInfo, new RecordItemIndex(2));
            repo.FrmAufk.Menge.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1{Tab}' with focus on 'FrmAufk.Menge'.", repo.FrmAufk.MengeInfo, new RecordItemIndex(3));
            repo.FrmAufk.Menge.PressKeys("1{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmAufk.DfAufpPreis' at Center.", repo.FrmAufk.DfAufpPreisInfo, new RecordItemIndex(4));
            repo.FrmAufk.DfAufpPreis.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='11') on item 'FrmAufk.DfAufpPreis'.", repo.FrmAufk.DfAufpPreisInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmAufk.DfAufpPreisInfo, "Text", "11");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.PbCommonSave' at Center.", repo.FrmAufk.PbCommonSaveInfo, new RecordItemIndex(6));
            repo.FrmAufk.PbCommonSave.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FrmAufk.Row1Column0' at Center.", repo.FrmAufk.Row1Column0Info, new RecordItemIndex(7));
            repo.FrmAufk.Row1Column0.Click(System.Windows.Forms.MouseButtons.Right);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VAUF.PosKopieren' at Center.", repo.VAUF.PosKopierenInfo, new RecordItemIndex(8));
            repo.VAUF.PosKopieren.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgAufpCopy.PbOk' at Center.", repo.DlgAufpCopy.PbOkInfo, new RecordItemIndex(9));
            repo.DlgAufpCopy.PbOk.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Keine weiteren Positionen zum Kopieren') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Keine weiteren Positionen zum Kopieren");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(11));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='22,00') on item 'FrmAufk.DfAufkWert1D'.", repo.FrmAufk.DfAufkWert1DInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmAufk.DfAufkWert1DInfo, "Text", "22,00");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}{LControlKey down}' with focus on 'FrmAufk.Row1Column0'.", repo.FrmAufk.Row1Column0Info, new RecordItemIndex(13));
            repo.FrmAufk.Row1Column0.EnsureVisible();
            Keyboard.Press("{LShiftKey down}{LControlKey down}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.Row1Column0' at Center.", repo.FrmAufk.Row1Column0Info, new RecordItemIndex(14));
            repo.FrmAufk.Row1Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.Row2Column0' at Center.", repo.FrmAufk.Row2Column0Info, new RecordItemIndex(15));
            repo.FrmAufk.Row2Column0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}{LControlKey down}' with focus on 'FrmAufk.Row1Column0'.", repo.FrmAufk.Row1Column0Info, new RecordItemIndex(16));
            repo.FrmAufk.Row1Column0.EnsureVisible();
            Keyboard.Press("{LShiftKey down}{LControlKey down}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FrmAufk.Row2Column0' at Center.", repo.FrmAufk.Row2Column0Info, new RecordItemIndex(17));
            repo.FrmAufk.Row2Column0.Click(System.Windows.Forms.MouseButtons.Right);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VAUF.PosKopierenUUrsprPosStornieren' at Center.", repo.VAUF.PosKopierenUUrsprPosStornierenInfo, new RecordItemIndex(18));
            repo.VAUF.PosKopierenUUrsprPosStornieren.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.PbCommonSave' at Center.", repo.FrmAufk.PbCommonSaveInfo, new RecordItemIndex(19));
            repo.FrmAufk.PbCommonSave.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.PbCommonSave' at Center.", repo.FrmAufk.PbCommonSaveInfo, new RecordItemIndex(20));
            repo.FrmAufk.PbCommonSave.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Keine weiteren Positionen zum Kopieren') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Keine weiteren Positionen zum Kopieren");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(22));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'FrmAufk.FlexGrid.ColAufpZeileAnzeigeRow3'.", repo.FrmAufk.FlexGrid.ColAufpZeileAnzeigeRow3Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.FrmAufk.FlexGrid.ColAufpZeileAnzeigeRow3Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='4') on item 'FrmAufk.FlexGrid.ColAufpZeileAnzeigeRow4'.", repo.FrmAufk.FlexGrid.ColAufpZeileAnzeigeRow4Info, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.FrmAufk.FlexGrid.ColAufpZeileAnzeigeRow4Info, "Text", "4");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='22,00') on item 'FrmAufk.DfAufkWert1D'.", repo.FrmAufk.DfAufkWert1DInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.FrmAufk.DfAufkWert1DInfo, "Text", "22,00");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.CbStornierte' at Center.", repo.FrmAufk.CbStornierteInfo, new RecordItemIndex(26));
            repo.FrmAufk.CbStornierte.Click();
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'FrmAufk.FlexGrid.ColAufpMengeRow1'.", repo.FrmAufk.FlexGrid.ColAufpMengeRow1Info, new RecordItemIndex(27));
            //Validate.AttributeEqual(repo.FrmAufk.FlexGrid.ColAufpMengeRow1Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'FrmAufk.FlexGrid.ColAufpMengeRow1' and assigning its value to variable 'AufpMenge_1'.", repo.FrmAufk.FlexGrid.ColAufpMengeRow1Info, new RecordItemIndex(28));
            AufpMenge_1 = repo.FrmAufk.FlexGrid.ColAufpMengeRow1.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateWithoutDecimals(AufpMenge_1, "0");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'FrmAufk.FlexGrid.ColAufpMengeRow2'.", repo.FrmAufk.FlexGrid.ColAufpMengeRow2Info, new RecordItemIndex(30));
            //Validate.AttributeEqual(repo.FrmAufk.FlexGrid.ColAufpMengeRow2Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'FrmAufk.FlexGrid.ColAufpMengeRow2' and assigning its value to variable 'AufpMenge_2'.", repo.FrmAufk.FlexGrid.ColAufpMengeRow2Info, new RecordItemIndex(31));
            AufpMenge_2 = repo.FrmAufk.FlexGrid.ColAufpMengeRow2.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateWithoutDecimals(AufpMenge_2, "0");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.CbStornierte' at Center.", repo.FrmAufk.CbStornierteInfo, new RecordItemIndex(33));
            repo.FrmAufk.CbStornierte.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
