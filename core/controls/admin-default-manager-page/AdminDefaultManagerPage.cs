﻿using zxcforum.core.interfaces;
using zxcforum.core.models.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zxcforum.core.presets;

namespace zxcforum.core.controls
{
    public partial class AdminDefaultManagerPage<T> : UserControl where T: Table, ITable, new()
    {
        public bool IsTaidis { get; set; } = false;
        public bool IsToode { get; set; } = false;
        public AdminDefaultManagerPage(string fieldName, int optionSize = 589, bool isTaidis = false, bool isToode = false)
        {
            IsTaidis = isTaidis;
            IsToode = isToode;
            this.Size = new Size(DefaultScales.PageWidth, DefaultScales.PageHeight);
            FieldName = fieldName;
            OptionSize = optionSize; 
            InitAll();
        }
        
    }
}
