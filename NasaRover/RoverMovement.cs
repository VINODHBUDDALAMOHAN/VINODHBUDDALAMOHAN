using System;
using System.Collections.Generic;
using System.Text;

namespace NasaRover
{
    public class RoverMovement
    {
        public int x; //x axis
        public int y; //y-axis
        public string direction; // Z is direction

        private INasaRover nasaRover;

        public RoverMovement(string location, INasaRover _nasaRover)
        {
            Int32.TryParse(location.Split(' ')[0], out x);
            Int32.TryParse(location.Split(' ')[1], out y);
            direction = (location.Split(' ')[2]);
            nasaRover = _nasaRover;
        }
        public string GoForward()
        {
            try
            {
                return nasaRover.GoForward(ref x, ref y, ref direction);

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string ScrollRight()
        {
            try
            {
                return nasaRover.ScrollRight(ref x, ref y, ref direction);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string ScrollLeft()
        {
            try
            {

                return nasaRover.ScrollLeft(ref x, ref y, ref direction);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Navigate(string movingInstructions)
        {
            try
            {
                return nasaRover.Navigate(movingInstructions, ref x, ref y, ref direction);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
