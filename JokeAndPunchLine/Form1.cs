/*
 Think of your favorite joke and identify its setup and punch line.
 Then, create an application that has a Label and two buttons on a form.
 One of the buttons should read "Setup" and the other button should read "Punch Line".
 When the SetUp button is clicked, display the joke's setup in the label control.
 When the Punch line button is clicked, display the joke's punch line in the label control
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokeAndPunchLine
{
    public partial class FormJoke : Form
    {
        public FormJoke()
        {
            InitializeComponent();
        }

        private void FormJoke_Load(object sender, EventArgs e)
        {

        }

        private void buttonSetUp_Click(object sender, EventArgs e)
        {
            labelJoke.Text = "Why Java Programmers Wear Glasses?";
        }

        private void buttonPunchLine_Click(object sender, EventArgs e)
        {
            labelJoke.Text = "Because they can't C#!!";
        }
    }
}
