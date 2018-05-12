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
                if (age > enemyCat.age)
                {
                    score++;
                    if (strength > enemyCat.strength)
                    {
                        score++;
                    }
                    else
                    {
                        enemyCat.score++;
                    }
                }
                else
                {
                    enemyCat.score++;
                }
            }
            if (weight < enemyCat.weight)
            {
                enemyCat.score++;
                if (age < enemyCat.age)
                {
                    enemyCat.score++;
                    if (strength < enemyCat.strength)
                    {
                        enemyCat.score++;
                    }
                    else
                    {
                        score++;
                    }
                }
                else
                {
                    score++;
                }
            }
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
