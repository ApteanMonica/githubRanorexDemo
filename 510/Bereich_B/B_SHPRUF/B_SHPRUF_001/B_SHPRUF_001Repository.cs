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

namespace B_SHPRUF_001
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the B_SHPRUF_001Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("1642cc25-fd43-4f06-a5f9-dbe2be164d6a")]
    public partial class B_SHPRUF_001Repository : RepoGenBaseFolder
    {
        static B_SHPRUF_001Repository instance = new B_SHPRUF_001Repository();
        B_SHPRUF_001RepositoryFolders.FrmMainAppFolder _frmmain;
        B_SHPRUF_001RepositoryFolders.DlgMessageBoxAppFolder _dlgmessagebox;

        /// <summary>
        /// Gets the singleton class instance representing the B_SHPRUF_001Repository element repository.
        /// </summary>
        [RepositoryFolder("1642cc25-fd43-4f06-a5f9-dbe2be164d6a")]
        public static B_SHPRUF_001Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public B_SHPRUF_001Repository() 
            : base("B_SHPRUF_001Repository", "/", null, 0, false, "1642cc25-fd43-4f06-a5f9-dbe2be164d6a", ".\\RepositoryImages\\B_SHPRUF_001Repository1642cc25.rximgres")
        {
            _frmmain = new B_SHPRUF_001RepositoryFolders.FrmMainAppFolder(this);
            _dlgmessagebox = new B_SHPRUF_001RepositoryFolders.DlgMessageBoxAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("1642cc25-fd43-4f06-a5f9-dbe2be164d6a")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmMain folder.
        /// </summary>
        [RepositoryFolder("0b9ca9f4-2223-4474-8e65-3b2bac319e4c")]
        public virtual B_SHPRUF_001RepositoryFolders.FrmMainAppFolder FrmMain
        {
            get { return _frmmain; }
        }

        /// <summary>
        /// The DlgMessageBox folder.
        /// </summary>
        [RepositoryFolder("d779360f-5d4a-4e1f-b598-145dcc59a9f6")]
        public virtual B_SHPRUF_001RepositoryFolders.DlgMessageBoxAppFolder DlgMessageBox
        {
            get { return _dlgmessagebox; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class B_SHPRUF_001RepositoryFolders
    {
        /// <summary>
        /// The FrmMainAppFolder folder.
        /// </summary>
        [RepositoryFolder("0b9ca9f4-2223-4474-8e65-3b2bac319e4c")]
        public partial class FrmMainAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _dfjahrbezInfo;
            RepoItemInfo _periodeInfo;
            RepoItemInfo _pbokInfo;
            RepoItemInfo _titlebar100pruefungbuchungenInfo;

            /// <summary>
            /// Creates a new FrmMain  folder.
            /// </summary>
            public FrmMainAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmMain", "/form[@controlname='frmMain']", parentFolder, 30000, null, true, "0b9ca9f4-2223-4474-8e65-3b2bac319e4c", "")
            {
                _dfjahrbezInfo = new RepoItemInfo(this, "DfJahrbez", "?/?/text[@controlname='dfJahrbez']", "", 30000, null, "05892aa0-8fab-4240-a289-a73f9b579767");
                _periodeInfo = new RepoItemInfo(this, "Periode", "?/?/text[@controlname='dfPeriode']/text[@accessiblename='Periode:']", "", 30000, null, "818ca48b-bd47-4079-97a8-09d656222e3f");
                _pbokInfo = new RepoItemInfo(this, "PbOK", "?/?/container[@controlname='ExtrasGroup']/button[@controlname='pbOK']", "", 30000, null, "1e92c848-b3f4-4b47-a6e8-881a2a530c0b");
                _titlebar100pruefungbuchungenInfo = new RepoItemInfo(this, "TitleBar100PruefungBuchungen", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "f070245b-7899-4d5d-8f10-a1ce5fae2bae");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("0b9ca9f4-2223-4474-8e65-3b2bac319e4c")]
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
            [RepositoryItemInfo("0b9ca9f4-2223-4474-8e65-3b2bac319e4c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The DfJahrbez item.
            /// </summary>
            [RepositoryItem("05892aa0-8fab-4240-a289-a73f9b579767")]
            public virtual Ranorex.Text DfJahrbez
            {
                get
                {
                    return _dfjahrbezInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The DfJahrbez item info.
            /// </summary>
            [RepositoryItemInfo("05892aa0-8fab-4240-a289-a73f9b579767")]
            public virtual RepoItemInfo DfJahrbezInfo
            {
                get
                {
                    return _dfjahrbezInfo;
                }
            }

            /// <summary>
            /// The Periode item.
            /// </summary>
            [RepositoryItem("818ca48b-bd47-4079-97a8-09d656222e3f")]
            public virtual Ranorex.Text Periode
            {
                get
                {
                    return _periodeInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Periode item info.
            /// </summary>
            [RepositoryItemInfo("818ca48b-bd47-4079-97a8-09d656222e3f")]
            public virtual RepoItemInfo PeriodeInfo
            {
                get
                {
                    return _periodeInfo;
                }
            }

            /// <summary>
            /// The PbOK item.
            /// </summary>
            [RepositoryItem("1e92c848-b3f4-4b47-a6e8-881a2a530c0b")]
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
            [RepositoryItemInfo("1e92c848-b3f4-4b47-a6e8-881a2a530c0b")]
            public virtual RepoItemInfo PbOKInfo
            {
                get
                {
                    return _pbokInfo;
                }
            }

            /// <summary>
            /// The TitleBar100PruefungBuchungen item.
            /// </summary>
            [RepositoryItem("f070245b-7899-4d5d-8f10-a1ce5fae2bae")]
            public virtual Ranorex.TitleBar TitleBar100PruefungBuchungen
            {
                get
                {
                    return _titlebar100pruefungbuchungenInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100PruefungBuchungen item info.
            /// </summary>
            [RepositoryItemInfo("f070245b-7899-4d5d-8f10-a1ce5fae2bae")]
            public virtual RepoItemInfo TitleBar100PruefungBuchungenInfo
            {
                get
                {
                    return _titlebar100pruefungbuchungenInfo;
                }
            }
        }

        /// <summary>
        /// The DlgMessageBoxAppFolder folder.
        /// </summary>
        [RepositoryFolder("d779360f-5d4a-4e1f-b598-145dcc59a9f6")]
        public partial class DlgMessageBoxAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _labelmeldungstextInfo;
            RepoItemInfo _button0Info;

            /// <summary>
            /// Creates a new DlgMessageBox  folder.
            /// </summary>
            public DlgMessageBoxAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DlgMessageBox", "/form[@controlname='dlgMessageBox']", parentFolder, 30000, null, true, "d779360f-5d4a-4e1f-b598-145dcc59a9f6", "")
            {
                _labelmeldungstextInfo = new RepoItemInfo(this, "LabelMeldungstext", "text[@controlname='labelMeldungstext']", "", 30000, null, "faddbe76-219e-4ff6-9afb-872998f91a7a");
                _button0Info = new RepoItemInfo(this, "Button0", "button[@controlname='button0']", "", 30000, null, "7e7f65bb-189f-41b8-86a8-cd1e9f491d03");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d779360f-5d4a-4e1f-b598-145dcc59a9f6")]
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
            [RepositoryItemInfo("d779360f-5d4a-4e1f-b598-145dcc59a9f6")]
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
            [RepositoryItem("faddbe76-219e-4ff6-9afb-872998f91a7a")]
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
            [RepositoryItemInfo("faddbe76-219e-4ff6-9afb-872998f91a7a")]
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
            [RepositoryItem("7e7f65bb-189f-41b8-86a8-cd1e9f491d03")]
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
            [RepositoryItemInfo("7e7f65bb-189f-41b8-86a8-cd1e9f491d03")]
            public virtual RepoItemInfo Button0Info
            {
                get
                {
                    return _button0Info;
                }
            }
        }

    }
#pragma warning restore 0436
}
