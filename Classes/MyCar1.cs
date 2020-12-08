using System;


namespace Classes
{
    public partial class MyCar
    {
        public void beep()
        {
            Console.WriteLine(" BEEP ");
            
            Console.Beep(2500, 100);
        }

        public void speedGraphicInfo()
        {
            for (int i = 0; i < speed; i++)
            {

                Console.Write("-");
            }
            // Console.Beep(50 * (speed+1) , 500);
            Console.Write("> "+speed);
        }
    }
}
