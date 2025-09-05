namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stat stat = new Stat();

            #region 가비지 컬렉터

            //프로그램이 실행되는 도중에 더 이상 사용되지 않는 메모리를 자동으로
            //탐색하여 해제하는 기능입니다.

            #endregion

            //stat.Wisdom = 5;
            //stat.Strength = 5;
            //stat.Dexterity = 10;
            //stat.Intelligence = 15;
            //
            //stat.Describe();

            #region 추상 클래스

            Item[] item = new Item[3];

            item[0] = new Knife();
            item[1] = new Potion();
            item[2] = new Charcoal();

            int count = 0;

            while (true)
            {
                ConsoleKeyInfo consolekeyInfo = Console.ReadKey(true);

                if (consolekeyInfo.Key == ConsoleKey.Spacebar)
                {
                    item[count].Activate();

                    count = (count + 1) % item.Length;

                }
            }

            #endregion
        }
    }
}
