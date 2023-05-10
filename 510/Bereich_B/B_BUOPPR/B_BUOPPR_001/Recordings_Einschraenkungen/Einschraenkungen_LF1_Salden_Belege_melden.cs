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

namespace B_BUOPPR_001.Recordings_Einschraenkungen
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Einschraenkungen_LF1_Salden_Belege_melden recording.
    /// </summary>
    [TestModule("a7c4d058-890c-4474-a01f-dc1b0be978c3", ModuleType.Recording, 1)]
    public partial class Einschraenkungen_LF1_Salden_Belege_melden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUOPPR_001.B_BUOPPR_001Repository repository.
        /// </summary>
        public static global::B_BUOPPR_001.B_BUOPPR_001Repository repo = global::B_BUOPPR_001.B_BUOPPR_001Repository.Instance;

        static Einschraenkungen_LF1_Salden_Belege_melden instance = new Einschraenkungen_LF1_Salden_Belege_melden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Einschraenkungen_LF1_Salden_Belege_melden()
        {
            LF_1 = "303006";
            KL = "L";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Einschraenkungen_LF1_Salden_Belege_melden Instance
        {
            get { return instance; }
        }

#region Variables

        string _LF_1;

        /// <summary>
        /// Gets or sets the value of variable LF_1.
        /// </summary>
        [TestVariable("99f66fc6-3ad9-4f40-9692-1245bb90c35e")]
        public string LF_1
        {
            get { return _LF_1; }
            set { _LF_1 = value; }
        }

        string _KL;

        /// <summary>
        /// Gets or sets the value of variable KL.
        /// </summary>
        [TestVariable("394af966-bcba-43ce-b45e-7c2e97b01600")]
        public string KL
        {
            get { return _KL; }
            set { _KL = value; }
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute text to '$KL' on item 'FrmMain.KundenLieferantenKL'.", repo.FrmMain.KundenLieferantenKLInfo, new RecordItemIndex(0));
            repo.FrmMain.KundenLieferantenKL.Element.SetAttributeValue("text", KL);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute text to '' on item 'FrmMain.Text_Adr_von_'.", repo.FrmMain.Text_Adr_von_Info, new RecordItemIndex(1));
            repo.FrmMain.Text_Adr_von_.Element.SetAttributeValue("text", "");
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute text to '' on item 'FrmMain.Text1_Adr_bis'.", repo.FrmMain.Text1_Adr_bisInfo, new RecordItemIndex(2));
            repo.FrmMain.Text1_Adr_bis.Element.SetAttributeValue("text", "");
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'True' on item 'FrmMain.CbDetailCheck'.", repo.FrmMain.CbDetailCheckInfo, new RecordItemIndex(3));
            repo.FrmMain.CbDetailCheck.Element.SetAttributeValue("Checked", "True");
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'True' on item 'FrmMain.CbAnzeigen'.", repo.FrmMain.CbAnzeigenInfo, new RecordItemIndex(4));
            repo.FrmMain.CbAnzeigen.Element.SetAttributeValue("Checked", "True");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LF_1' with focus on 'FrmMain.Text_Adr_von_'.", repo.FrmMain.Text_Adr_von_Info, new RecordItemIndex(5));
            repo.FrmMain.Text_Adr_von_.PressKeys(LF_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KL) on item 'FrmMain.KundenLieferantenKL'.", repo.FrmMain.KundenLieferantenKLInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmMain.KundenLieferantenKLInfo, "Text", KL);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_1) on item 'FrmMain.Text_Adr_von_'.", repo.FrmMain.Text_Adr_von_Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmMain.Text_Adr_von_Info, "Text", LF_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'FrmMain.Text1_Adr_bis'.", repo.FrmMain.Text1_Adr_bisInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmMain.Text1_Adr_bisInfo, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmMain.CbSaldo'.", repo.FrmMain.CbSaldoInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmMain.CbSaldoInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmMain.CbDetailCheck'.", repo.FrmMain.CbDetailCheckInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmMain.CbDetailCheckInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmMain.CbAnzeigen'.", repo.FrmMain.CbAnzeigenInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmMain.CbAnzeigenInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.PbShareDrucken' at Center.", repo.FrmMain.PbShareDruckenInfo, new RecordItemIndex(12));
            repo.FrmMain.PbShareDrucken.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
