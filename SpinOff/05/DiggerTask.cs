using System;
using System.Collections.Generic;
using System.Linq;
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
            return movement;
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
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

}
