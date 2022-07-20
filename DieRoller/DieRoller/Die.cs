using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single 6 sided die(1-6)
    /// </summary>
    public class Die
    {

        private static Random _random; 

        static Die()
        {
            _random = new Random();
        }
        /// <summary>
        /// Creates the die and rolls it to start wth
        /// a random number
        /// </summary>
        public Die()
        {
            Roll();
        }
        /// <summary>
        /// The face up value of the die
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// True if the die is current;y held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls a die and sets the <see cref="FaceValue"/>
        /// to the new numberif the die is currently held. Returns the new number
        /// Returns the <see cref="Facevalue"/>
        /// </summary>
        /// <returns>Return the <see cref="Facevalue"/></returns>
        public byte Roll()
        {
            if (!IsHeld)
            {
                //Generate a random number

                byte newValue = (byte)_random.Next(1, 7);

                FaceValue = newValue;
            }
            return FaceValue;
        }
    }
}
