using System;
namespace CatFactory
{
    class Cat
    {
        public string name;
        public double age;
        public double weight;
        public double strength;
        private int score = 0;

        public Cat(string name, double age, double weight, double strength)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.strength = strength;
        }

        public string Fight(Cat enemyCat)
        {
            if (weight > enemyCat.weight)
            {
                score++;
            }
            else
	        {       
                enemyCat.score++;
	        }
            if (this.age > enemyCat.age)
            {
                score++;
            }
            else
	        {       
                enemyCat.score++;
	        }
            if (this.strength > enemyCat.strength)
            {
                score++;
            }
            else
	        {       
                enemyCat.score++;
	        }

        
            Console.WriteLine("Cat: " + score);
            Console.WriteLine("Enemy cat: " + enemyCat.score);
            if (score < enemyCat.score)
            {
                return enemyCat.name;
            }
            else
            {
                return name;
            }
        }
      }
 }
