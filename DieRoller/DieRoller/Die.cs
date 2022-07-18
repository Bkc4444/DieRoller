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
        /// <summary>
        /// The face up value of the die
        /// </summary>
        public byte FaceValue { get; set; }
        
        /// <summary>
        /// True if the die is current;y held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls a die and sets the <see cref="FaceValue"/>
        /// to the new number. Returns the new number
        /// </summary>
        /// <returns>Return the new random number</returns>
        public byte Roll()
        {
            //Generate a random number
            //set to face value
            //return new number
            throw new NotImplementedException();
        }
    }
}
