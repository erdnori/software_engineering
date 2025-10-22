using gyak6.Models;

namespace gyak6
{
    public partial class Form1 : Form
    {
        private TextbookSupportContext textbookContext;
        public Form1()
        {
            InitializeComponent();
            textbookContext = new TextbookSupportContext();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cxt = new TextbookSupportContext();
            var students = cxt.Students.ToList();
            studentBindingSource.DataSource = students;

            var order = cxt.Orders.ToList();
            orderBindingSource.DataSource = order;

            var textbook = cxt.Textbooks.ToList();
            textbookBindingSource.DataSource = textbook;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void GetStudents()
        //{
        //    studentBindingSource.DataSource =
        //            (
        //                from s in textbookContext.Students
        //                where s.Name!.Contains(txtStudent.Text)
        //                select s
        //            ).ToList();
        //}

        private void studentTextBox_TextChanged(object sender, EventArgs e)
        {
            //GetStudents();
        }
    }
}
