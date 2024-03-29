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

namespace K_FIBU_005
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the K_FIBU_005Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("ae3cd1a8-c906-4d33-8167-714b2b2a3e7f")]
    public partial class K_FIBU_005Repository : RepoGenBaseFolder
    {
        static K_FIBU_005Repository instance = new K_FIBU_005Repository();
        K_FIBU_005RepositoryFolders.FrmMain_bis_521_tblMain_ab_530AppFolder _frmmain_bis_521_tblmain_ab_530;
        K_FIBU_005RepositoryFolders.FrmVerbuchAppFolder _frmverbuch;
        K_FIBU_005RepositoryFolders.DlgMessageBoxAppFolder _dlgmessagebox;
        K_FIBU_005RepositoryFolders.BJAHRAppFolder _bjahr;

        /// <summary>
        /// Gets the singleton class instance representing the K_FIBU_005Repository element repository.
        /// </summary>
        [RepositoryFolder("ae3cd1a8-c906-4d33-8167-714b2b2a3e7f")]
        public static K_FIBU_005Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public K_FIBU_005Repository() 
            : base("K_FIBU_005Repository", "/", null, 0, false, "ae3cd1a8-c906-4d33-8167-714b2b2a3e7f", ".\\RepositoryImages\\K_FIBU_005Repositoryae3cd1a8.rximgres")
        {
            _frmmain_bis_521_tblmain_ab_530 = new K_FIBU_005RepositoryFolders.FrmMain_bis_521_tblMain_ab_530AppFolder(this);
            _frmverbuch = new K_FIBU_005RepositoryFolders.FrmVerbuchAppFolder(this);
            _dlgmessagebox = new K_FIBU_005RepositoryFolders.DlgMessageBoxAppFolder(this);
            _bjahr = new K_FIBU_005RepositoryFolders.BJAHRAppFolder(this);
        }

#region Variables

        string _Jahr = "2017";

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("eb7fe1b4-cb23-47a4-a21e-eb6bffaf6d80")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("ae3cd1a8-c906-4d33-8167-714b2b2a3e7f")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmMain_bis_521_tblMain_ab_530 folder.
        /// </summary>
        [RepositoryFolder("5a1d34aa-07a1-4422-b046-f3b38c537cf6")]
        public virtual K_FIBU_005RepositoryFolders.FrmMain_bis_521_tblMain_ab_530AppFolder FrmMain_bis_521_tblMain_ab_530
        {
            get { return _frmmain_bis_521_tblmain_ab_530; }
        }

        /// <summary>
        /// The FrmVerbuch folder.
        /// </summary>
        [RepositoryFolder("d141d5b7-ae37-4b90-8069-c7e272feeb91")]
        public virtual K_FIBU_005RepositoryFolders.FrmVerbuchAppFolder FrmVerbuch
        {
            get { return _frmverbuch; }
        }

        /// <summary>
        /// The DlgMessageBox folder.
        /// </summary>
        [RepositoryFolder("4cb74804-31b3-4240-b03a-c29714546712")]
        public virtual K_FIBU_005RepositoryFolders.DlgMessageBoxAppFolder DlgMessageBox
        {
            get { return _dlgmessagebox; }
        }

        /// <summary>
        /// The BJAHR folder.
        /// </summary>
        [RepositoryFolder("6a794a9a-8d7f-492f-81ac-f65d15109a0e")]
        public virtual K_FIBU_005RepositoryFolders.BJAHRAppFolder BJAHR
        {
            get { return _bjahr; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class K_FIBU_005RepositoryFolders
    {
        /// <summary>
        /// The FrmMain_bis_521_tblMain_ab_530AppFolder folder.
        /// </summary>
        [RepositoryFolder("5a1d34aa-07a1-4422-b046-f3b38c537cf6")]
        public partial class FrmMain_bis_521_tblMain_ab_530AppFolder : RepoGenBaseFolder
        {
            K_FIBU_005RepositoryFolders.Tabelle_530_510Folder _tabelle_530_510;
            K_FIBU_005RepositoryFolders.Tabelle_510Folder _tabelle_510;
            RepoItemInfo _titlebar100verwaltengeschaeftsjahrInfo;
            RepoItemInfo _speichern_button_530Info;
            RepoItemInfo _pbstandard_530_510Info;
            RepoItemInfo _tabelle_530Info;

            /// <summary>
            /// Creates a new FrmMain_bis_521_tblMain_ab_530  folder.
            /// </summary>
            public FrmMain_bis_521_tblMain_ab_530AppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmMain_bis_521_tblMain_ab_530", "/form[@controlname~'Main']", parentFolder, 30000, null, true, "5a1d34aa-07a1-4422-b046-f3b38c537cf6", "")
            {
                _tabelle_530_510 = new K_FIBU_005RepositoryFolders.Tabelle_530_510Folder(this);
                _tabelle_510 = new K_FIBU_005RepositoryFolders.Tabelle_510Folder(this);
                _titlebar100verwaltengeschaeftsjahrInfo = new RepoItemInfo(this, "TitleBar100VerwaltenGeschaeftsjahr", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "5d440f6d-5acc-4cbe-8d65-5f9f67be92a5");
                _speichern_button_530Info = new RepoItemInfo(this, "Speichern_Button_530", "container[@controlname='ToolBar']/button[@controlname='pbSpeichern']", "element", 30000, null, "2a6f838d-cdc3-425a-93a9-9ace6da3632f");
                _pbstandard_530_510Info = new RepoItemInfo(this, "PbStandard_530_510", "container[@controlname='RibbonBar']/container[@controlname='CommonGroup']/button[@controlname='pbStandard1']", "", 30000, null, "c02f261d-6098-4ce5-86bb-e21317b51bba");
                _tabelle_530Info = new RepoItemInfo(this, "Tabelle_530", "container[@controlname='ChildTableWindow']/element[@controlname='mainGrid']/table[@accessiblename='FlexGrid']", "", 30000, null, "0a49bc62-18c1-430f-8c3a-2bbaa1f53082");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5a1d34aa-07a1-4422-b046-f3b38c537cf6")]
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
            [RepositoryItemInfo("5a1d34aa-07a1-4422-b046-f3b38c537cf6")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100VerwaltenGeschaeftsjahr item.
            /// </summary>
            [RepositoryItem("5d440f6d-5acc-4cbe-8d65-5f9f67be92a5")]
            public virtual Ranorex.TitleBar TitleBar100VerwaltenGeschaeftsjahr
            {
                get
                {
                    return _titlebar100verwaltengeschaeftsjahrInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100VerwaltenGeschaeftsjahr item info.
            /// </summary>
            [RepositoryItemInfo("5d440f6d-5acc-4cbe-8d65-5f9f67be92a5")]
            public virtual RepoItemInfo TitleBar100VerwaltenGeschaeftsjahrInfo
            {
                get
                {
                    return _titlebar100verwaltengeschaeftsjahrInfo;
                }
            }

            /// <summary>
            /// The Speichern_Button_530 item.
            /// </summary>
            [RepositoryItem("2a6f838d-cdc3-425a-93a9-9ace6da3632f")]
            public virtual Ranorex.Button Speichern_Button_530
            {
                get
                {
                    return _speichern_button_530Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Speichern_Button_530 item info.
            /// </summary>
            [RepositoryItemInfo("2a6f838d-cdc3-425a-93a9-9ace6da3632f")]
            public virtual RepoItemInfo Speichern_Button_530Info
            {
                get
                {
                    return _speichern_button_530Info;
                }
            }

            /// <summary>
            /// The PbStandard_530_510 item.
            /// </summary>
            [RepositoryItem("c02f261d-6098-4ce5-86bb-e21317b51bba")]
            public virtual Ranorex.Button PbStandard_530_510
            {
                get
                {
                    return _pbstandard_530_510Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbStandard_530_510 item info.
            /// </summary>
            [RepositoryItemInfo("c02f261d-6098-4ce5-86bb-e21317b51bba")]
            public virtual RepoItemInfo PbStandard_530_510Info
            {
                get
                {
                    return _pbstandard_530_510Info;
                }
            }

            /// <summary>
            /// The Tabelle_530 item.
            /// </summary>
            [RepositoryItem("0a49bc62-18c1-430f-8c3a-2bbaa1f53082")]
            public virtual Ranorex.Table Tabelle_530
            {
                get
                {
                    return _tabelle_530Info.CreateAdapter<Ranorex.Table>(true);
                }
            }

            /// <summary>
            /// The Tabelle_530 item info.
            /// </summary>
            [RepositoryItemInfo("0a49bc62-18c1-430f-8c3a-2bbaa1f53082")]
            public virtual RepoItemInfo Tabelle_530Info
            {
                get
                {
                    return _tabelle_530Info;
                }
            }

            /// <summary>
            /// The Tabelle_530_510 folder.
            /// </summary>
            [RepositoryFolder("557ac536-9b52-493e-b237-f77cf21f7d40")]
            public virtual K_FIBU_005RepositoryFolders.Tabelle_530_510Folder Tabelle_530_510
            {
                get { return _tabelle_530_510; }
            }

            /// <summary>
            /// The Tabelle_510 folder.
            /// </summary>
            [RepositoryFolder("10d5d570-2662-4de0-9cff-49af75798f5e")]
            public virtual K_FIBU_005RepositoryFolders.Tabelle_510Folder Tabelle_510
            {
                get { return _tabelle_510; }
            }
        }

        /// <summary>
        /// The Tabelle_530_510Folder folder.
        /// </summary>
        [RepositoryFolder("557ac536-9b52-493e-b237-f77cf21f7d40")]
        public partial class Tabelle_530_510Folder : RepoGenBaseFolder
        {
            RepoItemInfo _colgjhrperibisrow_zeile_gj_2017_fuer_klickInfo;
            RepoItemInfo _colgjhrperivonkore_zeile_gj_2017Info;
            RepoItemInfo _colgjhrperibiskore_zeile_gj_2017Info;

            /// <summary>
            /// Creates a new Tabelle_530_510  folder.
            /// </summary>
            public Tabelle_530_510Folder(RepoGenBaseFolder parentFolder) :
                    base("Tabelle_530_510", "container/?/element[@controlname='mainGrid']/table[@accessiblename='FlexGrid']", parentFolder, 30000, null, false, "557ac536-9b52-493e-b237-f77cf21f7d40", "")
            {
                _colgjhrperibisrow_zeile_gj_2017_fuer_klickInfo = new RepoItemInfo(this, "ColGjhrPeribisRow_Zeile_GJ_2017_fuer_klick", "row[@accessiblerole='Row' and @accessiblevalue~$Jahr]/cell[@accessiblename~'colGjhr_peribis']", "", 30000, null, "a1fa58ad-eb1b-4589-b4ae-6982db153670");
                _colgjhrperivonkore_zeile_gj_2017Info = new RepoItemInfo(this, "ColGjhrPerivonKore_Zeile_GJ_2017", "row[@accessiblerole='Row' and @accessiblevalue~$Jahr]/cell[@accessiblename~'colGjhr_perivon_kore']", "", 30000, null, "3d3024aa-2fce-4fa7-99ec-c8d162c6cf9d");
                _colgjhrperibiskore_zeile_gj_2017Info = new RepoItemInfo(this, "ColGjhrPeribisKore_Zeile_GJ_2017", "row[@accessiblerole='Row' and @accessiblevalue~$Jahr]/cell[@accessiblename~'colGjhr_peribis_kore']", "", 30000, null, "3d255a0a-f0a4-4906-a0eb-c2111b669f14");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("557ac536-9b52-493e-b237-f77cf21f7d40")]
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
            [RepositoryItemInfo("557ac536-9b52-493e-b237-f77cf21f7d40")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ColGjhrPeribisRow_Zeile_GJ_2017_fuer_klick item.
            /// </summary>
            [RepositoryItem("a1fa58ad-eb1b-4589-b4ae-6982db153670")]
            public virtual Ranorex.Cell ColGjhrPeribisRow_Zeile_GJ_2017_fuer_klick
            {
                get
                {
                    return _colgjhrperibisrow_zeile_gj_2017_fuer_klickInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColGjhrPeribisRow_Zeile_GJ_2017_fuer_klick item info.
            /// </summary>
            [RepositoryItemInfo("a1fa58ad-eb1b-4589-b4ae-6982db153670")]
            public virtual RepoItemInfo ColGjhrPeribisRow_Zeile_GJ_2017_fuer_klickInfo
            {
                get
                {
                    return _colgjhrperibisrow_zeile_gj_2017_fuer_klickInfo;
                }
            }

            /// <summary>
            /// The ColGjhrPerivonKore_Zeile_GJ_2017 item.
            /// </summary>
            [RepositoryItem("3d3024aa-2fce-4fa7-99ec-c8d162c6cf9d")]
            public virtual Ranorex.Cell ColGjhrPerivonKore_Zeile_GJ_2017
            {
                get
                {
                    return _colgjhrperivonkore_zeile_gj_2017Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColGjhrPerivonKore_Zeile_GJ_2017 item info.
            /// </summary>
            [RepositoryItemInfo("3d3024aa-2fce-4fa7-99ec-c8d162c6cf9d")]
            public virtual RepoItemInfo ColGjhrPerivonKore_Zeile_GJ_2017Info
            {
                get
                {
                    return _colgjhrperivonkore_zeile_gj_2017Info;
                }
            }

            /// <summary>
            /// The ColGjhrPeribisKore_Zeile_GJ_2017 item.
            /// </summary>
            [RepositoryItem("3d255a0a-f0a4-4906-a0eb-c2111b669f14")]
            public virtual Ranorex.Cell ColGjhrPeribisKore_Zeile_GJ_2017
            {
                get
                {
                    return _colgjhrperibiskore_zeile_gj_2017Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColGjhrPeribisKore_Zeile_GJ_2017 item info.
            /// </summary>
            [RepositoryItemInfo("3d255a0a-f0a4-4906-a0eb-c2111b669f14")]
            public virtual RepoItemInfo ColGjhrPeribisKore_Zeile_GJ_2017Info
            {
                get
                {
                    return _colgjhrperibiskore_zeile_gj_2017Info;
                }
            }
        }

        /// <summary>
        /// The Tabelle_510Folder folder.
        /// </summary>
        [RepositoryFolder("10d5d570-2662-4de0-9cff-49af75798f5e")]
        public partial class Tabelle_510Folder : RepoGenBaseFolder
        {
            RepoItemInfo _colgjhrperivonkore_zeile_gj_2017Info;
            RepoItemInfo _colgjhrperibiskore_zeile_gj_2017Info;
            RepoItemInfo _colgjhrperibisrow_zeile_gj_2017_fuer_klickInfo;

            /// <summary>
            /// Creates a new Tabelle_510  folder.
            /// </summary>
            public Tabelle_510Folder(RepoGenBaseFolder parentFolder) :
                    base("Tabelle_510", "container[@controlname='ClientArea']/container[@controlname='tblGjhr']/element[@controlname='mainGrid']/table[@accessiblename='FlexGrid']", parentFolder, 30000, null, false, "10d5d570-2662-4de0-9cff-49af75798f5e", "")
            {
                _colgjhrperivonkore_zeile_gj_2017Info = new RepoItemInfo(this, "ColGjhrPerivonKore_Zeile_GJ_2017", "row[@accessiblerole='Row' and @accessiblevalue~$Jahr]/cell[@accessiblename~'colGjhr_perivon_kore']", "", 30000, null, "c03829f6-f66e-4f63-ae3f-a1be4eb87db8");
                _colgjhrperibiskore_zeile_gj_2017Info = new RepoItemInfo(this, "ColGjhrPeribisKore_Zeile_GJ_2017", "row[@accessiblerole='Row' and @accessiblevalue~$Jahr]/cell[@accessiblename~'colGjhr_peribis_kore']", "", 30000, null, "2b2b4a1c-d3d3-4b84-9cca-44bc841148e0");
                _colgjhrperibisrow_zeile_gj_2017_fuer_klickInfo = new RepoItemInfo(this, "ColGjhrPeribisRow_Zeile_GJ_2017_fuer_klick", "row[@accessiblerole='Row' and @accessiblevalue~$Jahr]/cell[@accessiblename~'colGjhr_peribis']", "", 30000, null, "e1f0b71e-7d29-4630-860e-5cc4f7bf699d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("10d5d570-2662-4de0-9cff-49af75798f5e")]
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
            [RepositoryItemInfo("10d5d570-2662-4de0-9cff-49af75798f5e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ColGjhrPerivonKore_Zeile_GJ_2017 item.
            /// </summary>
            [RepositoryItem("c03829f6-f66e-4f63-ae3f-a1be4eb87db8")]
            public virtual Ranorex.Cell ColGjhrPerivonKore_Zeile_GJ_2017
            {
                get
                {
                    return _colgjhrperivonkore_zeile_gj_2017Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColGjhrPerivonKore_Zeile_GJ_2017 item info.
            /// </summary>
            [RepositoryItemInfo("c03829f6-f66e-4f63-ae3f-a1be4eb87db8")]
            public virtual RepoItemInfo ColGjhrPerivonKore_Zeile_GJ_2017Info
            {
                get
                {
                    return _colgjhrperivonkore_zeile_gj_2017Info;
                }
            }

            /// <summary>
            /// The ColGjhrPeribisKore_Zeile_GJ_2017 item.
            /// </summary>
            [RepositoryItem("2b2b4a1c-d3d3-4b84-9cca-44bc841148e0")]
            public virtual Ranorex.Cell ColGjhrPeribisKore_Zeile_GJ_2017
            {
                get
                {
                    return _colgjhrperibiskore_zeile_gj_2017Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColGjhrPeribisKore_Zeile_GJ_2017 item info.
            /// </summary>
            [RepositoryItemInfo("2b2b4a1c-d3d3-4b84-9cca-44bc841148e0")]
            public virtual RepoItemInfo ColGjhrPeribisKore_Zeile_GJ_2017Info
            {
                get
                {
                    return _colgjhrperibiskore_zeile_gj_2017Info;
                }
            }

            /// <summary>
            /// The ColGjhrPeribisRow_Zeile_GJ_2017_fuer_klick item.
            /// </summary>
            [RepositoryItem("e1f0b71e-7d29-4630-860e-5cc4f7bf699d")]
            public virtual Ranorex.Cell ColGjhrPeribisRow_Zeile_GJ_2017_fuer_klick
            {
                get
                {
                    return _colgjhrperibisrow_zeile_gj_2017_fuer_klickInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColGjhrPeribisRow_Zeile_GJ_2017_fuer_klick item info.
            /// </summary>
            [RepositoryItemInfo("e1f0b71e-7d29-4630-860e-5cc4f7bf699d")]
            public virtual RepoItemInfo ColGjhrPeribisRow_Zeile_GJ_2017_fuer_klickInfo
            {
                get
                {
                    return _colgjhrperibisrow_zeile_gj_2017_fuer_klickInfo;
                }
            }
        }

        /// <summary>
        /// The FrmVerbuchAppFolder folder.
        /// </summary>
        [RepositoryFolder("d141d5b7-ae37-4b90-8069-c7e272feeb91")]
        public partial class FrmVerbuchAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100bereichssummierungInfo;
            RepoItemInfo _jahrperiodeInfo;
            RepoItemInfo _textInfo;
            RepoItemInfo _bisInfo;
            RepoItemInfo _text1Info;
            RepoItemInfo _pbokInfo;

            /// <summary>
            /// Creates a new FrmVerbuch  folder.
            /// </summary>
            public FrmVerbuchAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmVerbuch", "/form[@controlname='frmVerbuch']", parentFolder, 30000, null, true, "d141d5b7-ae37-4b90-8069-c7e272feeb91", "")
            {
                _titlebar100bereichssummierungInfo = new RepoItemInfo(this, "TitleBar100BereichsSummierung", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "36b9e32e-dde9-429d-9415-b47f140b7d8c");
                _jahrperiodeInfo = new RepoItemInfo(this, "JahrPeriode", "container[@controlname='ClientArea']/text[@controlname='dfJahrbezP']/text[@accessiblename='Jahr/Periode']", "", 30000, null, "136248d4-6326-4b94-a78a-5962e8bfcfe6");
                _textInfo = new RepoItemInfo(this, "Text", "container[@controlname='ClientArea']/text[@controlname='dfPeriodeVon']/text[@accessiblerole='Text']", "", 30000, null, "90ebbcb5-1ef7-43d6-b78c-51d7001d3b91");
                _bisInfo = new RepoItemInfo(this, "Bis", "container[@controlname='ClientArea']/text[@controlname='dfJahrbezPBis']/text[@accessiblename='bis:']", "", 30000, null, "a663c716-ca68-4152-8cab-38e65f6a1e18");
                _text1Info = new RepoItemInfo(this, "Text1", "container[@controlname='ClientArea']/text[@controlname='dfPeriodeBis']/text[@accessiblerole='Text']", "", 30000, null, "f23aae01-dc83-4695-a453-5c470f66963a");
                _pbokInfo = new RepoItemInfo(this, "PbOK", "container[@controlname='ClientArea']/button[@controlname='pbOK']", "", 30000, null, "830a1c43-7dd7-494d-a9f4-47342f942e3c");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d141d5b7-ae37-4b90-8069-c7e272feeb91")]
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
            [RepositoryItemInfo("d141d5b7-ae37-4b90-8069-c7e272feeb91")]
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
            [RepositoryItem("36b9e32e-dde9-429d-9415-b47f140b7d8c")]
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
            [RepositoryItemInfo("36b9e32e-dde9-429d-9415-b47f140b7d8c")]
            public virtual RepoItemInfo TitleBar100BereichsSummierungInfo
            {
                get
                {
                    return _titlebar100bereichssummierungInfo;
                }
            }

            /// <summary>
            /// The JahrPeriode item.
            /// </summary>
            [RepositoryItem("136248d4-6326-4b94-a78a-5962e8bfcfe6")]
            public virtual Ranorex.Text JahrPeriode
            {
                get
                {
                    return _jahrperiodeInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The JahrPeriode item info.
            /// </summary>
            [RepositoryItemInfo("136248d4-6326-4b94-a78a-5962e8bfcfe6")]
            public virtual RepoItemInfo JahrPeriodeInfo
            {
                get
                {
                    return _jahrperiodeInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("90ebbcb5-1ef7-43d6-b78c-51d7001d3b91")]
            public virtual Ranorex.Text Text
            {
                get
                {
                    return _textInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text item info.
            /// </summary>
            [RepositoryItemInfo("90ebbcb5-1ef7-43d6-b78c-51d7001d3b91")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The Bis item.
            /// </summary>
            [RepositoryItem("a663c716-ca68-4152-8cab-38e65f6a1e18")]
            public virtual Ranorex.Text Bis
            {
                get
                {
                    return _bisInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Bis item info.
            /// </summary>
            [RepositoryItemInfo("a663c716-ca68-4152-8cab-38e65f6a1e18")]
            public virtual RepoItemInfo BisInfo
            {
                get
                {
                    return _bisInfo;
                }
            }

            /// <summary>
            /// The Text1 item.
            /// </summary>
            [RepositoryItem("f23aae01-dc83-4695-a453-5c470f66963a")]
            public virtual Ranorex.Text Text1
            {
                get
                {
                    return _text1Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text1 item info.
            /// </summary>
            [RepositoryItemInfo("f23aae01-dc83-4695-a453-5c470f66963a")]
            public virtual RepoItemInfo Text1Info
            {
                get
                {
                    return _text1Info;
                }
            }

            /// <summary>
            /// The PbOK item.
            /// </summary>
            [RepositoryItem("830a1c43-7dd7-494d-a9f4-47342f942e3c")]
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
            [RepositoryItemInfo("830a1c43-7dd7-494d-a9f4-47342f942e3c")]
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
        [RepositoryFolder("4cb74804-31b3-4240-b03a-c29714546712")]
        public partial class DlgMessageBoxAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _labelmeldungstextInfo;
            RepoItemInfo _button0Info;

            /// <summary>
            /// Creates a new DlgMessageBox  folder.
            /// </summary>
            public DlgMessageBoxAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgMessageBox", "/form[@controlname='dlgMessageBox']", parentFolder, 30000, null, true, "4cb74804-31b3-4240-b03a-c29714546712", "")
            {
                _labelmeldungstextInfo = new RepoItemInfo(this, "LabelMeldungstext", "text[@controlname='labelMeldungstext']", "", 30000, null, "44e7c440-d361-44ff-aaa5-9fa23556c552");
                _button0Info = new RepoItemInfo(this, "Button0", "button[@controlname='button0']", "", 30000, null, "4834afbe-b068-42f7-9635-2c2096618b9b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("4cb74804-31b3-4240-b03a-c29714546712")]
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
            [RepositoryItemInfo("4cb74804-31b3-4240-b03a-c29714546712")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The LabelMeldungstext item.
            /// </summary>
            [RepositoryItem("44e7c440-d361-44ff-aaa5-9fa23556c552")]
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
            [RepositoryItemInfo("44e7c440-d361-44ff-aaa5-9fa23556c552")]
            public virtual RepoItemInfo LabelMeldungstextInfo
            {
                get
                {
                    return _labelmeldungstextInfo;
                }
            }

            /// <summary>
            /// The Button0 item.
            /// </summary>
            [RepositoryItem("4834afbe-b068-42f7-9635-2c2096618b9b")]
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
            [RepositoryItemInfo("4834afbe-b068-42f7-9635-2c2096618b9b")]
            public virtual RepoItemInfo Button0Info
            {
                get
                {
                    return _button0Info;
                }
            }
        }

        /// <summary>
        /// The BJAHRAppFolder folder.
        /// </summary>
        [RepositoryFolder("6a794a9a-8d7f-492f-81ac-f65d15109a0e")]
        public partial class BJAHRAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _loeschenInfo;

            /// <summary>
            /// Creates a new BJAHR  folder.
            /// </summary>
            public BJAHRAppFolder(RepoGenBaseFolder parentFolder) :
                    base("BJAHR", "/contextmenu[@processname='B_JAHR']", parentFolder, 30000, null, true, "6a794a9a-8d7f-492f-81ac-f65d15109a0e", "")
            {
                _loeschenInfo = new RepoItemInfo(this, "Loeschen", "menuitem[@accessiblename='Löschen']", "", 30000, null, "0670e368-6eed-4747-b491-c29a831605e3");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6a794a9a-8d7f-492f-81ac-f65d15109a0e")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("6a794a9a-8d7f-492f-81ac-f65d15109a0e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Loeschen item.
            /// </summary>
            [RepositoryItem("0670e368-6eed-4747-b491-c29a831605e3")]
            public virtual Ranorex.MenuItem Loeschen
            {
                get
                {
                    return _loeschenInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The Loeschen item info.
            /// </summary>
            [RepositoryItemInfo("0670e368-6eed-4747-b491-c29a831605e3")]
            public virtual RepoItemInfo LoeschenInfo
            {
                get
                {
                    return _loeschenInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
