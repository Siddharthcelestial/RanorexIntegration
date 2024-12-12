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
    ///The ValidateUltraEditRegularExpressionCount recording.
    /// </summary>
    [TestModule("3663032b-ec34-435a-adf2-f476ceab34e4", ModuleType.Recording, 1)]
    public partial class ValidateUltraEditRegularExpressionCount : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UltraEditAutomationRepository repository.
        /// </summary>
        public static UltraEditAutomationRepository repo = UltraEditAutomationRepository.Instance;

        static ValidateUltraEditRegularExpressionCount instance = new ValidateUltraEditRegularExpressionCount();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateUltraEditRegularExpressionCount()
        {
            Text = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateUltraEditRegularExpressionCount Instance
        {
            get { return instance; }
        }

#region Variables

        string _Text;

        /// <summary>
        /// Gets or sets the value of variable Text.
        /// </summary>
        [TestVariable("6a9c48b2-59e8-40cb-b1de-990752a2e9d6")]
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Text' with focus on 'FindAndReplace.Uedit64.FindTextField'.", repo.FindAndReplace.Uedit64.FindTextFieldInfo, new RecordItemIndex(0));
            repo.FindAndReplace.Uedit64.FindTextField.PressKeys(Text);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FindAndReplace.Uedit64.RegularExpressions'.", repo.FindAndReplace.Uedit64.RegularExpressionsInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FindAndReplace.Uedit64.RegularExpressionsInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.ComboBox2926' at 138;16.", repo.FindAndReplace.Uedit64.ComboBox2926Info, new RecordItemIndex(2));
            repo.FindAndReplace.Uedit64.ComboBox2926.Click("138;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.UltraEdit' at 67;9.", repo.List1000.UltraEditInfo, new RecordItemIndex(3));
            repo.List1000.UltraEdit.Click("67;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (SelectedItemText='UltraEdit') on item 'FindAndReplace.Uedit64.ComboBox2926'.", repo.FindAndReplace.Uedit64.ComboBox2926Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FindAndReplace.Uedit64.ComboBox2926Info, "SelectedItemText", "UltraEdit");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FindAndReplace.Uedit64.CountAll' at 20;7.", repo.FindAndReplace.Uedit64.CountAllInfo, new RecordItemIndex(5));
            repo.FindAndReplace.Uedit64.CountAll.Click("20;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='84 occurrences found.') on item 'FindAndReplace.Uedit64.occurrences'.", repo.FindAndReplace.Uedit64.occurrencesInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FindAndReplace.Uedit64.occurrencesInfo, "Text", "84 occurrences found.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Close() on item 'FindAndReplace'.", repo.FindAndReplace.SelfInfo, new RecordItemIndex(7));
            repo.FindAndReplace.Self.Close();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
