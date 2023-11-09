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

namespace E_BSST_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Bestellungen_laden recording.
    /// </summary>
    [TestModule("4c902efc-2b24-4fa0-86d9-cbc304cc15ac", ModuleType.Recording, 1)]
    public partial class Bestellungen_laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_BSST_001.E_BSST_001Repository repository.
        /// </summary>
        public static global::E_BSST_001.E_BSST_001Repository repo = global::E_BSST_001.E_BSST_001Repository.Instance;

        static Bestellungen_laden instance = new Bestellungen_laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Bestellungen_laden()
        {
            Lieferant1 = "300024";
            Bestellung_E = "BS21/00001";
            Bestellung_B = "BS21/00007";
            Bestellung_L = "BS21/00008";
            Bestellung_2 = "301900006";
            Lieferant2 = "300022";
            Status_L = "L";
            Status_E = "E";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Bestellungen_laden Instance
        {
            get { return instance; }
        }

#region Variables

        string _Lieferant1;

        /// <summary>
        /// Gets or sets the value of variable Lieferant1.
        /// </summary>
        [TestVariable("69ca30fd-7c10-4251-a63b-10593d2b4a93")]
        public string Lieferant1
        {
            get { return _Lieferant1; }
            set { _Lieferant1 = value; }
        }

        string _Bestellung_B;

        /// <summary>
        /// Gets or sets the value of variable Bestellung_B.
        /// </summary>
        [TestVariable("1ffc0b94-4419-424e-bfb3-e783178ae559")]
        public string Bestellung_B
        {
            get { return _Bestellung_B; }
            set { _Bestellung_B = value; }
        }

        string _Bestellung_L;

        /// <summary>
        /// Gets or sets the value of variable Bestellung_L.
        /// </summary>
        [TestVariable("86dae974-be8a-49d5-879d-88c3bc0bb9d8")]
        public string Bestellung_L
        {
            get { return _Bestellung_L; }
            set { _Bestellung_L = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Bestellung_2.
        /// </summary>
        [TestVariable("c4a18d15-4c87-4793-aead-1e86c6bac20b")]
        public string Bestellung_2
        {
            get { return repo.Bestellung_2; }
            set { repo.Bestellung_2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Bestellung_E.
        /// </summary>
        [TestVariable("ab092543-ec58-4c90-b33e-a82c0ce093fb")]
        public string Bestellung_E
        {
            get { return repo.Bestellung_E; }
            set { repo.Bestellung_E = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Lieferant2.
        /// </summary>
        [TestVariable("565d53aa-9b70-4f9b-b0fb-a10a25e5abdc")]
        public string Lieferant2
        {
            get { return repo.Lieferant2; }
            set { repo.Lieferant2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Status_L.
        /// </summary>
        [TestVariable("8452e8a2-0a6c-4965-b70e-55eeb18171db")]
        public string Status_L
        {
            get { return repo.Status_L; }
            set { repo.Status_L = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Status_E.
        /// </summary>
        [TestVariable("77b94ed2-143f-494f-b8ee-c9f01292d1c8")]
        public string Status_E
        {
            get { return repo.Status_E; }
            set { repo.Status_E = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBsst.Text1' at Center.", repo.TblBsst.Text1Info, new RecordItemIndex(0));
            repo.TblBsst.Text1.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'BS21%' with focus on 'TblBsst.Text1'.", repo.TblBsst.Text1Info, new RecordItemIndex(1));
            repo.TblBsst.Text1.PressKeys("BS21%");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'TblBsst.Text1'.", repo.TblBsst.Text1Info, new RecordItemIndex(2));
            repo.TblBsst.Text1.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBsst.RbOffen' at Center.", repo.TblBsst.RbOffenInfo, new RecordItemIndex(3));
            repo.TblBsst.RbOffen.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBsst.PbDataAccessLoad' at Center.", repo.TblBsst.PbDataAccessLoadInfo, new RecordItemIndex(4));
            repo.TblBsst.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bestellung_E) on item 'TblBsst.FlexGrid.ColBskNrRow11'.", repo.TblBsst.FlexGrid.ColBskNrRow11Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblBsst.FlexGrid.ColBskNrRow11Info, "Text", Bestellung_E);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Status_E) on item 'TblBsst.FlexGrid.ColBspStatusRow11'.", repo.TblBsst.FlexGrid.ColBspStatusRow11Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblBsst.FlexGrid.ColBspStatusRow11Info, "Text", Status_E);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'TblBsst.FlexGrid.ColBspGeliefertRow11'.", repo.TblBsst.FlexGrid.ColBspGeliefertRow11Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblBsst.FlexGrid.ColBspGeliefertRow11Info, "Text", "0,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bestellung_B) on item 'TblBsst.FlexGrid.ColBskNrRow4'.", repo.TblBsst.FlexGrid.ColBskNrRow4Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblBsst.FlexGrid.ColBskNrRow4Info, "Text", Bestellung_B);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferant1) on item 'TblBsst.FlexGrid.ColAdrNrRow4'.", repo.TblBsst.FlexGrid.ColAdrNrRow4Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblBsst.FlexGrid.ColAdrNrRow4Info, "Text", Lieferant1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='B') on item 'TblBsst.FlexGrid.ColBspStatusRow4'.", repo.TblBsst.FlexGrid.ColBspStatusRow4Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblBsst.FlexGrid.ColBspStatusRow4Info, "Text", "B");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='6,00') on item 'TblBsst.FlexGrid.ColBspBestaetigtRow4'.", repo.TblBsst.FlexGrid.ColBspBestaetigtRow4Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblBsst.FlexGrid.ColBspBestaetigtRow4Info, "Text", "6,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0,00') on item 'TblBsst.FlexGrid.ColBspGeliefertRow4'.", repo.TblBsst.FlexGrid.ColBspGeliefertRow4Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblBsst.FlexGrid.ColBspGeliefertRow4Info, "Text", "0,00");
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBsst.Text' at Center.", repo.TblBsst.TextInfo, new RecordItemIndex(13));
            //repo.TblBsst.Text.Click();
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblBsst.Text' at Center.", repo.TblBsst.TextInfo, new RecordItemIndex(14));
            //repo.TblBsst.Text.DoubleClick();
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'TblBsst.Text'.", repo.TblBsst.TextInfo, new RecordItemIndex(15));
            //repo.TblBsst.Text.EnsureVisible();
            //Keyboard.Press("{Delete}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBsst.RbTeilLief' at Center.", repo.TblBsst.RbTeilLiefInfo, new RecordItemIndex(16));
            repo.TblBsst.RbTeilLief.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBsst.PbDataAccessLoad' at Center.", repo.TblBsst.PbDataAccessLoadInfo, new RecordItemIndex(17));
            repo.TblBsst.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bestellung_L) on item 'TblBsst.FlexGrid.ColBskNrRow11'.", repo.TblBsst.FlexGrid.ColBskNrRow11Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.TblBsst.FlexGrid.ColBskNrRow11Info, "Text", Bestellung_L);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Status_L) on item 'TblBsst.FlexGrid.ColBspStatusRow1'.", repo.TblBsst.FlexGrid.ColBspStatusRow1Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.TblBsst.FlexGrid.ColBspStatusRow1Info, "Text", Status_L);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10,00') on item 'TblBsst.FlexGrid.ColBspMengeRow1'.", repo.TblBsst.FlexGrid.ColBspMengeRow1Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.TblBsst.FlexGrid.ColBspMengeRow1Info, "Text", "10,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='8,00') on item 'TblBsst.FlexGrid.ColBspGeliefertRow11'.", repo.TblBsst.FlexGrid.ColBspGeliefertRow11Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.TblBsst.FlexGrid.ColBspGeliefertRow11Info, "Text", "8,00");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBsst.Text1' at Center.", repo.TblBsst.Text1Info, new RecordItemIndex(22));
            repo.TblBsst.Text1.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblBsst.Text1' at Center.", repo.TblBsst.Text1Info, new RecordItemIndex(23));
            repo.TblBsst.Text1.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'TblBsst.Text1'.", repo.TblBsst.Text1Info, new RecordItemIndex(24));
            repo.TblBsst.Text1.PressKeys("{Delete}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBsst.RbAlle' at Center.", repo.TblBsst.RbAlleInfo, new RecordItemIndex(25));
            repo.TblBsst.RbAlle.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBsst.PbDataAccessLoad' at Center.", repo.TblBsst.PbDataAccessLoadInfo, new RecordItemIndex(26));
            repo.TblBsst.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Wollen Sie wirklich ALLE offenen Bestellungen anzeigen?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(27));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Wollen Sie wirklich ALLE offenen Bestellungen anzeigen?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(28));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bestellung_2) on item 'TblBsst.FlexGrid.ColBskNrRow1'.", repo.TblBsst.FlexGrid.ColBskNrRow1Info, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.TblBsst.FlexGrid.ColBskNrRow1Info, "Text", Bestellung_2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~$Status_L) on item 'TblBsst.FlexGrid.ColBspStatusRow1'.", repo.TblBsst.FlexGrid.ColBspStatusRow1Info, new RecordItemIndex(30));
            Validate.AttributeRegex(repo.TblBsst.FlexGrid.ColBspStatusRow1Info, "Text", new Regex(Status_L));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'20,00') on item 'TblBsst.FlexGrid.ColBspMengeRow'.", repo.TblBsst.FlexGrid.ColBspMengeRowInfo, new RecordItemIndex(31));
            Validate.AttributeRegex(repo.TblBsst.FlexGrid.ColBspMengeRowInfo, "Text", new Regex("20,00"));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'5,00') on item 'TblBsst.FlexGrid.ColBspGeliefertRow'.", repo.TblBsst.FlexGrid.ColBspGeliefertRowInfo, new RecordItemIndex(32));
            Validate.AttributeRegex(repo.TblBsst.FlexGrid.ColBspGeliefertRowInfo, "Text", new Regex("5,00"));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~$Bestellung_E) on item 'TblBsst.FlexGrid.ColBskNrRow7'.", repo.TblBsst.FlexGrid.ColBskNrRow7Info, new RecordItemIndex(33));
            Validate.AttributeRegex(repo.TblBsst.FlexGrid.ColBskNrRow7Info, "Text", new Regex(Bestellung_E));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~$Lieferant2) on item 'TblBsst.FlexGrid.ColAdrNrRow7'.", repo.TblBsst.FlexGrid.ColAdrNrRow7Info, new RecordItemIndex(34));
            Validate.AttributeRegex(repo.TblBsst.FlexGrid.ColAdrNrRow7Info, "Text", new Regex(Lieferant2));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~$Status_E) on item 'TblBsst.FlexGrid.ColBspStatusRow7'.", repo.TblBsst.FlexGrid.ColBspStatusRow7Info, new RecordItemIndex(35));
            Validate.AttributeRegex(repo.TblBsst.FlexGrid.ColBspStatusRow7Info, "Text", new Regex(Status_E));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
