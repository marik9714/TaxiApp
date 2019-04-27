using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp12.DAL.Context;

namespace WindowsFormsApp12
{
    public partial class Form9 : Form
    {
        AppDbContext context;
        public Form9()
        {
            InitializeComponent();
            context = new AppDbContext();

            dataGridView1.DataSource = context.Clients.Select(x => new { ИД = x.Id, Имя = x.ClientName, Улица = x.Street.Name, Дом = x.HomeNumber, Квартира = x.FlatNumber}).ToList();
        }
    }
}
