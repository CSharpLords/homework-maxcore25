using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digger
{
    class Player : ICreature
    {
        public string GetImageFileName()
        {
            return "Digger.png";
        }

        public int GetDrawingPriority()
        {
            return 1;
        }

        public CreatureCommand Act(int x, int y)
        {
            CreatureCommand movement = new CreatureCommand();

            if (Game.KeyPressed == Keys.W || Game.KeyPressed == Keys.Up)
            {
                movement.DeltaY = -1;
            }

            if (Game.KeyPressed == Keys.S || Game.KeyPressed == Keys.Down)
            {
                movement.DeltaY = 1;
            }

            if (Game.KeyPressed == Keys.A || Game.KeyPressed == Keys.Left)
            {
                movement.DeltaX = -1;
            }

            if (Game.KeyPressed == Keys.D || Game.KeyPressed == Keys.Right)
            {
                movement.DeltaX = 1;
            }

            CheckBorders(x, y, movement);
            ICreature creatureX = Game.Map[x + movement.DeltaX, y];
            if (creatureX is Sack)
            {
                movement.DeltaX = 0;
            }

            ICreature creatureY = Game.Map[x, y + movement.DeltaY];
            if (creatureY is Sack)
            {
                movement.DeltaY = 0;
            }

            return movement;
        }

        public void CheckBorders(int x, int y, CreatureCommand movement)
        {
            if (x + movement.DeltaX >= Game.MapWidth || x + movement.DeltaX <= -1)
            {
                movement.DeltaX = 0;
            }

            if (y + movement.DeltaY >= Game.MapHeight || y + movement.DeltaY <= -1)
            {
                movement.DeltaY = 0;
            }
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            if (conflictedObject is Sack || conflictedObject is Monster)
            {
                return true;
            }

            return false;
        }
    }

    class Terrain : ICreature
    {
        public string GetImageFileName()
        {
            return "Terrain.png";
        }

        public int GetDrawingPriority()
        {
            return 1;
        }

        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand();
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            if (conflictedObject is Player)
            {
                return true;
            }

            return false;
        }
    }

    class Sack : ICreature
    {
        private bool isFalling = false;
        private int distance = 0;

        public string GetImageFileName()
        {
            return "Sack.png";
        }

        public int GetDrawingPriority()
        {
            return 1;
        }

        public CreatureCommand Act(int x, int y)
        {
            CreatureCommand command = new CreatureCommand();
            if (Game.MapHeight - 1 != y && Game.Map[x, y + 1] == null)
            {
                isFalling = true;
                command.DeltaY = 1;
                distance++;
            }
            else if (distance > 1 && (Game.MapHeight - 1 == y || !(Game.Map[x, y + 1] is Player)))
            {
                command.TransformTo = new Gold();
            }

            if (Game.MapHeight - 1 != y && isFalling == true && Game.Map[x, y + 1] is Player) //
            {
                command.DeltaY = 1;
                distance++;
            }

            if (distance == 1 && (Game.MapHeight - 1 == y || !(Game.Map[x, y + 1] is null) && !(Game.Map[x, y + 1] is Player)))
            {
                distance = 0;
            }

            return command;
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return false;
        }
    }

    class Gold : ICreature
    {
        public string GetImageFileName()
        {
            return "Gold.png";
        }

        public int GetDrawingPriority()
        {
            return 1;
        }

        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand();
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            if (conflictedObject is Player)
            {
                Game.Scores += 10;
                return true;
            }
            else if (conflictedObject is Monster)
            {
                return true;
            }

            return false;
        }
    }

    class Monster : ICreature
    {
        public string GetImageFileName()
        {
            return "Monster.png";
        }

        public int GetDrawingPriority()
        {
            return 1;
        }

        public CreatureCommand Act(int x, int y)
        {
            CreatureCommand movement = new CreatureCommand();
            Point? playerPoint = FindPlayer();
            if (playerPoint != null)
            {
                int distanceX = playerPoint.Value.X - x;
                int distanceY = playerPoint.Value.Y - y;
                
                if (x == playerPoint.Value.X)
                {
                    if (distanceY > 0)
                    {
                        movement.DeltaY = 1;
                    }
                    else
                    {
                        movement.DeltaY = -1;
                    }
                }
                else
                {
                    if (distanceX > 0)
                    {
                        movement.DeltaX = 1;
                    }
                    else
                    {
                        movement.DeltaX = -1;
                    }
                }

                ICreature creatureX = Game.Map[x + movement.DeltaX, y];
                ICreature creatureY = Game.Map[x, y + movement.DeltaY];
                if (creatureX is Sack || creatureX is Terrain || creatureX is Monster)
                {
                    movement.DeltaX = 0;
                }

                if (creatureY is Sack || creatureY is Terrain || creatureY is Monster)
                {
                    movement.DeltaY = 0;
                }
            }

            return movement;
        }

        private Point? FindPlayer() //nullable
        {
            for (int x = 0; x < Game.MapWidth; x++)
            {
                for (int y = 0; y < Game.MapHeight; y++)
                {
                    if (Game.Map[x, y] is Player)
                    {
                        return new Point(x, y);
                    }
                }
            }

            return null;
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            if (conflictedObject is Gold || conflictedObject is Player)
            {
                return false;
            }

            return true;
        }
    }
}