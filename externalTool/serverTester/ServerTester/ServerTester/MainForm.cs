﻿using System;
using RestSharp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerTester.Util;
using System.IO;
using System.Xml;
using ServerTester.TestItem;

namespace ServerTester
{
    public partial class MainForm : Form
    {
        private TestItemService testItemService;


        public MainForm()
        {
            InitializeComponent();
            this.Size = new Size(1125, 650);
            
            this.testItemService = new TestItemService();
            HelpTextBox.Text = string.Format("{0}개의 테스트 항목이 성공적으로 로드됨 !", this.testItemService.totalCount);
        
            
        }

        private void TestExecuteButton_Click(object sender, EventArgs e)
        {

        }

        private void TestButton_Click(object sender, EventArgs e)
        {

        }

        private void TestGroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
