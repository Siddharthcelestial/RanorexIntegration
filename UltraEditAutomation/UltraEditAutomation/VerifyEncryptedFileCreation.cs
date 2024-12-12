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

namespace UltraEditAutomation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerifyEncryptedFileCreation recording.
    /// </summary>
    [TestModule("c9bbd87d-1783-4752-9a9e-c73ee90aae15", ModuleType.Recording, 1)]
    public partial class VerifyEncryptedFileCreation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UltraEditAutomationRepository repository.
        /// </summary>
        public static UltraEditAutomationRepository repo = UltraEditAutomationRepository.Instance;

        static VerifyEncryptedFileCreation instance = new VerifyEncryptedFileCreation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyEncryptedFileCreation()
        {
            EncryptText = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyEncryptedFileCreation Instance
        {
            get { return instance; }
        }

#region Variables

        string _EncryptText;

        /// <summary>
        /// Gets or sets the value of variable EncryptText.
        /// </summary>
        [TestVariable("b7154838-0662-4e45-a0a4-e666c08c5c61")]
        public string EncryptText
        {
            get { return _EncryptText; }
            set { _EncryptText = value; }
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'UltraEdit64Bit.ToolBar.Advanced'.", repo.UltraEdit64Bit.ToolBar.AdvancedInfo, new RecordItemIndex(0));
            repo.UltraEdit64Bit.ToolBar.Advanced.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCUltraEditFilesUe20241025T06120.Encryption' at 31;58.", repo.FormCUltraEditFilesUe20241025T06120.EncryptionInfo, new RecordItemIndex(1));
            repo.FormCUltraEditFilesUe20241025T06120.Encryption.Click("31;58");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.EncryptFile' at Center.", repo.Uedit64.EncryptFileInfo, new RecordItemIndex(2));
            repo.Uedit64.EncryptFile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Uedit64.EncryptFileS'.", repo.Uedit64.EncryptFileSInfo, new RecordItemIndex(3));
            Validate.Exists(repo.Uedit64.EncryptFileSInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.EncryptText' at 209;9.", repo.Uedit64.EncryptTextInfo, new RecordItemIndex(4));
            repo.Uedit64.EncryptText.Click("209;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EncryptText' with focus on 'Uedit64.EncryptText'.", repo.Uedit64.EncryptTextInfo, new RecordItemIndex(5));
            repo.Uedit64.EncryptText.PressKeys(EncryptText);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.ConfirmEncryptText' at 51;6.", repo.Uedit64.ConfirmEncryptTextInfo, new RecordItemIndex(6));
            repo.Uedit64.ConfirmEncryptText.Click("51;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EncryptText' with focus on 'Uedit64.ConfirmEncryptText'.", repo.Uedit64.ConfirmEncryptTextInfo, new RecordItemIndex(7));
            repo.Uedit64.ConfirmEncryptText.PressKeys(EncryptText);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Enter}' with focus on 'Uedit64.ConfirmEncryptText'.", repo.Uedit64.ConfirmEncryptTextInfo, new RecordItemIndex(8));
            repo.Uedit64.ConfirmEncryptText.PressKeys("{Enter}");
            Delay.Milliseconds(80);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Uedit64.EncryptionDeleteFile'.", repo.Uedit64.EncryptionDeleteFileInfo, new RecordItemIndex(9));
            Validate.Exists(repo.Uedit64.EncryptionDeleteFileInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.EncryptButtonYes' at 50;11.", repo.Uedit64.EncryptButtonYesInfo, new RecordItemIndex(10));
            repo.Uedit64.EncryptButtonYes.Click("50;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.Close' at 19;18.", repo.Uedit64.CloseInfo, new RecordItemIndex(11));
            repo.Uedit64.Close.Click("19;18");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
