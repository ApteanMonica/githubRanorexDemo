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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordings_notepad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefung_Inhalt_XML_JUVA_AnlageUN_Bank_2022 recording.
    /// </summary>
    [TestModule("9c940495-7131-4644-8ef4-6a97a503917b", ModuleType.Recording, 1)]
    public partial class Pruefung_Inhalt_XML_JUVA_AnlageUN_Bank_2022 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_005Repository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_005Repository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_005Repository.Instance;

        static Pruefung_Inhalt_XML_JUVA_AnlageUN_Bank_2022 instance = new Pruefung_Inhalt_XML_JUVA_AnlageUN_Bank_2022();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_Inhalt_XML_JUVA_AnlageUN_Bank_2022()
        {
            XML_JUVA_2022_AnlageUN_Bank = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_Inhalt_XML_JUVA_AnlageUN_Bank_2022 Instance
        {
            get { return instance; }
        }

#region Variables

        string _XML_JUVA_2022_AnlageUN_Bank;

        /// <summary>
        /// Gets or sets the value of variable XML_JUVA_2022_AnlageUN_Bank.
        /// </summary>
        [TestVariable("10974ca0-9301-4a89-a3e5-a00051eec9f3")]
        public string XML_JUVA_2022_AnlageUN_Bank
        {
            get { return _XML_JUVA_2022_AnlageUN_Bank; }
            set { _XML_JUVA_2022_AnlageUN_Bank = value; }
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

            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_JUVA_2022_AnlageUN_Bank) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(0));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_JUVA_2022_AnlageUN_Bank, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
