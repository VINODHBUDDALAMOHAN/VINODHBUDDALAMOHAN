using System;
using System.Collections.Generic;
using System.Text;

namespace NasaRover
{
    public class RoverMovementBao : INasaRover
    {
        public string GoForward(ref int x, ref int y, ref string direction)
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
        public string ScrollRight(ref int x, ref int y, ref string direction)
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
        public string ScrollLeft(ref int x, ref int y, ref string direction)
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
        public string Navigate(string movingInstructions, ref int x, ref int y, ref string direction)
        {
            try
            {
                char[] instructions = movingInstructions.ToCharArray();
                string res = null;
                for (int i = 0; i < instructions.Length; i++)// Loop through all the characters in the string 
                {
                    switch (instructions[i])
                    {
                        case 'L':// L =Left
                           res = ScrollLeft(ref x, ref y, ref direction);
                            break;
                        case 'R':// R = Right
                            res =ScrollRight(ref x, ref y, ref direction);
                            break;
                        case 'M':// Move forward
                           res= GoForward(ref x, ref y, ref direction);
                            break;
                        default:
                            throw new ArgumentException(string.Format("Invalid value: {0}", direction));
                    }
                }
                return string.Format(x + " " + y + " " + direction);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
