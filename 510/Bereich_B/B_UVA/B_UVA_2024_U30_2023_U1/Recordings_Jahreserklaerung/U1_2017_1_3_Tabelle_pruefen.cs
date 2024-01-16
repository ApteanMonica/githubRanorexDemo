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

namespace B_UVA_2024_U30_2023_U1.Recordings_Jahreserklaerung
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The U1_2017_1_3_Tabelle_ausgeben_pruefen recording.
    /// </summary>
    [TestModule("5309d791-1de2-409b-b456-66c90ecb2703", ModuleType.Recording, 1)]
    public partial class U1_2017_1_3_Tabelle_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_2024_U30_2023_U1.B_UVA_2024_U30_2023_U1Repository repository.
        /// </summary>
        public static global::B_UVA_2024_U30_2023_U1.B_UVA_2024_U30_2023_U1Repository repo = global::B_UVA_2024_U30_2023_U1.B_UVA_2024_U30_2023_U1Repository.Instance;

        static U1_2017_1_3_Tabelle_pruefen instance = new U1_2017_1_3_Tabelle_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public U1_2017_1_3_Tabelle_pruefen()
        {
            Tabelle_Werte_U1_2017_1_3_Teil_1 = "";
            Tabelle_Werte_U1_2017_1_3_Teil_2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static U1_2017_1_3_Tabelle_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tabelle_Werte_U1_2017_1_3_Teil_1;

        /// <summary>
        /// Gets or sets the value of variable Tabelle_Werte_U1_2017_1_3_Teil_1.
        /// </summary>
        [TestVariable("b1b0e783-fd21-4d93-8d82-67554d2501bb")]
        public string Tabelle_Werte_U1_2017_1_3_Teil_1
        {
            get { return _Tabelle_Werte_U1_2017_1_3_Teil_1; }
            set { _Tabelle_Werte_U1_2017_1_3_Teil_1 = value; }
        }

        string _Tabelle_Werte_U1_2017_1_3_Teil_2;

        /// <summary>
        /// Gets or sets the value of variable Tabelle_Werte_U1_2017_1_3_Teil_2.
        /// </summary>
        [TestVariable("6f6299d2-7567-4f33-abe6-023cf2f4417c")]
        public string Tabelle_Werte_U1_2017_1_3_Teil_2
        {
            get { return _Tabelle_Werte_U1_2017_1_3_Teil_2; }
            set { _Tabelle_Werte_U1_2017_1_3_Teil_2 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tabelle_Werte_U1_2017_1_3_Teil_1) on item 'TblDrucken.Row1'.", repo.TblDrucken.Row1Info, new RecordItemIndex(0));
            Validate.AttributeContains(repo.TblDrucken.Row1Info, "Text", Tabelle_Werte_U1_2017_1_3_Teil_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tabelle_Werte_U1_2017_1_3_Teil_2) on item 'TblDrucken.Row1'.", repo.TblDrucken.Row1Info, new RecordItemIndex(1));
            Validate.AttributeContains(repo.TblDrucken.Row1Info, "Text", Tabelle_Werte_U1_2017_1_3_Teil_2);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
