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

namespace B_ELSTER_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Formularzuordnungen_kopieren_D20_D23 recording.
    /// </summary>
    [TestModule("0581483c-2795-499b-b0bd-6a588d610539", ModuleType.Recording, 1)]
    public partial class Formularzuordnungen_kopieren_D20_D23 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_004.B_ELSTER_004Repository repository.
        /// </summary>
        public static global::B_ELSTER_004.B_ELSTER_004Repository repo = global::B_ELSTER_004.B_ELSTER_004Repository.Instance;

        static Formularzuordnungen_kopieren_D20_D23 instance = new Formularzuordnungen_kopieren_D20_D23();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Formularzuordnungen_kopieren_D20_D23()
        {
            Firma = "300";
            UVA_D20_Form_Name = "UVA-Deutschland 2020 Elster";
            UVA_D23_Form_Name = "UVA-Deutschland 2023 Elster";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Formularzuordnungen_kopieren_D20_D23 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Firma;

        /// <summary>
        /// Gets or sets the value of variable Firma.
        /// </summary>
        [TestVariable("d916958f-f403-4525-867e-bb5f9ccbc453")]
        public string Firma
        {
            get { return _Firma; }
            set { _Firma = value; }
        }

        string _UVA_D20_Form_Name;

        /// <summary>
        /// Gets or sets the value of variable UVA_D20_Form_Name.
        /// </summary>
        [TestVariable("d84c4021-3d2c-44d8-aa14-68cad667167e")]
        public string UVA_D20_Form_Name
        {
            get { return _UVA_D20_Form_Name; }
            set { _UVA_D20_Form_Name = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable UVA_D23_Form_Name.
        /// </summary>
        [TestVariable("e522c944-cb8b-48a6-b505-4b2c22165086")]
        public string UVA_D23_Form_Name
        {
            get { return repo.UVA_D23_Form_Name; }
            set { repo.UVA_D23_Form_Name = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblUVAF.PbCommonKopieren' at Center.", repo.TblUVAF.PbCommonKopierenInfo, new RecordItemIndex(0));
            repo.TblUVAF.PbCommonKopieren.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'FrmUVAK.FormularKopieren'", repo.FrmUVAK.FormularKopierenInfo, new ActionTimeout(180000), new RecordItemIndex(1));
            repo.FrmUVAK.FormularKopierenInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmUVAK.ClientArea1.CmbUvak1' at Center.", repo.FrmUVAK.ClientArea1.CmbUvak1Info, new RecordItemIndex(2));
            repo.FrmUVAK.ClientArea1.CmbUvak1.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.UVADeutschland2020Elster' at Center.", repo.List1000.UVADeutschland2020ElsterInfo, new RecordItemIndex(3));
            repo.List1000.UVADeutschland2020Elster.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmUVAK.ClientArea1.CmbUvak2' at Center.", repo.FrmUVAK.ClientArea1.CmbUvak2Info, new RecordItemIndex(4));
            repo.FrmUVAK.ClientArea1.CmbUvak2.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'List1000.UVADeutschland2023Elster'.", repo.List1000.UVADeutschland2023ElsterInfo, new RecordItemIndex(5));
            Validate.Exists(repo.List1000.UVADeutschland2023ElsterInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.UVADeutschland2023Elster' at Center.", repo.List1000.UVADeutschland2023ElsterInfo, new RecordItemIndex(6));
            repo.List1000.UVADeutschland2023Elster.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_D20_Form_Name) on item 'FrmUVAK.ClientArea1.CmbUvak1'.", repo.FrmUVAK.ClientArea1.CmbUvak1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmUVAK.ClientArea1.CmbUvak1Info, "Text", UVA_D20_Form_Name);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_D23_Form_Name) on item 'FrmUVAK.ClientArea1.CmbUvak2'.", repo.FrmUVAK.ClientArea1.CmbUvak2Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmUVAK.ClientArea1.CmbUvak2Info, "Text", UVA_D23_Form_Name);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmUVAK.ClientArea1.CbNurZuordnung'.", repo.FrmUVAK.ClientArea1.CbNurZuordnungInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmUVAK.ClientArea1.CbNurZuordnungInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Firma) on item 'FrmUVAK.ClientArea1.DfZuordnungZielfirma'.", repo.FrmUVAK.ClientArea1.DfZuordnungZielfirmaInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmUVAK.ClientArea1.DfZuordnungZielfirmaInfo, "Text", Firma);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmUVAK.ClientArea1.PbUVAKKopieren' at Center.", repo.FrmUVAK.ClientArea1.PbUVAKKopierenInfo, new RecordItemIndex(11));
            repo.FrmUVAK.ClientArea1.PbUVAKKopieren.Click();
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'Hinweis.LabelMeldungstext'", repo.Hinweis.LabelMeldungstextInfo, new ActionTimeout(60000), new RecordItemIndex(12));
            //repo.Hinweis.LabelMeldungstextInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'J'.", new RecordItemIndex(13));
            Keyboard.Press("J");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Kopiervorgang beendet') on item 'Hinweis.LabelMeldungstext'.", repo.Hinweis.LabelMeldungstextInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.Hinweis.LabelMeldungstextInfo, "Text", "Kopiervorgang beendet");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hinweis.Button' at Center.", repo.Hinweis.ButtonInfo, new RecordItemIndex(15));
            repo.Hinweis.Button.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'FrmUVAK.FormularKopieren'.", repo.FrmUVAK.FormularKopierenInfo, new RecordItemIndex(16));
            Keyboard.PrepareFocus(repo.FrmUVAK.FormularKopieren);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
