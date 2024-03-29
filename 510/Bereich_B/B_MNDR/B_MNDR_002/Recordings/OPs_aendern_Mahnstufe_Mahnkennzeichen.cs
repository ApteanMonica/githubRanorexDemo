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

namespace B_MNDR_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OPs_aendern_Mahnstufe_Mahnkennzeichen recording.
    /// </summary>
    [TestModule("e15ace0a-0d19-4e72-af4a-28247fc1b125", ModuleType.Recording, 1)]
    public partial class OPs_aendern_Mahnstufe_Mahnkennzeichen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_MNDR_002.B_MNDR_002Repository repository.
        /// </summary>
        public static global::B_MNDR_002.B_MNDR_002Repository repo = global::B_MNDR_002.B_MNDR_002Repository.Instance;

        static OPs_aendern_Mahnstufe_Mahnkennzeichen instance = new OPs_aendern_Mahnstufe_Mahnkennzeichen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OPs_aendern_Mahnstufe_Mahnkennzeichen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OPs_aendern_Mahnstufe_Mahnkennzeichen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Beschreibung.
        /// </summary>
        [TestVariable("00803024-db45-4d55-9321-83ebc5774ea6")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblMndt.FlexGrid_Tabelle.Column0_Zeile_mit_Beschreibung' at Center.", repo.TblMndt.FlexGrid_Tabelle.Column0_Zeile_mit_BeschreibungInfo, new RecordItemIndex(0));
            repo.TblMndt.FlexGrid_Tabelle.Column0_Zeile_mit_Beschreibung.DoubleClick();
            
            // prüft auf erste Zeile jedoch nicht wenn mehrere Zeilen sind auf richtige Zeile
            //Report.Log(ReportLevel.Info, "Mouse", "prüft auf erste Zeile jedoch nicht wenn mehrere Zeilen sind auf richtige Zeile\r\nMouse Left DoubleClick item 'TblBuop.FlexGrid.Row1Column0' at Center.", repo.TblBuop.FlexGrid.Row1Column0Info, new RecordItemIndex(1));
            //repo.TblBuop.FlexGrid.Row1Column0.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmVorschlagAEndern.PbDataAccessSave' at Center.", repo.FrmVorschlagAEndern.PbDataAccessSaveInfo, new RecordItemIndex(2));
            repo.FrmVorschlagAEndern.PbDataAccessSave.Click();
            
            // Problem mit Repository in 521 TitelBar aus dem Mahnvorschlag heisst hier anders. Problem wird bei ähnlichen Prüfungen auch in anderen Fällen vermutlich auftreten? mit Pet besprechen
            Report.Log(ReportLevel.Info, "Validation", "Problem mit Repository in 521 TitelBar aus dem Mahnvorschlag heisst hier anders. Problem wird bei ähnlichen Prüfungen auch in anderen Fällen vermutlich auftreten? mit Pet besprechen\r\nValidating Exists on item 'FrmVorschlagAEndern.TitleBar1002BMNDR002Mahnvorschla'.", repo.FrmVorschlagAEndern.TitleBar1002BMNDR002MahnvorschlaInfo, new RecordItemIndex(3));
            Validate.Exists(repo.FrmVorschlagAEndern.TitleBar1002BMNDR002MahnvorschlaInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmVorschlagAEndern.RbRngNr' at Center.", repo.FrmVorschlagAEndern.RbRngNrInfo, new RecordItemIndex(4));
            repo.FrmVorschlagAEndern.RbRngNr.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmVorschlagAEndern.PbDataAccessLoad' at Center.", repo.FrmVorschlagAEndern.PbDataAccessLoadInfo, new RecordItemIndex(5));
            repo.FrmVorschlagAEndern.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row4.ColStufeRow4' at Center.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row4.ColStufeRow4Info, new RecordItemIndex(6));
            repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row4.ColStufeRow4.Click();
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row4.ColStufeRow4'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row4.ColStufeRow4Info, new RecordItemIndex(7));
            //repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row4.ColStufeRow4.EnsureVisible();
            //Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}2{Tab}' with focus on 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row4.ColStufeRow4'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row4.ColStufeRow4Info, new RecordItemIndex(8));
            repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row4.ColStufeRow4.PressKeys("{Back}2{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row4.ColStufeRow4'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row4.ColStufeRow4Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row4.ColStufeRow4Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3' at Center.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3Info, new RecordItemIndex(10));
            repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}N{Tab}' with focus on 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3Info, new RecordItemIndex(11));
            repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3.EnsureVisible();
            Keyboard.Press("{Back}N{Tab}");
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3Info, new RecordItemIndex(12));
            //Keyboard.PrepareFocus(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3);
            //Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row3.ColSperreRow3Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6' at Center.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6Info, new RecordItemIndex(14));
            repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}N{Tab}' with focus on 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6Info, new RecordItemIndex(15));
            repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6.EnsureVisible();
            Keyboard.Press("{Back}N{Tab}");
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6Info, new RecordItemIndex(16));
            //Keyboard.PrepareFocus(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6);
            //Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.Row6.ColSperreRow6Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmVorschlagAEndern.PbDataAccessSave' at Center.", repo.FrmVorschlagAEndern.PbDataAccessSaveInfo, new RecordItemIndex(18));
            repo.FrmVorschlagAEndern.PbDataAccessSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
