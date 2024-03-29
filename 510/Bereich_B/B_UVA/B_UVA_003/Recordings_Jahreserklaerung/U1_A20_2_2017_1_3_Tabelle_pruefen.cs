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

namespace B_UVA_003.Recordings_Jahreserklaerung
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The U1_A20_2_2017_1_3_Tabelle_pruefen recording.
    /// </summary>
    [TestModule("6ee0d291-3abf-4e82-a950-0cccf09f1676", ModuleType.Recording, 1)]
    public partial class U1_A20_2_2017_1_3_Tabelle_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_003.B_UVA_003Repository repository.
        /// </summary>
        public static global::B_UVA_003.B_UVA_003Repository repo = global::B_UVA_003.B_UVA_003Repository.Instance;

        static U1_A20_2_2017_1_3_Tabelle_pruefen instance = new U1_A20_2_2017_1_3_Tabelle_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public U1_A20_2_2017_1_3_Tabelle_pruefen()
        {
            Tabelle_Werte_A21_2017_1 = "";
            Tabelle_Werte_A20_2_2017_1_3_U1 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static U1_A20_2_2017_1_3_Tabelle_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tabelle_Werte_A21_2017_1;

        /// <summary>
        /// Gets or sets the value of variable Tabelle_Werte_A21_2017_1.
        /// </summary>
        [TestVariable("de74e8b4-66dc-43fc-8ea3-23739a012b7d")]
        public string Tabelle_Werte_A21_2017_1
        {
            get { return _Tabelle_Werte_A21_2017_1; }
            set { _Tabelle_Werte_A21_2017_1 = value; }
        }

        string _Tabelle_Werte_A20_2_2017_1_3_U1;

        /// <summary>
        /// Gets or sets the value of variable Tabelle_Werte_A20_2_2017_1_3_U1.
        /// </summary>
        [TestVariable("fdc496cd-ad0f-4749-aa18-82778d2aa610")]
        public string Tabelle_Werte_A20_2_2017_1_3_U1
        {
            get { return _Tabelle_Werte_A20_2_2017_1_3_U1; }
            set { _Tabelle_Werte_A20_2_2017_1_3_U1 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tabelle_Werte_A20_2_2017_1_3_U1) on item 'TblDrucken.Row1'.", repo.TblDrucken.Row1Info, new RecordItemIndex(0));
            Validate.AttributeContains(repo.TblDrucken.Row1Info, "Text", Tabelle_Werte_A20_2_2017_1_3_U1);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
