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
    ///The B_BUAB_Beleg6_pruefen recording.
    /// </summary>
    [TestModule("f012145a-a630-4f97-918a-d9f56583b4f3", ModuleType.Recording, 1)]
    public partial class B_BUAB_Beleg6_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_002.B_EXOPV_002Repository repository.
        /// </summary>
        public static global::B_EXOPV_002.B_EXOPV_002Repository repo = global::B_EXOPV_002.B_EXOPV_002Repository.Instance;

        static B_BUAB_Beleg6_pruefen instance = new B_BUAB_Beleg6_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_BUAB_Beleg6_pruefen()
        {
            Beleg6 = "KLOPO__03";
            Beleg6_FB_NEU = "FB_B_EXOPV_002";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_BUAB_Beleg6_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Beleg6;

        /// <summary>
        /// Gets or sets the value of variable Beleg6.
        /// </summary>
        [TestVariable("f9ad4d15-2325-4fd8-9f5c-9c27dded422b")]
        public string Beleg6
        {
            get { return _Beleg6; }
            set { _Beleg6 = value; }
        }

        string _Beleg6_FB_NEU;

        /// <summary>
        /// Gets or sets the value of variable Beleg6_FB_NEU.
        /// </summary>
        [TestVariable("399736a2-ef84-46c1-bb71-c93c8874b012")]
        public string Beleg6_FB_NEU
        {
            get { return _Beleg6_FB_NEU; }
            set { _Beleg6_FB_NEU = value; }
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

            // Zeile_7
            Report.Log(ReportLevel.Info, "Section", "Zeile_7", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg6) on item 'TblB.Buchungszeilen_Tabelle.Zeile7.ColBelegnrRow7'.", repo.TblB.Buchungszeilen_Tabelle.Zeile7.ColBelegnrRow7Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblB.Buchungszeilen_Tabelle.Zeile7.ColBelegnrRow7Info, "Text", Beleg6);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.200,00') on item 'TblB.Buchungszeilen_Tabelle.Zeile7.ColBetragRow7'.", repo.TblB.Buchungszeilen_Tabelle.Zeile7.ColBetragRow7Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblB.Buchungszeilen_Tabelle.Zeile7.ColBetragRow7Info, "Text", "1.200,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg6_FB_NEU) on item 'TblB.Buchungszeilen_Tabelle.Zeile7.ColBusaNrfremdbelegRow7'.", repo.TblB.Buchungszeilen_Tabelle.Zeile7.ColBusaNrfremdbelegRow7Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblB.Buchungszeilen_Tabelle.Zeile7.ColBusaNrfremdbelegRow7Info, "Text", Beleg6_FB_NEU);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10') on item 'TblB.Buchungszeilen_Tabelle.Zeile7.ColCd1Row7'.", repo.TblB.Buchungszeilen_Tabelle.Zeile7.ColCd1Row7Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblB.Buchungszeilen_Tabelle.Zeile7.ColCd1Row7Info, "Text", "10");
            
            // Zeile_8
            Report.Log(ReportLevel.Info, "Section", "Zeile_8", new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg6_FB_NEU) on item 'TblB.Buchungszeilen_Tabelle.Zeile_8.ColBusaNrfremdbelegRow8'.", repo.TblB.Buchungszeilen_Tabelle.Zeile_8.ColBusaNrfremdbelegRow8Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblB.Buchungszeilen_Tabelle.Zeile_8.ColBusaNrfremdbelegRow8Info, "Text", Beleg6_FB_NEU);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10') on item 'TblB.Buchungszeilen_Tabelle.Zeile_8.ColCd1Row8'.", repo.TblB.Buchungszeilen_Tabelle.Zeile_8.ColCd1Row8Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblB.Buchungszeilen_Tabelle.Zeile_8.ColCd1Row8Info, "Text", "10");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='M20') on item 'TblB.Buchungszeilen_Tabelle.Zeile_8.ColUstcdRow8'.", repo.TblB.Buchungszeilen_Tabelle.Zeile_8.ColUstcdRow8Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblB.Buchungszeilen_Tabelle.Zeile_8.ColUstcdRow8Info, "Text", "M20");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'TblB.Buchungszeilen_Tabelle.Zeile_8.ColUstmvRow8'.", repo.TblB.Buchungszeilen_Tabelle.Zeile_8.ColUstmvRow8Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblB.Buchungszeilen_Tabelle.Zeile_8.ColUstmvRow8Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='200,00') on item 'TblB.Buchungszeilen_Tabelle.Zeile_8.ColUstbetragRow8'.", repo.TblB.Buchungszeilen_Tabelle.Zeile_8.ColUstbetragRow8Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblB.Buchungszeilen_Tabelle.Zeile_8.ColUstbetragRow8Info, "Text", "200,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2020-1') on item 'TblB.Buchungszeilen_Tabelle.Zeile_8.ColUvaRow8'.", repo.TblB.Buchungszeilen_Tabelle.Zeile_8.ColUvaRow8Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblB.Buchungszeilen_Tabelle.Zeile_8.ColUvaRow8Info, "Text", "2020-1");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
