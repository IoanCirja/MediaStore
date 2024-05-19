using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SearchBoxExample
{
    public partial class MainForm : Form
    {
        private Dictionary<string, string> searchMappings;

        public MainForm()
        {
            InitializeComponent();

            // Initialize search mappings
            InitializeSearchMappings();
        }


    }
}
