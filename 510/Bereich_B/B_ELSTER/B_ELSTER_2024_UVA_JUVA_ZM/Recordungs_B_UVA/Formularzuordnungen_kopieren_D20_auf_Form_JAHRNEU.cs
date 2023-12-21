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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordungs_B_UVA
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Formularzuordnungen_kopieren_D20_auf_Form_JAHRNEU recording.
    /// </summary>
    [TestModule("0b7e4a93-d4a3-4205-b523-9e30f48dd938", ModuleType.Recording, 1)]
    public partial class Formularzuordnungen_kopieren_D20_auf_Form_JAHRNEU : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static Formularzuordnungen_kopieren_D20_auf_Form_JAHRNEU instance = new Formularzuordnungen_kopieren_D20_auf_Form_JAHRNEU();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Formularzuordnungen_kopieren_D20_auf_Form_JAHRNEU()
        {
            Firma = "300";
            UVA_D20_Form_Name = "UVA-Deutschland 2020 Elster";
            UVA_JAHRNEU_Form_Name = "UVA-Deutschland 2023 Elster";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Formularzuordnungen_kopieren_D20_auf_Form_JAHRNEU Instance
        {
            get { return instance; }
        }

#region Variables

        string _Firma;

        /// <summary>
        /// Gets or sets the value of variable Firma.
        /// </summary>
        [TestVariable("3589704c-4c2f-41e1-9a22-5162988d5f9b")]
        public string Firma
        {
            get { return _Firma; }
            set { _Firma = value; }
        }

        string _UVA_D20_Form_Name;

        /// <summary>
        /// Gets or sets the value of variable UVA_D20_Form_Name.
        /// </summary>
        [TestVariable("b49e4c5a-6cd4-4d5c-b91e-b8cb62bb9cd5")]
        public string UVA_D20_Form_Name
        {
            get { return _UVA_D20_Form_Name; }
            set { _UVA_D20_Form_Name = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable UVA_JAHRNEU_Form_Name.
        /// </summary>
        [TestVariable("a7bfebff-b30b-4d6b-b9e3-f2010919b966")]
        public string UVA_JAHRNEU_Form_Name
        {
            get { return repo.UVA_JAHRNEU_Form_Name; }
            set { repo.UVA_JAHRNEU_Form_Name = value; }
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'List1000.Formular_Elster_JAHRNEU'.", repo.List1000.Formular_Elster_JAHRNEUInfo, new RecordItemIndex(5));
            Validate.Exists(repo.List1000.Formular_Elster_JAHRNEUInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.Formular_Elster_JAHRNEU' at Center.", repo.List1000.Formular_Elster_JAHRNEUInfo, new RecordItemIndex(6));
            repo.List1000.Formular_Elster_JAHRNEU.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_D20_Form_Name) on item 'FrmUVAK.ClientArea1.CmbUvak1'.", repo.FrmUVAK.ClientArea1.CmbUvak1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmUVAK.ClientArea1.CmbUvak1Info, "Text", UVA_D20_Form_Name);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_JAHRNEU_Form_Name) on item 'FrmUVAK.ClientArea1.CmbUvak2'.", repo.FrmUVAK.ClientArea1.CmbUvak2Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmUVAK.ClientArea1.CmbUvak2Info, "Text", UVA_JAHRNEU_Form_Name);
            
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
