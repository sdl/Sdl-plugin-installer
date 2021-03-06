﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sdl.Community.SdlPluginInstaller
{
    public partial class Processes : Form
    {
        private readonly List<string> _processes;
        public Processes()
        {
            InitializeComponent();
        }

        public Processes(List<string> processes) : this()
        {
            _processes = processes;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _processes.ForEach(process => lstProcesses.Items.Add(process));
        }
    }
}
