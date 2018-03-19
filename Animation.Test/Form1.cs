using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Animation;
namespace Animation.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        protected override void OnLoad(EventArgs e)
        {
            Animator.DebutAnimation(this, DebutEffects.Fade|DebutEffects.Debut);
            base.OnLoad(e);
        }
        protected override void OnClosed(EventArgs e)
        {
            Animator.DebutAnimation(this, DebutEffects.Fade|DebutEffects.WalkOff);
            
            base.OnClosed(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animator.DebutAnimation(this.button2, DebutEffects.SliderLeftToRight);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
