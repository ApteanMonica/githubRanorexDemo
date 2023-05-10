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

namespace L_KMSM_001
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the L_KMSM_001Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("4100728c-c131-47fd-86a5-9c82d7525f11")]
    public partial class L_KMSM_001Repository : RepoGenBaseFolder
    {
        static L_KMSM_001Repository instance = new L_KMSM_001Repository();
        L_KMSM_001RepositoryFolders.TblKMSMAppFolder _tblkmsm;
        L_KMSM_001RepositoryFolders.LKMSMAppFolder _lkmsm;
        L_KMSM_001RepositoryFolders.DlgMessageBoxAppFolder _dlgmessagebox;
        L_KMSM_001RepositoryFolders.DlgListBoxAppFolder _dlglistbox;

        /// <summary>
        /// Gets the singleton class instance representing the L_KMSM_001Repository element repository.
        /// </summary>
        [RepositoryFolder("4100728c-c131-47fd-86a5-9c82d7525f11")]
        public static L_KMSM_001Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public L_KMSM_001Repository() 
            : base("L_KMSM_001Repository", "/", null, 0, false, "4100728c-c131-47fd-86a5-9c82d7525f11", ".\\RepositoryImages\\L_KMSM_001Repository4100728c.rximgres")
        {
            _tblkmsm = new L_KMSM_001RepositoryFolders.TblKMSMAppFolder(this);
            _lkmsm = new L_KMSM_001RepositoryFolders.LKMSMAppFolder(this);
            _dlgmessagebox = new L_KMSM_001RepositoryFolders.DlgMessageBoxAppFolder(this);
            _dlglistbox = new L_KMSM_001RepositoryFolders.DlgListBoxAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("4100728c-c131-47fd-86a5-9c82d7525f11")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The TblKMSM folder.
        /// </summary>
        [RepositoryFolder("eb4accc2-1f5c-4843-aae3-db4e999d9221")]
        public virtual L_KMSM_001RepositoryFolders.TblKMSMAppFolder TblKMSM
        {
            get { return _tblkmsm; }
        }

        /// <summary>
        /// The LKMSM folder.
        /// </summary>
        [RepositoryFolder("c202582f-b6b4-45b5-82c2-e1f16212f46f")]
        public virtual L_KMSM_001RepositoryFolders.LKMSMAppFolder LKMSM
        {
            get { return _lkmsm; }
        }

        /// <summary>
        /// The DlgMessageBox folder.
        /// </summary>
        [RepositoryFolder("b705d0c2-95df-481c-bb48-e0fc6a3bc214")]
        public virtual L_KMSM_001RepositoryFolders.DlgMessageBoxAppFolder DlgMessageBox
        {
            get { return _dlgmessagebox; }
        }

        /// <summary>
        /// The DlgListBox folder.
        /// </summary>
        [RepositoryFolder("b2bbad00-05e6-4de2-bb6e-574d9cedc4bf")]
        public virtual L_KMSM_001RepositoryFolders.DlgListBoxAppFolder DlgListBox
        {
            get { return _dlglistbox; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class L_KMSM_001RepositoryFolders
    {
        /// <summary>
        /// The TblKMSMAppFolder folder.
        /// </summary>
        [RepositoryFolder("eb4accc2-1f5c-4843-aae3-db4e999d9221")]
        public partial class TblKMSMAppFolder : RepoGenBaseFolder
        {
            L_KMSM_001RepositoryFolders.FlexGridFolder _flexgrid;
            RepoItemInfo _titlebar100kommissionsscheinemeldunInfo;
            RepoItemInfo _lagerInfo;
            RepoItemInfo _koscheinnrInfo;
            RepoItemInfo _cbstrukturInfo;
            RepoItemInfo _ldatumInfo;
            RepoItemInfo _pbcommonalle0Info;
            RepoItemInfo _pbdataaccesszwischenspeichernInfo;
            RepoItemInfo _colkmspmgistrow1Info;
            RepoItemInfo _pbcommonalleokInfo;
            RepoItemInfo _pbdataaccesssaveInfo;
            RepoItemInfo _sometextInfo;
            RepoItemInfo _statusInfo;

            /// <summary>
            /// Creates a new TblKMSM  folder.
            /// </summary>
            public TblKMSMAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TblKMSM", "/form[@controlname='tblKMSM']", parentFolder, 30000, null, true, "eb4accc2-1f5c-4843-aae3-db4e999d9221", "")
            {
                _flexgrid = new L_KMSM_001RepositoryFolders.FlexGridFolder(this);
                _titlebar100kommissionsscheinemeldunInfo = new RepoItemInfo(this, "TitleBar100KommissionsscheineMeldun", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "3db3a627-2537-4392-92d5-ae89f05d6537");
                _lagerInfo = new RepoItemInfo(this, "Lager", "container[@controlname='ToolBar']//text[@accessiblename='Lager']", "", 30000, null, "f42eb10d-1fa5-484e-aba8-14bd7755add0");
                _koscheinnrInfo = new RepoItemInfo(this, "KoScheinNr", "container[@controlname='ToolBar']//text[@accessiblename='Ko-schein-Nr.']", "", 30000, null, "8404d211-d5aa-41df-89ff-39f1cb331cf7");
                _cbstrukturInfo = new RepoItemInfo(this, "CbStruktur", "container[@controlname='ToolBar']/?/?/checkbox[@controlname='cbStruktur']", "", 30000, null, "a5eabb8e-6078-4bc0-b0f1-b0c5719ddeaf");
                _ldatumInfo = new RepoItemInfo(this, "LDatum", "container[@controlname='ToolBar']//text[@accessiblename='L-Datum:']", "", 30000, null, "287d1833-910c-4dde-8223-29e74f7fb345");
                _pbcommonalle0Info = new RepoItemInfo(this, "PbCommonAlle0", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbCommon_Alle0']", "", 30000, null, "d68c565b-5c68-4d60-b9a6-6abe27a79689");
                _pbdataaccesszwischenspeichernInfo = new RepoItemInfo(this, "PbDataAccessZwischenspeichern", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbDataAccess_Zwischenspeichern']", "", 30000, null, "7118e675-49bc-4a65-98e3-750d14e2b854");
                _colkmspmgistrow1Info = new RepoItemInfo(this, "ColKmspMgistRow1", "container[@controlname='ChildTableWindow']/?/?/table[@accessiblename='FlexGrid']/?/?/cell[@accessiblename='colKmsp_mgist Row 1']", "", 30000, null, "623b3e4a-6933-4944-a8c4-850fa49ee329");
                _pbcommonalleokInfo = new RepoItemInfo(this, "PbCommonAlleOk", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbCommon_AlleOk']", "", 30000, null, "ae731253-e414-4948-8a93-e1dda03decad");
                _pbdataaccesssaveInfo = new RepoItemInfo(this, "PbDataAccessSave", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbDataAccess_Save']", "", 30000, null, "970bab24-33e1-407c-959b-f8d5b90a4ffa");
                _sometextInfo = new RepoItemInfo(this, "SomeText", "container[@controlname='ChildTableWindow']/?/?/text[@controltypename='']", "", 30000, null, "df746f10-d395-4d20-b537-17563a5c3998");
                _statusInfo = new RepoItemInfo(this, "Status", "container[@controlname='ToolBar']/?/?/text[@controlname='dfKmsk_status']", "", 30000, null, "accdabe3-c090-404d-86e9-aff2c4c97485");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("eb4accc2-1f5c-4843-aae3-db4e999d9221")]
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
            [RepositoryItemInfo("eb4accc2-1f5c-4843-aae3-db4e999d9221")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100KommissionsscheineMeldun item.
            /// </summary>
            [RepositoryItem("3db3a627-2537-4392-92d5-ae89f05d6537")]
            public virtual Ranorex.TitleBar TitleBar100KommissionsscheineMeldun
            {
                get
                {
                    return _titlebar100kommissionsscheinemeldunInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100KommissionsscheineMeldun item info.
            /// </summary>
            [RepositoryItemInfo("3db3a627-2537-4392-92d5-ae89f05d6537")]
            public virtual RepoItemInfo TitleBar100KommissionsscheineMeldunInfo
            {
                get
                {
                    return _titlebar100kommissionsscheinemeldunInfo;
                }
            }

            /// <summary>
            /// The Lager item.
            /// </summary>
            [RepositoryItem("f42eb10d-1fa5-484e-aba8-14bd7755add0")]
            public virtual Ranorex.Text Lager
            {
                get
                {
                    return _lagerInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Lager item info.
            /// </summary>
            [RepositoryItemInfo("f42eb10d-1fa5-484e-aba8-14bd7755add0")]
            public virtual RepoItemInfo LagerInfo
            {
                get
                {
                    return _lagerInfo;
                }
            }

            /// <summary>
            /// The KoScheinNr item.
            /// </summary>
            [RepositoryItem("8404d211-d5aa-41df-89ff-39f1cb331cf7")]
            public virtual Ranorex.Text KoScheinNr
            {
                get
                {
                    return _koscheinnrInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The KoScheinNr item info.
            /// </summary>
            [RepositoryItemInfo("8404d211-d5aa-41df-89ff-39f1cb331cf7")]
            public virtual RepoItemInfo KoScheinNrInfo
            {
                get
                {
                    return _koscheinnrInfo;
                }
            }

            /// <summary>
            /// The CbStruktur item.
            /// </summary>
            [RepositoryItem("a5eabb8e-6078-4bc0-b0f1-b0c5719ddeaf")]
            public virtual Ranorex.CheckBox CbStruktur
            {
                get
                {
                    return _cbstrukturInfo.CreateAdapter<Ranorex.CheckBox>(true);
                }
            }

            /// <summary>
            /// The CbStruktur item info.
            /// </summary>
            [RepositoryItemInfo("a5eabb8e-6078-4bc0-b0f1-b0c5719ddeaf")]
            public virtual RepoItemInfo CbStrukturInfo
            {
                get
                {
                    return _cbstrukturInfo;
                }
            }

            /// <summary>
            /// The LDatum item.
            /// </summary>
            [RepositoryItem("287d1833-910c-4dde-8223-29e74f7fb345")]
            public virtual Ranorex.Text LDatum
            {
                get
                {
                    return _ldatumInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LDatum item info.
            /// </summary>
            [RepositoryItemInfo("287d1833-910c-4dde-8223-29e74f7fb345")]
            public virtual RepoItemInfo LDatumInfo
            {
                get
                {
                    return _ldatumInfo;
                }
            }

            /// <summary>
            /// The PbCommonAlle0 item.
            /// </summary>
            [RepositoryItem("d68c565b-5c68-4d60-b9a6-6abe27a79689")]
            public virtual Ranorex.Button PbCommonAlle0
            {
                get
                {
                    return _pbcommonalle0Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbCommonAlle0 item info.
            /// </summary>
            [RepositoryItemInfo("d68c565b-5c68-4d60-b9a6-6abe27a79689")]
            public virtual RepoItemInfo PbCommonAlle0Info
            {
                get
                {
                    return _pbcommonalle0Info;
                }
            }

            /// <summary>
            /// The PbDataAccessZwischenspeichern item.
            /// </summary>
            [RepositoryItem("7118e675-49bc-4a65-98e3-750d14e2b854")]
            public virtual Ranorex.Button PbDataAccessZwischenspeichern
            {
                get
                {
                    return _pbdataaccesszwischenspeichernInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbDataAccessZwischenspeichern item info.
            /// </summary>
            [RepositoryItemInfo("7118e675-49bc-4a65-98e3-750d14e2b854")]
            public virtual RepoItemInfo PbDataAccessZwischenspeichernInfo
            {
                get
                {
                    return _pbdataaccesszwischenspeichernInfo;
                }
            }

            /// <summary>
            /// The ColKmspMgistRow1 item.
            /// </summary>
            [RepositoryItem("623b3e4a-6933-4944-a8c4-850fa49ee329")]
            public virtual Ranorex.Cell ColKmspMgistRow1
            {
                get
                {
                    return _colkmspmgistrow1Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColKmspMgistRow1 item info.
            /// </summary>
            [RepositoryItemInfo("623b3e4a-6933-4944-a8c4-850fa49ee329")]
            public virtual RepoItemInfo ColKmspMgistRow1Info
            {
                get
                {
                    return _colkmspmgistrow1Info;
                }
            }

            /// <summary>
            /// The PbCommonAlleOk item.
            /// </summary>
            [RepositoryItem("ae731253-e414-4948-8a93-e1dda03decad")]
            public virtual Ranorex.Button PbCommonAlleOk
            {
                get
                {
                    return _pbcommonalleokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbCommonAlleOk item info.
            /// </summary>
            [RepositoryItemInfo("ae731253-e414-4948-8a93-e1dda03decad")]
            public virtual RepoItemInfo PbCommonAlleOkInfo
            {
                get
                {
                    return _pbcommonalleokInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessSave item.
            /// </summary>
            [RepositoryItem("970bab24-33e1-407c-959b-f8d5b90a4ffa")]
            public virtual Ranorex.Button PbDataAccessSave
            {
                get
                {
                    return _pbdataaccesssaveInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbDataAccessSave item info.
            /// </summary>
            [RepositoryItemInfo("970bab24-33e1-407c-959b-f8d5b90a4ffa")]
            public virtual RepoItemInfo PbDataAccessSaveInfo
            {
                get
                {
                    return _pbdataaccesssaveInfo;
                }
            }

            /// <summary>
            /// The SomeText item.
            /// </summary>
            [RepositoryItem("df746f10-d395-4d20-b537-17563a5c3998")]
            public virtual Ranorex.Text SomeText
            {
                get
                {
                    return _sometextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The SomeText item info.
            /// </summary>
            [RepositoryItemInfo("df746f10-d395-4d20-b537-17563a5c3998")]
            public virtual RepoItemInfo SomeTextInfo
            {
                get
                {
                    return _sometextInfo;
                }
            }

            /// <summary>
            /// The Status item.
            /// </summary>
            [RepositoryItem("accdabe3-c090-404d-86e9-aff2c4c97485")]
            public virtual Ranorex.Text Status
            {
                get
                {
                    return _statusInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Status item info.
            /// </summary>
            [RepositoryItemInfo("accdabe3-c090-404d-86e9-aff2c4c97485")]
            public virtual RepoItemInfo StatusInfo
            {
                get
                {
                    return _statusInfo;
                }
            }

            /// <summary>
            /// The FlexGrid folder.
            /// </summary>
            [RepositoryFolder("6c04c8f3-28cf-4ee8-ab5a-1c9456eee972")]
            public virtual L_KMSM_001RepositoryFolders.FlexGridFolder FlexGrid
            {
                get { return _flexgrid; }
            }
        }

        /// <summary>
        /// The FlexGridFolder folder.
        /// </summary>
        [RepositoryFolder("6c04c8f3-28cf-4ee8-ab5a-1c9456eee972")]
        public partial class FlexGridFolder : RepoGenBaseFolder
        {
            RepoItemInfo _colkmspmgistrow2Info;
            RepoItemInfo _colkmspmgistrow3Info;
            RepoItemInfo _colkmspmgistrow4Info;
            RepoItemInfo _colkmspmgistrow5Info;
            RepoItemInfo _colkmspmgistrow6Info;
            RepoItemInfo _colkmspmgistrow7Info;
            RepoItemInfo _colzuteilungrow2Info;
            RepoItemInfo _collgpbchgnrrow6Info;
            RepoItemInfo _collgpbchgnrrow5Info;
            RepoItemInfo _collgpbchgnrrow12Info;

            /// <summary>
            /// Creates a new FlexGrid  folder.
            /// </summary>
            public FlexGridFolder(RepoGenBaseFolder parentFolder) :
                    base("FlexGrid", "container[@controlname='ChildTableWindow']/?/?/table[@accessiblename='FlexGrid']", parentFolder, 30000, null, false, "6c04c8f3-28cf-4ee8-ab5a-1c9456eee972", "")
            {
                _colkmspmgistrow2Info = new RepoItemInfo(this, "ColKmspMgistRow2", "?/?/cell[@accessiblename='colKmsp_mgist Row 2']", "", 30000, null, "90ab2fe9-e52c-4da6-b047-0bccef41371b");
                _colkmspmgistrow3Info = new RepoItemInfo(this, "ColKmspMgistRow3", "?/?/cell[@accessiblename='colKmsp_mgist Row 3']", "", 30000, null, "a26cb9ac-f6b3-47c2-9af1-050065ca4958");
                _colkmspmgistrow4Info = new RepoItemInfo(this, "ColKmspMgistRow4", "?/?/cell[@accessiblename='colKmsp_mgist Row 4']", "", 30000, null, "55addab5-6e41-4be7-b7a1-6c872a3c3863");
                _colkmspmgistrow5Info = new RepoItemInfo(this, "ColKmspMgistRow5", "?/?/cell[@accessiblename='colKmsp_mgist Row 5']", "", 30000, null, "22056a50-d6ca-4707-963b-1956917cb7b0");
                _colkmspmgistrow6Info = new RepoItemInfo(this, "ColKmspMgistRow6", "?/?/cell[@accessiblename='colKmsp_mgist Row 6']", "", 30000, null, "de3a1a72-85de-4919-b982-26aa43c4c6f3");
                _colkmspmgistrow7Info = new RepoItemInfo(this, "ColKmspMgistRow7", "?/?/cell[@accessiblename='colKmsp_mgist Row 7']", "", 30000, null, "5a1f775e-33f2-42b8-9e6c-2352b374c93e");
                _colzuteilungrow2Info = new RepoItemInfo(this, "ColZuteilungRow2", "?/?/cell[@accessiblename='colZuteilung Row 2']", "", 30000, null, "70cf2418-c0a1-4476-ba9b-462f45cd6472");
                _collgpbchgnrrow6Info = new RepoItemInfo(this, "ColLgpbChgnrRow6", "?/?/cell[@accessiblename='colLgpb_chgnr Row 6']", "", 30000, null, "c6426479-d585-40d9-87e2-0b6afb64f1dd");
                _collgpbchgnrrow5Info = new RepoItemInfo(this, "ColLgpbChgnrRow5", "?/?/cell[@accessiblename='colLgpb_chgnr Row 5']", "", 30000, null, "a38761b5-f394-463f-9c4e-025ee6d94ac4");
                _collgpbchgnrrow12Info = new RepoItemInfo(this, "ColLgpbChgnrRow12", "?/?/cell[@accessiblename='colLgpb_chgnr Row 12']", "", 30000, null, "ca56d392-bd29-44be-ad35-dd3d9acbc555");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6c04c8f3-28cf-4ee8-ab5a-1c9456eee972")]
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
            [RepositoryItemInfo("6c04c8f3-28cf-4ee8-ab5a-1c9456eee972")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ColKmspMgistRow2 item.
            /// </summary>
            [RepositoryItem("90ab2fe9-e52c-4da6-b047-0bccef41371b")]
            public virtual Ranorex.Cell ColKmspMgistRow2
            {
                get
                {
                    return _colkmspmgistrow2Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColKmspMgistRow2 item info.
            /// </summary>
            [RepositoryItemInfo("90ab2fe9-e52c-4da6-b047-0bccef41371b")]
            public virtual RepoItemInfo ColKmspMgistRow2Info
            {
                get
                {
                    return _colkmspmgistrow2Info;
                }
            }

            /// <summary>
            /// The ColKmspMgistRow3 item.
            /// </summary>
            [RepositoryItem("a26cb9ac-f6b3-47c2-9af1-050065ca4958")]
            public virtual Ranorex.Cell ColKmspMgistRow3
            {
                get
                {
                    return _colkmspmgistrow3Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColKmspMgistRow3 item info.
            /// </summary>
            [RepositoryItemInfo("a26cb9ac-f6b3-47c2-9af1-050065ca4958")]
            public virtual RepoItemInfo ColKmspMgistRow3Info
            {
                get
                {
                    return _colkmspmgistrow3Info;
                }
            }

            /// <summary>
            /// The ColKmspMgistRow4 item.
            /// </summary>
            [RepositoryItem("55addab5-6e41-4be7-b7a1-6c872a3c3863")]
            public virtual Ranorex.Cell ColKmspMgistRow4
            {
                get
                {
                    return _colkmspmgistrow4Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColKmspMgistRow4 item info.
            /// </summary>
            [RepositoryItemInfo("55addab5-6e41-4be7-b7a1-6c872a3c3863")]
            public virtual RepoItemInfo ColKmspMgistRow4Info
            {
                get
                {
                    return _colkmspmgistrow4Info;
                }
            }

            /// <summary>
            /// The ColKmspMgistRow5 item.
            /// </summary>
            [RepositoryItem("22056a50-d6ca-4707-963b-1956917cb7b0")]
            public virtual Ranorex.Cell ColKmspMgistRow5
            {
                get
                {
                    return _colkmspmgistrow5Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColKmspMgistRow5 item info.
            /// </summary>
            [RepositoryItemInfo("22056a50-d6ca-4707-963b-1956917cb7b0")]
            public virtual RepoItemInfo ColKmspMgistRow5Info
            {
                get
                {
                    return _colkmspmgistrow5Info;
                }
            }

            /// <summary>
            /// The ColKmspMgistRow6 item.
            /// </summary>
            [RepositoryItem("de3a1a72-85de-4919-b982-26aa43c4c6f3")]
            public virtual Ranorex.Cell ColKmspMgistRow6
            {
                get
                {
                    return _colkmspmgistrow6Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColKmspMgistRow6 item info.
            /// </summary>
            [RepositoryItemInfo("de3a1a72-85de-4919-b982-26aa43c4c6f3")]
            public virtual RepoItemInfo ColKmspMgistRow6Info
            {
                get
                {
                    return _colkmspmgistrow6Info;
                }
            }

            /// <summary>
            /// The ColKmspMgistRow7 item.
            /// </summary>
            [RepositoryItem("5a1f775e-33f2-42b8-9e6c-2352b374c93e")]
            public virtual Ranorex.Cell ColKmspMgistRow7
            {
                get
                {
                    return _colkmspmgistrow7Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColKmspMgistRow7 item info.
            /// </summary>
            [RepositoryItemInfo("5a1f775e-33f2-42b8-9e6c-2352b374c93e")]
            public virtual RepoItemInfo ColKmspMgistRow7Info
            {
                get
                {
                    return _colkmspmgistrow7Info;
                }
            }

            /// <summary>
            /// The ColZuteilungRow2 item.
            /// </summary>
            [RepositoryItem("70cf2418-c0a1-4476-ba9b-462f45cd6472")]
            public virtual Ranorex.Cell ColZuteilungRow2
            {
                get
                {
                    return _colzuteilungrow2Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColZuteilungRow2 item info.
            /// </summary>
            [RepositoryItemInfo("70cf2418-c0a1-4476-ba9b-462f45cd6472")]
            public virtual RepoItemInfo ColZuteilungRow2Info
            {
                get
                {
                    return _colzuteilungrow2Info;
                }
            }

            /// <summary>
            /// The ColLgpbChgnrRow6 item.
            /// </summary>
            [RepositoryItem("c6426479-d585-40d9-87e2-0b6afb64f1dd")]
            public virtual Ranorex.Cell ColLgpbChgnrRow6
            {
                get
                {
                    return _collgpbchgnrrow6Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColLgpbChgnrRow6 item info.
            /// </summary>
            [RepositoryItemInfo("c6426479-d585-40d9-87e2-0b6afb64f1dd")]
            public virtual RepoItemInfo ColLgpbChgnrRow6Info
            {
                get
                {
                    return _collgpbchgnrrow6Info;
                }
            }

            /// <summary>
            /// The ColLgpbChgnrRow5 item.
            /// </summary>
            [RepositoryItem("a38761b5-f394-463f-9c4e-025ee6d94ac4")]
            public virtual Ranorex.Cell ColLgpbChgnrRow5
            {
                get
                {
                    return _collgpbchgnrrow5Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColLgpbChgnrRow5 item info.
            /// </summary>
            [RepositoryItemInfo("a38761b5-f394-463f-9c4e-025ee6d94ac4")]
            public virtual RepoItemInfo ColLgpbChgnrRow5Info
            {
                get
                {
                    return _collgpbchgnrrow5Info;
                }
            }

            /// <summary>
            /// The ColLgpbChgnrRow12 item.
            /// </summary>
            [RepositoryItem("ca56d392-bd29-44be-ad35-dd3d9acbc555")]
            public virtual Ranorex.Cell ColLgpbChgnrRow12
            {
                get
                {
                    return _collgpbchgnrrow12Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColLgpbChgnrRow12 item info.
            /// </summary>
            [RepositoryItemInfo("ca56d392-bd29-44be-ad35-dd3d9acbc555")]
            public virtual RepoItemInfo ColLgpbChgnrRow12Info
            {
                get
                {
                    return _collgpbchgnrrow12Info;
                }
            }
        }

        /// <summary>
        /// The LKMSMAppFolder folder.
        /// </summary>
        [RepositoryFolder("c202582f-b6b4-45b5-82c2-e1f16212f46f")]
        public partial class LKMSMAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _dropdownInfo;

            /// <summary>
            /// Creates a new LKMSM  folder.
            /// </summary>
            public LKMSMAppFolder(RepoGenBaseFolder parentFolder) :
                    base("LKMSM", "/toolbar[@processname='L_KMSM']", parentFolder, 30000, null, true, "c202582f-b6b4-45b5-82c2-e1f16212f46f", "")
            {
                _dropdownInfo = new RepoItemInfo(this, "DropDown", "contextmenu[@accessiblename='DropDown']", "", 30000, null, "8722eae1-4cf3-4a45-a2ff-535080cbc728");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c202582f-b6b4-45b5-82c2-e1f16212f46f")]
            public virtual Ranorex.ToolBar Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ToolBar>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c202582f-b6b4-45b5-82c2-e1f16212f46f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The DropDown item.
            /// </summary>
            [RepositoryItem("8722eae1-4cf3-4a45-a2ff-535080cbc728")]
            public virtual Ranorex.ContextMenu DropDown
            {
                get
                {
                    return _dropdownInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The DropDown item info.
            /// </summary>
            [RepositoryItemInfo("8722eae1-4cf3-4a45-a2ff-535080cbc728")]
            public virtual RepoItemInfo DropDownInfo
            {
                get
                {
                    return _dropdownInfo;
                }
            }
        }

        /// <summary>
        /// The DlgMessageBoxAppFolder folder.
        /// </summary>
        [RepositoryFolder("b705d0c2-95df-481c-bb48-e0fc6a3bc214")]
        public partial class DlgMessageBoxAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _labelmeldungstextInfo;
            RepoItemInfo _button0Info;

            /// <summary>
            /// Creates a new DlgMessageBox  folder.
            /// </summary>
            public DlgMessageBoxAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgMessageBox", "/form[@controlname='dlgMessageBox']", parentFolder, 30000, null, true, "b705d0c2-95df-481c-bb48-e0fc6a3bc214", "")
            {
                _labelmeldungstextInfo = new RepoItemInfo(this, "LabelMeldungstext", "text[@controlname='labelMeldungstext']", "", 30000, null, "88ae541e-787a-4ee2-9fac-adfa14303ed0");
                _button0Info = new RepoItemInfo(this, "Button0", "button[@controlname='button0']", "", 30000, null, "cdfe5b99-66fb-4f61-b6ec-0fb8781c78f9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b705d0c2-95df-481c-bb48-e0fc6a3bc214")]
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
            [RepositoryItemInfo("b705d0c2-95df-481c-bb48-e0fc6a3bc214")]
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
            [RepositoryItem("88ae541e-787a-4ee2-9fac-adfa14303ed0")]
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
            [RepositoryItemInfo("88ae541e-787a-4ee2-9fac-adfa14303ed0")]
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
            [RepositoryItem("cdfe5b99-66fb-4f61-b6ec-0fb8781c78f9")]
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
            [RepositoryItemInfo("cdfe5b99-66fb-4f61-b6ec-0fb8781c78f9")]
            public virtual RepoItemInfo Button0Info
            {
                get
                {
                    return _button0Info;
                }
            }
        }

        /// <summary>
        /// The DlgListBoxAppFolder folder.
        /// </summary>
        [RepositoryFolder("b2bbad00-05e6-4de2-bb6e-574d9cedc4bf")]
        public partial class DlgListBoxAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _celltmpcols9row1Info;
            RepoItemInfo _row1column0Info;

            /// <summary>
            /// Creates a new DlgListBox  folder.
            /// </summary>
            public DlgListBoxAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgListBox", "/form[@controlname='dlgListBox']", parentFolder, 30000, null, true, "b2bbad00-05e6-4de2-bb6e-574d9cedc4bf", "")
            {
                _celltmpcols9row1Info = new RepoItemInfo(this, "CellTmpColS9Row1", "container[@controlname='panelEins']//table[@accessiblename='FlexGrid']/?/?/cell[@accessiblename='__tmp__colS9 Row 1']", "", 30000, null, "6fe98d74-2c9a-4288-a66b-7385a54cddd1");
                _row1column0Info = new RepoItemInfo(this, "Row1Column0", "container[@controlname='panelAuswahl']//table[@accessiblename='FlexGrid']/?/?/cell[@accessiblename='Row 1 Column 0']", "", 30000, null, "8dd21223-d575-4eb2-a4a7-d9d6939a92b2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b2bbad00-05e6-4de2-bb6e-574d9cedc4bf")]
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
            [RepositoryItemInfo("b2bbad00-05e6-4de2-bb6e-574d9cedc4bf")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The CellTmpColS9Row1 item.
            /// </summary>
            [RepositoryItem("6fe98d74-2c9a-4288-a66b-7385a54cddd1")]
            public virtual Ranorex.Cell CellTmpColS9Row1
            {
                get
                {
                    return _celltmpcols9row1Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellTmpColS9Row1 item info.
            /// </summary>
            [RepositoryItemInfo("6fe98d74-2c9a-4288-a66b-7385a54cddd1")]
            public virtual RepoItemInfo CellTmpColS9Row1Info
            {
                get
                {
                    return _celltmpcols9row1Info;
                }
            }

            /// <summary>
            /// The Row1Column0 item.
            /// </summary>
            [RepositoryItem("8dd21223-d575-4eb2-a4a7-d9d6939a92b2")]
            public virtual Ranorex.Cell Row1Column0
            {
                get
                {
                    return _row1column0Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Row1Column0 item info.
            /// </summary>
            [RepositoryItemInfo("8dd21223-d575-4eb2-a4a7-d9d6939a92b2")]
            public virtual RepoItemInfo Row1Column0Info
            {
                get
                {
                    return _row1column0Info;
                }
            }
        }

    }
#pragma warning restore 0436
}
