using System.Drawing.Text;
using System.Linq.Expressions;

namespace AutoNerdUI
{
    public partial class Main : Form
    {
        private Dictionary<string, string> pcInfo = new Dictionary<string, string>();

        public Main()
        {

            InitializeComponent();
            GatherPCInfo();
            PopulateSgvPCInfo();
        }

        private void PopulateSgvPCInfo()
        {
            dgvPCInfo.Columns.Add("properties", "Properties");
            dgvPCInfo.Columns.Add("values", "Values");

            foreach (string s in pcInfo.Keys)
            {
                AddRowToPCInfo(s, pcInfo[s]);
            }
        }

        private void GatherPCInfo()
        {
            pcInfo.Clear();
            pcInfo.Add("PC Name", System.Windows.Forms.SystemInformation.ComputerName);
        }

        private void AddRowToPCInfo(string property, string value)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell propertyCell = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell valueCell = new DataGridViewTextBoxCell();

            propertyCell.Value = property;
            row.Cells.Add(propertyCell);

            valueCell.Value = value;
            row.Cells.Add(valueCell);

            dgvPCInfo.Rows.Add(row);
        }
    }
}