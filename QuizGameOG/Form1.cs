using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGameOG
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 5;
        }
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int btnTag = Convert.ToInt32(senderObject.Tag);
            if (btnTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                // work out the percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                    "Quiz ist Zuende!" + Environment.NewLine +
                    "Du hast " + score + " Fragen richtig beantwortet." + Environment.NewLine +
                    "Deine Prozentzahl " + percentage + "%" + Environment.NewLine +
                    "Clicke OK um die Lösungen zu sehen"
                    );
                MessageBox.Show("Wer malte die MonaLisa? = B Leonardo Davinci" + Environment.NewLine +
                    "Was ist das seltenste Mineral? = C Kyawthuit" + Environment.NewLine +
                    "Was kam Zuerst? Huhn oder Ei = A Ei" + Environment.NewLine +
                    "Wer ist der beste Youtuber? = A Mrbeast" + Environment.NewLine +
                    "Was ist das seltenste Material im Universum aus den unteren Antworten? = D Holz");
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    lblQuestion.Text = "Wer malte die MonaLisa?";
                    btn1.Text = "Leonardo Davinchi";
                    btn2.Text = "Leonardo Davinci";
                    btn3.Text = "Vincent van Gogh";
                    btn4.Text = "Kevin Hart";
                    correctAnswer = 2;
                    break;
                case 2:
                    lblQuestion.Text = "Was ist das seltenste Mineral?";
                    btn1.Text = "Citrin";
                    btn2.Text = "Amethyst";
                    btn3.Text = "Kyawthuit";
                    btn4.Text = "Obsidian";
                    correctAnswer = 3;
                    break;
                case 3:
                    lblQuestion.Text = "Was kam Zuerst? Huhn oder Ei";
                    btn1.Text = "Ei";
                    btn2.Text = "Huhn";
                    btn3.Visible = false;
                    label3.Visible = false;
                    btn4.Visible = false;
                    label4.Visible = false;
                    correctAnswer = 1;
                    break;

                case 4:
                    btn3.Visible = true;
                    label3.Visible = true;
                    btn4.Visible = true;
                    label4.Visible = true;
                    lblQuestion.Text = "Welche Buchstaben werden in der Geometrie verwendet?";
                    btn1.Text = "Deutsche";
                    btn2.Text = "Griechische";
                    btn3.Text = "Englische";
                    btn4.Text = "Französiche";
                    correctAnswer = 2;
                    break;
                case 5:
                    lblQuestion.Text = "Was ist das seltenste Material im Universum aus den unteren Antworten?";
                    btn1.Text = "Platinum";
                    btn2.Text = "Gold";
                    btn3.Text = "Nullitin";
                    btn4.Text = "Holz";
                    correctAnswer = 4;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
