using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp12.DAL.Context;

namespace WindowsFormsApp12
{
    public partial class Form7 : Form
    {
        AppDbContext context;
        public Form7()
        {
            InitializeComponent();
            context = new AppDbContext();

            dataGridView1.DataSource = context.Dispatchers.Select(x => new { ИД = x.Id, ФИО = x.FIO}).ToList();
        }
    }
}
