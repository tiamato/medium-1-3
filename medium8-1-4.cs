using System;

namespace Player
{
    class Player
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Vector2 MovementDirection { get; private set; }
        public float MovementSpeed { get; private set; }

        public Player(string name, int age)
        {
            Name = name;
            Age = age;
            MovementDirection = new Vector2(0, 0);
            MovementSpeed = 0;
        }

        public void Move()
        {
            //Do move: F(MovementDirection, MovementSpeed);
            throw new NotImplementedException();
        }

        public void Attack()
        {
            //attack: Weapon[x].Fire();...
            throw new NotImplementedException();
        }
    }

    internal class Vector2
    {
        public float X { get; }
        public float Y { get; }
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }
    }

    internal class Weapon
    {
        public float Cooldown { get; }
        public int Damage { get; }

        public Weapon(float cooldown, int damage)
        {
            Cooldown = cooldown;
            Damage = damage;
        }

        public bool IsReloading()
        {
            // Currently is in reloading process
            throw new NotImplementedException();
        }

        public void Fire()
        {
            // Fire: F(Damage, ...)
            throw new NotImplementedException();
        }
    }
}