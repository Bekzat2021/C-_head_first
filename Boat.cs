using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    class Boat
    {
        private int length;
        public void SetLength(int len)
        {
            length = len;
        }

        public int GetLength()
        {
            return length;
        }

        public virtual string Move()
        {
            return " drift ";
        }
    }

    class RowBoat:Boat
    {
        public string rowTheBoat()
        {
            return " stroke natasha ";
        }
    }

    class SailBoat:Boat
    {
        public override string Move()
        {
            return " hoist sail "; 
        }
    }

    class TestBoats
    {
        public static void Main()
        {
            string xyz = "";
            Boat b1 = new Boat();
            SailBoat b2 = new SailBoat();
            RowBoat b3 = new RowBoat();
            b2.SetLength(32);
            xyz += b1.Move();
            xyz += b3.Move();
            xyz += b2.Move();
            System.Windows.Forms.MessageBox.Show(xyz);
        }
    }
}
