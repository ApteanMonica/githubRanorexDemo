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

namespace L_KMSM_002
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the L_KMSM_002Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("1755dae8-c959-4e6b-a526-b12a669715d4")]
    public partial class L_KMSM_002Repository : RepoGenBaseFolder
    {
        static L_KMSM_002Repository instance = new L_KMSM_002Repository();
        L_KMSM_002RepositoryFolders.TblKMSMAppFolder _tblkmsm;
        L_KMSM_002RepositoryFolders.DlgMessageBoxAppFolder _dlgmessagebox;
        L_KMSM_002RepositoryFolders.TblKMSM1AppFolder _tblkmsm1;
        RepoItemInfo _colkmspmgistrow1Info;

        /// <summary>
        /// Gets the singleton class instance representing the L_KMSM_002Repository element repository.
        /// </summary>
        [RepositoryFolder("1755dae8-c959-4e6b-a526-b12a669715d4")]
        public static L_KMSM_002Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public L_KMSM_002Repository() 
            : base("L_KMSM_002Repository", "/", null, 0, false, "1755dae8-c959-4e6b-a526-b12a669715d4", ".\\RepositoryImages\\L_KMSM_002Repository1755dae8.rximgres")
        {
            _tblkmsm = new L_KMSM_002RepositoryFolders.TblKMSMAppFolder(this);
            _dlgmessagebox = new L_KMSM_002RepositoryFolders.DlgMessageBoxAppFolder(this);
            _tblkmsm1 = new L_KMSM_002RepositoryFolders.TblKMSM1AppFolder(this);
            _colkmspmgistrow1Info = new RepoItemInfo(this, "ColKmspMgistRow1", "/form[@controltypename='tblKMSM']//table/row[@accessiblename='Row 1']/cell[@accessiblename='colKmsp_mgist Row 1']", 30000, null, "a595748f-de0c-4b19-a3ab-d5a95725ffb9");
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("1755dae8-c959-4e6b-a526-b12a669715d4")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ColKmspMgistRow1 item.
        /// </summary>
        [RepositoryItem("a595748f-de0c-4b19-a3ab-d5a95725ffb9")]
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
        [RepositoryItemInfo("a595748f-de0c-4b19-a3ab-d5a95725ffb9")]
        public virtual RepoItemInfo ColKmspMgistRow1Info
        {
            get
            {
                return _colkmspmgistrow1Info;
            }
        }

        /// <summary>
        /// The TblKMSM folder.
        /// </summary>
        [RepositoryFolder("ed401a30-2771-4c54-bf6f-39424824ca14")]
        public virtual L_KMSM_002RepositoryFolders.TblKMSMAppFolder TblKMSM
        {
            get { return _tblkmsm; }
        }

        /// <summary>
        /// The DlgMessageBox folder.
        /// </summary>
        [RepositoryFolder("0c6778c8-c50c-4185-ad8a-00f0e2125a4f")]
        public virtual L_KMSM_002RepositoryFolders.DlgMessageBoxAppFolder DlgMessageBox
        {
            get { return _dlgmessagebox; }
        }

        /// <summary>
        /// The TblKMSM1 folder.
        /// </summary>
        [RepositoryFolder("63afa383-93f6-4c83-9f35-cb15e131ba9f")]
        public virtual L_KMSM_002RepositoryFolders.TblKMSM1AppFolder TblKMSM1
        {
            get { return _tblkmsm1; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class L_KMSM_002RepositoryFolders
    {
        /// <summary>
        /// The TblKMSMAppFolder folder.
        /// </summary>
        [RepositoryFolder("ed401a30-2771-4c54-bf6f-39424824ca14")]
        public partial class TblKMSMAppFolder : RepoGenBaseFolder
        {
            L_KMSM_002RepositoryFolders.FlexGridFolder _flexgrid;
            RepoItemInfo _titlebar100kommissionsscheinemeldunInfo;
            RepoItemInfo _lagerInfo;
            RepoItemInfo _koscheinnrInfo;
            RepoItemInfo _pbextrassplitInfo;
            RepoItemInfo _pbdataaccesssaveInfo;
            RepoItemInfo _sometextInfo;

            /// <summary>
            /// Creates a new TblKMSM  folder.
            /// </summary>
            public TblKMSMAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TblKMSM", "/form[@controlname='tblKMSM']", parentFolder, 30000, null, true, "ed401a30-2771-4c54-bf6f-39424824ca14", "")
            {
                _flexgrid = new L_KMSM_002RepositoryFolders.FlexGridFolder(this);
                _titlebar100kommissionsscheinemeldunInfo = new RepoItemInfo(this, "TitleBar100KommissionsscheineMeldun", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "38f6e109-fa27-4c7d-9b05-2c987af31821");
                _lagerInfo = new RepoItemInfo(this, "Lager", "container[@controlname='ToolBar']//text[@accessiblename='Lager']", "", 30000, null, "ff365648-b360-43d9-a84c-38ee8c526232");
                _koscheinnrInfo = new RepoItemInfo(this, "KoScheinNr", "container[@controlname='ToolBar']//text[@accessiblename='Ko-schein-Nr.']", "", 30000, null, "48af20a6-0b69-4e2c-b854-9a5558d635cc");
                _pbextrassplitInfo = new RepoItemInfo(this, "PbExtrasSplit", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbExtras_Split']", "", 30000, null, "bb14592d-c352-4341-bf77-0b7a5ceb54b1");
                _pbdataaccesssaveInfo = new RepoItemInfo(this, "PbDataAccessSave", "container[@controlname='RibbonBar']/?/?/button[@controlname='pbDataAccess_Save']", "", 30000, null, "151f8562-d7bd-469e-9a96-c13cea5d240f");
                _sometextInfo = new RepoItemInfo(this, "SomeText", "container[@controlname='ChildTableWindow']/?/?/text[@controltypename='']", "", 30000, null, "278817ba-8098-4daf-a989-d7b816a0e17d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ed401a30-2771-4c54-bf6f-39424824ca14")]
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
            [RepositoryItemInfo("ed401a30-2771-4c54-bf6f-39424824ca14")]
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
            [RepositoryItem("38f6e109-fa27-4c7d-9b05-2c987af31821")]
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
            [RepositoryItemInfo("38f6e109-fa27-4c7d-9b05-2c987af31821")]
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
            [RepositoryItem("ff365648-b360-43d9-a84c-38ee8c526232")]
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
            [RepositoryItemInfo("ff365648-b360-43d9-a84c-38ee8c526232")]
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
            [RepositoryItem("48af20a6-0b69-4e2c-b854-9a5558d635cc")]
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
            [RepositoryItemInfo("48af20a6-0b69-4e2c-b854-9a5558d635cc")]
            public virtual RepoItemInfo KoScheinNrInfo
            {
                get
                {
                    return _koscheinnrInfo;
                }
            }

            /// <summary>
            /// The PbExtrasSplit item.
            /// </summary>
            [RepositoryItem("bb14592d-c352-4341-bf77-0b7a5ceb54b1")]
            public virtual Ranorex.Button PbExtrasSplit
            {
                get
                {
                    return _pbextrassplitInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbExtrasSplit item info.
            /// </summary>
            [RepositoryItemInfo("bb14592d-c352-4341-bf77-0b7a5ceb54b1")]
            public virtual RepoItemInfo PbExtrasSplitInfo
            {
                get
                {
                    return _pbextrassplitInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessSave item.
            /// </summary>
            [RepositoryItem("151f8562-d7bd-469e-9a96-c13cea5d240f")]
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
            [RepositoryItemInfo("151f8562-d7bd-469e-9a96-c13cea5d240f")]
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
            [RepositoryItem("278817ba-8098-4daf-a989-d7b816a0e17d")]
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
            [RepositoryItemInfo("278817ba-8098-4daf-a989-d7b816a0e17d")]
            public virtual RepoItemInfo SomeTextInfo
            {
                get
                {
                    return _sometextInfo;
                }
            }

            /// <summary>
            /// The FlexGrid folder.
            /// </summary>
            [RepositoryFolder("6e343ea4-ed60-4a97-ac10-438eb878a073")]
            public virtual L_KMSM_002RepositoryFolders.FlexGridFolder FlexGrid
            {
                get { return _flexgrid; }
            }
        }

        /// <summary>
        /// The FlexGridFolder folder.
        /// </summary>
        [RepositoryFolder("6e343ea4-ed60-4a97-ac10-438eb878a073")]
        public partial class FlexGridFolder : RepoGenBaseFolder
        {
            RepoItemInfo _row1column0Info;
            RepoItemInfo _row3column0Info;
            RepoItemInfo _colkmspmgistrow1Info;
            RepoItemInfo _colkmspmgistrow2Info;
            RepoItemInfo _colzuteilungrow2Info;
            RepoItemInfo _colkmspmgistrow3Info;
            RepoItemInfo _colzuteilungrow4Info;
            RepoItemInfo _colkmspmgistrow4Info;
            RepoItemInfo _row5column0Info;
            RepoItemInfo _colkmspmgistrow5Info;
            RepoItemInfo _colzuteilungrow6Info;
            RepoItemInfo _colkmspmgistrow6Info;
            RepoItemInfo _collgpbchgnrrow4Info;

            /// <summary>
            /// Creates a new FlexGrid  folder.
            /// </summary>
            public FlexGridFolder(RepoGenBaseFolder parentFolder) :
                    base("FlexGrid", "container[@controlname='ChildTableWindow']/?/?/table[@accessiblename='FlexGrid']", parentFolder, 30000, null, false, "6e343ea4-ed60-4a97-ac10-438eb878a073", "")
            {
                _row1column0Info = new RepoItemInfo(this, "Row1Column0", "?/?/cell[@accessiblename='Row 1 Column 0']", "", 30000, null, "eafe51ab-bb68-48ac-8eeb-0df85127172e");
                _row3column0Info = new RepoItemInfo(this, "Row3Column0", "?/?/cell[@accessiblename='Row 3 Column 0']", "", 30000, null, "cee60bdf-5379-4d0a-abe1-f2b8dcda9ab6");
                _colkmspmgistrow1Info = new RepoItemInfo(this, "ColKmspMgistRow1", "?/?/cell[@accessiblename='colKmsp_mgist Row 1']", "", 30000, null, "6541bd71-14b7-424a-8b43-af5da17def57");
                _colkmspmgistrow2Info = new RepoItemInfo(this, "ColKmspMgistRow2", "?/?/cell[@accessiblename='colKmsp_mgist Row 2']", "", 30000, null, "c3af5adb-c635-4d7e-9c9a-05e7485d4ea5");
                _colzuteilungrow2Info = new RepoItemInfo(this, "ColZuteilungRow2", "?/?/cell[@accessiblename='colZuteilung Row 2']", "", 30000, null, "3bfbddbd-bd5e-4bbf-9ef8-fdc81f5c521b");
                _colkmspmgistrow3Info = new RepoItemInfo(this, "ColKmspMgistRow3", "?/?/cell[@accessiblename='colKmsp_mgist Row 3']", "", 30000, null, "ede990c1-0655-4676-8f0a-93c927d9aa08");
                _colzuteilungrow4Info = new RepoItemInfo(this, "ColZuteilungRow4", "?/?/cell[@accessiblename='colZuteilung Row 4']", "", 30000, null, "e0e8fd12-ceaa-4d5f-a89f-5eceab5d9317");
                _colkmspmgistrow4Info = new RepoItemInfo(this, "ColKmspMgistRow4", "?/?/cell[@accessiblename='colKmsp_mgist Row 4']", "", 30000, null, "e9e599d9-8026-4697-b106-3dfef005079a");
                _row5column0Info = new RepoItemInfo(this, "Row5Column0", "?/?/cell[@accessiblename='Row 5 Column 0']", "", 30000, null, "0cb2f4aa-bd32-4009-9246-fa36ea082205");
                _colkmspmgistrow5Info = new RepoItemInfo(this, "ColKmspMgistRow5", "?/?/cell[@accessiblename='colKmsp_mgist Row 5']", "", 30000, null, "98767433-88b6-41b8-9ec9-9cc8a39a56c9");
                _colzuteilungrow6Info = new RepoItemInfo(this, "ColZuteilungRow6", "?/?/cell[@accessiblename='colZuteilung Row 6']", "", 30000, null, "41934213-baed-4924-95cf-c0b1e09b61ef");
                _colkmspmgistrow6Info = new RepoItemInfo(this, "ColKmspMgistRow6", "?/?/cell[@accessiblename='colKmsp_mgist Row 6']", "", 30000, null, "1a1ab205-afb0-4ee5-8acf-13a7b3debb89");
                _collgpbchgnrrow4Info = new RepoItemInfo(this, "ColLgpbChgnrRow4", "?/?/cell[@accessiblename='colLgpb_chgnr Row 4']", "", 30000, null, "144076a3-4da5-40e9-8d5c-050508f78719");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6e343ea4-ed60-4a97-ac10-438eb878a073")]
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
            [RepositoryItemInfo("6e343ea4-ed60-4a97-ac10-438eb878a073")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Row1Column0 item.
            /// </summary>
            [RepositoryItem("eafe51ab-bb68-48ac-8eeb-0df85127172e")]
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
            [RepositoryItemInfo("eafe51ab-bb68-48ac-8eeb-0df85127172e")]
            public virtual RepoItemInfo Row1Column0Info
            {
                get
                {
                    return _row1column0Info;
                }
            }

            /// <summary>
            /// The Row3Column0 item.
            /// </summary>
            [RepositoryItem("cee60bdf-5379-4d0a-abe1-f2b8dcda9ab6")]
            public virtual Ranorex.Cell Row3Column0
            {
                get
                {
                    return _row3column0Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Row3Column0 item info.
            /// </summary>
            [RepositoryItemInfo("cee60bdf-5379-4d0a-abe1-f2b8dcda9ab6")]
            public virtual RepoItemInfo Row3Column0Info
            {
                get
                {
                    return _row3column0Info;
                }
            }

            /// <summary>
            /// The ColKmspMgistRow1 item.
            /// </summary>
            [RepositoryItem("6541bd71-14b7-424a-8b43-af5da17def57")]
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
            [RepositoryItemInfo("6541bd71-14b7-424a-8b43-af5da17def57")]
            public virtual RepoItemInfo ColKmspMgistRow1Info
            {
                get
                {
                    return _colkmspmgistrow1Info;
                }
            }

            /// <summary>
            /// The ColKmspMgistRow2 item.
            /// </summary>
            [RepositoryItem("c3af5adb-c635-4d7e-9c9a-05e7485d4ea5")]
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
            [RepositoryItemInfo("c3af5adb-c635-4d7e-9c9a-05e7485d4ea5")]
            public virtual RepoItemInfo ColKmspMgistRow2Info
            {
                get
                {
                    return _colkmspmgistrow2Info;
                }
            }

            /// <summary>
            /// The ColZuteilungRow2 item.
            /// </summary>
            [RepositoryItem("3bfbddbd-bd5e-4bbf-9ef8-fdc81f5c521b")]
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
            [RepositoryItemInfo("3bfbddbd-bd5e-4bbf-9ef8-fdc81f5c521b")]
            public virtual RepoItemInfo ColZuteilungRow2Info
            {
                get
                {
                    return _colzuteilungrow2Info;
                }
            }

            /// <summary>
            /// The ColKmspMgistRow3 item.
            /// </summary>
            [RepositoryItem("ede990c1-0655-4676-8f0a-93c927d9aa08")]
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
            [RepositoryItemInfo("ede990c1-0655-4676-8f0a-93c927d9aa08")]
            public virtual RepoItemInfo ColKmspMgistRow3Info
            {
                get
                {
                    return _colkmspmgistrow3Info;
                }
            }

            /// <summary>
            /// The ColZuteilungRow4 item.
            /// </summary>
            [RepositoryItem("e0e8fd12-ceaa-4d5f-a89f-5eceab5d9317")]
            public virtual Ranorex.Cell ColZuteilungRow4
            {
                get
                {
                    return _colzuteilungrow4Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColZuteilungRow4 item info.
            /// </summary>
            [RepositoryItemInfo("e0e8fd12-ceaa-4d5f-a89f-5eceab5d9317")]
            public virtual RepoItemInfo ColZuteilungRow4Info
            {
                get
                {
                    return _colzuteilungrow4Info;
                }
            }

            /// <summary>
            /// The ColKmspMgistRow4 item.
            /// </summary>
            [RepositoryItem("e9e599d9-8026-4697-b106-3dfef005079a")]
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
            [RepositoryItemInfo("e9e599d9-8026-4697-b106-3dfef005079a")]
            public virtual RepoItemInfo ColKmspMgistRow4Info
            {
                get
                {
                    return _colkmspmgistrow4Info;
                }
            }

            /// <summary>
            /// The Row5Column0 item.
            /// </summary>
            [RepositoryItem("0cb2f4aa-bd32-4009-9246-fa36ea082205")]
            public virtual Ranorex.Cell Row5Column0
            {
                get
                {
                    return _row5column0Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Row5Column0 item info.
            /// </summary>
            [RepositoryItemInfo("0cb2f4aa-bd32-4009-9246-fa36ea082205")]
            public virtual RepoItemInfo Row5Column0Info
            {
                get
                {
                    return _row5column0Info;
                }
            }

            /// <summary>
            /// The ColKmspMgistRow5 item.
            /// </summary>
            [RepositoryItem("98767433-88b6-41b8-9ec9-9cc8a39a56c9")]
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
            [RepositoryItemInfo("98767433-88b6-41b8-9ec9-9cc8a39a56c9")]
            public virtual RepoItemInfo ColKmspMgistRow5Info
            {
                get
                {
                    return _colkmspmgistrow5Info;
                }
            }

            /// <summary>
            /// The ColZuteilungRow6 item.
            /// </summary>
            [RepositoryItem("41934213-baed-4924-95cf-c0b1e09b61ef")]
            public virtual Ranorex.Cell ColZuteilungRow6
            {
                get
                {
                    return _colzuteilungrow6Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColZuteilungRow6 item info.
            /// </summary>
            [RepositoryItemInfo("41934213-baed-4924-95cf-c0b1e09b61ef")]
            public virtual RepoItemInfo ColZuteilungRow6Info
            {
                get
                {
                    return _colzuteilungrow6Info;
                }
            }

            /// <summary>
            /// The ColKmspMgistRow6 item.
            /// </summary>
            [RepositoryItem("1a1ab205-afb0-4ee5-8acf-13a7b3debb89")]
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
            [RepositoryItemInfo("1a1ab205-afb0-4ee5-8acf-13a7b3debb89")]
            public virtual RepoItemInfo ColKmspMgistRow6Info
            {
                get
                {
                    return _colkmspmgistrow6Info;
                }
            }

            /// <summary>
            /// The ColLgpbChgnrRow4 item.
            /// </summary>
            [RepositoryItem("144076a3-4da5-40e9-8d5c-050508f78719")]
            public virtual Ranorex.Cell ColLgpbChgnrRow4
            {
                get
                {
                    return _collgpbchgnrrow4Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColLgpbChgnrRow4 item info.
            /// </summary>
            [RepositoryItemInfo("144076a3-4da5-40e9-8d5c-050508f78719")]
            public virtual RepoItemInfo ColLgpbChgnrRow4Info
            {
                get
                {
                    return _collgpbchgnrrow4Info;
                }
            }
        }

        /// <summary>
        /// The DlgMessageBoxAppFolder folder.
        /// </summary>
        [RepositoryFolder("0c6778c8-c50c-4185-ad8a-00f0e2125a4f")]
        public partial class DlgMessageBoxAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _button0Info;
            RepoItemInfo _labelmeldungstextInfo;

            /// <summary>
            /// Creates a new DlgMessageBox  folder.
            /// </summary>
            public DlgMessageBoxAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgMessageBox", "/form[@controlname='dlgMessageBox']", parentFolder, 30000, null, true, "0c6778c8-c50c-4185-ad8a-00f0e2125a4f", "")
            {
                _button0Info = new RepoItemInfo(this, "Button0", "button[@controlname='button0']", "", 30000, null, "f6b65027-a147-4a5e-93cc-837e1e9af0fe");
                _labelmeldungstextInfo = new RepoItemInfo(this, "LabelMeldungstext", "text[@controlname='labelMeldungstext']", "", 30000, null, "8f7b4828-34eb-40bd-9079-f1bce4af9271");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("0c6778c8-c50c-4185-ad8a-00f0e2125a4f")]
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
            [RepositoryItemInfo("0c6778c8-c50c-4185-ad8a-00f0e2125a4f")]
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
            [RepositoryItem("f6b65027-a147-4a5e-93cc-837e1e9af0fe")]
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
            [RepositoryItemInfo("f6b65027-a147-4a5e-93cc-837e1e9af0fe")]
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
            [RepositoryItem("8f7b4828-34eb-40bd-9079-f1bce4af9271")]
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
            [RepositoryItemInfo("8f7b4828-34eb-40bd-9079-f1bce4af9271")]
            public virtual RepoItemInfo LabelMeldungstextInfo
            {
                get
                {
                    return _labelmeldungstextInfo;
                }
            }
        }

        /// <summary>
        /// The TblKMSM1AppFolder folder.
        /// </summary>
        [RepositoryFolder("63afa383-93f6-4c83-9f35-cb15e131ba9f")]
        public partial class TblKMSM1AppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new TblKMSM1  folder.
            /// </summary>
            public TblKMSM1AppFolder(RepoGenBaseFolder parentFolder) :
                    base("TblKMSM1", "/form[@controltypename='tblKMSM']", parentFolder, 30000, null, true, "63afa383-93f6-4c83-9f35-cb15e131ba9f", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("63afa383-93f6-4c83-9f35-cb15e131ba9f")]
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
            [RepositoryItemInfo("63afa383-93f6-4c83-9f35-cb15e131ba9f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
