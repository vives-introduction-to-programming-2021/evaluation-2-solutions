using System;
using System.Collections.Generic;
using System.Text;

namespace KingsOfNothing
{
    public class Player
    {
        public void Move(int deltaX, int deltaY)
        {
            // TODO - Pas de speler zijn huidige locatie aan met de
            // de waarden deltaX en deltaY.
            this.locationX = this.locationX + deltaX;
            this.locationY = this.locationY + deltaY;
        }

        public void Damage(int damage)
        {
            // TODO - Verlaag het leven `health` van de gebruiker met de
            // hoeveelheid in `damage`. Zorg er wel voor dat `health` niet
            // kleiner dan 0 gaat.

            if (health - damage > 0)
            {
                health = health - damage;
            }
            else
            {
                health = 0;
            }

            // Or very short
            //health = Math.Max(health - damage, 0);


        }

        public bool IsAlive()
        {
            // TODO - Geef aan of de speler nog in leven is. Dit is het geval
            // indien de `health` groter is dan 0.

            //if (health > 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //SAME

            return health > 0;
        }

        public void Heal(int amount)
        {
            // TODO - Verhoog de speler zijn leven indien deze niet dood is.
            // Zorg er wel voor dat de health niet hoger dan 100 kan gaan.

            if (IsAlive())
            {
                health = health + amount;
                if (health > 100)
                {
                    health = 100;
                }
            }
        }
        
        // Attributes
        private int locationX = 0;
        private int locationY = 0;
        private int health = 100;

        // Getters / Setters (mag je negeren)
        public int GetX() { return locationX; }
        public void SetX(int x) { this.locationX = x; }
        public int GetY() { return locationY; }
        public void SetY(int y) { this.locationY = y; }
        public int GetHealth() { return health; }
        public void SetHealth(int health) { this.health = health; }
    }
}
