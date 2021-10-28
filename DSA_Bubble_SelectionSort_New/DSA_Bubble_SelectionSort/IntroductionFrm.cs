using System;
using System.Windows.Forms;

namespace DSA_Bubble_SelectionSort
{
    /// <summary>
    /// Introduction form
    /// </summary>
    public partial class IntroductionFrm : Form
    {
        /// <summary>
        /// Constructor for Introduction form
        /// </summary>
        public IntroductionFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// button click event to go to the next page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            BubbleSelectionSortFrm bubbleSelectionSortFrm = new BubbleSelectionSortFrm();
            bubbleSelectionSortFrm.ShowDialog();
        }
    }
}
