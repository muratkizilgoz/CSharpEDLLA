using System;

namespace Delegates
{
    public class SuSebili
    {
        
        //Action<> => void
        //Func<> => TResult

        #region DelegateSebilWorkHandler
        //public delegate void SebilWorkHandler(Su su);
        //public void CalisSebil(string hangiMarka, SebilWorkHandler sebilWorkHandler)
        //{
        //    var su = Su.Al(hangiMarka);

        //    if(hangiMarka=="belediye"||hangiMarka=="musluk"||hangiMarka=="markasız")
        //        throw new Exception("Arsenik var diyorlar");

        //    sebilWorkHandler(su);

        //} 
        #endregion

        public void CalisSebil(string hangiMarka, Action<Su> handler)
        {
            var su = Su.Al(hangiMarka);

            if(hangiMarka=="belediye"||hangiMarka=="musluk"||hangiMarka=="markasız")
                throw new Exception("Arsenik var diyorlar");

            handler(su);

        }
    }
}
