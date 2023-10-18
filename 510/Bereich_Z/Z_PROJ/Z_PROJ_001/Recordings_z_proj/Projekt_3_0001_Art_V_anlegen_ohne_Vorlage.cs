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

namespace Z_PROJ_001.Recordings_z_proj
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Projekt_3_0001_Art_V_anlegen_ohne_Vorlage recording.
    /// </summary>
    [TestModule("c48c34f4-ab8d-46f7-8887-e8c4f930d632", ModuleType.Recording, 1)]
    public partial class Projekt_3_0001_Art_V_anlegen_ohne_Vorlage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_001.Z_PROJ_001Repository repository.
        /// </summary>
        public static global::Z_PROJ_001.Z_PROJ_001Repository repo = global::Z_PROJ_001.Z_PROJ_001Repository.Instance;

        static Projekt_3_0001_Art_V_anlegen_ohne_Vorlage instance = new Projekt_3_0001_Art_V_anlegen_ohne_Vorlage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Projekt_3_0001_Art_V_anlegen_ohne_Vorlage()
        {
            PROJ_NR_3_V = "0001";
            PROJ_BEZ_3_V = "PAPAMONAT";
            bis_Datum = "31.12.2099";
            User_RSX = "RSX";
            User_RS = "RS";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Projekt_3_0001_Art_V_anlegen_ohne_Vorlage Instance
        {
            get { return instance; }
        }

#region Variables

        string _PROJ_BEZ_3_V;

        /// <summary>
        /// Gets or sets the value of variable PROJ_BEZ_3_V.
        /// </summary>
        [TestVariable("0b4bfce9-4717-40f3-8fb1-8a278c5bbca6")]
        public string PROJ_BEZ_3_V
        {
            get { return _PROJ_BEZ_3_V; }
            set { _PROJ_BEZ_3_V = value; }
        }

        string _bis_Datum;

        /// <summary>
        /// Gets or sets the value of variable bis_Datum.
        /// </summary>
        [TestVariable("0f516454-a07c-4129-85e1-9250f2678182")]
        public string bis_Datum
        {
            get { return _bis_Datum; }
            set { _bis_Datum = value; }
        }

        string _User_RSX;

        /// <summary>
        /// Gets or sets the value of variable User_RSX.
        /// </summary>
        [TestVariable("2588c262-3a8c-4799-b7ba-3bcede8a00ac")]
        public string User_RSX
        {
            get { return _User_RSX; }
            set { _User_RSX = value; }
        }

        string _User_RS;

        /// <summary>
        /// Gets or sets the value of variable User_RS.
        /// </summary>
        [TestVariable("d3e18d35-1033-4a5d-bcc0-642f11194841")]
        public string User_RS
        {
            get { return _User_RS; }
            set { _User_RS = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PROJ_NR_3_V.
        /// </summary>
        [TestVariable("8ee0abd1-ed5b-4dd2-bab2-6bc210d50039")]
        public string PROJ_NR_3_V
        {
            get { return repo.PROJ_NR_3_V; }
            set { repo.PROJ_NR_3_V = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmTabProjekt.TitleBar100ProjektVerwalten'.", repo.FrmTabProjekt.TitleBar100ProjektVerwaltenInfo, new RecordItemIndex(0));
            Validate.Exists(repo.FrmTabProjekt.TitleBar100ProjektVerwaltenInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.Suche.PbNew' at Center.", repo.FrmTabProjekt.Suche.PbNewInfo, new RecordItemIndex(1));
            repo.FrmTabProjekt.Suche.PbNew.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.TextArt' at Center.", repo.FrmTabProjekt.TextArtInfo, new RecordItemIndex(2));
            repo.FrmTabProjekt.TextArt.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press with focus on 'FrmTabProjekt.TextArt'.", repo.FrmTabProjekt.TextArtInfo, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.FrmTabProjekt.TextArt);
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'V' with focus on 'FrmTabProjekt.TextArt'.", repo.FrmTabProjekt.TextArtInfo, new RecordItemIndex(5));
            repo.FrmTabProjekt.TextArt.PressKeys("V");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmTabProjekt.TextArt'.", repo.FrmTabProjekt.TextArtInfo, new RecordItemIndex(6));
            Keyboard.PrepareFocus(repo.FrmTabProjekt.TextArt);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.VorlageProjektnr'.", repo.FrmTabProjekt.VorlageProjektnrInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmTabProjekt.VorlageProjektnrInfo, "Text", "");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.PbToolBarItemsNummer' at Center.", repo.FrmTabProjekt.PbToolBarItemsNummerInfo, new RecordItemIndex(8));
            repo.FrmTabProjekt.PbToolBarItemsNummer.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$PROJ_NR_3_V) on item 'FrmTabProjekt.Projektnr'.", repo.FrmTabProjekt.ProjektnrInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmTabProjekt.ProjektnrInfo, "Text", PROJ_NR_3_V);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '' on item 'FrmTabProjekt.Bezeichnung'.", repo.FrmTabProjekt.BezeichnungInfo, new RecordItemIndex(10));
            repo.FrmTabProjekt.Bezeichnung.Element.SetAttributeValue("Text", "");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PROJ_BEZ_3_V' with focus on 'FrmTabProjekt.Bezeichnung'.", repo.FrmTabProjekt.BezeichnungInfo, new RecordItemIndex(11));
            repo.FrmTabProjekt.Bezeichnung.PressKeys(PROJ_BEZ_3_V);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$bis_Datum' with focus on 'FrmTabProjekt.Register_Projekt.TextBis'.", repo.FrmTabProjekt.Register_Projekt.TextBisInfo, new RecordItemIndex(12));
            repo.FrmTabProjekt.Register_Projekt.TextBis.PressKeys(bis_Datum);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmTabProjekt.Register_Projekt.TextBis'.", repo.FrmTabProjekt.Register_Projekt.TextBisInfo, new RecordItemIndex(13));
            repo.FrmTabProjekt.Register_Projekt.TextBis.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Projekt.ColPersNrRow1'.", repo.FrmTabProjekt.Register_Projekt.ColPersNrRow1Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Projekt.ColPersNrRow1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Projekt.ColPersNrRow2'.", repo.FrmTabProjekt.Register_Projekt.ColPersNrRow2Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Projekt.ColPersNrRow2Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$User_RSX' with focus on 'FrmTabProjekt.Register_Projekt.ColPersNrRow1'.", repo.FrmTabProjekt.Register_Projekt.ColPersNrRow1Info, new RecordItemIndex(16));
            repo.FrmTabProjekt.Register_Projekt.ColPersNrRow1.PressKeys(User_RSX);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmTabProjekt.Register_Projekt.ColPersNrRow1'.", repo.FrmTabProjekt.Register_Projekt.ColPersNrRow1Info, new RecordItemIndex(17));
            repo.FrmTabProjekt.Register_Projekt.ColPersNrRow1.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$User_RS' with focus on 'FrmTabProjekt.Register_Projekt.ColPersNrRow2'.", repo.FrmTabProjekt.Register_Projekt.ColPersNrRow2Info, new RecordItemIndex(18));
            repo.FrmTabProjekt.Register_Projekt.ColPersNrRow2.PressKeys(User_RS);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmTabProjekt.Register_Projekt.ColPersNrRow2'.", repo.FrmTabProjekt.Register_Projekt.ColPersNrRow2Info, new RecordItemIndex(19));
            repo.FrmTabProjekt.Register_Projekt.ColPersNrRow2.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.Allgemein_Tab_regex_Sonderzeichen' at Center.", repo.FrmTabProjekt.Allgemein_Tab_regex_SonderzeichenInfo, new RecordItemIndex(20));
            repo.FrmTabProjekt.Allgemein_Tab_regex_Sonderzeichen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmTabProjekt.Register_Allgemein.Text1'.", repo.FrmTabProjekt.Register_Allgemein.Text1Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Allgemein.Text1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'FrmTabProjekt.Register_Allgemein.CbProjBukzzeit'.", repo.FrmTabProjekt.Register_Allgemein.CbProjBukzzeitInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Allgemein.CbProjBukzzeitInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'FrmTabProjekt.Register_Allgemein.CbProjKzuhr'.", repo.FrmTabProjekt.Register_Allgemein.CbProjKzuhrInfo, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Allgemein.CbProjKzuhrInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmTabProjekt.Register_Allgemein.CbProjKzdauer'.", repo.FrmTabProjekt.Register_Allgemein.CbProjKzdauerInfo, new RecordItemIndex(24));
            Validate.AttributeEqual(repo.FrmTabProjekt.Register_Allgemein.CbProjKzdauerInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'KA' with focus on 'FrmTabProjekt.Register_Allgemein.Text1'.", repo.FrmTabProjekt.Register_Allgemein.Text1Info, new RecordItemIndex(25));
            repo.FrmTabProjekt.Register_Allgemein.Text1.PressKeys("KA");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.PbDataAccessSave' at Center.", repo.FrmTabProjekt.PbDataAccessSaveInfo, new RecordItemIndex(26));
            repo.FrmTabProjekt.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Projekt kann ohne Phaseneintrag nicht gespeichert werden!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Projekt kann ohne Phaseneintrag nicht gespeichert werden!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(28));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
