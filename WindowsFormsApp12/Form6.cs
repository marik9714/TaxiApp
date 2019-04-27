using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp12.DAL.Context;

namespace WindowsFormsApp12
{
    public partial class Form6 : Form
    {
        AppDbContext context;
        public Form6()
        {
            InitializeComponent();
            context = new AppDbContext();

            dataGridView1.DataSource = context.Traffics.Select(x => 
            new {
                ИД = x.Id,
                Машина = x.CarId,
                Водитель = x.Driver.FIO,
                Клиент = x.Client.ClientName,
                Диспетчер = x.Dispatcher.FIO,
                Сумма = x.OrderCost,
                Тип = x.OrderType,
                Дата = x.CreateionDateTime.Value,
                Примерчание = x.Note
                }).ToList();
        }
    }
}
