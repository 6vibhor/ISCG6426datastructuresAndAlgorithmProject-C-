using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DSA_Bubble_SelectionSort
{
    /// <summary>
    /// Bubble selection sort form
    /// </summary>
    public partial class BubbleSelectionSortFrm : Form
    {
        int[] _unSortingArray;

        /// <summary>
        /// Constructor for Bubble selection sort
        /// </summary>
        public BubbleSelectionSortFrm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Button click event to generate the random number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int arrayLength = Convert.ToInt16(txtArrayLength.Text);
                _unSortingArray = new int[arrayLength];
                Random random = new Random();
                for (int i = 0; i < arrayLength; i++)
                {
                    _unSortingArray[i] = random.Next(0, 600);
                }

                MessageBox.Show("Random numbers are generated sucessfully", "Sorting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bubble Selection Sort", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button click event to generate the visual of Bubble sort.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (_unSortingArray == null || _unSortingArray.Length == 0)
                {
                    MessageBox.Show("Please generate the array", "Bubble Selection Sort", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SfmlVisulization v = new SfmlVisulization(_unSortingArray, "Bubble Sort");
                v.Run(null);

                int temp1;
                int[] sortedArray = new int[_unSortingArray.Length];
                _unSortingArray.CopyTo(sortedArray, 0);

                Stopwatch sw = new Stopwatch();
                sw.Start();
                for (int j = 0; j <= sortedArray.Length - 2; j++)
                {
                    for (int i = 0; i <= sortedArray.Length - 2; i++)
                    {
                        if (sortedArray[i] > sortedArray[i + 1])
                        {
                            temp1 = sortedArray[i + 1];
                            sortedArray[i + 1] = sortedArray[i];
                            sortedArray[i] = temp1;
                        }
                    }
                }
                sw.Stop();

                v.renderWindow.Clear();
                v.renderWindow.Display();
                v.Run(sortedArray);
                
                lblBubbleSort.Text = "Time taken to sort the array(milliseconds): " + sw.Elapsed.TotalSeconds*1000;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bubble Selection Sort", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Button click to generate the visual of selection sort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (_unSortingArray == null || _unSortingArray.Length == 0)
                {
                    MessageBox.Show("Please generate the array", "Bubble Selection Sort", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SfmlVisulization v = new SfmlVisulization(_unSortingArray, "Selection Sort");
                v.Run(null);
                int temp, smallest;
                int[] sortedArray = new int[_unSortingArray.Length];
                _unSortingArray.CopyTo(sortedArray, 0);

                Stopwatch sw = new Stopwatch();
                sw.Start();
                for (int i = 0; i < sortedArray.Length - 1; i++)
                {
                    smallest = i;
                    for (int j = i + 1; j < sortedArray.Length; j++)
                    {
                        if (sortedArray[j] < sortedArray[smallest])
                        {
                            smallest = j;
                        }
                    }
                    temp = sortedArray[smallest];
                    sortedArray[smallest] = sortedArray[i];
                    sortedArray[i] = temp;
                }
                sw.Stop();

                v.renderWindow.Clear();
                v.renderWindow.Display();
                v.Run(sortedArray);
                
                lblSelectionSort.Text = "Time taken to sort the array(milliseconds): " + sw.Elapsed.TotalSeconds * 1000;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bubble Selection Sort", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Event to handle only number to be entered in text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtArrayLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                e.Handled = !char.IsDigit(e.KeyChar);

            }
        }
    }
}
