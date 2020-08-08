using System;

namespace Player
{
    class Player
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Vector2 MovementDirection { get; private set; }
        public float MovementSpeed { get; private set; }

        public void Move()
        {
            //Do move: F(MovementDirection, MovementSpeed)
        }

        public void Attack()
        {
            //attack: Weapon.Fire();...
        }

    }

    internal class Vector2
    {
        public float X { get; private set; }
        public float Y { get; private set; }
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
            throw new NotImplementedException();
        }

        public void Fire()
        {
            throw new NotImplementedException();
        }
    }
}