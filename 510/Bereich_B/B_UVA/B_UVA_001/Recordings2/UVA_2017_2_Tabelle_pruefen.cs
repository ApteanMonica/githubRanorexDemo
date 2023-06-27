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

namespace B_UVA_001.Recordings2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UVA_2017_2_Tabelle_pruefen recording.
    /// </summary>
    [TestModule("f2dcfe0c-c500-44a3-95d3-55a7027a9863", ModuleType.Recording, 1)]
    public partial class UVA_2017_2_Tabelle_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_001.B_UVA_001Repository repository.
        /// </summary>
        public static global::B_UVA_001.B_UVA_001Repository repo = global::B_UVA_001.B_UVA_001Repository.Instance;

        static UVA_2017_2_Tabelle_pruefen instance = new UVA_2017_2_Tabelle_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UVA_2017_2_Tabelle_pruefen()
        {
            Tabelle_Werte_A20_2017_2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UVA_2017_2_Tabelle_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tabelle_Werte_A20_2017_2;

        /// <summary>
        /// Gets or sets the value of variable Tabelle_Werte_A20_2017_2.
        /// </summary>
        [TestVariable("52063780-b4a5-42cc-8235-4270a4b09d75")]
        public string Tabelle_Werte_A20_2017_2
        {
            get { return _Tabelle_Werte_A20_2017_2; }
            set { _Tabelle_Werte_A20_2017_2 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tabelle_Werte_A20_2017_2) on item 'ChildTableWindow.Row1'.", repo.ChildTableWindow.Row1Info, new RecordItemIndex(0));
            Validate.AttributeContains(repo.ChildTableWindow.Row1Info, "Text", Tabelle_Werte_A20_2017_2);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
