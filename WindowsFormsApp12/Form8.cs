using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp12.DAL.Context;

namespace WindowsFormsApp12
{
    public partial class Form8 : Form
    {
        AppDbContext context;
        public Form8()
        {
            InitializeComponent();

            context = new AppDbContext();

            dataGridView1.DataSource = context.Cashboxs.Select(x => new { ИД = x.Id, Водитель = x.Driver.FIO, Диспетчер = x.Dispatcher.FIO, Сумма = x.Profit }).ToList();
        }
    }
}
