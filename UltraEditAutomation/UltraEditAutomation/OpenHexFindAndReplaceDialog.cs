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
    ///The OpenHexFindAndReplaceDialog recording.
    /// </summary>
    [TestModule("9d8cc124-2259-47d8-b082-64c86ec1eb68", ModuleType.Recording, 1)]
    public partial class OpenHexFindAndReplaceDialog : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UltraEditAutomationRepository repository.
        /// </summary>
        public static UltraEditAutomationRepository repo = UltraEditAutomationRepository.Instance;

        static OpenHexFindAndReplaceDialog instance = new OpenHexFindAndReplaceDialog();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenHexFindAndReplaceDialog()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenHexFindAndReplaceDialog Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+H' Press with focus on 'UltraEdit64Bit.editorScreen'.", repo.UltraEdit64Bit.editorScreenInfo, new RecordItemIndex(0));
            Keyboard.PrepareFocus(repo.UltraEdit64Bit.editorScreen);
            Keyboard.Press(System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.Control, 35, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(2930);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UltraEdit64Bit.Home' at 39;6.", repo.UltraEdit64Bit.HomeInfo, new RecordItemIndex(1));
            repo.UltraEdit64Bit.Home.Click("39;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormEdit1UltraEdit64Bit.Find' at 16;26.", repo.FormEdit1UltraEdit64Bit.FindInfo, new RecordItemIndex(2));
            repo.FormEdit1UltraEdit64Bit.Find.Click("16;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'HEXFindReplace'.", repo.HEXFindReplace.SelfInfo, new RecordItemIndex(3));
            Validate.Exists(repo.HEXFindReplace.SelfInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
