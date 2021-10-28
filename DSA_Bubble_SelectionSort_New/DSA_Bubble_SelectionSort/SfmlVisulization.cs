using SFML.Graphics;
using SFML.Window;
using System;

namespace DSA_Bubble_SelectionSort
{
    /// <summary>
    /// class to create visual presentation of lines
    /// </summary>
    public class SfmlVisulization
    {
        VideoMode vm = new VideoMode(800, 600);
        public RenderWindow renderWindow;
        public int[] _unsortedArray;
        int index = 0;
        RectangleShape rectangleShape;
        int pos = 1;
        SFML.System.Vector2f[] positions;
        SFML.System.Vector2f[] sizes;

        /// <summary>
        /// constructor for SfmlVisulization
        /// </summary>
        /// <param name="unsortedarray"></param>
        /// <param name="title"></param>
        public SfmlVisulization(int[] unsortedarray, string title)
        {
            renderWindow = new RenderWindow(vm, title);
            renderWindow.Closed += new EventHandler(OnClose);
            _unsortedArray = unsortedarray;
            
        }

        private void OnClose(object sender, EventArgs e)
        {
            // Close the window when the OnClose event is received
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }

        /// <summary>
        /// Method to start draw line
        /// </summary>
        /// <param name="sortedArray">pass the sorted array</param>
        public void Run(int[] sortedArray)
        {
            positions = new SFML.System.Vector2f[_unsortedArray.Length];
            sizes = new SFML.System.Vector2f[_unsortedArray.Length];
            index = 0;
            pos = 1;

            if (sortedArray != null)
            {
                _unsortedArray = sortedArray;
            }

            while (index < _unsortedArray.Length)
            {
                //if (index < _unsortedArray.Length)
                //{
                    Update();
                    Draw();
                    index++;
                //}
                //renderWindow.Display();
            }

            if (sortedArray != null)
            {
                renderWindow.Close();
            }
        }

        private void Draw()
        {
            renderWindow.Clear();
            for (int i = 0; i <= index; i++)
            {
                System.Threading.Thread.Sleep(1);
                rectangleShape.Position = positions[i];
                rectangleShape.Size = sizes[i];
                renderWindow.Draw(rectangleShape, RenderStates.Default);
                
            }
            renderWindow.Display();

        }
       
        private void Update()
        {
            rectangleShape = new RectangleShape();
            positions[index] = new SFML.System.Vector2f(pos, 0);
            sizes[index] = new SFML.System.Vector2f(2, _unsortedArray[index]);
            rectangleShape.FillColor = SFML.Graphics.Color.Blue;
            
            renderWindow.DispatchEvents();
            pos = pos + 4;
        }
    }
   
}
