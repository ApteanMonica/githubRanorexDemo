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
    ///The Pruefung_Inhalt_XML_Zeitraum_Ende recording.
    /// </summary>
    [TestModule("dddb6907-4caf-4540-845d-4fe4e4c3d7fe", ModuleType.Recording, 1)]
    public partial class Pruefung_Inhalt_XML_Zeitraum_Ende : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_005Repository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_005Repository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_005Repository.Instance;

        static Pruefung_Inhalt_XML_Zeitraum_Ende instance = new Pruefung_Inhalt_XML_Zeitraum_Ende();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_Inhalt_XML_Zeitraum_Ende()
        {
            Jahr = "";
            XML_JUVA_2021_Vorsatz = "";
            XML_JUVA_2021_Ende = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_Inhalt_XML_Zeitraum_Ende Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("b99ef79a-09a8-46d9-8e52-2991c4107ae2")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _XML_JUVA_2021_Vorsatz;

        /// <summary>
        /// Gets or sets the value of variable XML_JUVA_2021_Vorsatz.
        /// </summary>
        [TestVariable("5784283a-e343-4647-8ebd-c9f7902bcf30")]
        public string XML_JUVA_2021_Vorsatz
        {
            get { return _XML_JUVA_2021_Vorsatz; }
            set { _XML_JUVA_2021_Vorsatz = value; }
        }

        string _XML_JUVA_2021_Ende;

        /// <summary>
        /// Gets or sets the value of variable XML_JUVA_2021_Ende.
        /// </summary>
        [TestVariable("876c1747-5c9e-4cd4-b45c-c6ed238439a8")]
        public string XML_JUVA_2021_Ende
        {
            get { return _XML_JUVA_2021_Ende; }
            set { _XML_JUVA_2021_Ende = value; }
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
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_JUVA_2021_Vorsatz) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(0));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_JUVA_2021_Vorsatz, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$Jahr) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(1));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", Jahr, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_JUVA_2021_Ende) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(2));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_JUVA_2021_Ende, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
