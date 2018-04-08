using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostNumerousPenguin 
{
	class Program 
    {
		static void Main(string[] args) 
        {
			string mostNumerous1 = GetMostNumerous(new string[] { "Emperor Penguin", "Macaroni Penguin", "Emperor Penguin", "Little Penguin" });
			string mostNumerous2 = GetMostNumerous(new string[] { "Emperor Penguin", "Macaroni Penguin", "Little Penguin", "Emperor Penguin", "Macaroni Penguin", "Macaroni Penguin", "Little Penguin" });
			Console.WriteLine(mostNumerous1);
			Console.WriteLine(mostNumerous2);

			Console.ReadLine();
		}

		static string GetMostNumerous(string[] penguins) 
        {
            int amountOfEP = 0;
            int amountOfMP = 0;
            int amountOfLP = 0;
            for (int i = 0; i < penguins.Length; i++ )
            {
                if (penguins[i] == "Emperor Penguin")
                {
                    amountOfEP++;
                }
                if (penguins[i] == "Macaroni Penguin")
                {
                    amountOfMP++;
                }
                if (penguins[i] == "Little Penguin")
                {
                    amountOfLP++;
                }
            }
            if(amountOfEP > amountOfLP && amountOfEP > amountOfMP)
            {
			    return "Emperor Penguin";
            }
            if (amountOfMP > amountOfLP && amountOfMP > amountOfEP)
            {
                return "Macaroni Penguin";
            }
            if (amountOfLP > amountOfMP && amountOfLP > amountOfEP)
            {
                return "Little Penguin";
            }
            return "";
		}
	}
}
