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

namespace L_LGBUCH_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Buchungsliste recording.
    /// </summary>
    [TestModule("8a8afda7-e333-4bd1-a2bf-b03c6f440d49", ModuleType.Recording, 1)]
    public partial class Buchungsliste : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::L_LGBUCH_001.L_LGBUCH_001Repository repository.
        /// </summary>
        public static global::L_LGBUCH_001.L_LGBUCH_001Repository repo = global::L_LGBUCH_001.L_LGBUCH_001Repository.Instance;

        static Buchungsliste instance = new Buchungsliste();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Buchungsliste()
        {
            Artikel2 = "100037";
            Abgang = "A";
            Lager2 = "200";
            Charge_Nr = "E";
            Zugang = "Z";
            Lager1 = "100";
            Artikel1 = "100032";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Buchungsliste Instance
        {
            get { return instance; }
        }

#region Variables

        string _Artikel2;

        /// <summary>
        /// Gets or sets the value of variable Artikel2.
        /// </summary>
        [TestVariable("b63bdd32-147c-408e-8c09-b13d3354fabb")]
        public string Artikel2
        {
            get { return _Artikel2; }
            set { _Artikel2 = value; }
        }

        string _Abgang;

        /// <summary>
        /// Gets or sets the value of variable Abgang.
        /// </summary>
        [TestVariable("93fa5d70-8af2-4e34-ac67-404cd7cca8f7")]
        public string Abgang
        {
            get { return _Abgang; }
            set { _Abgang = value; }
        }

        string _Lager2;

        /// <summary>
        /// Gets or sets the value of variable Lager2.
        /// </summary>
        [TestVariable("862a8d60-d28c-4797-a996-1c8cee6a355f")]
        public string Lager2
        {
            get { return _Lager2; }
            set { _Lager2 = value; }
        }

        string _Charge_Nr;

        /// <summary>
        /// Gets or sets the value of variable Charge_Nr.
        /// </summary>
        [TestVariable("9b54cd85-b365-4605-bd15-f2830b369be9")]
        public string Charge_Nr
        {
            get { return _Charge_Nr; }
            set { _Charge_Nr = value; }
        }

        string _Zugang;

        /// <summary>
        /// Gets or sets the value of variable Zugang.
        /// </summary>
        [TestVariable("d1160345-30b9-42e0-b131-e346c1aa35bb")]
        public string Zugang
        {
            get { return _Zugang; }
            set { _Zugang = value; }
        }

        string _Lager1;

        /// <summary>
        /// Gets or sets the value of variable Lager1.
        /// </summary>
        [TestVariable("52a10afa-dcbd-4e2f-b04e-791d3aeecab8")]
        public string Lager1
        {
            get { return _Lager1; }
            set { _Lager1 = value; }
        }

        string _Artikel1;

        /// <summary>
        /// Gets or sets the value of variable Artikel1.
        /// </summary>
        [TestVariable("1fd2ed86-e265-4479-a2a6-21abc45d1408")]
        public string Artikel1
        {
            get { return _Artikel1; }
            set { _Artikel1 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmLagerbuch.PbExtrasBuchungsliste' at Center.", repo.FrmLagerbuch.PbExtrasBuchungslisteInfo, new RecordItemIndex(0));
            repo.FrmLagerbuch.PbExtrasBuchungsliste.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Auswahlliste Lagerbewegung') on item 'DlgListBox.TitleBar100AuswahllisteLagerbewegun'.", repo.DlgListBox.TitleBar100AuswahllisteLagerbewegunInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.DlgListBox.TitleBar100AuswahllisteLagerbewegunInfo, "Text", "Auswahlliste Lagerbewegung");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel2) on item 'DlgListBox.FlexGrid.CellTmpColS3Row1'.", repo.DlgListBox.FlexGrid.CellTmpColS3Row1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.DlgListBox.FlexGrid.CellTmpColS3Row1Info, "Text", Artikel2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Abgang) on item 'DlgListBox.FlexGrid.CellTmpColS4Row1'.", repo.DlgListBox.FlexGrid.CellTmpColS4Row1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgListBox.FlexGrid.CellTmpColS4Row1Info, "Text", Abgang);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lager2) on item 'DlgListBox.FlexGrid.CellTmpColS5Row1'.", repo.DlgListBox.FlexGrid.CellTmpColS5Row1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgListBox.FlexGrid.CellTmpColS5Row1Info, "Text", Lager2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Charge_Nr) on item 'DlgListBox.FlexGrid.CellTmpColS8Row1'.", repo.DlgListBox.FlexGrid.CellTmpColS8Row1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgListBox.FlexGrid.CellTmpColS8Row1Info, "Text", Charge_Nr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Zugang) on item 'DlgListBox.FlexGrid.CellTmpColS4Row2'.", repo.DlgListBox.FlexGrid.CellTmpColS4Row2Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.DlgListBox.FlexGrid.CellTmpColS4Row2Info, "Text", Zugang);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lager1) on item 'DlgListBox.FlexGrid.CellTmpColS5Row2'.", repo.DlgListBox.FlexGrid.CellTmpColS5Row2Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgListBox.FlexGrid.CellTmpColS5Row2Info, "Text", Lager1);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgListBox.CellTmpColS12Row1' at Center.", repo.DlgListBox.CellTmpColS12Row1Info, new RecordItemIndex(8));
            repo.DlgListBox.CellTmpColS12Row1.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgListBox.CellTmpColS12Row1' at Center.", repo.DlgListBox.CellTmpColS12Row1Info, new RecordItemIndex(9));
            repo.DlgListBox.CellTmpColS12Row1.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'DlgListBox.CellTmpColS12Row1'.", repo.DlgListBox.CellTmpColS12Row1Info, new RecordItemIndex(10));
            repo.DlgListBox.CellTmpColS12Row1.EnsureVisible();
            Keyboard.Press("{Delete}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}{NumPad0}{NumPad0}{NumPad0}{NumPad3}' with focus on 'DlgListBox.CellTmpColS3Row1'.", repo.DlgListBox.CellTmpColS3Row1Info, new RecordItemIndex(11));
            repo.DlgListBox.CellTmpColS3Row1.PressKeys("{NumPad1}{NumPad0}{NumPad0}{NumPad0}{NumPad3}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'DlgListBox.CellTmpColS3Row1'.", repo.DlgListBox.CellTmpColS3Row1Info, new RecordItemIndex(12));
            repo.DlgListBox.CellTmpColS3Row1.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel1) on item 'DlgListBox.FlexGrid.CellTmpColS3Row1'.", repo.DlgListBox.FlexGrid.CellTmpColS3Row1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.DlgListBox.FlexGrid.CellTmpColS3Row1Info, "Text", Artikel1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Zugang) on item 'DlgListBox.FlexGrid.CellTmpColS4Row1'.", repo.DlgListBox.FlexGrid.CellTmpColS4Row1Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.DlgListBox.FlexGrid.CellTmpColS4Row1Info, "Text", Zugang);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Abgang) on item 'DlgListBox.FlexGrid.CellTmpColS4Row2'.", repo.DlgListBox.FlexGrid.CellTmpColS4Row2Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.DlgListBox.FlexGrid.CellTmpColS4Row2Info, "Text", Abgang);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgListBox.Schliessen' at Center.", repo.DlgListBox.SchliessenInfo, new RecordItemIndex(16));
            repo.DlgListBox.Schliessen.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
