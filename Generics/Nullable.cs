namespace Generics
{
    //Ne olursan ol önce value type ol
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
            
        }
        public Nullable(T value)
        {
            _value = value;
        }

        //Value boş olmadığında döncem ben sana
        public bool HasValue
        {
            get
            {
                return _value != null;
            }
        }

        public T GetValueorDefault()
        {
            if (HasValue)
                return (T) _value;

            return default(T);
        }
    }
}