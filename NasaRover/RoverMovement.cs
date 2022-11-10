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

        public RoverMovement(string location)
        {
            Int32.TryParse(location.Split(' ')[0], out x);
            Int32.TryParse(location.Split(' ')[1], out y);
            direction = (location.Split(' ')[2]);
        }
        public string GoForward()
        {
            try
            {

                switch (direction)
                {
                    case "N"://N = North
                        y++;
                        break;
                    case "E"://E = East
                        x++;
                        break;
                    case "S":// S = South
                        y--;
                        break;
                    case "W":// W = West
                        x--;
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", direction));
                }
                return string.Format(x + " " + y + " " + direction);
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
                switch (direction)
                {
                    case "N":
                        direction = "E";
                        break;
                    case "E":
                        direction = "S";
                        break;
                    case "S":
                        direction = "W";
                        break;
                    case "W":
                        direction = "N";
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", direction));
                }
                return string.Format(x + " " + y + " " + direction);
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
                switch (direction)
                {
                    case "N":
                        direction = "W";
                        break;
                    case "E":
                        direction = "N";
                        break;
                    case "S":
                        direction = "E";
                        break;
                    case "W":
                        direction = "S";
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", direction));
                }
                return string.Format(x + " " + y + " " + direction);
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
                char[] instructions = movingInstructions.ToCharArray();
                for (int i = 0; i < instructions.Length; i++)// Loop through all the characters in the string 
                {
                    switch (instructions[i])
                    {
                        case 'L':// L =Left
                            ScrollLeft();
                            break;
                        case 'R':// R = Right
                            ScrollRight();
                            break;
                        case 'M':// Move forward
                            GoForward();
                            break;
                        default:
                            throw new ArgumentException(string.Format("Invalid value: {0}", direction));
                    }
                }
                // string res = GoForward(direction);
                return string.Format(x + " " + y + " " + direction);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }        
    }
}
