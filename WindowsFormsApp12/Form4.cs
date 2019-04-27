using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp12.DAL.Context;

namespace WindowsFormsApp12
{
    public partial class Form4 : Form
    {
        AppDbContext context;
        public Form4()
        {
            InitializeComponent();
            context = new AppDbContext();

            dataGridView1.DataSource = context.Streets.Select(x => new { ИД = x.Id, Название = x.Name}).ToList();
        }
    }
}
