using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Charting;

namespace MediaStore.Forms
{
    public partial class Search : Form
    {
        private TextBox searchTextBox;
        private ListBox searchResultsListBox;
        private Dictionary<string, string> searchMappings;
        public static string url; 


        public Search()
        {
            InitializeComponent();

            InitializeSearchMappings();

            InitializeSearchBar();
            InitializeSearchResults();

            searchResultsListBox.SelectedIndexChanged += SearchResultsListBox_SelectedIndexChanged;

            this.Load += Search_Load;
        }

        private void InitializeSearchMappings()
        {
            searchMappings = URLS._websiteProducts;
        }
   

        private void InitializeSearchBar()
        {
            searchTextBox = new TextBox();
            searchTextBox.Location = new Point(20, 20);
            searchTextBox.Size = new Size(200, 20);
            searchTextBox.TextChanged += SearchTextBox_TextChanged; 
            this.Controls.Add(searchTextBox);
        }

        private void InitializeSearchResults()
        {
            searchResultsListBox = new ListBox();
            searchResultsListBox.Location = new Point(20, 50);
            searchResultsListBox.Size = new Size(200, 500);
            this.Controls.Add(searchResultsListBox);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSearchResults(searchTextBox.Text);
        }

        private void UpdateSearchResults(string searchTerm)
        {
            searchResultsListBox.Items.Clear();

            foreach (var mapping in searchMappings)
            {
                if (mapping.Key.StartsWith(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    searchResultsListBox.Items.Add(mapping.Key);
                }
            }
        }

        private void SearchResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTerm = searchResultsListBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedTerm) && searchMappings.ContainsKey(selectedTerm))
            {
                url = searchMappings[selectedTerm];
                this.Close();
                this.Hide();
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
        }


        


    }
}
