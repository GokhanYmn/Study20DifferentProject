using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project14_SQLAllRelations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db14ProjectSQLRelationsDataSet3.TeamDetails' table. You can move, or remove it, as needed.
            this.teamDetailsTableAdapter.Fill(this.db14ProjectSQLRelationsDataSet3.TeamDetails);
            // TODO: This line of code loads data into the 'db14ProjectSQLRelationsDataSet2.Sponsors' table. You can move, or remove it, as needed.
            this.sponsorsTableAdapter.Fill(this.db14ProjectSQLRelationsDataSet2.Sponsors);
            // TODO: This line of code loads data into the 'db14ProjectSQLRelationsDataSet1.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.db14ProjectSQLRelationsDataSet1.Players);
            // TODO: This line of code loads data into the 'db14ProjectSQLRelationsDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.db14ProjectSQLRelationsDataSet.Teams);

        }
    }
}
