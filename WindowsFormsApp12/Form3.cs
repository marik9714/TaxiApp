using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp12.DAL.Context;

namespace WindowsFormsApp12
{
    public partial class Form3 : Form
    {
        AppDbContext context;
        public Form3()
        {
            InitializeComponent();
            context = new AppDbContext();

            dataGridView1.DataSource = context.Cars.Select(x=> new {ИД = x.Id, Марка = x.Mark.MarkName, Цвет = x.CarColor.ColorName}).ToList();
        }
    }
}
