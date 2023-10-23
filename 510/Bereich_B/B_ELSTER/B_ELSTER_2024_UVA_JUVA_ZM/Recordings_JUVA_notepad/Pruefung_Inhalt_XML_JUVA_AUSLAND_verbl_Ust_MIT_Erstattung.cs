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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordings_JUVA_notepad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefung_Inhalt_XML_JUVA_AUSLAND_verbl_Ust_MIT_Erstattung recording.
    /// </summary>
    [TestModule("2fa47b34-58ae-46ea-b0ec-811eb0cd36a6", ModuleType.Recording, 1)]
    public partial class Pruefung_Inhalt_XML_JUVA_AUSLAND_verbl_Ust_MIT_Erstattung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_005Repository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_005Repository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_005Repository.Instance;

        static Pruefung_Inhalt_XML_JUVA_AUSLAND_verbl_Ust_MIT_Erstattung instance = new Pruefung_Inhalt_XML_JUVA_AUSLAND_verbl_Ust_MIT_Erstattung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_Inhalt_XML_JUVA_AUSLAND_verbl_Ust_MIT_Erstattung()
        {
            XML_JUVA_2021_Berech_Ust_MIT_Erstattung = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_Inhalt_XML_JUVA_AUSLAND_verbl_Ust_MIT_Erstattung Instance
        {
            get { return instance; }
        }

#region Variables

        string _XML_JUVA_2021_Berech_Ust_MIT_Erstattung;

        /// <summary>
        /// Gets or sets the value of variable XML_JUVA_2021_Berech_Ust_MIT_Erstattung.
        /// </summary>
        [TestVariable("0619b45f-0bb0-482c-acc8-4c8c42ae0818")]
        public string XML_JUVA_2021_Berech_Ust_MIT_Erstattung
        {
            get { return _XML_JUVA_2021_Berech_Ust_MIT_Erstattung; }
            set { _XML_JUVA_2021_Berech_Ust_MIT_Erstattung = value; }
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
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_JUVA_2021_Berech_Ust_MIT_Erstattung) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(0));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_JUVA_2021_Berech_Ust_MIT_Erstattung, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
