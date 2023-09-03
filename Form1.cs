using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Windows.Forms;

namespace sampleconnection
{
    public partial class Form1 : Form
    {
        public static decimal weightFinal;
        public static int weightToLoseFinal;
        public static string sexFinal;
        public static decimal heightFinal;
        public static int ageFinal;
        public static decimal activityCoefFinal;
        public static int durationNumFinal;
        public static int resultFinal;
        public static string testing = "";

        public static int idNum = 0;
        public static List<String> id = new List<String>();
        public static List<String> name = new List<String>();
        public static List<String> portion = new List<String>();
        public static List<String> calories = new List<String>();
        public static List<String> link = new List<String>();

        public static int idNumL = 0;
        public static List<String> idL = new List<String>();
        public static List<String> nameL = new List<String>();
        public static List<String> portionL = new List<String>();
        public static List<String> caloriesL = new List<String>();
        public static List<String> linkL = new List<String>();

        public static int idNumD = 0;
        public static List<String> idD = new List<String>();
        public static List<String> nameD = new List<String>();
        public static List<String> portionD = new List<String>();
        public static List<String> caloriesD = new List<String>();
        public static List<String> linkD = new List<String>();
        public struct Food
        {
            public int Id;
            public string Name;
            public decimal PortionSize;
            public decimal Calories;
            public string Link;
        }

        public static List<Food> Breakfast = new List<Food>();
        public static List<Food> Lunch = new List<Food>();
        public static List<Food> Dinner = new List<Food>();

        public Form1()
        {
            InitializeComponent();

            Food placeholder = new Food();

            string mysqlConn = "server=127.0.0.1; user=root; database=foods; password=";
            MySqlConnection mySqlConnection= new MySqlConnection(mysqlConn);

            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Successful connection");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                System.Environment.Exit(1);
            }

            MySqlCommand mySqlCommand = new MySqlCommand("select * from breakfast", mySqlConnection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                id.Add(reader.GetString("ID"));
                name.Add(reader.GetString("Name"));
                portion.Add(reader.GetString("Portion size (grams)"));
                calories.Add(reader.GetString("Calorie per portion"));
                link.Add(reader.GetString("Link for the recipe"));
                idNum++;
            }
            reader.Close();
            for (int i = 0; i < idNum; i++)
            {
                placeholder.Id = Convert.ToInt32(id[i]);
                placeholder.Name = name[i];
                placeholder.PortionSize = Convert.ToDecimal(portion[i]);
                placeholder.Calories = Convert.ToDecimal(calories[i]);
                placeholder.Link = link[i];
                Breakfast.Add(placeholder);
            }


            MySqlCommand mySqlCommandL = new MySqlCommand("select * from lunch", mySqlConnection);
            MySqlDataReader readerL = mySqlCommandL.ExecuteReader();
            while (readerL.Read())
            {
                idL.Add(readerL.GetString("ID"));
                nameL.Add(readerL.GetString("Name"));
                portionL.Add(readerL.GetString("Portion size (grams)"));
                caloriesL.Add(readerL.GetString("Calorie per portion"));
                linkL.Add(readerL.GetString("Link for the recipe"));
                idNumL++;
            }
            readerL.Close();
            for (int i = 0; i < idNumL; i++)
            {
                placeholder.Id = Convert.ToInt32(idL[i]);
                placeholder.Name = nameL[i];
                placeholder.PortionSize = Convert.ToDecimal(portionL[i]);
                placeholder.Calories = Convert.ToDecimal(caloriesL[i]);
                placeholder.Link = linkL[i];
                Lunch.Add(placeholder);
            }           

