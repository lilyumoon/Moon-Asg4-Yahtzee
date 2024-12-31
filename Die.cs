using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moon_Asg4_Yahtzee
{
    internal class Die
    {
        private int dieValue = -1;
        private Image dieImage;
        private ImageList dieImages;
        
        public int Value { get; }
        public Image DieImage { get => dieImage; }

        public Die(ImageList dieImages) 
        {
            this.dieImages = dieImages;
            rollDie();
        }

        /// <summary>
        /// Simulates rolling the die. Also updates the associated image.
        /// </summary>
        public void rollDie()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int randomNumber = random.Next(1, 7);
            dieValue = randomNumber;

            int imageIndex = dieValue - 1;
            dieImage = dieImages.Images[imageIndex];
        }

    }
}
