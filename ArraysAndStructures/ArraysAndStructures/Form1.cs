using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace ArraysAndStructures
{
    public struct Grade
    {
        public int points;
        public string grade;
    }
    public partial class Form1 : Form
    {
        private Grade grd;
        private ArrayList grades = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grd.grade = "F";
            grd.points = 299;
            grades.Add(grd);

            grd.grade = "D";
            grd.points = 349;
            grades.Add(grd);

            grd.grade = "C";
            grd.points = 399;
            grades.Add(grd);

            grd.grade = "B";
            grd.points = 449;
            grades.Add(grd);

            grd.grade = "A";
            grd.points = 500;
            grades.Add(grd);
        }

        private void btnFindGrade_Click(object sender, EventArgs e)
        {
            int entGrade = Convert.ToInt32(txtScore.Text);
            //if (entGrade >= Convert.ToInt32(grades[0][grd.points]))
            //{

            //}
        }
    }
}
