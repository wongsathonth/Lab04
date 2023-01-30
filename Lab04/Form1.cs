namespace Lab04
{
    public partial class Form1 : Form
    {
        private Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            int year = int.Parse(this.textBox2.Text);
            double grade = double.Parse(this.textBox3.Text);

            Person person= new Person(name, year, grade);
            this.classroom.addPerson(person);

            textBox8.Text = this.classroom.ShowPerson();
            textBox7.Text = this.classroom.ShowAllAge().ToString();
            this.classroom.SetGrade();
            this.textBox4.Text = this.classroom.ShowMaxGrade().ToString();
            this.textBox5.Text = this.classroom.ShowMinGrade().ToString();
            this.textBox9.Text = this.classroom.ShowMaxGradeName();
            this.textBox10.Text = this.classroom.ShowMinGradeName();
            this.textBox6.Text = this.classroom.ShowAvgGrade().ToString();
        }
    }
}