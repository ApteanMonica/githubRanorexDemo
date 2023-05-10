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

namespace K_FIBU_004
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the K_FIBU_004Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("6803c4bc-6c62-44dc-aa40-f07e7b090406")]
    public partial class K_FIBU_004Repository : RepoGenBaseFolder
    {
        static K_FIBU_004Repository instance = new K_FIBU_004Repository();
        K_FIBU_004RepositoryFolders.FrmVerbuchAppFolder _frmverbuch;
        K_FIBU_004RepositoryFolders.DlgMessageBoxAppFolder _dlgmessagebox;
        K_FIBU_004RepositoryFolders.TblIbufeAppFolder _tblibufe;
        K_FIBU_004RepositoryFolders.KIBUFEAppFolder _kibufe;

        /// <summary>
        /// Gets the singleton class instance representing the K_FIBU_004Repository element repository.
        /// </summary>
        [RepositoryFolder("6803c4bc-6c62-44dc-aa40-f07e7b090406")]
        public static K_FIBU_004Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public K_FIBU_004Repository() 
            : base("K_FIBU_004Repository", "/", null, 0, false, "6803c4bc-6c62-44dc-aa40-f07e7b090406", ".\\RepositoryImages\\K_FIBU_004Repository6803c4bc.rximgres")
        {
            _frmverbuch = new K_FIBU_004RepositoryFolders.FrmVerbuchAppFolder(this);
            _dlgmessagebox = new K_FIBU_004RepositoryFolders.DlgMessageBoxAppFolder(this);
            _tblibufe = new K_FIBU_004RepositoryFolders.TblIbufeAppFolder(this);
            _kibufe = new K_FIBU_004RepositoryFolders.KIBUFEAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("6803c4bc-6c62-44dc-aa40-f07e7b090406")]
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
        [RepositoryFolder("a9e9436d-5019-4b94-85c5-c7937a612080")]
        public virtual K_FIBU_004RepositoryFolders.FrmVerbuchAppFolder FrmVerbuch
        {
            get { return _frmverbuch; }
        }

        /// <summary>
        /// The DlgMessageBox folder.
        /// </summary>
        [RepositoryFolder("50ab3b88-675d-42e6-a759-2df150234620")]
        public virtual K_FIBU_004RepositoryFolders.DlgMessageBoxAppFolder DlgMessageBox
        {
            get { return _dlgmessagebox; }
        }

        /// <summary>
        /// The TblIbufe folder.
        /// </summary>
        [RepositoryFolder("84479547-2746-46d9-b865-d831725127b6")]
        public virtual K_FIBU_004RepositoryFolders.TblIbufeAppFolder TblIbufe
        {
            get { return _tblibufe; }
        }

        /// <summary>
        /// The KIBUFE folder.
        /// </summary>
        [RepositoryFolder("b7ef93b6-5c50-4721-83ff-92892e2ed638")]
        public virtual K_FIBU_004RepositoryFolders.KIBUFEAppFolder KIBUFE
        {
            get { return _kibufe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class K_FIBU_004RepositoryFolders
    {
        /// <summary>
        /// The FrmVerbuchAppFolder folder.
        /// </summary>
        [RepositoryFolder("a9e9436d-5019-4b94-85c5-c7937a612080")]
        public partial class FrmVerbuchAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100bereichssummierungInfo;
            RepoItemInfo _jahrperiodeInfo;
            RepoItemInfo _text_von_periodeInfo;
            RepoItemInfo _bis_jahrInfo;
            RepoItemInfo _text_periode_bisInfo;
            RepoItemInfo _pbokInfo;

            /// <summary>
            /// Creates a new FrmVerbuch  folder.
            /// </summary>
            public FrmVerbuchAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmVerbuch", "/form[@controlname='frmVerbuch']", parentFolder, 30000, null, true, "a9e9436d-5019-4b94-85c5-c7937a612080", "")
            {
                _titlebar100bereichssummierungInfo = new RepoItemInfo(this, "TitleBar100BereichsSummierung", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "b9555472-6750-4926-bd84-d5ea02ba4d4c");
                _jahrperiodeInfo = new RepoItemInfo(this, "JahrPeriode", "container[@controlname='ClientArea']/text[@controlname='dfJahrbezP']/text[@accessiblename='Jahr/Periode']", "", 30000, null, "ca36df01-8538-431d-b444-ae497c87aede");
                _text_von_periodeInfo = new RepoItemInfo(this, "Text_von_Periode", "container[@controlname='ClientArea']/text[@controlname='dfPeriodeVon']/text[@accessiblerole='Text']", "", 30000, null, "650560df-3582-48eb-bde8-e919eab8b51f");
                _bis_jahrInfo = new RepoItemInfo(this, "Bis_Jahr", "container[@controlname='ClientArea']/text[@controlname='dfJahrbezPBis']/text[@accessiblename='bis:']", "", 30000, null, "961f2a22-6606-4600-a0f2-edda0781ecd0");
                _text_periode_bisInfo = new RepoItemInfo(this, "Text_Periode_bis", "container[@controlname='ClientArea']/text[@controlname='dfPeriodeBis']/text[@accessiblerole='Text']", "", 30000, null, "0656fb72-0f69-4e9c-8e71-5d1003873f88");
                _pbokInfo = new RepoItemInfo(this, "PbOK", "container[@controlname='ClientArea']/button[@controlname='pbOK']", "", 30000, null, "ebce2b5a-49f5-4db2-ac63-949d28ccaaba");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a9e9436d-5019-4b94-85c5-c7937a612080")]
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
            [RepositoryItemInfo("a9e9436d-5019-4b94-85c5-c7937a612080")]
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
            [RepositoryItem("b9555472-6750-4926-bd84-d5ea02ba4d4c")]
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
            [RepositoryItemInfo("b9555472-6750-4926-bd84-d5ea02ba4d4c")]
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
            [RepositoryItem("ca36df01-8538-431d-b444-ae497c87aede")]
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
            [RepositoryItemInfo("ca36df01-8538-431d-b444-ae497c87aede")]
            public virtual RepoItemInfo JahrPeriodeInfo
            {
                get
                {
                    return _jahrperiodeInfo;
                }
            }

            /// <summary>
            /// The Text_von_Periode item.
            /// </summary>
            [RepositoryItem("650560df-3582-48eb-bde8-e919eab8b51f")]
            public virtual Ranorex.Text Text_von_Periode
            {
                get
                {
                    return _text_von_periodeInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text_von_Periode item info.
            /// </summary>
            [RepositoryItemInfo("650560df-3582-48eb-bde8-e919eab8b51f")]
            public virtual RepoItemInfo Text_von_PeriodeInfo
            {
                get
                {
                    return _text_von_periodeInfo;
                }
            }

            /// <summary>
            /// The Bis_Jahr item.
            /// </summary>
            [RepositoryItem("961f2a22-6606-4600-a0f2-edda0781ecd0")]
            public virtual Ranorex.Text Bis_Jahr
            {
                get
                {
                    return _bis_jahrInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Bis_Jahr item info.
            /// </summary>
            [RepositoryItemInfo("961f2a22-6606-4600-a0f2-edda0781ecd0")]
            public virtual RepoItemInfo Bis_JahrInfo
            {
                get
                {
                    return _bis_jahrInfo;
                }
            }

            /// <summary>
            /// The Text_Periode_bis item.
            /// </summary>
            [RepositoryItem("0656fb72-0f69-4e9c-8e71-5d1003873f88")]
            public virtual Ranorex.Text Text_Periode_bis
            {
                get
                {
                    return _text_periode_bisInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text_Periode_bis item info.
            /// </summary>
            [RepositoryItemInfo("0656fb72-0f69-4e9c-8e71-5d1003873f88")]
            public virtual RepoItemInfo Text_Periode_bisInfo
            {
                get
                {
                    return _text_periode_bisInfo;
                }
            }

            /// <summary>
            /// The PbOK item.
            /// </summary>
            [RepositoryItem("ebce2b5a-49f5-4db2-ac63-949d28ccaaba")]
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
            [RepositoryItemInfo("ebce2b5a-49f5-4db2-ac63-949d28ccaaba")]
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
        [RepositoryFolder("50ab3b88-675d-42e6-a759-2df150234620")]
        public partial class DlgMessageBoxAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _labelmeldungstextInfo;
            RepoItemInfo _button0Info;

            /// <summary>
            /// Creates a new DlgMessageBox  folder.
            /// </summary>
            public DlgMessageBoxAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgMessageBox", "/form[@controlname='dlgMessageBox']", parentFolder, 30000, null, true, "50ab3b88-675d-42e6-a759-2df150234620", "")
            {
                _labelmeldungstextInfo = new RepoItemInfo(this, "LabelMeldungstext", "text[@controlname='labelMeldungstext']", "", 30000, null, "7fe5d026-d2a3-42d3-b63e-31777644f0b0");
                _button0Info = new RepoItemInfo(this, "Button0", "button[@controlname='button0']", "", 30000, null, "97000250-9d48-4d14-a09a-16bdb90191e5");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("50ab3b88-675d-42e6-a759-2df150234620")]
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
            [RepositoryItemInfo("50ab3b88-675d-42e6-a759-2df150234620")]
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
            [RepositoryItem("7fe5d026-d2a3-42d3-b63e-31777644f0b0")]
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
            [RepositoryItemInfo("7fe5d026-d2a3-42d3-b63e-31777644f0b0")]
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
            [RepositoryItem("97000250-9d48-4d14-a09a-16bdb90191e5")]
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
            [RepositoryItemInfo("97000250-9d48-4d14-a09a-16bdb90191e5")]
            public virtual RepoItemInfo Button0Info
            {
                get
                {
                    return _button0Info;
                }
            }
        }

        /// <summary>
        /// The TblIbufeAppFolder folder.
        /// </summary>
        [RepositoryFolder("84479547-2746-46d9-b865-d831725127b6")]
        public partial class TblIbufeAppFolder : RepoGenBaseFolder
        {
            K_FIBU_004RepositoryFolders.ToolBarFolder _toolbar;
            K_FIBU_004RepositoryFolders.FlexGridFolder _flexgrid;
            RepoItemInfo _titlebar100korebuchungenanzeigenInfo;
            RepoItemInfo _pbdataaccessladenInfo;
            RepoItemInfo _pbkontenkontenInfo;
            RepoItemInfo _colbetragrow0Info;
            RepoItemInfo _colkontorow0Info;

            /// <summary>
            /// Creates a new TblIbufe  folder.
            /// </summary>
            public TblIbufeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TblIbufe", "/form[@controlname='tblIbufe']", parentFolder, 30000, null, true, "84479547-2746-46d9-b865-d831725127b6", "")
            {
                _toolbar = new K_FIBU_004RepositoryFolders.ToolBarFolder(this);
                _flexgrid = new K_FIBU_004RepositoryFolders.FlexGridFolder(this);
                _titlebar100korebuchungenanzeigenInfo = new RepoItemInfo(this, "TitleBar100KOREBuchungenAnzeigen", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "50a91432-7788-4d2a-a7a6-383136916763");
                _pbdataaccessladenInfo = new RepoItemInfo(this, "PbDataAccessLaden", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbDataAccess_Laden']", "", 30000, null, "8ed7544b-e8ef-4a18-9d79-766a98f64f13");
                _pbkontenkontenInfo = new RepoItemInfo(this, "PbKontenKonten", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbKonten_Konten']", "", 30000, null, "76395ca9-102d-4b93-92e9-fdd07568c80b");
                _colbetragrow0Info = new RepoItemInfo(this, "ColBetragRow0", "container[@controlname='ChildTableWindow']/element[@controlname='splitGrid']/table[@accessiblename='FlexGrid']/?/?/cell[@accessiblename='colBetrag Row 0']", "", 30000, null, "d364f43f-7e6b-4390-997b-82f3b40df458");
                _colkontorow0Info = new RepoItemInfo(this, "ColKontoRow0", "container[@controlname='ChildTableWindow']/element[@controlname='splitGrid']/table[@accessiblename='FlexGrid']/?/?/cell[@accessiblename='colKonto Row 0']", "", 30000, null, "ed17413d-f54b-4dd4-8e77-e10682982e95");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("84479547-2746-46d9-b865-d831725127b6")]
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
            [RepositoryItemInfo("84479547-2746-46d9-b865-d831725127b6")]
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
            [RepositoryItem("50a91432-7788-4d2a-a7a6-383136916763")]
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
            [RepositoryItemInfo("50a91432-7788-4d2a-a7a6-383136916763")]
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
            [RepositoryItem("8ed7544b-e8ef-4a18-9d79-766a98f64f13")]
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
            [RepositoryItemInfo("8ed7544b-e8ef-4a18-9d79-766a98f64f13")]
            public virtual RepoItemInfo PbDataAccessLadenInfo
            {
                get
                {
                    return _pbdataaccessladenInfo;
                }
            }

            /// <summary>
            /// The PbKontenKonten item.
            /// </summary>
            [RepositoryItem("76395ca9-102d-4b93-92e9-fdd07568c80b")]
            public virtual Ranorex.Button PbKontenKonten
            {
                get
                {
                    return _pbkontenkontenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbKontenKonten item info.
            /// </summary>
            [RepositoryItemInfo("76395ca9-102d-4b93-92e9-fdd07568c80b")]
            public virtual RepoItemInfo PbKontenKontenInfo
            {
                get
                {
                    return _pbkontenkontenInfo;
                }
            }

            /// <summary>
            /// The ColBetragRow0 item.
            /// </summary>
            [RepositoryItem("d364f43f-7e6b-4390-997b-82f3b40df458")]
            public virtual Ranorex.Cell ColBetragRow0
            {
                get
                {
                    return _colbetragrow0Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColBetragRow0 item info.
            /// </summary>
            [RepositoryItemInfo("d364f43f-7e6b-4390-997b-82f3b40df458")]
            public virtual RepoItemInfo ColBetragRow0Info
            {
                get
                {
                    return _colbetragrow0Info;
                }
            }

            /// <summary>
            /// The ColKontoRow0 item.
            /// </summary>
            [RepositoryItem("ed17413d-f54b-4dd4-8e77-e10682982e95")]
            public virtual Ranorex.Cell ColKontoRow0
            {
                get
                {
                    return _colkontorow0Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColKontoRow0 item info.
            /// </summary>
            [RepositoryItemInfo("ed17413d-f54b-4dd4-8e77-e10682982e95")]
            public virtual RepoItemInfo ColKontoRow0Info
            {
                get
                {
                    return _colkontorow0Info;
                }
            }

            /// <summary>
            /// The ToolBar folder.
            /// </summary>
            [RepositoryFolder("fd3f5e8a-abb3-471c-848e-67268d7d090f")]
            public virtual K_FIBU_004RepositoryFolders.ToolBarFolder ToolBar
            {
                get { return _toolbar; }
            }

            /// <summary>
            /// The FlexGrid folder.
            /// </summary>
            [RepositoryFolder("9a914dbe-72fc-4963-a01c-0f9ad42f6522")]
            public virtual K_FIBU_004RepositoryFolders.FlexGridFolder FlexGrid
            {
                get { return _flexgrid; }
            }
        }

        /// <summary>
        /// The ToolBarFolder folder.
        /// </summary>
        [RepositoryFolder("fd3f5e8a-abb3-471c-848e-67268d7d090f")]
        public partial class ToolBarFolder : RepoGenBaseFolder
        {
            RepoItemInfo _periodevonInfo;
            RepoItemInfo _text1Info;
            RepoItemInfo _textInfo;
            RepoItemInfo _textbisInfo;

            /// <summary>
            /// Creates a new ToolBar  folder.
            /// </summary>
            public ToolBarFolder(RepoGenBaseFolder parentFolder) :
                    base("ToolBar", "container[@controlname='ToolBar']", parentFolder, 30000, null, false, "fd3f5e8a-abb3-471c-848e-67268d7d090f", "")
            {
                _periodevonInfo = new RepoItemInfo(this, "PeriodeVon", "?/?/text[@accessiblename='Periode von']", "", 30000, null, "09f947dd-98a2-4eca-88db-7296df0f388a");
                _text1Info = new RepoItemInfo(this, "Text1", "text[@controlname='dfJahrB']/text[@accessiblerole='Text']", "", 30000, null, "6608d195-cdf3-4c38-a8c1-86799d0845ef");
                _textInfo = new RepoItemInfo(this, "Text", "text[@controlname='dfPeriodeV']/text[@accessiblerole='Text']", "", 30000, null, "3fc61cff-77f4-493c-b21e-9a0340ba1215");
                _textbisInfo = new RepoItemInfo(this, "TextBis", "text[@controlname='dfPeriodeB']/text[@accessiblename='bis']", "", 30000, null, "c847ba05-cacc-43b4-a9ca-f10536b92a07");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("fd3f5e8a-abb3-471c-848e-67268d7d090f")]
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
            [RepositoryItemInfo("fd3f5e8a-abb3-471c-848e-67268d7d090f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The PeriodeVon item.
            /// </summary>
            [RepositoryItem("09f947dd-98a2-4eca-88db-7296df0f388a")]
            public virtual Ranorex.Text PeriodeVon
            {
                get
                {
                    return _periodevonInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The PeriodeVon item info.
            /// </summary>
            [RepositoryItemInfo("09f947dd-98a2-4eca-88db-7296df0f388a")]
            public virtual RepoItemInfo PeriodeVonInfo
            {
                get
                {
                    return _periodevonInfo;
                }
            }

            /// <summary>
            /// The Text1 item.
            /// </summary>
            [RepositoryItem("6608d195-cdf3-4c38-a8c1-86799d0845ef")]
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
            [RepositoryItemInfo("6608d195-cdf3-4c38-a8c1-86799d0845ef")]
            public virtual RepoItemInfo Text1Info
            {
                get
                {
                    return _text1Info;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("3fc61cff-77f4-493c-b21e-9a0340ba1215")]
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
            [RepositoryItemInfo("3fc61cff-77f4-493c-b21e-9a0340ba1215")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The TextBis item.
            /// </summary>
            [RepositoryItem("c847ba05-cacc-43b4-a9ca-f10536b92a07")]
            public virtual Ranorex.Text TextBis
            {
                get
                {
                    return _textbisInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TextBis item info.
            /// </summary>
            [RepositoryItemInfo("c847ba05-cacc-43b4-a9ca-f10536b92a07")]
            public virtual RepoItemInfo TextBisInfo
            {
                get
                {
                    return _textbisInfo;
                }
            }
        }

        /// <summary>
        /// The FlexGridFolder folder.
        /// </summary>
        [RepositoryFolder("9a914dbe-72fc-4963-a01c-0f9ad42f6522")]
        public partial class FlexGridFolder : RepoGenBaseFolder
        {
            RepoItemInfo _colbetragrow1Info;
            RepoItemInfo _colbetragrow2Info;
            RepoItemInfo _colbetragrow3Info;
            RepoItemInfo _colbetragrow4Info;
            RepoItemInfo _colbetragrow6Info;
            RepoItemInfo _colbetragrow5Info;
            RepoItemInfo _colbetragrow7Info;
            RepoItemInfo _colibudtaendgrow1Info;
            RepoItemInfo _colibudtaendgrow7Info;

            /// <summary>
            /// Creates a new FlexGrid  folder.
            /// </summary>
            public FlexGridFolder(RepoGenBaseFolder parentFolder) :
                    base("FlexGrid", "container[@controlname='ChildTableWindow']/?/?/table[@accessiblename='FlexGrid']", parentFolder, 30000, null, false, "9a914dbe-72fc-4963-a01c-0f9ad42f6522", "")
            {
                _colbetragrow1Info = new RepoItemInfo(this, "ColBetragRow1", "?/?/cell[@accessiblename='colBetrag Row 1']", "", 30000, null, "a0e46a6c-5b73-4186-be23-fab31de06d76");
                _colbetragrow2Info = new RepoItemInfo(this, "ColBetragRow2", "?/?/cell[@accessiblename='colBetrag Row 2']", "", 30000, null, "61dd30f4-d11e-4fcb-9e55-df2ff7232674");
                _colbetragrow3Info = new RepoItemInfo(this, "ColBetragRow3", "?/?/cell[@accessiblename='colBetrag Row 3']", "", 30000, null, "d69ece63-bed2-4ed2-b4e1-2a8da8492161");
                _colbetragrow4Info = new RepoItemInfo(this, "ColBetragRow4", "?/?/cell[@accessiblename='colBetrag Row 4']", "", 30000, null, "11d06918-d59e-4c00-9350-178aca69caeb");
                _colbetragrow6Info = new RepoItemInfo(this, "ColBetragRow6", "?/?/cell[@accessiblename='colBetrag Row 6']", "", 30000, null, "c18d5930-fd10-42bb-a3a2-ce53f884d63c");
                _colbetragrow5Info = new RepoItemInfo(this, "ColBetragRow5", "?/?/cell[@accessiblename='colBetrag Row 5']", "", 30000, null, "b132db3e-639e-4dcd-b35e-6886d2075011");
                _colbetragrow7Info = new RepoItemInfo(this, "ColBetragRow7", "?/?/cell[@accessiblename='colBetrag Row 7']", "", 30000, null, "daa36fc3-f418-42f3-8100-009787c03098");
                _colibudtaendgrow1Info = new RepoItemInfo(this, "ColIbuDtaendgRow1", "?/?/cell[@accessiblename='colIbu_dtaendg Row 1']", "", 30000, null, "59d1b534-3c25-4626-bba5-32c1fcd73000");
                _colibudtaendgrow7Info = new RepoItemInfo(this, "ColIbuDtaendgRow7", "?/?/cell[@accessiblename='colIbu_dtaendg Row 7']", "", 30000, null, "b3a729d4-3e0e-47b0-a526-6e2698b94d9b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9a914dbe-72fc-4963-a01c-0f9ad42f6522")]
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
            [RepositoryItemInfo("9a914dbe-72fc-4963-a01c-0f9ad42f6522")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ColBetragRow1 item.
            /// </summary>
            [RepositoryItem("a0e46a6c-5b73-4186-be23-fab31de06d76")]
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
            [RepositoryItemInfo("a0e46a6c-5b73-4186-be23-fab31de06d76")]
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
            [RepositoryItem("61dd30f4-d11e-4fcb-9e55-df2ff7232674")]
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
            [RepositoryItemInfo("61dd30f4-d11e-4fcb-9e55-df2ff7232674")]
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
            [RepositoryItem("d69ece63-bed2-4ed2-b4e1-2a8da8492161")]
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
            [RepositoryItemInfo("d69ece63-bed2-4ed2-b4e1-2a8da8492161")]
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
            [RepositoryItem("11d06918-d59e-4c00-9350-178aca69caeb")]
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
            [RepositoryItemInfo("11d06918-d59e-4c00-9350-178aca69caeb")]
            public virtual RepoItemInfo ColBetragRow4Info
            {
                get
                {
                    return _colbetragrow4Info;
                }
            }

            /// <summary>
            /// The ColBetragRow6 item.
            /// </summary>
            [RepositoryItem("c18d5930-fd10-42bb-a3a2-ce53f884d63c")]
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
            [RepositoryItemInfo("c18d5930-fd10-42bb-a3a2-ce53f884d63c")]
            public virtual RepoItemInfo ColBetragRow6Info
            {
                get
                {
                    return _colbetragrow6Info;
                }
            }

            /// <summary>
            /// The ColBetragRow5 item.
            /// </summary>
            [RepositoryItem("b132db3e-639e-4dcd-b35e-6886d2075011")]
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
            [RepositoryItemInfo("b132db3e-639e-4dcd-b35e-6886d2075011")]
            public virtual RepoItemInfo ColBetragRow5Info
            {
                get
                {
                    return _colbetragrow5Info;
                }
            }

            /// <summary>
            /// The ColBetragRow7 item.
            /// </summary>
            [RepositoryItem("daa36fc3-f418-42f3-8100-009787c03098")]
            public virtual Ranorex.Cell ColBetragRow7
            {
                get
                {
                    return _colbetragrow7Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColBetragRow7 item info.
            /// </summary>
            [RepositoryItemInfo("daa36fc3-f418-42f3-8100-009787c03098")]
            public virtual RepoItemInfo ColBetragRow7Info
            {
                get
                {
                    return _colbetragrow7Info;
                }
            }

            /// <summary>
            /// The ColIbuDtaendgRow1 item.
            /// </summary>
            [RepositoryItem("59d1b534-3c25-4626-bba5-32c1fcd73000")]
            public virtual Ranorex.Cell ColIbuDtaendgRow1
            {
                get
                {
                    return _colibudtaendgrow1Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColIbuDtaendgRow1 item info.
            /// </summary>
            [RepositoryItemInfo("59d1b534-3c25-4626-bba5-32c1fcd73000")]
            public virtual RepoItemInfo ColIbuDtaendgRow1Info
            {
                get
                {
                    return _colibudtaendgrow1Info;
                }
            }

            /// <summary>
            /// The ColIbuDtaendgRow7 item.
            /// </summary>
            [RepositoryItem("b3a729d4-3e0e-47b0-a526-6e2698b94d9b")]
            public virtual Ranorex.Cell ColIbuDtaendgRow7
            {
                get
                {
                    return _colibudtaendgrow7Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColIbuDtaendgRow7 item info.
            /// </summary>
            [RepositoryItemInfo("b3a729d4-3e0e-47b0-a526-6e2698b94d9b")]
            public virtual RepoItemInfo ColIbuDtaendgRow7Info
            {
                get
                {
                    return _colibudtaendgrow7Info;
                }
            }
        }

        /// <summary>
        /// The KIBUFEAppFolder folder.
        /// </summary>
        [RepositoryFolder("b7ef93b6-5c50-4721-83ff-92892e2ed638")]
        public partial class KIBUFEAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _bestandskontenInfo;

            /// <summary>
            /// Creates a new KIBUFE  folder.
            /// </summary>
            public KIBUFEAppFolder(RepoGenBaseFolder parentFolder) :
                    base("KIBUFE", "/contextmenu[@processname='K_IBUFE']", parentFolder, 30000, null, true, "b7ef93b6-5c50-4721-83ff-92892e2ed638", "")
            {
                _bestandskontenInfo = new RepoItemInfo(this, "Bestandskonten", "menuitem[@accessiblename='Bestandskonten']", "", 30000, null, "3257f6aa-8c10-4b9e-9837-3ab7b6e171ce");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b7ef93b6-5c50-4721-83ff-92892e2ed638")]
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
            [RepositoryItemInfo("b7ef93b6-5c50-4721-83ff-92892e2ed638")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Bestandskonten item.
            /// </summary>
            [RepositoryItem("3257f6aa-8c10-4b9e-9837-3ab7b6e171ce")]
            public virtual Ranorex.MenuItem Bestandskonten
            {
                get
                {
                    return _bestandskontenInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The Bestandskonten item info.
            /// </summary>
            [RepositoryItemInfo("3257f6aa-8c10-4b9e-9837-3ab7b6e171ce")]
            public virtual RepoItemInfo BestandskontenInfo
            {
                get
                {
                    return _bestandskontenInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
