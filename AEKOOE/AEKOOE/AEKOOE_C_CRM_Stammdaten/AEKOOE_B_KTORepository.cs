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

namespace AEKOOE_C_CRM_Stammdaten
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the AEKOOE_B_KTORepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("97edc0a8-7af7-4ff0-9994-0d4fefcdaa1f")]
    public partial class AEKOOE_B_KTORepository : RepoGenBaseFolder
    {
        static AEKOOE_B_KTORepository instance = new AEKOOE_B_KTORepository();
        AEKOOE_B_KTORepositoryFolders.FrmKtoAppFolder _frmkto;
        AEKOOE_B_KTORepositoryFolders.DlgLoginAppFolder _dlglogin;
        AEKOOE_B_KTORepositoryFolders.FormWorkplaceAppFolder _formworkplace;
        AEKOOE_B_KTORepositoryFolders.DlgAusfuehrenAppFolder _dlgausfuehren;

        /// <summary>
        /// Gets the singleton class instance representing the AEKOOE_B_KTORepository element repository.
        /// </summary>
        [RepositoryFolder("97edc0a8-7af7-4ff0-9994-0d4fefcdaa1f")]
        public static AEKOOE_B_KTORepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public AEKOOE_B_KTORepository() 
            : base("AEKOOE_B_KTORepository", "/", null, 0, false, "97edc0a8-7af7-4ff0-9994-0d4fefcdaa1f", ".\\RepositoryImages\\AEKOOE_B_KTORepository97edc0a8.rximgres")
        {
            _frmkto = new AEKOOE_B_KTORepositoryFolders.FrmKtoAppFolder(this);
            _dlglogin = new AEKOOE_B_KTORepositoryFolders.DlgLoginAppFolder(this);
            _formworkplace = new AEKOOE_B_KTORepositoryFolders.FormWorkplaceAppFolder(this);
            _dlgausfuehren = new AEKOOE_B_KTORepositoryFolders.DlgAusfuehrenAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("97edc0a8-7af7-4ff0-9994-0d4fefcdaa1f")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmKto folder.
        /// </summary>
        [RepositoryFolder("fbe68293-5c4e-443c-95a8-a6f907e9c7aa")]
        public virtual AEKOOE_B_KTORepositoryFolders.FrmKtoAppFolder FrmKto
        {
            get { return _frmkto; }
        }

        /// <summary>
        /// The DlgLogin folder.
        /// </summary>
        [RepositoryFolder("613f9dce-a462-4464-abdc-e4220cc43818")]
        public virtual AEKOOE_B_KTORepositoryFolders.DlgLoginAppFolder DlgLogin
        {
            get { return _dlglogin; }
        }

        /// <summary>
        /// The FormWorkplace folder.
        /// </summary>
        [RepositoryFolder("6b3fe7bc-676c-4b81-a2c3-8277391afb9a")]
        public virtual AEKOOE_B_KTORepositoryFolders.FormWorkplaceAppFolder FormWorkplace
        {
            get { return _formworkplace; }
        }

        /// <summary>
        /// The DlgAusfuehren folder.
        /// </summary>
        [RepositoryFolder("88a384a1-e8b4-40fb-a957-91b69f81477a")]
        public virtual AEKOOE_B_KTORepositoryFolders.DlgAusfuehrenAppFolder DlgAusfuehren
        {
            get { return _dlgausfuehren; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class AEKOOE_B_KTORepositoryFolders
    {
        /// <summary>
        /// The FrmKtoAppFolder folder.
        /// </summary>
        [RepositoryFolder("fbe68293-5c4e-443c-95a8-a6f907e9c7aa")]
        public partial class FrmKtoAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebarwfksachkontenverwaltenInfo;

            /// <summary>
            /// Creates a new FrmKto  folder.
            /// </summary>
            public FrmKtoAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmKto", "/form[@controlname='frmKto']", parentFolder, 30000, null, true, "fbe68293-5c4e-443c-95a8-a6f907e9c7aa", "")
            {
                _titlebarwfksachkontenverwaltenInfo = new RepoItemInfo(this, "TitleBarWFKSachkontenVerwalten", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "b6d39da3-d1ca-4673-9f1c-c5c3fd1d6354");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("fbe68293-5c4e-443c-95a8-a6f907e9c7aa")]
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
            [RepositoryItemInfo("fbe68293-5c4e-443c-95a8-a6f907e9c7aa")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBarWFKSachkontenVerwalten item.
            /// </summary>
            [RepositoryItem("b6d39da3-d1ca-4673-9f1c-c5c3fd1d6354")]
            public virtual Ranorex.TitleBar TitleBarWFKSachkontenVerwalten
            {
                get
                {
                    return _titlebarwfksachkontenverwaltenInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBarWFKSachkontenVerwalten item info.
            /// </summary>
            [RepositoryItemInfo("b6d39da3-d1ca-4673-9f1c-c5c3fd1d6354")]
            public virtual RepoItemInfo TitleBarWFKSachkontenVerwaltenInfo
            {
                get
                {
                    return _titlebarwfksachkontenverwaltenInfo;
                }
            }
        }

        /// <summary>
        /// The DlgLoginAppFolder folder.
        /// </summary>
        [RepositoryFolder("613f9dce-a462-4464-abdc-e4220cc43818")]
        public partial class DlgLoginAppFolder : RepoGenBaseFolder
        {
            AEKOOE_B_KTORepositoryFolders.Frame1Folder _frame1;

            /// <summary>
            /// Creates a new DlgLogin  folder.
            /// </summary>
            public DlgLoginAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgLogin", "/form[@controlname='dlgLogin']", parentFolder, 30000, null, true, "613f9dce-a462-4464-abdc-e4220cc43818", "")
            {
                _frame1 = new AEKOOE_B_KTORepositoryFolders.Frame1Folder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("613f9dce-a462-4464-abdc-e4220cc43818")]
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
            [RepositoryItemInfo("613f9dce-a462-4464-abdc-e4220cc43818")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Frame1 folder.
            /// </summary>
            [RepositoryFolder("1ccd0416-bddd-4197-9af7-56a6aedbdce0")]
            public virtual AEKOOE_B_KTORepositoryFolders.Frame1Folder Frame1
            {
                get { return _frame1; }
            }
        }

        /// <summary>
        /// The Frame1Folder folder.
        /// </summary>
        [RepositoryFolder("1ccd0416-bddd-4197-9af7-56a6aedbdce0")]
        public partial class Frame1Folder : RepoGenBaseFolder
        {
            RepoItemInfo _benutzerInfo;
            RepoItemInfo _kennwortInfo;
            RepoItemInfo _firmaInfo;
            RepoItemInfo _labelrs2loginInfo;
            RepoItemInfo _datenbankInfo;
            RepoItemInfo _pbstandardInfo;

            /// <summary>
            /// Creates a new Frame1  folder.
            /// </summary>
            public Frame1Folder(RepoGenBaseFolder parentFolder) :
                    base("Frame1", "container[@controlname='ApteanBackground']/container[@controlname='frame1']", parentFolder, 30000, null, false, "1ccd0416-bddd-4197-9af7-56a6aedbdce0", "")
            {
                _benutzerInfo = new RepoItemInfo(this, "Benutzer", "text[@controlname='dfBenutzer']/text[@accessiblename='Benutzer']", "", 30000, null, "a9d68afe-8ab8-4a3a-84a9-846fb1576d4b");
                _kennwortInfo = new RepoItemInfo(this, "Kennwort", "text[@controlname='dfPasswort']/text[@accessiblename='Kennwort']", "", 30000, null, "6fab1c1a-0666-49b0-9c27-d9d6bdabf5f4");
                _firmaInfo = new RepoItemInfo(this, "Firma", "text[@controlname='dfFirma']/text[@accessiblename='Firma']", "", 30000, null, "81e19fd7-7c0b-4805-896f-be9b986277a6");
                _labelrs2loginInfo = new RepoItemInfo(this, "LabelRs2Login", "text[@controlname='labelRs2Login']", "", 30000, null, "ac3d9e40-13e3-4f07-b476-61b425db5849");
                _datenbankInfo = new RepoItemInfo(this, "Datenbank", "text[@controlname='dfDatenbank']/text[@accessiblename='Datenbank']", "", 30000, null, "3ef68837-8e94-4074-b007-2c3e2b4725dd");
                _pbstandardInfo = new RepoItemInfo(this, "PbStandard", "container[@controlname='cFlowLayoutPanel1']/button[@controltypename='pbStandard']", "", 30000, null, "e42e59ee-3191-48c9-bd73-77c369c1a47d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1ccd0416-bddd-4197-9af7-56a6aedbdce0")]
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
            [RepositoryItemInfo("1ccd0416-bddd-4197-9af7-56a6aedbdce0")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Benutzer item.
            /// </summary>
            [RepositoryItem("a9d68afe-8ab8-4a3a-84a9-846fb1576d4b")]
            public virtual Ranorex.Text Benutzer
            {
                get
                {
                    return _benutzerInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Benutzer item info.
            /// </summary>
            [RepositoryItemInfo("a9d68afe-8ab8-4a3a-84a9-846fb1576d4b")]
            public virtual RepoItemInfo BenutzerInfo
            {
                get
                {
                    return _benutzerInfo;
                }
            }

            /// <summary>
            /// The Kennwort item.
            /// </summary>
            [RepositoryItem("6fab1c1a-0666-49b0-9c27-d9d6bdabf5f4")]
            public virtual Ranorex.Text Kennwort
            {
                get
                {
                    return _kennwortInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Kennwort item info.
            /// </summary>
            [RepositoryItemInfo("6fab1c1a-0666-49b0-9c27-d9d6bdabf5f4")]
            public virtual RepoItemInfo KennwortInfo
            {
                get
                {
                    return _kennwortInfo;
                }
            }

            /// <summary>
            /// The Firma item.
            /// </summary>
            [RepositoryItem("81e19fd7-7c0b-4805-896f-be9b986277a6")]
            public virtual Ranorex.Text Firma
            {
                get
                {
                    return _firmaInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Firma item info.
            /// </summary>
            [RepositoryItemInfo("81e19fd7-7c0b-4805-896f-be9b986277a6")]
            public virtual RepoItemInfo FirmaInfo
            {
                get
                {
                    return _firmaInfo;
                }
            }

            /// <summary>
            /// The LabelRs2Login item.
            /// </summary>
            [RepositoryItem("ac3d9e40-13e3-4f07-b476-61b425db5849")]
            public virtual Ranorex.Text LabelRs2Login
            {
                get
                {
                    return _labelrs2loginInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LabelRs2Login item info.
            /// </summary>
            [RepositoryItemInfo("ac3d9e40-13e3-4f07-b476-61b425db5849")]
            public virtual RepoItemInfo LabelRs2LoginInfo
            {
                get
                {
                    return _labelrs2loginInfo;
                }
            }

            /// <summary>
            /// The Datenbank item.
            /// </summary>
            [RepositoryItem("3ef68837-8e94-4074-b007-2c3e2b4725dd")]
            public virtual Ranorex.Text Datenbank
            {
                get
                {
                    return _datenbankInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Datenbank item info.
            /// </summary>
            [RepositoryItemInfo("3ef68837-8e94-4074-b007-2c3e2b4725dd")]
            public virtual RepoItemInfo DatenbankInfo
            {
                get
                {
                    return _datenbankInfo;
                }
            }

            /// <summary>
            /// The PbStandard item.
            /// </summary>
            [RepositoryItem("e42e59ee-3191-48c9-bd73-77c369c1a47d")]
            public virtual Ranorex.Button PbStandard
            {
                get
                {
                    return _pbstandardInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbStandard item info.
            /// </summary>
            [RepositoryItemInfo("e42e59ee-3191-48c9-bd73-77c369c1a47d")]
            public virtual RepoItemInfo PbStandardInfo
            {
                get
                {
                    return _pbstandardInfo;
                }
            }
        }

        /// <summary>
        /// The FormWorkplaceAppFolder folder.
        /// </summary>
        [RepositoryFolder("6b3fe7bc-676c-4b81-a2c3-8277391afb9a")]
        public partial class FormWorkplaceAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar_workplaceInfo;

            /// <summary>
            /// Creates a new FormWorkplace  folder.
            /// </summary>
            public FormWorkplaceAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FormWorkplace", "/form[@controlname='FormWorkplace']", parentFolder, 30000, null, true, "6b3fe7bc-676c-4b81-a2c3-8277391afb9a", "")
            {
                _titlebar_workplaceInfo = new RepoItemInfo(this, "TitleBar_Workplace", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "c1f4df91-b366-4133-b777-6e0186dabd93");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6b3fe7bc-676c-4b81-a2c3-8277391afb9a")]
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
            [RepositoryItemInfo("6b3fe7bc-676c-4b81-a2c3-8277391afb9a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar_Workplace item.
            /// </summary>
            [RepositoryItem("c1f4df91-b366-4133-b777-6e0186dabd93")]
            public virtual Ranorex.TitleBar TitleBar_Workplace
            {
                get
                {
                    return _titlebar_workplaceInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar_Workplace item info.
            /// </summary>
            [RepositoryItemInfo("c1f4df91-b366-4133-b777-6e0186dabd93")]
            public virtual RepoItemInfo TitleBar_WorkplaceInfo
            {
                get
                {
                    return _titlebar_workplaceInfo;
                }
            }
        }

        /// <summary>
        /// The DlgAusfuehrenAppFolder folder.
        /// </summary>
        [RepositoryFolder("88a384a1-e8b4-40fb-a957-91b69f81477a")]
        public partial class DlgAusfuehrenAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebarwfkausfuehrenInfo;
            RepoItemInfo _text1001Info;
            RepoItemInfo _pbokInfo;

            /// <summary>
            /// Creates a new DlgAusfuehren  folder.
            /// </summary>
            public DlgAusfuehrenAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgAusfuehren", "/form[@controlname='dlgAusführen']", parentFolder, 30000, null, true, "88a384a1-e8b4-40fb-a957-91b69f81477a", "")
            {
                _titlebarwfkausfuehrenInfo = new RepoItemInfo(this, "TitleBarWFKAusfuehren", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "8c727dc1-6f07-4fae-a205-0155b8e33c92");
                _text1001Info = new RepoItemInfo(this, "Text1001", "combobox[@controlname='cmbProgramm']/text[@controlid='1001']", "", 30000, null, "e7303dd4-5ab5-44f9-acea-cf7e950f8425");
                _pbokInfo = new RepoItemInfo(this, "PbOk", "button[@controlname='pbOk']", "", 30000, null, "20abff77-71f9-4d72-a3cc-b060a9280a6a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("88a384a1-e8b4-40fb-a957-91b69f81477a")]
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
            [RepositoryItemInfo("88a384a1-e8b4-40fb-a957-91b69f81477a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBarWFKAusfuehren item.
            /// </summary>
            [RepositoryItem("8c727dc1-6f07-4fae-a205-0155b8e33c92")]
            public virtual Ranorex.TitleBar TitleBarWFKAusfuehren
            {
                get
                {
                    return _titlebarwfkausfuehrenInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBarWFKAusfuehren item info.
            /// </summary>
            [RepositoryItemInfo("8c727dc1-6f07-4fae-a205-0155b8e33c92")]
            public virtual RepoItemInfo TitleBarWFKAusfuehrenInfo
            {
                get
                {
                    return _titlebarwfkausfuehrenInfo;
                }
            }

            /// <summary>
            /// The Text1001 item.
            /// </summary>
            [RepositoryItem("e7303dd4-5ab5-44f9-acea-cf7e950f8425")]
            public virtual Ranorex.Text Text1001
            {
                get
                {
                    return _text1001Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text1001 item info.
            /// </summary>
            [RepositoryItemInfo("e7303dd4-5ab5-44f9-acea-cf7e950f8425")]
            public virtual RepoItemInfo Text1001Info
            {
                get
                {
                    return _text1001Info;
                }
            }

            /// <summary>
            /// The PbOk item.
            /// </summary>
            [RepositoryItem("20abff77-71f9-4d72-a3cc-b060a9280a6a")]
            public virtual Ranorex.Button PbOk
            {
                get
                {
                    return _pbokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The PbOk item info.
            /// </summary>
            [RepositoryItemInfo("20abff77-71f9-4d72-a3cc-b060a9280a6a")]
            public virtual RepoItemInfo PbOkInfo
            {
                get
                {
                    return _pbokInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
