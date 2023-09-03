using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static sampleconnection.Form1;

namespace sampleconnection
{
    public partial class Form2 : Form
    {

        

        public Form2()
        {
            
            InitializeComponent();

            Food placeholder = new Food();

            LabelFoods.Text = "";
            LabelResult.Text = "Your daily caloric intake for maintaining your current weight should be around:\n" + 
                Form1.resultFinal.ToString() + " kcal";
            int days = Form1.durationNumFinal * 30;
            decimal caloricDeficitDecimal = (Form1.weightToLoseFinal * 7700M) / days;
            caloricDeficitDecimal = Decimal.Round(caloricDeficitDecimal);
            int caloricDeficit = Convert.ToInt32(caloricDeficitDecimal);
            int caloricBalance = Form1.resultFinal - caloricDeficit;
            decimal caloricBlanaceDecimal = Convert.ToDecimal(caloricBalance);
            if (caloricDeficit >= Form1.resultFinal)
            {
                LabelInformation.Text = "This much weight is practically impossible to be shed in this much time.";
                return;
            }
            else
            { LabelInformation.Text = "Your daily caloric intake for the next " +
                    days.ToString() + " days in order to shed " + Form1.weightToLoseFinal.ToString() +
                    " kgs should be around:\n" + caloricBalance.ToString() + " kcal"; }

            decimal IncreaseOrDecreaseFrom2000 = caloricBlanaceDecimal - 2000;
            decimal percentage = (IncreaseOrDecreaseFrom2000 / 2000) * 100;
            decimal caloriesPerGram;

            int smallestNumForDimesion = Math.Min(Convert.ToInt32(Form1.idNum), Convert.ToInt32(Form1.idNumL));
            smallestNumForDimesion = Math.Min(smallestNumForDimesion, Convert.ToInt32(Form1.idNumD));

            decimal[,] matrix = new decimal[3, smallestNumForDimesion];
            Food[,] matrix1 = new Food[3, smallestNumForDimesion];

            for (int i = 0; i < smallestNumForDimesion; i++)
            {
                placeholder = Form1.Breakfast[i];
                caloriesPerGram = placeholder.Calories / placeholder.PortionSize;
                placeholder.PortionSize = placeholder.PortionSize + placeholder.PortionSize * (percentage / 100);
                placeholder.PortionSize = Decimal.Round(placeholder.PortionSize);
                if ((placeholder.PortionSize % 10) < 5)
                {
                    placeholder.PortionSize = placeholder.PortionSize - (placeholder.PortionSize % 10);
                }
                else
                {
                    placeholder.PortionSize = placeholder.PortionSize + (10 - (placeholder.PortionSize % 10));
                }


                placeholder.Calories = placeholder.PortionSize * caloriesPerGram;
                placeholder.Calories = Decimal.Round(placeholder.Calories);
                Form1.Breakfast[i] = placeholder;
                matrix[0, i] = Form1.Breakfast[i].Calories;
                matrix1[0, i] = Form1.Breakfast[i];
            }

            for (int i = 0; i < smallestNumForDimesion; i++)
            {
                placeholder = Form1.Lunch[i];
                caloriesPerGram = placeholder.Calories / placeholder.PortionSize;
                placeholder.PortionSize = placeholder.PortionSize + placeholder.PortionSize * (percentage / 100);
                placeholder.PortionSize = Decimal.Round(placeholder.PortionSize);
                if ((placeholder.PortionSize % 10) < 5)
                {
                    placeholder.PortionSize = placeholder.PortionSize - (placeholder.PortionSize % 10);
                }
                else
                {
                    placeholder.PortionSize = placeholder.PortionSize + (10 - (placeholder.PortionSize % 10));
                }

                placeholder.Calories = placeholder.PortionSize * caloriesPerGram;
                placeholder.Calories = Decimal.Round(placeholder.Calories);
                Form1.Lunch[i] = placeholder;
                matrix[1, i] = Form1.Lunch[i].Calories;
                matrix1[1, i] = Form1.Lunch[i];
            }

            for (int i = 0; i < smallestNumForDimesion; i++)
            {
                placeholder = Form1.Dinner[i];
                caloriesPerGram = placeholder.Calories / placeholder.PortionSize;
                placeholder.PortionSize = placeholder.PortionSize + placeholder.PortionSize * (percentage / 100);
                placeholder.PortionSize = Decimal.Round(placeholder.PortionSize);
                if ((placeholder.PortionSize % 10) < 5)
                {
                    placeholder.PortionSize = placeholder.PortionSize - (placeholder.PortionSize % 10);
                }
                else
                {
                    placeholder.PortionSize = placeholder.PortionSize + (10 - (placeholder.PortionSize % 10));
                }

                placeholder.Calories = placeholder.PortionSize * caloriesPerGram;
                placeholder.Calories = Decimal.Round(placeholder.Calories);
                Form1.Dinner[i] = placeholder;
                matrix[2, i] = Form1.Dinner[i].Calories;
                matrix1[2, i] = Form1.Dinner[i];
            }



            int[] Assignment(decimal[,] input)
            {
                decimal result0;
                int[] Index = new int[6];
                int counter1=0;

                for (int i = 0; i < 3; i++)
                {               
                    result0 = input[i,0];
                    Index[counter1] = i;
                    Index[counter1 + 1] = 0;
                    for (int j = 0; j < smallestNumForDimesion; j++)
                    {
                        if (input[i, j] > result0)
                        {
                            result0 = input[i, j];
                            Index[counter1] = i;
                            Index[counter1 + 1] = j;
                        }
                        
                    }
                    counter1 +=2;
                }

                return (Index);
            }

            int caloriesForDay;
            string FinalResult = "";
            
            for (int i = 0; i < smallestNumForDimesion; i++)
            {
                int[] result = Assignment(matrix);
                FinalResult += "Day " + (i+1).ToString() + ":" + "\n";
                FinalResult += matrix1[result[0], result[1]].Name + " " 
                    + matrix1[result[0], result[1]].PortionSize.ToString() 
                    + " " + matrix1[result[0], result[1]].Calories.ToString() 
                    + " " + matrix1[result[0], result[1]].Link + "\n";

                FinalResult += matrix1[result[2], result[3]].Name 
                    + " " + matrix1[result[2], result[3]].PortionSize.ToString() 
                    + " " + matrix1[result[2], result[3]].Calories.ToString() + " " 
                    + matrix1[result[2], result[3]].Link + "\n";

                FinalResult += matrix1[result[4], result[5]].Name + " " 
                    + matrix1[result[4], result[5]].PortionSize.ToString() 
                    + " " + matrix1[result[4], result[5]].Calories.ToString() 
                    + " " + matrix1[result[4], result[5]].Link + "\n";

                caloriesForDay = Convert.ToInt32(matrix[result[0], result[1]] + matrix[result[2], result[3]] 
                    + matrix[result[4], result[5]]);
                FinalResult += "->" + caloriesForDay.ToString() + " kcal for the day" + "\n";

                FinalResult += "\n";

                matrix[result[0], result[1]] = 0M;
                matrix[result[2], result[3]] = 0M;
                matrix[result[4], result[5]] = 0M;
            }

            LabelFoods.Text = FinalResult;

        }
    }
}