            MySqlCommand mySqlCommandD = new MySqlCommand("select * from dinner", mySqlConnection);
            MySqlDataReader readerD = mySqlCommandD.ExecuteReader();
            while (readerD.Read())
            {
                idD.Add(readerD.GetString("ID"));
                nameD.Add(readerD.GetString("Name"));
                portionD.Add(readerD.GetString("Portion size (grams)"));
                caloriesD.Add(readerD.GetString("Calorie per portion"));
                linkD.Add(readerD.GetString("Link for the recipe"));
                idNumD++;
            }
            readerD.Close();
            for (int i = 0; i < idNumD; i++)
            {
                placeholder.Id = Convert.ToInt32(idD[i]);
                placeholder.Name = nameD[i];
                placeholder.PortionSize = Convert.ToDecimal(portionD[i]);
                placeholder.Calories = Convert.ToDecimal(caloriesD[i]);
                placeholder.Link = linkD[i];
                Dinner.Add(placeholder);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string weight = weightValue.Text;
            bool weightRes = int.TryParse(weight,out int weightInt);
            if (weightRes == false)
            {
                MessageBox.Show("The input for weight is not a valid value or is missing, please re-enter", "Error");
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
                return;
            }

            string weightToLose = shedding.Text;
            bool weightToLoseRes = int.TryParse(weightToLose, out int weightToLoseInt);
            if (weightToLoseRes == false)
            {
                MessageBox.Show("The input for weight to lose is not a valid value or is missing, please re-enter", "Error");
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                    textBox.Text = "";
                return;
            }
            if (weightToLoseInt > weightInt && weightToLoseInt < 1)
            {
                weightToLoseRes = false;
                MessageBox.Show("The input for weight to lose is not a within the required parameters (1 - actual weight), please re-enter", "Invalid value");
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                    textBox.Text = "";
                return;
            }

            bool sexRes = true;
            if (comboBox1.SelectedItem == null)
            {
                sexRes = false;
                MessageBox.Show("Please choose a sex", "No input");
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                    textBox.Text = "";
                return;
            }
            string sex = comboBox1.SelectedItem.ToString();

            string height = heightValue.Text;
            bool heightRes = int.TryParse(height, out int heightInt);
            if (heightRes == false)
            {
                MessageBox.Show("The input for height is not a whole number, please re-enter", "Invalid value");
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                    textBox.Text = "";
                return;
            }

            string age = ageValue.Text;
            bool ageRes = int.TryParse(age, out int ageInt);
            if (ageRes == false)
            {
                MessageBox.Show("The input for age is not a whole number, please re-enter", "Invalid value");
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                    textBox.Text = "";
                return;
            }

            bool activityRes = true;
            decimal activityCoef = 0M;
            if (comboBox2.SelectedItem == null)
            {
                activityRes = false;
                MessageBox.Show("Please choose your activity frequency", "No input");
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                    textBox.Text = "";
                return;
            }
            string activity = comboBox2.SelectedItem.ToString();
            if (activity == "Little or none")
            {
                activityCoef = 1.2M;
            }
            if (activity == "1-3 days a week")
            {
                activityCoef = 1.37M;            
            }
            if (activity == "3-5 days a week")
            {
                activityCoef = 1.55M;
            }
            if (activity == "6-7 days a week")
            {
                activityCoef = 1.725M;
            }
            if (activity == "Extra heavy physical activity almost if not every day")
            {
                activityCoef = 1.9M;
            }

            bool durationRes;
            if (comboBox3.SelectedItem == null)
            {
                durationRes = false;
                MessageBox.Show("Please choose the duration of the diet", "No input");
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                    textBox.Text = "";
                return;
            }
            durationRes = int.TryParse(comboBox3.SelectedItem.ToString(), out int durationNum);

            if (weightRes == true && weightToLoseRes == true && sexRes == true && heightRes == true && ageRes == true && activityRes == true && durationRes == true)
            {
                decimal result = 0M;
                weightFinal = weightInt;
                weightToLoseFinal = weightToLoseInt;
                sexFinal = sex;
                heightFinal = heightInt;
                ageFinal = ageInt;
                activityCoefFinal = activityCoef;  
                durationNumFinal = durationNum;

                if(sexFinal == "Male")
                {
                    result = (10 * weightFinal + 6.25M * heightFinal - ageFinal * 5M + 5M) * activityCoefFinal;
                }

                if(sex == "Female")
                {
                    result = (10 * weightFinal + 6.25M * heightFinal - ageFinal * 5M - 161M) * activityCoefFinal;
                }

                result = Decimal.Round(result);

                resultFinal = Convert.ToInt32(result);

                this.Hide();
                var form2 = new Form2();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }

            


        }
    }
}