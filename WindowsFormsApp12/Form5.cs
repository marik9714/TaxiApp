using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp12.DAL.Context;

namespace WindowsFormsApp12
{
    public partial class Form5 : Form
    {
        AppDbContext context;
        public Form5()
        {
            InitializeComponent();
            context = new AppDbContext();

            dataGridView1.DataSource = context.Drivers.Select(x => new { ИД = x.Id, ФИО = x.FIO}).ToList();
        }
    }
}
