using System;
using System.Windows.Forms;

namespace DSA_Bubble_SelectionSort
{
    /// <summary>
    /// Start up form
    /// </summary>
    public partial class StartUpFrm : Form
    {
        /// <summary>
        /// Constructor for thr Startup class
        /// </summary>
        public StartUpFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event to open introduction form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBegin_Click(object sender, EventArgs e)
        {
            IntroductionFrm introductionFrm = new IntroductionFrm();
            introductionFrm.ShowDialog();
        }
    }
}
