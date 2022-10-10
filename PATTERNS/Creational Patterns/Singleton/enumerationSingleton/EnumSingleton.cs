namespace enumerationSingleton
{
    public class EnumSingleton
    {
        private int count = 0;
        private EnumSingleton()
        {

        }

        public enum enumSingleton
        {
            SINGLETON
        }

        public static enumSingleton Instance
        {
            get {return enumSingleton.SINGLETON;}
        }

        public void PrintName()
        {
            count ++;
            Console.WriteLine(enumSingleton.SINGLETON.ToString());
        }

        
        
    }
}