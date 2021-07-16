using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTrainingTests
{
    public class FlowControl
    {
        public bool isYourFavoriteColorBlue(string color)
        {
            if (color.ToLower() == "blue")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isYourFavoriteColorRed(string color)
        {
            if (color.ToLower() == "red") return true;
            return false;

        }

        public bool isYourFavoriteColorGreen(string color)
        {
            return (color.ToLower() == "green") ? true:false;
        }

        public bool isYourFavoriteColorYellow(string color)
        {
            return (color.ToLower() == "yellow");
        }
    }
}
