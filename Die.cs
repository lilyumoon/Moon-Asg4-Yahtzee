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
        
        public int Value { get => dieValue; }
        public Image DieImage { get => dieImage; }

        public Die(ImageList dieImages) 
        {
            this.dieImages = dieImages;
            rollDie();
        }

        /// <summary>
        /// Simulates rolling the die, giving it a new value and updated its associated image.
        /// </summary>
        public void rollDie()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int randomNumber = random.Next(1, 7);
            dieValue = randomNumber;

            updateImage();
        }

        /// <summary>
        /// Sets the die to an "unused" state, effectively removing the image.
        /// </summary>
        public void resetDie()
        {
            dieValue = 0; 
            updateImage();
        }

        private void updateImage()
        {
            int dieImageIndex = dieValue - 1;
            if (dieImageIndex == -1)
                dieImage = null;
            else
                dieImage = dieImages.Images[dieImageIndex];
        }

    }
}
