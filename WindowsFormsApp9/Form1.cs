using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        struct ExamResult
        {
            public string FullName;
            public int ExamCount;
            public List<int> Grades;
        }

        List<ExamResult> examResults = new List<ExamResult>();

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            processButton.Click += ProcessButton_Click;
            processListButton.Click += ProcessListButton_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Оценка";
            gradesDataGridView.Columns.Add(column);
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            ProcessExamResults();
        }

        private void ProcessListButton_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
            foreach (DataGridViewRow row in gradesDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int number))
                {
                    numbers.Add(number);
                }
            }

            ProcessIntegerList(numbers);
        }

        private void ProcessExamResults()
        {
            string fullName = fullNameTextBox.Text.Trim();
            if (fullName == "")
            {
                MessageBox.Show("Введите имя студента!");
                return;
            }

            int examCount = (int)examCountNumericUpDown.Value;
            List<int> grades = new List<int>();

            foreach (DataGridViewRow row in gradesDataGridView.Rows)
            {
                if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int grade))
                {
                    grades.Add(grade);
                }
            }

            if (grades.Count != examCount)
            {
                MessageBox.Show($"Введите оценки для всех {examCount} экзаменов!");
                return;
            }

            ExamResult result = new ExamResult
            {
                FullName = fullName,
                ExamCount = examCount,
                Grades = grades
            };
            examResults.Add(result);

            int passedWithHighGradesCount = 0;
            foreach (ExamResult examResult in examResults)
            {
                bool passedWithHighGrades = true;
                foreach (int grade in examResult.Grades)
                {
                    if (grade < 4)
                    {
                        passedWithHighGrades = false;
                        break;
                    }
                }
                if (passedWithHighGrades)
                {
                    passedWithHighGradesCount++;
                }
            }

            double successRate = examResults.Count == 0 ? 0 : (double)passedWithHighGradesCount / examResults.Count * 100;

            MessageBox.Show($"Успеваемость студентов: {successRate:F2}%");
        }

        private void ProcessIntegerList(List<int> numbers)
        {
            int sumOfPositiveNumbers = 0;

            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    sumOfPositiveNumbers += number;
                }
            }

            if (sumOfPositiveNumbers > 0)
            {
                MessageBox.Show($"Сумма положительных элементов списка: {sumOfPositiveNumbers}");
            }
            else
            {
                MessageBox.Show("Нет положительных элементов в списке.");
            }
        }
    }
}
