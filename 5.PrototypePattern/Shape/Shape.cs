using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.PrototypePattern
{
    public abstract class Shape:ICloneable
    {
        string id;
        string type;
        public abstract void Draw();

        public string GetID()
        {
            return id;
        }
        public string GetType()
        {
            return type;
        }
        public void SetID(string id)
        {
            this.id = id;
        }

        public object Clone()
        {
            object clone = null;
            try
            {
                clone = MemberwiseClone();//.net 的浅拷贝
            }
            catch (System.NotSupportedException e)
            {
                Console.WriteLine(e.StackTrace); 
            }
            return clone;
        }
    }
}
