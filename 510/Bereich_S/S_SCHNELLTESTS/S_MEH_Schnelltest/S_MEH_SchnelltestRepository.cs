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

namespace S_MEH_Schnelltest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the S_MEH_SchnelltestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("25a2ac80-2911-4586-9921-609076cb31ac")]
    public partial class S_MEH_SchnelltestRepository : RepoGenBaseFolder
    {
        static S_MEH_SchnelltestRepository instance = new S_MEH_SchnelltestRepository();
        S_MEH_SchnelltestRepositoryFolders.TblMehAppFolder _tblmeh;

        /// <summary>
        /// Gets the singleton class instance representing the S_MEH_SchnelltestRepository element repository.
        /// </summary>
        [RepositoryFolder("25a2ac80-2911-4586-9921-609076cb31ac")]
        public static S_MEH_SchnelltestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public S_MEH_SchnelltestRepository() 
            : base("S_MEH_SchnelltestRepository", "/", null, 0, false, "25a2ac80-2911-4586-9921-609076cb31ac", ".\\RepositoryImages\\S_MEH_SchnelltestRepository25a2ac80.rximgres")
        {
            _tblmeh = new S_MEH_SchnelltestRepositoryFolders.TblMehAppFolder(this);
        }

#region Variables

        string _Mengeneinheit_CD_Neu = "XX";

        /// <summary>
        /// Gets or sets the value of variable Mengeneinheit_CD_Neu.
        /// </summary>
        [TestVariable("7c504ea6-c758-4215-8ca4-331ce4746b1d")]
        public string Mengeneinheit_CD_Neu
        {
            get { return _Mengeneinheit_CD_Neu; }
            set { _Mengeneinheit_CD_Neu = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("25a2ac80-2911-4586-9921-609076cb31ac")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The TblMeh folder.
        /// </summary>
        [RepositoryFolder("dccaa056-cd37-4da0-87ec-7015a24ad150")]
        public virtual S_MEH_SchnelltestRepositoryFolders.TblMehAppFolder TblMeh
        {
            get { return _tblmeh; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class S_MEH_SchnelltestRepositoryFolders
    {
        /// <summary>
        /// The TblMehAppFolder folder.
        /// </summary>
        [RepositoryFolder("dccaa056-cd37-4da0-87ec-7015a24ad150")]
        public partial class TblMehAppFolder : RepoGenBaseFolder
        {
            S_MEH_SchnelltestRepositoryFolders.RibbonBarFolder _ribbonbar;
            S_MEH_SchnelltestRepositoryFolders.FlexGridFolder _flexgrid;
            RepoItemInfo _titlebar100verwaltungmengeneinheiInfo;

            /// <summary>
            /// Creates a new TblMeh  folder.
            /// </summary>
            public TblMehAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TblMeh", "/form[@controlname='tblMeh']", parentFolder, 30000, null, true, "dccaa056-cd37-4da0-87ec-7015a24ad150", "")
            {
                _ribbonbar = new S_MEH_SchnelltestRepositoryFolders.RibbonBarFolder(this);
                _flexgrid = new S_MEH_SchnelltestRepositoryFolders.FlexGridFolder(this);
                _titlebar100verwaltungmengeneinheiInfo = new RepoItemInfo(this, "TitleBar100VerwaltungMengeneinhei", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "330d8911-6182-48ed-9840-4526e46e71da");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("dccaa056-cd37-4da0-87ec-7015a24ad150")]
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
            [RepositoryItemInfo("dccaa056-cd37-4da0-87ec-7015a24ad150")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100VerwaltungMengeneinhei item.
            /// </summary>
            [RepositoryItem("330d8911-6182-48ed-9840-4526e46e71da")]
            public virtual Ranorex.TitleBar TitleBar100VerwaltungMengeneinhei
            {
                get
                {
                    return _titlebar100verwaltungmengeneinheiInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100VerwaltungMengeneinhei item info.
            /// </summary>
            [RepositoryItemInfo("330d8911-6182-48ed-9840-4526e46e71da")]
            public virtual RepoItemInfo TitleBar100VerwaltungMengeneinheiInfo
            {
                get
                {
                    return _titlebar100verwaltungmengeneinheiInfo;
                }
            }

            /// <summary>
            /// The RibbonBar folder.
            /// </summary>
            [RepositoryFolder("a486d104-8a46-4054-aa30-3d166f61b0c0")]
            public virtual S_MEH_SchnelltestRepositoryFolders.RibbonBarFolder RibbonBar
            {
                get { return _ribbonbar; }
            }

            /// <summary>
            /// The FlexGrid folder.
            /// </summary>
            [RepositoryFolder("6c51f207-27be-4176-b911-a0fa927680eb")]
            public virtual S_MEH_SchnelltestRepositoryFolders.FlexGridFolder FlexGrid
            {
                get { return _flexgrid; }
            }
        }

        /// <summary>
        /// The RibbonBarFolder folder.
        /// </summary>
        [RepositoryFolder("a486d104-8a46-4054-aa30-3d166f61b0c0")]
        public partial class RibbonBarFolder : RepoGenBaseFolder
        {
            RepoItemInfo _pbdataaccessnewInfo;
            RepoItemInfo _pbdataaccesssaveInfo;
            RepoItemInfo _pbdataaccessloadInfo;

            /// <summary>
            /// Creates a new RibbonBar  folder.
            /// </summary>
            public RibbonBarFolder(RepoGenBaseFolder parentFolder) :
                    base("RibbonBar", "container[@controlname='RibbonBar']", parentFolder, 30000, null, false, "a486d104-8a46-4054-aa30-3d166f61b0c0", "")
            {
                _pbdataaccessnewInfo = new RepoItemInfo(this, "PbDataAccessNew", "container[@controlname='DataAccessGroup']/button[@controlname='pbDataAccess_New']", "", 30000, null, "fd9335e8-824b-46d5-8d80-6c20936356e2");
                _pbdataaccesssaveInfo = new RepoItemInfo(this, "PbDataAccessSave", "container[@controlname='DataAccessGroup']/button[@controlname='pbDataAccess_Save']", "", 30000, null, "e9606d12-071a-478a-b34a-0844e5a62e2c");
                _pbdataaccessloadInfo = new RepoItemInfo(this, "PbDataAccessLoad", "container[@controlname='DataAccessGroup']/button[@controlname='pbDataAccess_Load']", "", 30000, null, "cc3dfec0-28fc-4687-882f-930a5c34dd04");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a486d104-8a46-4054-aa30-3d166f61b0c0")]
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
            [RepositoryItemInfo("a486d104-8a46-4054-aa30-3d166f61b0c0")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessNew item.
            /// </summary>
            [RepositoryItem("fd9335e8-824b-46d5-8d80-6c20936356e2")]
            public virtual Ranorex.Button PbDataAccessNew
            {
                get
                {
                    return _pbdataaccessnewInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbDataAccessNew item info.
            /// </summary>
            [RepositoryItemInfo("fd9335e8-824b-46d5-8d80-6c20936356e2")]
            public virtual RepoItemInfo PbDataAccessNewInfo
            {
                get
                {
                    return _pbdataaccessnewInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessSave item.
            /// </summary>
            [RepositoryItem("e9606d12-071a-478a-b34a-0844e5a62e2c")]
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
            [RepositoryItemInfo("e9606d12-071a-478a-b34a-0844e5a62e2c")]
            public virtual RepoItemInfo PbDataAccessSaveInfo
            {
                get
                {
                    return _pbdataaccesssaveInfo;
                }
            }

            /// <summary>
            /// The PbDataAccessLoad item.
            /// </summary>
            [RepositoryItem("cc3dfec0-28fc-4687-882f-930a5c34dd04")]
            public virtual Ranorex.Button PbDataAccessLoad
            {
                get
                {
                    return _pbdataaccessloadInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbDataAccessLoad item info.
            /// </summary>
            [RepositoryItemInfo("cc3dfec0-28fc-4687-882f-930a5c34dd04")]
            public virtual RepoItemInfo PbDataAccessLoadInfo
            {
                get
                {
                    return _pbdataaccessloadInfo;
                }
            }
        }

        /// <summary>
        /// The FlexGridFolder folder.
        /// </summary>
        [RepositoryFolder("6c51f207-27be-4176-b911-a0fa927680eb")]
        public partial class FlexGridFolder : RepoGenBaseFolder
        {
            S_MEH_SchnelltestRepositoryFolders.Row_mit_Variable_Mengeneinheit_CD_NeuFolder _row_mit_variable_mengeneinheit_cd_neu;
            RepoItemInfo _row22column0Info;

            /// <summary>
            /// Creates a new FlexGrid  folder.
            /// </summary>
            public FlexGridFolder(RepoGenBaseFolder parentFolder) :
                    base("FlexGrid", "container[@controlname='ChildTableWindow']/element[@controlname='mainGrid']/table[@accessiblename='FlexGrid']", parentFolder, 30000, null, false, "6c51f207-27be-4176-b911-a0fa927680eb", "")
            {
                _row_mit_variable_mengeneinheit_cd_neu = new S_MEH_SchnelltestRepositoryFolders.Row_mit_Variable_Mengeneinheit_CD_NeuFolder(this);
                _row22column0Info = new RepoItemInfo(this, "Row22Column0", "row[@accessiblename='Row 22']/cell[@accessiblename='Row 22 Column 0']", "", 30000, null, "e28a73af-17e2-434a-a9f7-731a9352ffbb");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6c51f207-27be-4176-b911-a0fa927680eb")]
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
            [RepositoryItemInfo("6c51f207-27be-4176-b911-a0fa927680eb")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Row22Column0 item.
            /// </summary>
            [RepositoryItem("e28a73af-17e2-434a-a9f7-731a9352ffbb")]
            public virtual Ranorex.Cell Row22Column0
            {
                get
                {
                    return _row22column0Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Row22Column0 item info.
            /// </summary>
            [RepositoryItemInfo("e28a73af-17e2-434a-a9f7-731a9352ffbb")]
            public virtual RepoItemInfo Row22Column0Info
            {
                get
                {
                    return _row22column0Info;
                }
            }

            /// <summary>
            /// The Row_mit_Variable_Mengeneinheit_CD_Neu folder.
            /// </summary>
            [RepositoryFolder("5e903758-483a-4d81-aa4e-7375ebd54d88")]
            public virtual S_MEH_SchnelltestRepositoryFolders.Row_mit_Variable_Mengeneinheit_CD_NeuFolder Row_mit_Variable_Mengeneinheit_CD_Neu
            {
                get { return _row_mit_variable_mengeneinheit_cd_neu; }
            }
        }

        /// <summary>
        /// The Row_mit_Variable_Mengeneinheit_CD_NeuFolder folder.
        /// </summary>
        [RepositoryFolder("5e903758-483a-4d81-aa4e-7375ebd54d88")]
        public partial class Row_mit_Variable_Mengeneinheit_CD_NeuFolder : RepoGenBaseFolder
        {
            RepoItemInfo _colmehcdInfo;
            RepoItemInfo _colmehbezInfo;
            RepoItemInfo _colmehz_checkbox_zeit_ehInfo;
            RepoItemInfo _colmehfaktorInfo;

            /// <summary>
            /// Creates a new Row_mit_Variable_Mengeneinheit_CD_Neu  folder.
            /// </summary>
            public Row_mit_Variable_Mengeneinheit_CD_NeuFolder(RepoGenBaseFolder parentFolder) :
                    base("Row_mit_Variable_Mengeneinheit_CD_Neu", "row[@accessiblerole='Row' and @accessiblevalue~$Mengeneinheit_CD_Neu]", parentFolder, 30000, null, false, "5e903758-483a-4d81-aa4e-7375ebd54d88", "")
            {
                _colmehcdInfo = new RepoItemInfo(this, "ColMehCd", "cell[@accessiblename~'colMeh_cd']", "", 30000, null, "dc5951f2-9622-47ba-aaf7-787d11568666");
                _colmehbezInfo = new RepoItemInfo(this, "ColMehBez", "cell[@accessiblename~'colMeh_bez']", "", 30000, null, "23460dde-4820-45d3-bf09-2e3daf22e629");
                _colmehz_checkbox_zeit_ehInfo = new RepoItemInfo(this, "ColMehZ_Checkbox_Zeit_EH", "cell[@accessiblename~'colMeh_z Row']", "", 30000, null, "e79d6c3e-3c9e-49dc-bc26-d50918f05904");
                _colmehfaktorInfo = new RepoItemInfo(this, "ColMehFaktor", "cell[@accessiblename~'colMeh_faktor']", "", 30000, null, "c990860f-4887-46fa-8d97-223b7cb65f81");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5e903758-483a-4d81-aa4e-7375ebd54d88")]
            public virtual Ranorex.Row Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Row>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5e903758-483a-4d81-aa4e-7375ebd54d88")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ColMehCd item.
            /// </summary>
            [RepositoryItem("dc5951f2-9622-47ba-aaf7-787d11568666")]
            public virtual Ranorex.Cell ColMehCd
            {
                get
                {
                    return _colmehcdInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColMehCd item info.
            /// </summary>
            [RepositoryItemInfo("dc5951f2-9622-47ba-aaf7-787d11568666")]
            public virtual RepoItemInfo ColMehCdInfo
            {
                get
                {
                    return _colmehcdInfo;
                }
            }

            /// <summary>
            /// The ColMehBez item.
            /// </summary>
            [RepositoryItem("23460dde-4820-45d3-bf09-2e3daf22e629")]
            public virtual Ranorex.Cell ColMehBez
            {
                get
                {
                    return _colmehbezInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColMehBez item info.
            /// </summary>
            [RepositoryItemInfo("23460dde-4820-45d3-bf09-2e3daf22e629")]
            public virtual RepoItemInfo ColMehBezInfo
            {
                get
                {
                    return _colmehbezInfo;
                }
            }

            /// <summary>
            /// The ColMehZ_Checkbox_Zeit_EH item.
            /// </summary>
            [RepositoryItem("e79d6c3e-3c9e-49dc-bc26-d50918f05904")]
            public virtual Ranorex.Cell ColMehZ_Checkbox_Zeit_EH
            {
                get
                {
                    return _colmehz_checkbox_zeit_ehInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColMehZ_Checkbox_Zeit_EH item info.
            /// </summary>
            [RepositoryItemInfo("e79d6c3e-3c9e-49dc-bc26-d50918f05904")]
            public virtual RepoItemInfo ColMehZ_Checkbox_Zeit_EHInfo
            {
                get
                {
                    return _colmehz_checkbox_zeit_ehInfo;
                }
            }

            /// <summary>
            /// The ColMehFaktor item.
            /// </summary>
            [RepositoryItem("c990860f-4887-46fa-8d97-223b7cb65f81")]
            public virtual Ranorex.Cell ColMehFaktor
            {
                get
                {
                    return _colmehfaktorInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The ColMehFaktor item info.
            /// </summary>
            [RepositoryItemInfo("c990860f-4887-46fa-8d97-223b7cb65f81")]
            public virtual RepoItemInfo ColMehFaktorInfo
            {
                get
                {
                    return _colmehfaktorInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
