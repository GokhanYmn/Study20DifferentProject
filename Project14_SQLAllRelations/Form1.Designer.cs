namespace Project14_SQLAllRelations
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db14ProjectSQLRelationsDataSet = new Project14_SQLAllRelations.Db14ProjectSQLRelationsDataSet();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new Project14_SQLAllRelations.Db14ProjectSQLRelationsDataSetTableAdapters.TeamsTableAdapter();
            this.teamIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.db14ProjectSQLRelationsDataSet1 = new Project14_SQLAllRelations.Db14ProjectSQLRelationsDataSet1();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new Project14_SQLAllRelations.Db14ProjectSQLRelationsDataSet1TableAdapters.PlayersTableAdapter();
            this.playerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db14ProjectSQLRelationsDataSet2 = new Project14_SQLAllRelations.Db14ProjectSQLRelationsDataSet2();
            this.sponsorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sponsorsTableAdapter = new Project14_SQLAllRelations.Db14ProjectSQLRelationsDataSet2TableAdapters.SponsorsTableAdapter();
            this.sponsorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sponsorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db14ProjectSQLRelationsDataSet3 = new Project14_SQLAllRelations.Db14ProjectSQLRelationsDataSet3();
            this.teamDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamDetailsTableAdapter = new Project14_SQLAllRelations.Db14ProjectSQLRelationsDataSet3TableAdapters.TeamDetailsTableAdapter();
            this.teamDetailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14ProjectSQLRelationsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14ProjectSQLRelationsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14ProjectSQLRelationsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14ProjectSQLRelationsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamIdDataGridViewTextBoxColumn,
            this.teamNameDataGridViewTextBoxColumn,
            this.teamCountryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teamsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(307, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // db14ProjectSQLRelationsDataSet
            // 
            this.db14ProjectSQLRelationsDataSet.DataSetName = "Db14ProjectSQLRelationsDataSet";
            this.db14ProjectSQLRelationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.db14ProjectSQLRelationsDataSet;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // teamIdDataGridViewTextBoxColumn
            // 
            this.teamIdDataGridViewTextBoxColumn.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn.Name = "teamIdDataGridViewTextBoxColumn";
            this.teamIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamNameDataGridViewTextBoxColumn
            // 
            this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.HeaderText = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
            // 
            // teamCountryDataGridViewTextBoxColumn
            // 
            this.teamCountryDataGridViewTextBoxColumn.DataPropertyName = "TeamCountry";
            this.teamCountryDataGridViewTextBoxColumn.HeaderText = "TeamCountry";
            this.teamCountryDataGridViewTextBoxColumn.Name = "teamCountryDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIdDataGridViewTextBoxColumn,
            this.playerNameDataGridViewTextBoxColumn,
            this.teamIdDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.playersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 228);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(306, 210);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamDetailIdDataGridViewTextBoxColumn,
            this.teamIdDataGridViewTextBoxColumn2,
            this.teamColorDataGridViewTextBoxColumn,
            this.teamCityDataGridViewTextBoxColumn,
            this.teamValueDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.teamDetailsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(325, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(435, 173);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sponsorIdDataGridViewTextBoxColumn,
            this.sponsorNameDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.sponsorsBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(325, 228);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(435, 210);
            this.dataGridView4.TabIndex = 3;
            // 
            // db14ProjectSQLRelationsDataSet1
            // 
            this.db14ProjectSQLRelationsDataSet1.DataSetName = "Db14ProjectSQLRelationsDataSet1";
            this.db14ProjectSQLRelationsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.db14ProjectSQLRelationsDataSet1;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // playerIdDataGridViewTextBoxColumn
            // 
            this.playerIdDataGridViewTextBoxColumn.DataPropertyName = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn.HeaderText = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn.Name = "playerIdDataGridViewTextBoxColumn";
            this.playerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            // 
            // teamIdDataGridViewTextBoxColumn1
            // 
            this.teamIdDataGridViewTextBoxColumn1.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn1.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn1.Name = "teamIdDataGridViewTextBoxColumn1";
            // 
            // db14ProjectSQLRelationsDataSet2
            // 
            this.db14ProjectSQLRelationsDataSet2.DataSetName = "Db14ProjectSQLRelationsDataSet2";
            this.db14ProjectSQLRelationsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sponsorsBindingSource
            // 
            this.sponsorsBindingSource.DataMember = "Sponsors";
            this.sponsorsBindingSource.DataSource = this.db14ProjectSQLRelationsDataSet2;
            // 
            // sponsorsTableAdapter
            // 
            this.sponsorsTableAdapter.ClearBeforeFill = true;
            // 
            // sponsorIdDataGridViewTextBoxColumn
            // 
            this.sponsorIdDataGridViewTextBoxColumn.DataPropertyName = "SponsorId";
            this.sponsorIdDataGridViewTextBoxColumn.HeaderText = "SponsorId";
            this.sponsorIdDataGridViewTextBoxColumn.Name = "sponsorIdDataGridViewTextBoxColumn";
            this.sponsorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sponsorNameDataGridViewTextBoxColumn
            // 
            this.sponsorNameDataGridViewTextBoxColumn.DataPropertyName = "SponsorName";
            this.sponsorNameDataGridViewTextBoxColumn.HeaderText = "SponsorName";
            this.sponsorNameDataGridViewTextBoxColumn.Name = "sponsorNameDataGridViewTextBoxColumn";
            // 
            // db14ProjectSQLRelationsDataSet3
            // 
            this.db14ProjectSQLRelationsDataSet3.DataSetName = "Db14ProjectSQLRelationsDataSet3";
            this.db14ProjectSQLRelationsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamDetailsBindingSource
            // 
            this.teamDetailsBindingSource.DataMember = "TeamDetails";
            this.teamDetailsBindingSource.DataSource = this.db14ProjectSQLRelationsDataSet3;
            // 
            // teamDetailsTableAdapter
            // 
            this.teamDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // teamDetailIdDataGridViewTextBoxColumn
            // 
            this.teamDetailIdDataGridViewTextBoxColumn.DataPropertyName = "TeamDetailId";
            this.teamDetailIdDataGridViewTextBoxColumn.HeaderText = "TeamDetailId";
            this.teamDetailIdDataGridViewTextBoxColumn.Name = "teamDetailIdDataGridViewTextBoxColumn";
            this.teamDetailIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamIdDataGridViewTextBoxColumn2
            // 
            this.teamIdDataGridViewTextBoxColumn2.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn2.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn2.Name = "teamIdDataGridViewTextBoxColumn2";
            // 
            // teamColorDataGridViewTextBoxColumn
            // 
            this.teamColorDataGridViewTextBoxColumn.DataPropertyName = "TeamColor";
            this.teamColorDataGridViewTextBoxColumn.HeaderText = "TeamColor";
            this.teamColorDataGridViewTextBoxColumn.Name = "teamColorDataGridViewTextBoxColumn";
            // 
            // teamCityDataGridViewTextBoxColumn
            // 
            this.teamCityDataGridViewTextBoxColumn.DataPropertyName = "TeamCity";
            this.teamCityDataGridViewTextBoxColumn.HeaderText = "TeamCity";
            this.teamCityDataGridViewTextBoxColumn.Name = "teamCityDataGridViewTextBoxColumn";
            // 
            // teamValueDataGridViewTextBoxColumn
            // 
            this.teamValueDataGridViewTextBoxColumn.DataPropertyName = "TeamValue";
            this.teamValueDataGridViewTextBoxColumn.HeaderText = "TeamValue";
            this.teamValueDataGridViewTextBoxColumn.Name = "teamValueDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14ProjectSQLRelationsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14ProjectSQLRelationsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14ProjectSQLRelationsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14ProjectSQLRelationsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Db14ProjectSQLRelationsDataSet db14ProjectSQLRelationsDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private Db14ProjectSQLRelationsDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private Db14ProjectSQLRelationsDataSet1 db14ProjectSQLRelationsDataSet1;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private Db14ProjectSQLRelationsDataSet1TableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn1;
        private Db14ProjectSQLRelationsDataSet2 db14ProjectSQLRelationsDataSet2;
        private System.Windows.Forms.BindingSource sponsorsBindingSource;
        private Db14ProjectSQLRelationsDataSet2TableAdapters.SponsorsTableAdapter sponsorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sponsorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sponsorNameDataGridViewTextBoxColumn;
        private Db14ProjectSQLRelationsDataSet3 db14ProjectSQLRelationsDataSet3;
        private System.Windows.Forms.BindingSource teamDetailsBindingSource;
        private Db14ProjectSQLRelationsDataSet3TableAdapters.TeamDetailsTableAdapter teamDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDetailIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamValueDataGridViewTextBoxColumn;
    }
}

