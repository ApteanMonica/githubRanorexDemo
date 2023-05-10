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

namespace B_MNDR_004.Recordings_B_KLAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The B_KLAB_Mahnsperren_Kontolle_Kunde_2 recording.
    /// </summary>
    [TestModule("89ebe94d-0a78-4672-a0a3-f9005f29bae8", ModuleType.Recording, 1)]
    public partial class B_KLAB_Mahnsperren_Kontolle_Kunde_2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_MNDR_004.B_MNDR_004Repository repository.
        /// </summary>
        public static global::B_MNDR_004.B_MNDR_004Repository repo = global::B_MNDR_004.B_MNDR_004Repository.Instance;

        static B_KLAB_Mahnsperren_Kontolle_Kunde_2 instance = new B_KLAB_Mahnsperren_Kontolle_Kunde_2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_KLAB_Mahnsperren_Kontolle_Kunde_2()
        {
            Kunde_2 = "200025";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_KLAB_Mahnsperren_Kontolle_Kunde_2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Kunde_2;

        /// <summary>
        /// Gets or sets the value of variable Kunde_2.
        /// </summary>
        [TestVariable("b6410ea9-bc98-402a-be0c-87a564543a01")]
        public string Kunde_2
        {
            get { return _Kunde_2; }
            set { _Kunde_2 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuop.FlexGrid.Row2Column0' at Center.", repo.TblBuop.FlexGrid.Row2Column0Info, new RecordItemIndex(0));
            repo.TblBuop.FlexGrid.Row2Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuop.PbSperrenSperren' at Center.", repo.TblBuop.PbSperrenSperrenInfo, new RecordItemIndex(1));
            repo.TblBuop.PbSperrenSperren.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BKLAB.Mahnsperre' at Center.", repo.BKLAB.MahnsperreInfo, new RecordItemIndex(2));
            repo.BKLAB.Mahnsperre.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'Form100Sperren.TitleBar100Sperren'", repo.Form100Sperren.TitleBar100SperrenInfo, new ActionTimeout(60000), new RecordItemIndex(3));
            repo.Form100Sperren.TitleBar100SperrenInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Mahnsperre') on item 'Form100Sperren.DfOpspTypBez'.", repo.Form100Sperren.DfOpspTypBezInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.Form100Sperren.DfOpspTypBezInfo, "Text", "Mahnsperre");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kunde_2) on item 'Form100Sperren.Adresse'.", repo.Form100Sperren.AdresseInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.Form100Sperren.AdresseInfo, "Text", Kunde_2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'N\t\tMahnsperre\t\tB_MNDR_004_02\t55,00') on item 'Form100Sperren.obere_Sperrtabelle.Row1_obere_Sperrtabelle'.", repo.Form100Sperren.obere_Sperrtabelle.Row1_obere_SperrtabelleInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.Form100Sperren.obere_Sperrtabelle.Row1_obere_SperrtabelleInfo, "Text", "N\t\tMahnsperre\t\tB_MNDR_004_02\t55,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Mahnsperre\t01.02.2021\t28.02.2021\tB_MNDR_004_01\t*\tKLAGE\tkeine Mahnung wegen Klage\t\t36,00') on item 'Form100Sperren.untere_Sperrtabelle.Row1_untere_Sperrtabelle'.", repo.Form100Sperren.untere_Sperrtabelle.Row1_untere_SperrtabelleInfo, new RecordItemIndex(7));
            Validate.AttributeContains(repo.Form100Sperren.untere_Sperrtabelle.Row1_untere_SperrtabelleInfo, "Text", "Mahnsperre\t01.02.2021\t28.02.2021\tB_MNDR_004_01\t*\tKLAGE\tkeine Mahnung wegen Klage\t\t36,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Mahnsperre\t\t\tB_MNDR_004_02\t\tN\t\tMahnsperre\t55,00') on item 'Form100Sperren.untere_Sperrtabelle.Row2_untere_Sperrtabelle'.", repo.Form100Sperren.untere_Sperrtabelle.Row2_untere_SperrtabelleInfo, new RecordItemIndex(8));
            Validate.AttributeContains(repo.Form100Sperren.untere_Sperrtabelle.Row2_untere_SperrtabelleInfo, "Text", "Mahnsperre\t\t\tB_MNDR_004_02\t\tN\t\tMahnsperre\t55,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'Form100Sperren.untere_Sperrtabelle.Row3_Textfeld_mit_Mahnsperre'.", repo.Form100Sperren.untere_Sperrtabelle.Row3_Textfeld_mit_MahnsperreInfo, new RecordItemIndex(9));
            Validate.NotExists(repo.Form100Sperren.untere_Sperrtabelle.Row3_Textfeld_mit_MahnsperreInfo);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'Form100Sperren.TitleBar100Sperren'.", repo.Form100Sperren.TitleBar100SperrenInfo, new RecordItemIndex(10));
            Keyboard.PrepareFocus(repo.Form100Sperren.TitleBar100Sperren);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
