using System;

namespace MyFirstGame
{
    class Player
    {
        string name;
        int healthPoint;

        public Player (string _name)
        {
            Random rnd = new Random();
            name = _name;
            healthPoint = rnd.Next(100,151) ;
        }

        public string Name
        {
            get { return name; }
        }

        public int HealthPoint
        {
            get { return healthPoint; }
        }

        public int MakeDamage()
        {
            Random rnd = new Random();
            return rnd.Next(10, 51); //lihtsalt returnib numbri  
        }
        public  void TakeDamage(int damage) //ei returni numbri vaid arvutiba healtpointidest maha
        {
            if (healthPoint <= 0) //kontroll, et healthpoint ei saa väiksem kui 0 olla.
            {
                healthPoint = 0;
            }
            else
            {
                healthPoint -= damage;
            }
        }

    }
}
