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

namespace B_EXOPV_005.Recordings_B_BUAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The B_BUAB_Tagesdatum_Tagesdatum2_valdieren_Usercode recording.
    /// </summary>
    [TestModule("40ed5814-055e-49a5-b1f0-a469f65a9182", ModuleType.Recording, 1)]
    public partial class B_BUAB_Tagesdatum_Tagesdatum2_valdieren_Usercode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_005.B_EXOPV_005Repository repository.
        /// </summary>
        public static global::B_EXOPV_005.B_EXOPV_005Repository repo = global::B_EXOPV_005.B_EXOPV_005Repository.Instance;

        static B_BUAB_Tagesdatum_Tagesdatum2_valdieren_Usercode instance = new B_BUAB_Tagesdatum_Tagesdatum2_valdieren_Usercode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_BUAB_Tagesdatum_Tagesdatum2_valdieren_Usercode()
        {
            Tagesdatum2 = "";
            Inhalt_Buchungsdatum_Zeile9 = "";
            Tagesdatum = "";
            Inhalt_Buchungsdatum_Zeile11 = "";
            Inhalt_Buchungsdatum_Zeile13 = "";
            Inhalt_Buchungsdatum_Zeile15 = "";
            Inhalt_Buchungsdatum_Zeile17 = "";
            Inhalt_Buchungsdatum_Zeile19 = "";
            Inhalt_Buchungsdatum_Zeile21 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_BUAB_Tagesdatum_Tagesdatum2_valdieren_Usercode Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum2;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum2.
        /// </summary>
        [TestVariable("f62bff77-db1e-420f-a9cb-a8c1b3284546")]
        public string Tagesdatum2
        {
            get { return _Tagesdatum2; }
            set { _Tagesdatum2 = value; }
        }

        string _Inhalt_Buchungsdatum_Zeile9;

        /// <summary>
        /// Gets or sets the value of variable Inhalt_Buchungsdatum_Zeile9.
        /// </summary>
        [TestVariable("95028247-f9c9-45b0-84d2-c448c74424c3")]
        public string Inhalt_Buchungsdatum_Zeile9
        {
            get { return _Inhalt_Buchungsdatum_Zeile9; }
            set { _Inhalt_Buchungsdatum_Zeile9 = value; }
        }

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("2c276c4f-5f21-4faa-a47c-a1fc7479c62a")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        string _Inhalt_Buchungsdatum_Zeile11;

        /// <summary>
        /// Gets or sets the value of variable Inhalt_Buchungsdatum_Zeile11.
        /// </summary>
        [TestVariable("ff209639-976d-4d7f-8661-45f52db6170f")]
        public string Inhalt_Buchungsdatum_Zeile11
        {
            get { return _Inhalt_Buchungsdatum_Zeile11; }
            set { _Inhalt_Buchungsdatum_Zeile11 = value; }
        }

        string _Inhalt_Buchungsdatum_Zeile13;

        /// <summary>
        /// Gets or sets the value of variable Inhalt_Buchungsdatum_Zeile13.
        /// </summary>
        [TestVariable("ec0d4b66-eae6-409a-995c-a4091f5248fa")]
        public string Inhalt_Buchungsdatum_Zeile13
        {
            get { return _Inhalt_Buchungsdatum_Zeile13; }
            set { _Inhalt_Buchungsdatum_Zeile13 = value; }
        }

        string _Inhalt_Buchungsdatum_Zeile15;

        /// <summary>
        /// Gets or sets the value of variable Inhalt_Buchungsdatum_Zeile15.
        /// </summary>
        [TestVariable("5f54cf7e-2e19-4c58-930f-e1abb3db49c6")]
        public string Inhalt_Buchungsdatum_Zeile15
        {
            get { return _Inhalt_Buchungsdatum_Zeile15; }
            set { _Inhalt_Buchungsdatum_Zeile15 = value; }
        }

        string _Inhalt_Buchungsdatum_Zeile17;

        /// <summary>
        /// Gets or sets the value of variable Inhalt_Buchungsdatum_Zeile17.
        /// </summary>
        [TestVariable("dd210403-3dc3-4358-b7d7-b9e985ed34cd")]
        public string Inhalt_Buchungsdatum_Zeile17
        {
            get { return _Inhalt_Buchungsdatum_Zeile17; }
            set { _Inhalt_Buchungsdatum_Zeile17 = value; }
        }

        string _Inhalt_Buchungsdatum_Zeile19;

        /// <summary>
        /// Gets or sets the value of variable Inhalt_Buchungsdatum_Zeile19.
        /// </summary>
        [TestVariable("51a91dc0-0c14-4843-9d83-cd48a85b75ea")]
        public string Inhalt_Buchungsdatum_Zeile19
        {
            get { return _Inhalt_Buchungsdatum_Zeile19; }
            set { _Inhalt_Buchungsdatum_Zeile19 = value; }
        }

        string _Inhalt_Buchungsdatum_Zeile21;

        /// <summary>
        /// Gets or sets the value of variable Inhalt_Buchungsdatum_Zeile21.
        /// </summary>
        [TestVariable("d844cc32-494a-4707-8337-ef0598adc52d")]
        public string Inhalt_Buchungsdatum_Zeile21
        {
            get { return _Inhalt_Buchungsdatum_Zeile21; }
            set { _Inhalt_Buchungsdatum_Zeile21 = value; }
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

            Tagesdatum2 = Ranorex.AutomationHelpers.UserCodeCollections.Aptean.GetDateAsString("dd.MM.yyyy", "");
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'TblB.Buchungszeilen_Tabelle.Zeile9.ColDtAendgRow9' and assigning its value to variable 'Inhalt_Buchungsdatum_Zeile9'.", repo.TblB.Buchungszeilen_Tabelle.Zeile9.ColDtAendgRow9Info, new RecordItemIndex(1));
            Inhalt_Buchungsdatum_Zeile9 = repo.TblB.Buchungszeilen_Tabelle.Zeile9.ColDtAendgRow9.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateContainsVar1Var2(Inhalt_Buchungsdatum_Zeile9, Tagesdatum, Tagesdatum2);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'TblB.Buchungszeilen_Tabelle.Zeile11.ColDtAendgRow11' and assigning its value to variable 'Inhalt_Buchungsdatum_Zeile11'.", repo.TblB.Buchungszeilen_Tabelle.Zeile11.ColDtAendgRow11Info, new RecordItemIndex(3));
            Inhalt_Buchungsdatum_Zeile11 = repo.TblB.Buchungszeilen_Tabelle.Zeile11.ColDtAendgRow11.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateContainsVar1Var2(Inhalt_Buchungsdatum_Zeile11, Tagesdatum, Tagesdatum2);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'TblB.Buchungszeilen_Tabelle.Zeile13.ColDtAendgRow13' and assigning its value to variable 'Inhalt_Buchungsdatum_Zeile13'.", repo.TblB.Buchungszeilen_Tabelle.Zeile13.ColDtAendgRow13Info, new RecordItemIndex(5));
            Inhalt_Buchungsdatum_Zeile13 = repo.TblB.Buchungszeilen_Tabelle.Zeile13.ColDtAendgRow13.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateContainsVar1Var2(Inhalt_Buchungsdatum_Zeile13, Tagesdatum, Tagesdatum2);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'TblB.Buchungszeilen_Tabelle.Zeile15.ColDtAendgRow15' and assigning its value to variable 'Inhalt_Buchungsdatum_Zeile15'.", repo.TblB.Buchungszeilen_Tabelle.Zeile15.ColDtAendgRow15Info, new RecordItemIndex(7));
            Inhalt_Buchungsdatum_Zeile15 = repo.TblB.Buchungszeilen_Tabelle.Zeile15.ColDtAendgRow15.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateContainsVar1Var2(Inhalt_Buchungsdatum_Zeile15, Tagesdatum, Tagesdatum2);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'TblB.Buchungszeilen_Tabelle.Zeile17.ColDtAendgRow17' and assigning its value to variable 'Inhalt_Buchungsdatum_Zeile17'.", repo.TblB.Buchungszeilen_Tabelle.Zeile17.ColDtAendgRow17Info, new RecordItemIndex(9));
            Inhalt_Buchungsdatum_Zeile17 = repo.TblB.Buchungszeilen_Tabelle.Zeile17.ColDtAendgRow17.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateContainsVar1Var2(Inhalt_Buchungsdatum_Zeile17, Tagesdatum, Tagesdatum2);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'TblB.Buchungszeilen_Tabelle.Zeile19.ColDtAendgRow19' and assigning its value to variable 'Inhalt_Buchungsdatum_Zeile19'.", repo.TblB.Buchungszeilen_Tabelle.Zeile19.ColDtAendgRow19Info, new RecordItemIndex(11));
            Inhalt_Buchungsdatum_Zeile19 = repo.TblB.Buchungszeilen_Tabelle.Zeile19.ColDtAendgRow19.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateContainsVar1Var2(Inhalt_Buchungsdatum_Zeile19, Tagesdatum, Tagesdatum2);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'TblB.Buchungszeilen_Tabelle.Zeile21.ColDtAendgRow21' and assigning its value to variable 'Inhalt_Buchungsdatum_Zeile21'.", repo.TblB.Buchungszeilen_Tabelle.Zeile21.ColDtAendgRow21Info, new RecordItemIndex(13));
            Inhalt_Buchungsdatum_Zeile21 = repo.TblB.Buchungszeilen_Tabelle.Zeile21.ColDtAendgRow21.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateContainsVar1Var2(Inhalt_Buchungsdatum_Zeile21, Tagesdatum, Tagesdatum2);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}