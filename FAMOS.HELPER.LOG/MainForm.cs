﻿using FAMOS.HELPER.LOG.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace FAMOS.HELPER.LOG
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public static RadTextBox txtFileLocation { get; set; }
        public static Telerik.WinControls.UI.RadForm Instance { get; set; }
        class NodeCountPair
        {
            public RadTreeNode TreeNode;
            public int Count;

            public NodeCountPair(RadTreeNode TreeNode, int Count)
            {
                this.TreeNode = TreeNode;
                this.Count = Count;
            }

            public NodeCountPair(RadTreeNode TreeNode)
            {
                this.TreeNode = TreeNode;
                this.Count = -1;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            RadMessageBox.SetThemeName(TelerikTheme.ThemeName);
            
            txtFileLocation = this.FileLocationPath;
            Instance = this;
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            FileLocationPath.Text = "";
            DialogResult dirResult = ofd.ShowDialog();
            if (dirResult == DialogResult.OK)
            {
                FileLocationPath.Text = ofd.FileName;
                StatusStripText.Text = "파일 선택 완료";
            }
            else
            {
                StatusStripText.Text = "파일 선택 취소";
            }
        }

        public void DrawLogList(List<Log> LogList)
        {
            Stack<NodeCountPair> PairStack = new Stack<NodeCountPair>();
            NodeCountPair currentList = null;

            foreach (Log log in LogList)
            {
                List<string> ConvertedLogList;
                try
                {
                    ConvertedLogList = (Activator.CreateInstance(Type.GetType($"FAMOS.HELPER.SECS.SF.{log.SF}")) as IConversable).Convert(log);
                }
                catch (NullReferenceException nre)
                {
                    Console.WriteLine(nre.StackTrace);
                    ConvertedLogList = log.LowRankLogs;
                }
                catch (NotImplementedException nie)
                {
                    ConvertedLogList = log.LowRankLogs;
                }


                foreach (string LowLog in ConvertedLogList)
                {
                    if (currentList.Count == 0 && PairStack.Count != 0)
                    {
                        currentList = PairStack.Pop();
                    }
                    if (LowLog.IndexOf("LIST") > 0)
                    {
                        if (currentList.Count > 1)
                        {
                            PairStack.Push(currentList);
                        }
                        int count = int.Parse(Regex.Replace(LowLog, @"\D", ""));
                        currentList = new NodeCountPair(currentList.TreeNode.Nodes.Add(LowLog), count);
                    }
                    else
                    {
                        currentList.TreeNode.Nodes.Add(LowLog);
                        currentList.Count--;
                    }
                }
            }

        }

        #region [EVENT]
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (FileLocationPath.Text == "")
            {
                RadMessageBox.Show("파일 선택을 먼저 해주세요.");
                StatusStripText.Text = "파일 선택을 먼저 해주세요.";
                return;
            }

            this.logView.GridDataBinding();
        }
        #endregion
    }
}