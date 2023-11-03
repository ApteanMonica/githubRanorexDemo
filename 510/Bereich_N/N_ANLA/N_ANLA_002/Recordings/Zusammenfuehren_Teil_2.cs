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

namespace N_ANLA_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Zusammenfuehren_Teil_2 recording.
    /// </summary>
    [TestModule("cdfc25a4-5a02-4121-b193-591189941286", ModuleType.Recording, 1)]
    public partial class Zusammenfuehren_Teil_2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_ANLA_002.N_ANLA_002Repository repository.
        /// </summary>
        public static global::N_ANLA_002.N_ANLA_002Repository repo = global::N_ANLA_002.N_ANLA_002Repository.Instance;

        static Zusammenfuehren_Teil_2 instance = new Zusammenfuehren_Teil_2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Zusammenfuehren_Teil_2()
        {
            Anlage_D = "N_ANLA_002_04";
            Anlage_E = "N_ANLA_002_05";
            Anlage_F = "N_ANLA_002_06";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Zusammenfuehren_Teil_2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Anlage_D;

        /// <summary>
        /// Gets or sets the value of variable Anlage_D.
        /// </summary>
        [TestVariable("eca6e420-cc97-4429-9b22-81d2418726bf")]
        public string Anlage_D
        {
            get { return _Anlage_D; }
            set { _Anlage_D = value; }
        }

        string _Anlage_E;

        /// <summary>
        /// Gets or sets the value of variable Anlage_E.
        /// </summary>
        [TestVariable("811c0edb-10c9-4627-85a6-3432c8fd6991")]
        public string Anlage_E
        {
            get { return _Anlage_E; }
            set { _Anlage_E = value; }
        }

        string _Anlage_F;

        /// <summary>
        /// Gets or sets the value of variable Anlage_F.
        /// </summary>
        [TestVariable("399f580e-db73-4216-950e-0894f5f65d13")]
        public string Anlage_F
        {
            get { return _Anlage_F; }
            set { _Anlage_F = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anlage_D' with focus on 'FrmZuauf.TabPageTp1.ColAnlaNrRow2'.", repo.FrmZuauf.TabPageTp1.ColAnlaNrRow2Info, new RecordItemIndex(0));
            repo.FrmZuauf.TabPageTp1.ColAnlaNrRow2.PressKeys(Anlage_D);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            // Umgehungsschritte nach Lösung des Items 37966 wieder raus löschen
            Report.Log(ReportLevel.Info, "Keyboard", "Umgehungsschritte nach Lösung des Items 37966 wieder raus löschen\r\nKey sequence '{Insert}' with focus on 'FrmZuauf.FlexGrid'.", repo.FrmZuauf.FlexGridInfo, new RecordItemIndex(2));
            repo.FrmZuauf.FlexGrid.PressKeys("{Insert}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anlage_E' with focus on 'FrmZuauf.TabPageTp1.ColAnlaNrRow3'.", repo.FrmZuauf.TabPageTp1.ColAnlaNrRow3Info, new RecordItemIndex(3));
            repo.FrmZuauf.TabPageTp1.ColAnlaNrRow3.PressKeys(Anlage_E);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Insert}' with focus on 'FrmZuauf.FlexGrid'.", repo.FrmZuauf.FlexGridInfo, new RecordItemIndex(4));
            repo.FrmZuauf.FlexGrid.PressKeys("{Insert}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anlage_F'.", new RecordItemIndex(5));
            Keyboard.Press(Anlage_F);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
