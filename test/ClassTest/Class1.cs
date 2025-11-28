namespace ClassTest
{
    public class Class1
    {
        public void PublicMethod()
        {
            PrivateMethod();
            ProtectedMethod();
            Console.WriteLine("Public method main");
            Class2 class2 = new Class2();   
            class2.PublicMethod();
            //comment added
        }
        private void PrivateMethod()
        {
            string privatev = "private";
            Console.WriteLine("Private method");
        }
        protected void ProtectedMethod()
        {
        string protectedv = "protected";
            Console.WriteLine("Protected method");
        }
    }

    class Class2 {
        public void PublicMethod()
        {
            PrivateMethod();
            ProtectedMethod();
            Console.WriteLine("Public method");
        }
        private void PrivateMethod()
        {
            string privatev = "private";
            Console.WriteLine("Private method");
        }
        protected void ProtectedMethod()
        {
            string protectedv = "protected";
            Console.WriteLine("Protected method");
        }
    }

}
