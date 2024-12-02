using WinFormsDapper.Data;
using WinFormsDapper.Data.Models.Person;
using WinFormsDapper.UserControls;

namespace WinFormsDapper
{
    public partial class Form1 : Form
    {

        List<Person> people = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            UserControl personSearch = new PersonSearch();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(personSearch);
            ResizeUC(personSearch);
        }

        private void ResizeUC(UserControl uc0)
        {
            uc0.Top = 5;
            uc0.Left = 5;
            uc0.Width = flowLayoutPanel1.Width-10;
            uc0.Height = flowLayoutPanel1.Height-10;
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            foreach (UserControl uc in flowLayoutPanel1.Controls)
            {
                ResizeUC((UserControl)uc);
            }
        }
    }
}
