using System;

namespace Delegates
{
    class Program
    {
        //Use a delegate when the caller doesnt need to access other properties or methods on the object implementing the method.
        static void Main(string[] args)
        {
            var sebil = new SuSebili();
            var sebilWork = new SebilWork();

            #region DelegateSebilWorkHandler
            //SuSebili.SebilWorkHandler handler = sebilWork.Sogut;
            //handler += sebilWork.Isıt;
            //handler += RemoveIlıkSu; 
            #endregion

            Action<Su> handler = sebilWork.Sogut;
            handler += sebilWork.Isıt;
            handler += RemoveIlıkSu;

            sebil.CalisSebil("NaturalSpringWater",handler);
        }

        static void RemoveIlıkSu(Su su)
        {
            Console.WriteLine("Ilıt removed");
        }
    }
}
