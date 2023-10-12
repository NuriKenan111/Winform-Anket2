namespace Anket2
{
    public partial class Form1 : Form
    {
        Database data = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            name.Text = data.GetPerson()[listBox1.SelectedIndex].Name;
            surname.Text = data.GetPerson()[listBox1.SelectedIndex].Surname;
            email.Text = data.GetPerson()[listBox1.SelectedIndex].Email;
            phone.Text = data.GetPerson()[listBox1.SelectedIndex].Phone;
            pic1.Value = data.GetPerson()[listBox1.SelectedIndex].Date;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Person> person = new List<Person>()
            {
                new("Kenan","Nuri","kenan@gmail.com","0556489497",new DateTime(2005,11,21)),
                new("Ismayil","Rehimov","Ismayil@gmail.com","0506489497",new DateTime(2005,10,12)),
                new("Kamran","Hesenov","kamran@gmail.com","0706489497", new DateTime(2004, 6, 16)),
                new("Murad","Qasimov","murad@gmail.com","0996489497",new DateTime(2005,9,28))

            };

            var personName = data.GetPerson().Select(x => x.Name).ToList();
            foreach (var item in personName)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var target = data.GetPerson().Any(t => t.Email == email.Text);
            if (target)
                MessageBox.Show("There is another user in this email");

            else
            {
                data.AddPerson(new Person(name.Text, surname.Text, email.Text, phone.Text, new DateTime(pic1.Value.Year, pic1.Value.Month, pic1.Value.Day)));
                listBox1.Items.Add(name.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name.ResetText(); 
            surname.ResetText(); 
            email.ResetText(); 
            phone.ResetText();
            pic1.ResetText();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var isCheck = data.GetPerson().Any(x => x.Email == email.Text);
            if (isCheck)
            {
                var target = data.GetPerson().FirstOrDefault(t => t.Email == email.Text);
                data.GetPerson().Remove(target);
                data.AddPerson(new Person(name.Text, surname.Text, email.Text, phone.Text, new DateTime(pic1.Value.Year, pic1.Value.Month, pic1.Value.Day)));
            }
            else
            {
                MessageBox.Show("will not change email");
                email.Text = data.GetPerson()[listBox1.SelectedIndex].Email;
            }
        }
    }
}