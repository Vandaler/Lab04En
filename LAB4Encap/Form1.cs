namespace LAB4Encap
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputBt = textBt.Text;
            string inputName = textName.Text;
            string inputGpa = textGpa.Text;
            int iYear = Int32.Parse(inputBt);
            double iGpa = double.Parse(inputGpa);
            //create object form Person class
            Person person = new Person(inputName, iYear,iGpa);
            // show all person name 
            //textListName.Text += person.getName() + "\t\t\t";
            //sum all person age
            //int currentAge = Int32.Parse(textBtList.Text);
            //int newTotalAge = currentAge + person.getAge();
            //textBtList.Text = newTotalAge.ToString();
            this.classroom.addPerson2Class(person);
            this.textListName.Text = 
                classroom.showAllPersononClass();
            textBtList.Text =
                classroom.SumAllYearClass();
            textGpaAvg.Text =
                classroom.avgMaxGPA();
            textGpaMax.Text =
                classroom.MaxGPA();
            textGpaMin.Text =
                classroom.MinGPA();
            textBox4.Text =
                classroom.maxGPAName();
            textBox5.Text =
                classroom.minGPAName();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}