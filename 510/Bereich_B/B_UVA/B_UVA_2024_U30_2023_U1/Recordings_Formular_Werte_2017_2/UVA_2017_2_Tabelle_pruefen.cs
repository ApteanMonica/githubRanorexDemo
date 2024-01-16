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

namespace B_UVA_2024_U30_2023_U1.Recordings_Formular_Werte_2017_2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UVA_2017_2_Tabelle_pruefen recording.
    /// </summary>
    [TestModule("9b7a49fe-40f0-4dde-8bdf-93effa814d2a", ModuleType.Recording, 1)]
    public partial class UVA_2017_2_Tabelle_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_2024_U30_2023_U1.B_UVA_2024_U30_2023_U1Repository repository.
        /// </summary>
        public static global::B_UVA_2024_U30_2023_U1.B_UVA_2024_U30_2023_U1Repository repo = global::B_UVA_2024_U30_2023_U1.B_UVA_2024_U30_2023_U1Repository.Instance;

        static UVA_2017_2_Tabelle_pruefen instance = new UVA_2017_2_Tabelle_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UVA_2017_2_Tabelle_pruefen()
        {
            Tabelle_Werte_U30_2017_2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UVA_2017_2_Tabelle_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tabelle_Werte_U30_2017_2;

        /// <summary>
        /// Gets or sets the value of variable Tabelle_Werte_U30_2017_2.
        /// </summary>
        [TestVariable("863a03d0-f5e8-4a3b-bd7a-32063494884c")]
        public string Tabelle_Werte_U30_2017_2
        {
            get { return _Tabelle_Werte_U30_2017_2; }
            set { _Tabelle_Werte_U30_2017_2 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tabelle_Werte_U30_2017_2) on item 'TblDrucken.Row1'.", repo.TblDrucken.Row1Info, new RecordItemIndex(0));
            Validate.AttributeContains(repo.TblDrucken.Row1Info, "Text", Tabelle_Werte_U30_2017_2);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
