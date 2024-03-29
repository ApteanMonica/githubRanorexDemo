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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace K_FIBU_002
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the K_FIBU_002Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("dde5c433-5c7e-4737-8ffe-00ede259bd32")]
    public partial class K_FIBU_002Repository : RepoGenBaseFolder
    {
        static K_FIBU_002Repository instance = new K_FIBU_002Repository();
        K_FIBU_002RepositoryFolders.FrmVerbuchAppFolder _frmverbuch;
        K_FIBU_002RepositoryFolders.DlgMessageBoxAppFolder _dlgmessagebox;
        K_FIBU_002RepositoryFolders.TblIbufeAppFolder _tblibufe;

        /// <summary>
        /// Gets the singleton class instance representing the K_FIBU_002Repository element repository.
        /// </summary>
        [RepositoryFolder("dde5c433-5c7e-4737-8ffe-00ede259bd32")]
        public static K_FIBU_002Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public K_FIBU_002Repository() 
            : base("K_FIBU_002Repository", "/", null, 0, false, "dde5c433-5c7e-4737-8ffe-00ede259bd32", ".\\RepositoryImages\\K_FIBU_002Repositorydde5c433.rximgres")
        {
            _frmverbuch = new K_FIBU_002RepositoryFolders.FrmVerbuchAppFolder(this);
            _dlgmessagebox = new K_FIBU_002RepositoryFolders.DlgMessageBoxAppFolder(this);
            _tblibufe = new K_FIBU_002RepositoryFolders.TblIbufeAppFolder(this);
        }

#region Variables

        string _Tagesdatum = "";

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("fc800f8b-6a2b-4300-a413-9c16ecc65e3c")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        string _Periode_bis = "2";

        /// <summary>
        /// Gets or sets the value of variable Periode_bis.
        /// </summary>
        [TestVariable("13366ffa-1f4b-4af2-8ccd-9d5b781d38b7")]
        public string Periode_bis
        {
            get { return _Periode_bis; }
            set { _Periode_bis = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("dde5c433-5c7e-4737-8ffe-00ede259bd32")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmVerbuch folder.
        /// </summary>
        [RepositoryFolder("fd4264bd-33e0-4c56-953b-f5c96d185409")]
        public virtual K_FIBU_002RepositoryFolders.FrmVerbuchAppFolder FrmVerbuch
        {
            get { return _frmverbuch; }
        }

        /// <summary>
        /// The DlgMessageBox folder.
        /// </summary>
        [RepositoryFolder("e109e565-432b-4bc3-b94b-ca0902ccefca")]
        public virtual K_FIBU_002RepositoryFolders.DlgMessageBoxAppFolder DlgMessageBox
        {
            get { return _dlgmessagebox; }
        }

        /// <summary>
        /// The TblIbufe folder.
        /// </summary>
        [RepositoryFolder("2129d9f8-e6e8-4091-ab52-8e9cb5eab752")]
        public virtual K_FIBU_002RepositoryFolders.TblIbufeAppFolder TblIbufe
        {
            get { return _tblibufe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class K_FIBU_002RepositoryFolders
    {
        /// <summary>
        /// The FrmVerbuchAppFolder folder.
        /// </summary>
        [RepositoryFolder("fd4264bd-33e0-4c56-953b-f5c96d185409")]
        public partial class FrmVerbuchAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100bereichssummierungInfo;
            RepoItemInfo _jahr_vonInfo;
            RepoItemInfo _periode_vonInfo;
            RepoItemInfo _jahr_bisInfo;
            RepoItemInfo _periode_bisInfo;
            RepoItemInfo _pbokInfo;

            /// <summary>
            /// Creates a new FrmVerbuch  folder.
            /// </summary>
            public FrmVerbuchAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmVerbuch", "/form[@controlname='frmVerbuch']", parentFolder, 30000, null, true, "fd4264bd-33e0-4c56-953b-f5c96d185409", "")
            {
                _titlebar100bereichssummierungInfo = new RepoItemInfo(this, "TitleBar100BereichsSummierung", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "8c3fe432-bae5-4a6c-a6bd-ece504644554");
                _jahr_vonInfo = new RepoItemInfo(this, "Jahr_von", "container[@controlname='ClientArea']/text[@controlname='dfJahrbezP']/text[@accessiblename='Jahr/Periode']", "", 30000, null, "d745611a-bdec-4e17-b971-59699a54c11a");
                _periode_vonInfo = new RepoItemInfo(this, "Periode_von", "container[@controlname='ClientArea']/text[@controlname='dfPeriodeVon']/text[@accessiblerole='Text']", "", 30000, null, "1ccc5e0d-f966-465e-a717-8db4eb997fd3");
                _jahr_bisInfo = new RepoItemInfo(this, "Jahr_bis", "container[@controlname='ClientArea']/text[@controlname='dfJahrbezPBis']/text[@accessiblename='bis:']", "", 30000, null, "d2e46e6d-76b0-4ab1-a2d1-2d3fe3a525b4");
                _periode_bisInfo = new RepoItemInfo(this, "Periode_bis", "container[@controlname='ClientArea']/text[@controlname='dfPeriodeBis']/text[@accessiblerole='Text']", "", 30000, null, "06706bcd-fd01-4456-a521-14a207dd4787");
                _pbokInfo = new RepoItemInfo(this, "PbOK", "container[@controlname='ClientArea']/button[@controlname='pbOK']", "", 30000, null, "b480f9db-9ee5-4851-a478-f1211dd782a3");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("fd4264bd-33e0-4c56-953b-f5c96d185409")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("fd4264bd-33e0-4c56-953b-f5c96d185409")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100BereichsSummierung item.
            /// </summary>
            [RepositoryItem("8c3fe432-bae5-4a6c-a6bd-ece504644554")]
            public virtual Ranorex.TitleBar TitleBar100BereichsSummierung
            {
                get
                {
                    return _titlebar100bereichssummierungInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100BereichsSummierung item info.
            /// </summary>
            [RepositoryItemInfo("8c3fe432-bae5-4a6c-a6bd-ece504644554")]
            public virtual RepoItemInfo TitleBar100BereichsSummierungInfo
            {
                get
                {
                    return _titlebar100bereichssummierungInfo;
                }
            }

            /// <summary>
            /// The Jahr_von item.
            /// </summary>
            [RepositoryItem("d745611a-bdec-4e17-b971-59699a54c11a")]
            public virtual Ranorex.Text Jahr_von
            {
                get
                {
                    return _jahr_vonInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Jahr_von item info.
            /// </summary>
            [RepositoryItemInfo("d745611a-bdec-4e17-b971-59699a54c11a")]
            public virtual RepoItemInfo Jahr_vonInfo
            {
                get
                {
                    return _jahr_vonInfo;
                }
            }

            /// <summary>
            /// The Periode_von item.
            /// </summary>
            [RepositoryItem("1ccc5e0d-f966-465e-a717-8db4eb997fd3")]
            public virtual Ranorex.Text Periode_von
            {
                get
                {
                    return _periode_vonInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Periode_von item info.
            /// </summary>
            [RepositoryItemInfo("1ccc5e0d-f966-465e-a717-8db4eb997fd3")]
            public virtual RepoItemInfo Periode_vonInfo
            {
                get
                {
                    return _periode_vonInfo;
                }
            }

            /// <summary>
            /// The Jahr_bis item.
            /// </summary>
            [RepositoryItem("d2e46e6d-76b0-4ab1-a2d1-2d3fe3a525b4")]
            public virtual Ranorex.Text Jahr_bis
            {
                get
                {
                    return _jahr_bisInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Jahr_bis item info.
            /// </summary>
            [RepositoryItemInfo("d2e46e6d-76b0-4ab1-a2d1-2d3fe3a525b4")]
            public virtual RepoItemInfo Jahr_bisInfo
            {
                get
                {
                    return _jahr_bisInfo;
                }
            }

            /// <summary>
            /// The Periode_bis item.
            /// </summary>
            [RepositoryItem("06706bcd-fd01-4456-a521-14a207dd4787")]
            public virtual Ranorex.Text Periode_bis
            {
                get
                {
                    return _periode_bisInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Periode_bis item info.
            /// </summary>
            [RepositoryItemInfo("06706bcd-fd01-4456-a521-14a207dd4787")]
            public virtual RepoItemInfo Periode_bisInfo
            {
                get
                {
                    return _periode_bisInfo;
                }
            }

            /// <summary>
            /// The PbOK item.
            /// </summary>
            [RepositoryItem("b480f9db-9ee5-4851-a478-f1211dd782a3")]
            public virtual Ranorex.Button PbOK
            {
                get
                {
                    return _pbokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbOK item info.
            /// </summary>
            [RepositoryItemInfo("b480f9db-9ee5-4851-a478-f1211dd782a3")]
            public virtual RepoItemInfo PbOKInfo
            {
                get
                {
                    return _pbokInfo;
                }
            }
        }

        /// <summary>
        /// The DlgMessageBoxAppFolder folder.
        /// </summary>
        [RepositoryFolder("e109e565-432b-4bc3-b94b-ca0902ccefca")]
        public partial class DlgMessageBoxAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _button0Info;
            RepoItemInfo _labelmeldungstextInfo;

            /// <summary>
            /// Creates a new DlgMessageBox  folder.
            /// </summary>
            public DlgMessageBoxAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgMessageBox", "/form[@controlname='dlgMessageBox']", parentFolder, 30000, null, true, "e109e565-432b-4bc3-b94b-ca0902ccefca", "")
            {
                _button0Info = new RepoItemInfo(this, "Button0", "button[@controlname='button0']", "", 30000, null, "45f53d25-e09f-4795-8baf-32392e510f4a");
                _labelmeldungstextInfo = new RepoItemInfo(this, "LabelMeldungstext", "text[@controlname='labelMeldungstext']", "", 30000, null, "9e1e8307-ce78-4d30-8fed-8a438c6c13a5");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e109e565-432b-4bc3-b94b-ca0902ccefca")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e109e565-432b-4bc3-b94b-ca0902ccefca")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Button0 item.
            /// </summary>
            [RepositoryItem("45f53d25-e09f-4795-8baf-32392e510f4a")]
            public virtual Ranorex.Button Button0
            {
                get
                {
                    return _button0Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Button0 item info.
            /// </summary>
            [RepositoryItemInfo("45f53d25-e09f-4795-8baf-32392e510f4a")]
            public virtual RepoItemInfo Button0Info
            {
                get
                {
                    return _button0Info;
                }
            }

            /// <summary>
            /// The LabelMeldungstext item.
            /// </summary>
            [RepositoryItem("9e1e8307-ce78-4d30-8fed-8a438c6c13a5")]
            public virtual Ranorex.Text LabelMeldungstext
            {
                get
                {
                    return _labelmeldungstextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LabelMeldungstext item info.
            /// </summary>
            [RepositoryItemInfo("9e1e8307-ce78-4d30-8fed-8a438c6c13a5")]
            public virtual RepoItemInfo LabelMeldungstextInfo
            {
                get
                {
                    return _labelmeldungstextInfo;
                }
            }
        }

        /// <summary>
        /// The TblIbufeAppFolder folder.
        /// </summary>
        [RepositoryFolder("2129d9f8-e6e8-4091-ab52-8e9cb5eab752")]
        public partial class TblIbufeAppFolder : RepoGenBaseFolder
        {
            K_FIBU_002RepositoryFolders.ToolBarFolder _toolbar;
            K_FIBU_002RepositoryFolders.TabelleFolder _tabelle;
            K_FIBU_002RepositoryFolders.Fusszeile_SummeFolder _fusszeile_summe;
            RepoItemInfo _titlebar100korebuchungenanzeigenInfo;
            RepoItemInfo _pbdataaccessladenInfo;

            /// <summary>
            /// Creates a new TblIbufe  folder.
            /// </summary>
            public TblIbufeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TblIbufe", "/form[@controlname='tblIbufe']", parentFolder, 30000, null, true, "2129d9f8-e6e8-4091-ab52-8e9cb5eab752", "")
            {
                _toolbar = new K_FIBU_002RepositoryFolders.ToolBarFolder(this);
                _tabelle = new K_FIBU_002RepositoryFolders.TabelleFolder(this);
                _fusszeile_summe = new K_FIBU_002RepositoryFolders.Fusszeile_SummeFolder(this);
                _titlebar100korebuchungenanzeigenInfo = new RepoItemInfo(this, "TitleBar100KOREBuchungenAnzeigen", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "ba87b716-79db-4408-b4a7-800911b00407");
                _pbdataaccessladenInfo = new RepoItemInfo(this, "PbDataAccessLaden", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbDataAccess_Laden']", "", 30000, null, "3166703d-93fe-4765-9999-e504ad83af60");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("2129d9f8-e6e8-4091-ab52-8e9cb5eab752")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("2129d9f8-e6e8-4091-ab52-8e9cb5eab752")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100KOREBuchungenAnzeigen item.
            /// </summary>
            [RepositoryItem("ba87b716-79db-4408-b4a7-800911b00407")]
            public virtual Ranorex.TitleBar TitleBar100KOREBuchungenAnzeigen
            {
                get
                {
                    return _titlebar100korebuchungenanzeigenInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100KOREBuchungenAnzeigen item info.
            /// </summary>
            [RepositoryItemInfo("ba87b716-79db-4408-b4a7-800911b00407")]
            public virtual RepoItemInfo TitleBar100KOREBuchungenAnzeigenInfo
            {
                get
                {
                    return _titlebar100korebuchungenanzeigenInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessLaden item.
            /// </summary>
            [RepositoryItem("3166703d-93fe-4765-9999-e504ad83af60")]
            public virtual Ranorex.Button PbDataAccessLaden
            {
                get
                {
                    return _pbdataaccessladenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbDataAccessLaden item info.
            /// </summary>
            [RepositoryItemInfo("3166703d-93fe-4765-9999-e504ad83af60")]
            public virtual RepoItemInfo PbDataAccessLadenInfo
            {
                get
                {
                    return _pbdataaccessladenInfo;
                }
            }

            /// <summary>
            /// The ToolBar folder.
            /// </summary>
            [RepositoryFolder("cbe375e4-dbed-4384-abb0-854eab1dfe78")]
            public virtual K_FIBU_002RepositoryFolders.ToolBarFolder ToolBar
            {
                get { return _toolbar; }
            }

            /// <summary>
            /// The Tabelle folder.
            /// </summary>
            [RepositoryFolder("7f3e05f5-5a1e-4f20-8e65-7a952f4e5eda")]
            public virtual K_FIBU_002RepositoryFolders.TabelleFolder Tabelle
            {
                get { return _tabelle; }
            }

            /// <summary>
            /// The Fusszeile_Summe folder.
            /// </summary>
            [RepositoryFolder("9f2581d5-a1c6-4bf7-bca0-b28fe74f6f7f")]
            public virtual K_FIBU_002RepositoryFolders.Fusszeile_SummeFolder Fusszeile_Summe
            {
                get { return _fusszeile_summe; }
            }
        }

        /// <summary>
        /// The ToolBarFolder folder.
        /// </summary>
        [RepositoryFolder("cbe375e4-dbed-4384-abb0-854eab1dfe78")]
        public partial class ToolBarFolder : RepoGenBaseFolder
        {
            RepoItemInfo _jahr_vonInfo;
            RepoItemInfo _periode_vonInfo;
            RepoItemInfo _jahr_bisInfo;
            RepoItemInfo _periode_bis_530_510Info;
            RepoItemInfo _periode_bis_510_521Info;
            RepoItemInfo _text_530Info;

            /// <summary>
            /// Creates a new ToolBar  folder.
            /// </summary>
            public ToolBarFolder(RepoGenBaseFolder parentFolder) :
                    base("ToolBar", "container[@controlname='ToolBar']", parentFolder, 30000, null, false, "cbe375e4-dbed-4384-abb0-854eab1dfe78", "")
            {
                _jahr_vonInfo = new RepoItemInfo(this, "Jahr_von", "text[@controlname='dfJahrV']/text[@accessiblename='Periode von']", "", 30000, null, "6606fba0-a2ed-4dce-8196-c2fb4171347b");
                _periode_vonInfo = new RepoItemInfo(this, "Periode_von", "text[@controlname='dfPeriodeV']/text[@accessiblerole='Text']", "", 30000, null, "b2e3ec41-da47-49d6-a043-8528df1cb6e7");
                _jahr_bisInfo = new RepoItemInfo(this, "Jahr_bis", "text[@controlname='dfJahrB']/text[@accessiblerole='Text']", "", 30000, null, "c5e148e9-1eff-4801-8b62-0375e9b0732b");
                _periode_bis_530_510Info = new RepoItemInfo(this, "Periode_bis_530_510", "text[@controlname='dfPeriodeB']/text[@accessiblerole='Text']", "", 30000, null, "9a937e97-2c05-4218-9302-261399f2d6f8");
                _periode_bis_510_521Info = new RepoItemInfo(this, "Periode_bis_510_521", "text[@controlname='dfPeriodeB']/text[@accessiblename='bis']", "", 30000, null, "d61445b4-513a-4cb5-9007-027bcfd04d22");
                _text_530Info = new RepoItemInfo(this, "Text_530", "text[@controlname='dfPeriodeB']/text[@accessiblerole='Text']", "", 30000, null, "0b17ccad-617c-4b4d-a1c6-121d490ad40a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("cbe375e4-dbed-4384-abb0-854eab1dfe78")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("cbe375e4-dbed-4384-abb0-854eab1dfe78")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Jahr_von item.
            /// </summary>
            [RepositoryItem("6606fba0-a2ed-4dce-8196-c2fb4171347b")]
            public virtual Ranorex.Text Jahr_von
            {
                get
                {
                    return _jahr_vonInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Jahr_von item info.
            /// </summary>
            [RepositoryItemInfo("6606fba0-a2ed-4dce-8196-c2fb4171347b")]
            public virtual RepoItemInfo Jahr_vonInfo
            {
                get
                {
                    return _jahr_vonInfo;
                }
            }

            /// <summary>
            /// The Periode_von item.
            /// </summary>
            [RepositoryItem("b2e3ec41-da47-49d6-a043-8528df1cb6e7")]
            public virtual Ranorex.Text Periode_von
            {
                get
                {
                    return _periode_vonInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Periode_von item info.
            /// </summary>
            [RepositoryItemInfo("b2e3ec41-da47-49d6-a043-8528df1cb6e7")]
            public virtual RepoItemInfo Periode_vonInfo
            {
                get
                {
                    return _periode_vonInfo;
                }
            }

            /// <summary>
            /// The Jahr_bis item.
            /// </summary>
            [RepositoryItem("c5e148e9-1eff-4801-8b62-0375e9b0732b")]
            public virtual Ranorex.Text Jahr_bis
            {
                get
                {
                    return _jahr_bisInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Jahr_bis item info.
            /// </summary>
            [RepositoryItemInfo("c5e148e9-1eff-4801-8b62-0375e9b0732b")]
            public virtual RepoItemInfo Jahr_bisInfo
            {
                get
                {
                    return _jahr_bisInfo;
                }
            }

            /// <summary>
            /// The Periode_bis_530_510 item.
            /// </summary>
            [RepositoryItem("9a937e97-2c05-4218-9302-261399f2d6f8")]
            public virtual Ranorex.Text Periode_bis_530_510
            {
                get
                {
                    return _periode_bis_530_510Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Periode_bis_530_510 item info.
            /// </summary>
            [RepositoryItemInfo("9a937e97-2c05-4218-9302-261399f2d6f8")]
            public virtual RepoItemInfo Periode_bis_530_510Info
            {
                get
                {
                    return _periode_bis_530_510Info;
                }
            }

            /// <summary>
            /// The Periode_bis_510_521 item.
            /// </summary>
            [RepositoryItem("d61445b4-513a-4cb5-9007-027bcfd04d22")]
            public virtual Ranorex.Text Periode_bis_510_521
            {
                get
                {
                    return _periode_bis_510_521Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Periode_bis_510_521 item info.
            /// </summary>
            [RepositoryItemInfo("d61445b4-513a-4cb5-9007-027bcfd04d22")]
            public virtual RepoItemInfo Periode_bis_510_521Info
            {
                get
                {
                    return _periode_bis_510_521Info;
                }
            }

            /// <summary>
            /// The Text_530 item.
            /// </summary>
            [RepositoryItem("0b17ccad-617c-4b4d-a1c6-121d490ad40a")]
            public virtual Ranorex.Text Text_530
            {
                get
                {
                    return _text_530Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text_530 item info.
            /// </summary>
            [RepositoryItemInfo("0b17ccad-617c-4b4d-a1c6-121d490ad40a")]
            public virtual RepoItemInfo Text_530Info
            {
                get
                {
                    return _text_530Info;
                }
            }
        }

        /// <summary>
        /// The TabelleFolder folder.
        /// </summary>
        [RepositoryFolder("7f3e05f5-5a1e-4f20-8e65-7a952f4e5eda")]
        public partial class TabelleFolder : RepoGenBaseFolder
        {
            RepoItemInfo _row1Info;
            RepoItemInfo _colbetragrow1Info;
            RepoItemInfo _colbetragrow2Info;
            RepoItemInfo _colbetragrow3Info;
            RepoItemInfo _colbetragrow4Info;
            RepoItemInfo _colbetragrow5Info;
            RepoItemInfo _colbetragrow6Info;
            RepoItemInfo _aenderungsdatum_zeile1Info;
            RepoItemInfo _aenderungsdatum_zeile6Info;

            /// <summary>
            /// Creates a new Tabelle  folder.
            /// </summary>
            public TabelleFolder(RepoGenBaseFolder parentFolder) :
                    base("Tabelle", "container[@controlname='ChildTableWindow']/element[@controlname='mainGrid']/table[@accessiblename='FlexGrid']", parentFolder, 30000, null, false, "7f3e05f5-5a1e-4f20-8e65-7a952f4e5eda", "")
            {
                _row1Info = new RepoItemInfo(this, "Row1", "row[@accessiblename='Row 1']", "", 30000, null, "e9e9c629-707e-467d-981b-f8682d004db7");
                _colbetragrow1Info = new RepoItemInfo(this, "ColBetragRow1", "row[@accessiblename='Row 1']/cell[@accessiblename='colBetrag Row 1']", "", 30000, null, "272c5043-9f4c-44a1-a83a-f54970877832");
                _colbetragrow2Info = new RepoItemInfo(this, "ColBetragRow2", "row[@accessiblename='Row 2']/cell[@accessiblename='colBetrag Row 2']", "", 30000, null, "4c7d2449-c21d-4517-8e76-9120aea140dc");
                _colbetragrow3Info = new RepoItemInfo(this, "ColBetragRow3", "row[@accessiblename='Row 3']/cell[@accessiblename='colBetrag Row 3']", "", 30000, null, "7911d120-c52b-4293-95c0-1f347352cb73");
                _colbetragrow4Info = new RepoItemInfo(this, "ColBetragRow4", "row[@accessiblename='Row 4']/cell[@accessiblename='colBetrag Row 4']", "", 30000, null, "d9b9afdc-6766-4e9e-af16-0f27f87d0af6");
                _colbetragrow5Info = new RepoItemInfo(this, "ColBetragRow5", "row[@accessiblename='Row 5']/cell[@accessiblename='colBetrag Row 5']", "", 30000, null, "d79f20ea-2031-4691-9e1f-20d581b5c88c");
                _colbetragrow6Info = new RepoItemInfo(this, "ColBetragRow6", "row[@accessiblename='Row 6']/cell[@accessiblename='colBetrag Row 6']", "", 30000, null, "75e66eef-1468-46b1-beaf-60e36074281c");
                _aenderungsdatum_zeile1Info = new RepoItemInfo(this, "Aenderungsdatum_Zeile1", "row[@accessiblename='Row 1']/cell[@accessiblename='colIbu_dtaendg Row 1']", "", 30000, null, "25ffad7c-aa0b-4455-82c4-1d1412bc4c9a");
                _aenderungsdatum_zeile6Info = new RepoItemInfo(this, "Aenderungsdatum_Zeile6", "row[@accessiblename='Row 6']/cell[@accessiblename='colIbu_dtaendg Row 6']", "", 30000, null, "7e60f29c-d589-4520-9ade-6ebe9a266d82");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7f3e05f5-5a1e-4f20-8e65-7a952f4e5eda")]
            public virtual Ranorex.Table Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Table>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("7f3e05f5-5a1e-4f20-8e65-7a952f4e5eda")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Row1 item.
            /// </summary>
            [RepositoryItem("e9e9c629-707e-467d-981b-f8682d004db7")]
            public virtual Ranorex.Row Row1
            {
                get
                {
                    return _row1Info.CreateAdapter<Ranorex.Row>(true);
                }
            }

            /// <summary>
            /// The Row1 item info.
            /// </summary>
            [RepositoryItemInfo("e9e9c629-707e-467d-981b-f8682d004db7")]
            public virtual RepoItemInfo Row1Info
            {
                get
                {
                    return _row1Info;
                }
            }

            /// <summary>
            /// The ColBetragRow1 item.
            /// </summary>
            [RepositoryItem("272c5043-9f4c-44a1-a83a-f54970877832")]
            public virtual Ranorex.Cell ColBetragRow1
            {
                get
                {
                    return _colbetragrow1Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColBetragRow1 item info.
            /// </summary>
            [RepositoryItemInfo("272c5043-9f4c-44a1-a83a-f54970877832")]
            public virtual RepoItemInfo ColBetragRow1Info
            {
                get
                {
                    return _colbetragrow1Info;
                }
            }

            /// <summary>
            /// The ColBetragRow2 item.
            /// </summary>
            [RepositoryItem("4c7d2449-c21d-4517-8e76-9120aea140dc")]
            public virtual Ranorex.Cell ColBetragRow2
            {
                get
                {
                    return _colbetragrow2Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColBetragRow2 item info.
            /// </summary>
            [RepositoryItemInfo("4c7d2449-c21d-4517-8e76-9120aea140dc")]
            public virtual RepoItemInfo ColBetragRow2Info
            {
                get
                {
                    return _colbetragrow2Info;
                }
            }

            /// <summary>
            /// The ColBetragRow3 item.
            /// </summary>
            [RepositoryItem("7911d120-c52b-4293-95c0-1f347352cb73")]
            public virtual Ranorex.Cell ColBetragRow3
            {
                get
                {
                    return _colbetragrow3Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColBetragRow3 item info.
            /// </summary>
            [RepositoryItemInfo("7911d120-c52b-4293-95c0-1f347352cb73")]
            public virtual RepoItemInfo ColBetragRow3Info
            {
                get
                {
                    return _colbetragrow3Info;
                }
            }

            /// <summary>
            /// The ColBetragRow4 item.
            /// </summary>
            [RepositoryItem("d9b9afdc-6766-4e9e-af16-0f27f87d0af6")]
            public virtual Ranorex.Cell ColBetragRow4
            {
                get
                {
                    return _colbetragrow4Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColBetragRow4 item info.
            /// </summary>
            [RepositoryItemInfo("d9b9afdc-6766-4e9e-af16-0f27f87d0af6")]
            public virtual RepoItemInfo ColBetragRow4Info
            {
                get
                {
                    return _colbetragrow4Info;
                }
            }

            /// <summary>
            /// The ColBetragRow5 item.
            /// </summary>
            [RepositoryItem("d79f20ea-2031-4691-9e1f-20d581b5c88c")]
            public virtual Ranorex.Cell ColBetragRow5
            {
                get
                {
                    return _colbetragrow5Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColBetragRow5 item info.
            /// </summary>
            [RepositoryItemInfo("d79f20ea-2031-4691-9e1f-20d581b5c88c")]
            public virtual RepoItemInfo ColBetragRow5Info
            {
                get
                {
                    return _colbetragrow5Info;
                }
            }

            /// <summary>
            /// The ColBetragRow6 item.
            /// </summary>
            [RepositoryItem("75e66eef-1468-46b1-beaf-60e36074281c")]
            public virtual Ranorex.Cell ColBetragRow6
            {
                get
                {
                    return _colbetragrow6Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColBetragRow6 item info.
            /// </summary>
            [RepositoryItemInfo("75e66eef-1468-46b1-beaf-60e36074281c")]
            public virtual RepoItemInfo ColBetragRow6Info
            {
                get
                {
                    return _colbetragrow6Info;
                }
            }

            /// <summary>
            /// The Aenderungsdatum_Zeile1 item.
            /// </summary>
            [RepositoryItem("25ffad7c-aa0b-4455-82c4-1d1412bc4c9a")]
            public virtual Ranorex.Cell Aenderungsdatum_Zeile1
            {
                get
                {
                    return _aenderungsdatum_zeile1Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Aenderungsdatum_Zeile1 item info.
            /// </summary>
            [RepositoryItemInfo("25ffad7c-aa0b-4455-82c4-1d1412bc4c9a")]
            public virtual RepoItemInfo Aenderungsdatum_Zeile1Info
            {
                get
                {
                    return _aenderungsdatum_zeile1Info;
                }
            }

            /// <summary>
            /// The Aenderungsdatum_Zeile6 item.
            /// </summary>
            [RepositoryItem("7e60f29c-d589-4520-9ade-6ebe9a266d82")]
            public virtual Ranorex.Cell Aenderungsdatum_Zeile6
            {
                get
                {
                    return _aenderungsdatum_zeile6Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Aenderungsdatum_Zeile6 item info.
            /// </summary>
            [RepositoryItemInfo("7e60f29c-d589-4520-9ade-6ebe9a266d82")]
            public virtual RepoItemInfo Aenderungsdatum_Zeile6Info
            {
                get
                {
                    return _aenderungsdatum_zeile6Info;
                }
            }
        }

        /// <summary>
        /// The Fusszeile_SummeFolder folder.
        /// </summary>
        [RepositoryFolder("9f2581d5-a1c6-4bf7-bca0-b28fe74f6f7f")]
        public partial class Fusszeile_SummeFolder : RepoGenBaseFolder
        {
            RepoItemInfo _summeInfo;

            /// <summary>
            /// Creates a new Fusszeile_Summe  folder.
            /// </summary>
            public Fusszeile_SummeFolder(RepoGenBaseFolder parentFolder) :
                    base("Fusszeile_Summe", "container[@controlname='ChildTableWindow']/element[@controlname='splitGrid']/table[@accessiblename='FlexGrid']", parentFolder, 30000, null, false, "9f2581d5-a1c6-4bf7-bca0-b28fe74f6f7f", "")
            {
                _summeInfo = new RepoItemInfo(this, "Summe", "row[@accessiblename='Row 0']/cell[@accessiblename='colBetrag Row 0']", "", 30000, null, "0f768c6c-1cbd-426e-aa79-950155ec60ab");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9f2581d5-a1c6-4bf7-bca0-b28fe74f6f7f")]
            public virtual Ranorex.Table Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Table>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9f2581d5-a1c6-4bf7-bca0-b28fe74f6f7f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Summe item.
            /// </summary>
            [RepositoryItem("0f768c6c-1cbd-426e-aa79-950155ec60ab")]
            public virtual Ranorex.Cell Summe
            {
                get
                {
                    return _summeInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Summe item info.
            /// </summary>
            [RepositoryItemInfo("0f768c6c-1cbd-426e-aa79-950155ec60ab")]
            public virtual RepoItemInfo SummeInfo
            {
                get
                {
                    return _summeInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
