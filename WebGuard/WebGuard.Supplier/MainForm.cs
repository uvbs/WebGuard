﻿using CefSharp;
using System.Windows.Forms;

namespace WebGuard.Supplier
{
    public partial class MainForm : Form
    {
        private readonly ChromiumObject _chromiumObject;

        public MainForm(string url = null)
        {
            InitializeComponent();
            _chromiumObject = new ChromiumObject(url, this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
            _chromiumObject.KillZombieProcess();
        }
    }
}
