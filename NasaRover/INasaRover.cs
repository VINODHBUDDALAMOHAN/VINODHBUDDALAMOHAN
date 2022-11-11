using System;
using System.Collections.Generic;
using System.Text;

namespace NasaRover
{
    public interface INasaRover
    {
        string GoForward(ref int x, ref int y, ref string direction);
        string ScrollRight(ref int x, ref int y, ref string direction);
        public string ScrollLeft(ref int x, ref int y, ref string direction);
        string Navigate(string movingInstructions, ref int x, ref int y, ref string direction);
    }
}
