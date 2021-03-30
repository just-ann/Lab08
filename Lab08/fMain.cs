using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddTown_Click(object sender, EventArgs e)
        {
            Printer printer = new Printer();
            fPrinter ft = new fPrinter(printer);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbPrintersInfo.Text +=
 string.Format("{0},{1},{2}. Покупців: {3}. Річний дохід з продажу:{4}грн.Площа принтера: {5} кв.см.. | Середній кошт принтера: {8}грн\r\n",printer.Name, printer.Appointment, printer.Printing_technology,
 printer.Buyers, printer.YearIncome, printer.Square,
 printer.HasPhotoprinting ? "Є фотодрук" : "Немає фотодруку",
 printer.HasTwo_sided_printing ? "Є двусторонній друк" : "Немає двустороннього друку", printer.GetYearIncomePerInhabitant());

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
"Припинити роботу", MessageBoxButtons.OKCancel,
MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
