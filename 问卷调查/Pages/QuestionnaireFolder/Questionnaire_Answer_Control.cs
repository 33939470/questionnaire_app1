﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace 问卷调查.Pages.QuestionnaireFolder
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class Questionnaire_Answer_Control : Smobiler.Core.Controls.MobileUserControl
    {
        public Questionnaire_Answer_Control() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
    }
}