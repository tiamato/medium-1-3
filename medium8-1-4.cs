using System;

namespace Player
{
    public class Player
    {
        public string Name { get; }
        public int Age { get; }
        public MovementParametersHolder MovementParameters { get; set; }

        public Player(string name, int age)
        {
            Name = name;
            Age = age;
            MovementParameters = new MovementParametersHolder(new Vector2(0, 0), 0);
        }

        public void Move()
        {
            //Do move: new position = F(position, movement parameters);
            throw new NotImplementedException();
        }

        public void Attack()
        {
            //attack: Weapon[x].Fire();...
            throw new NotImplementedException();
        }
    }

    public class MovementParametersHolder
    {
        public Vector2 Direction { get; }
        public float Speed { get; }

        public MovementParametersHolder(Vector2 direction, float speed)
        {
            Direction = direction;
            Speed = speed;
        }
    }


    public class Vector2
    {
        public float X { get; }
        public float Y { get; }

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }
    }

    public class Weapon
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
