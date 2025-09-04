namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stat stat = new Stat();

            #region 가비지 컬렉터

            //프로그램이 실행되는 도중에 더 이상 사용되지 않는 메모리를 자동으로
            //탐색하여 해제하는 기능입니다.

            #endregion

            stat.Wisdom = 5;
            stat.Strength = 5;
            stat.Dexterity = 10;
            stat.Intelligence = 15;

            stat.Describe();
        }
    }
}
