namespace AbstractFactoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Department thehomedepot;

            

            thehomedepot = new LaptopGamer();
            Laptop laptop = thehomedepot.Comprar();
            
            Console.WriteLine(laptop.Description);

            //Oficina
            thehomedepot = new LaptopOficina();
            laptop = thehomedepot.Comprar();
            Console.WriteLine(laptop.Description);

            Department thehomedepot1;
            thehomedepot1 = new Android();
            Celular cel = thehomedepot1.Garantia();
            Console.WriteLine(cel.Description);

        }
    }
}
