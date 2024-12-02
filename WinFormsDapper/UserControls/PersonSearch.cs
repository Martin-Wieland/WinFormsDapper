using WinFormsDapper.Data;
using WinFormsDapper.Data.Models.Person;

namespace WinFormsDapper.UserControls
{
    public partial class PersonSearch : UserControl
    {

        List<Person> people = new List<Person>();

        public PersonSearch()
        {
            InitializeComponent();
        }

        public void BindFormData()
        {
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullName";
            dataGridView1.DataSource = people;
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            people = db.GetPeople(lastNameText.Text);
            BindFormData();

        }
    }
}
