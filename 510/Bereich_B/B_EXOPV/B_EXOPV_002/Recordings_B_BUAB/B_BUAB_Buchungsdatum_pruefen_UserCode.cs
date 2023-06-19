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

namespace B_EXOPV_002.Recordings_B_BUAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The B_BUAB_Buchungsdatum_pruefen_UserCode recording.
    /// </summary>
    [TestModule("e42731e2-4e12-469c-a740-e397ca8ae66a", ModuleType.Recording, 1)]
    public partial class B_BUAB_Buchungsdatum_pruefen_UserCode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_002.B_EXOPV_002Repository repository.
        /// </summary>
        public static global::B_EXOPV_002.B_EXOPV_002Repository repo = global::B_EXOPV_002.B_EXOPV_002Repository.Instance;

        static B_BUAB_Buchungsdatum_pruefen_UserCode instance = new B_BUAB_Buchungsdatum_pruefen_UserCode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_BUAB_Buchungsdatum_pruefen_UserCode()
        {
            Tagesdatum2 = "";
            Feldinhalt_Buchungsdatum = "";
            Tagesdatum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_BUAB_Buchungsdatum_pruefen_UserCode Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum2;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum2.
        /// </summary>
        [TestVariable("bf5c8962-eacd-4fb4-bb08-ae2eaa579a2f")]
        public string Tagesdatum2
        {
            get { return _Tagesdatum2; }
            set { _Tagesdatum2 = value; }
        }

        string _Feldinhalt_Buchungsdatum;

        /// <summary>
        /// Gets or sets the value of variable Feldinhalt_Buchungsdatum.
        /// </summary>
        [TestVariable("49399c05-32aa-433a-8184-9f186f8c04d5")]
        public string Feldinhalt_Buchungsdatum
        {
            get { return _Feldinhalt_Buchungsdatum; }
            set { _Feldinhalt_Buchungsdatum = value; }
        }

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("3fef9a41-f6a6-420f-b776-102d24af1241")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
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

            Tagesdatum2 = Ranorex.AutomationHelpers.UserCodeCollections.SystemLibrary.GetDateTimeAsString("dd.MM.yyyy");
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'TblB.Buchungszeilen_Tabelle.Zeile1.ColDtAendgRow1' and assigning its value to variable 'Feldinhalt_Buchungsdatum'.", repo.TblB.Buchungszeilen_Tabelle.Zeile1.ColDtAendgRow1Info, new RecordItemIndex(1));
            Feldinhalt_Buchungsdatum = repo.TblB.Buchungszeilen_Tabelle.Zeile1.ColDtAendgRow1.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateContainsVar1Var2(Feldinhalt_Buchungsdatum, Tagesdatum, Tagesdatum2);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
