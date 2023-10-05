using Anket.database;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Anket
{
    public partial class Form1 : Form
    {
        static List<User> users = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tbox_searcById.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbox_searcById.Text != "" && btn_load.Text == "load")
            {
                foreach (var user in users)
                {
                    int id = default;
                    try
                    {
                        id = int.Parse(tbox_searcById.Text.Trim());

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (user.Id == id)
                    {
                        tbox_name.Text = user.username;
                        tbox_surname.Text = user.surname;
                        tbox_phone.Text = user.phone;
                        tbox_gmail.Text = user.gmail;
                        dateTimePicker1.Value = user.birtdhdate;
                        radioButton1.Checked = user.gender == "male" ? true : false;
                        radioButton2.Checked = user.gender == "male" ? false : true;
                    }

                }
                btn_load.Text = "remove";
            }
            else if (btn_load.Text == "remove")
            {
                tbox_name.Text = "";
                tbox_surname.Text = "";
                tbox_phone.Text = "";
                tbox_gmail.Text = "";
                dateTimePicker1 = new DateTimePicker();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                btn_load.Text = "load";
            }
            tbox_searcById.Text = "USER ID";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            users = new();
            if (Directory.Exists("users"))
            {
                string[] userfiles = Directory.GetFiles("users");

                foreach (var file in userfiles)
                    users.Add(JsonSerializer.Deserialize<User>(File.ReadAllText(file)));
                gridview_users.Rows.Clear();
                foreach (var user in users)
                    gridview_users.Rows.Add(user.Id, user.username, user.surname, user.phone, user.gmail, user.birtdhdate, user.gender);


            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbox_name.Text, "^[a-zA-Z]{3,10}$"))
                lbl_error.Text = "error username";
            else if (!Regex.IsMatch(tbox_surname.Text, "^[a-zA-Z]{3,10}$"))
                lbl_error.Text = "error surname";
            else if (!Regex.IsMatch(tbox_phone.Text, @"(^\+994) \((055|050|070|077|010|099)\)\s(\d{3})\s(\d{2})\s(\d{2})"))
                lbl_error.Text = "error phone";
            else if (!Regex.IsMatch(tbox_gmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                lbl_error.Text = "error gmail";
            else if (dateTimePicker1.Value.Year > 2005)
                lbl_error.Text = "your age under of 18";
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
                lbl_error.Text = "error gender";
            else
            {
                users.Add(new User()
                {
                    username = tbox_name.Text,
                    surname = tbox_surname.Text,
                    phone = tbox_phone.Text,
                    gmail = tbox_gmail.Text,
                    birtdhdate = dateTimePicker1.Value,
                    gender = radioButton1.Checked == true ? radioButton1.Text : radioButton2.Text
                });
                if (!Directory.Exists("users"))
                    Directory.CreateDirectory("users");
                File.WriteAllText($"users\\{tbox_name.Text}.json", JsonSerializer.Serialize(users[users.Count - 1],
                    new JsonSerializerOptions() { WriteIndented = true }));
                tbox_name.Text = "";
                tbox_surname.Text = "";
                tbox_phone.Text = "";
                tbox_gmail.Text = "";
                dateTimePicker1 = new DateTimePicker();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                Form1_Load(default, default);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void tbox_searcById_Click(object sender, EventArgs e)
        {
            tbox_searcById.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (btn_sort.Text == "sort by Id")
            {
                users = users.OrderBy(u => u.Id).ToList();
                gridview_users.Rows.Clear();
                foreach (var user in users)
                    gridview_users.Rows.Add(user.Id, user.username, user.surname, user.phone, user.gmail, user.birtdhdate, user.gender);
                btn_sort.Text = "default";
            }
            else
            {
                Form1_Load(default,default);
                btn_sort.Text = "sort by Id";
            }
        }
    }
}