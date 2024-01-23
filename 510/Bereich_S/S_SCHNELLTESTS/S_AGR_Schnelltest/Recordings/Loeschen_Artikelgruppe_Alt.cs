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

namespace S_AGR_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Loeschen_Artikelgruppe_Alt recording.
    /// </summary>
    [TestModule("7dc1b3a5-db3f-49f6-94f1-25162cde604e", ModuleType.Recording, 1)]
    public partial class Loeschen_Artikelgruppe_Alt : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository repository.
        /// </summary>
        public static global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository repo = global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository.Instance;

        static Loeschen_Artikelgruppe_Alt instance = new Loeschen_Artikelgruppe_Alt();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Loeschen_Artikelgruppe_Alt()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Loeschen_Artikelgruppe_Alt Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable GRUPPENART_ALT.
        /// </summary>
        [TestVariable("04d596e0-f25a-4df1-9d2f-5ae4d510d7df")]
        public string GRUPPENART_ALT
        {
            get { return repo.GRUPPENART_ALT; }
            set { repo.GRUPPENART_ALT = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblArtikelgruppen.FlexGrid.Row_mit_Artikelgruppe_Alt' at Center.", repo.TblArtikelgruppen.FlexGrid.Row_mit_Artikelgruppe_Alt.SelfInfo, new RecordItemIndex(0));
            repo.TblArtikelgruppen.FlexGrid.Row_mit_Artikelgruppe_Alt.Self.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}'.", new RecordItemIndex(1));
            Keyboard.Press("{Delete}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblArtikelgruppen.RibbonBar.PbDataAccessSave' at Center.", repo.TblArtikelgruppen.RibbonBar.PbDataAccessSaveInfo, new RecordItemIndex(2));
            repo.TblArtikelgruppen.RibbonBar.PbDataAccessSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}