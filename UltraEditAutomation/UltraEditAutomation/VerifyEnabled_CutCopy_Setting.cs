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
    ///The VerifyEnabled_CutCopy_Setting recording.
    /// </summary>
    [TestModule("d1ab732f-fe38-40f0-b962-936cdbaedf8c", ModuleType.Recording, 1)]
    public partial class VerifyEnabled_CutCopy_Setting : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UltraEditAutomationRepository repository.
        /// </summary>
        public static UltraEditAutomationRepository repo = UltraEditAutomationRepository.Instance;

        static VerifyEnabled_CutCopy_Setting instance = new VerifyEnabled_CutCopy_Setting();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyEnabled_CutCopy_Setting()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyEnabled_CutCopy_Setting Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UltraEdit64Bit.ToolBar.Advanced' at 41;9.", repo.UltraEdit64Bit.ToolBar.AdvancedInfo, new RecordItemIndex(0));
            repo.UltraEdit64Bit.ToolBar.Advanced.Click("41;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UltraEdit64Bit.Settings' at 24;45.", repo.UltraEdit64Bit.SettingsInfo, new RecordItemIndex(1));
            repo.UltraEdit64Bit.Settings.Click("24;45");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Configuration.Miscellaneous1' at 41;13.", repo.Configuration.Miscellaneous1Info, new RecordItemIndex(2));
            repo.Configuration.Miscellaneous1.Click("41;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Configuration.EnableCopyCutOfCurrentLineWithNo' at 10;12.", repo.Configuration.EnableCopyCutOfCurrentLineWithNoInfo, new RecordItemIndex(3));
            repo.Configuration.EnableCopyCutOfCurrentLineWithNo.Click("10;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'Configuration.EnableCopyCutOfCurrentLineWithNo'.", repo.Configuration.EnableCopyCutOfCurrentLineWithNoInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.Configuration.EnableCopyCutOfCurrentLineWithNoInfo, "Checked", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Configuration.Close' at 23;18.", repo.Configuration.CloseInfo, new RecordItemIndex(5));
            repo.Configuration.Close.Click("23;18");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}