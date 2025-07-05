namespace AssignmentC_05
{
    #region Enum Q1
    enum WeekDays
    {
        //Monday,
        //Tuesday, 
        //Wednesday,
        //Thursday,
        //Friday,
        //Saturday,
        //Sunday
    }
    #endregion

    #region Enum Q2
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Days Of Week : ");
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Q2
            //Console.WriteLine("Enter Your Season (Spring , Summer , Autumn , Winter) : ");
            //String Input = Console.ReadLine();
            //if (Enum.TryParse(typeof(Season), Input , true  , out object result))
            //{
            //    Season season = (Season)result;
            //
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring : March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer : June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autmn : September to Novamber");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter : December to February");
            //            break;
            //
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered. Please enter Spring, Summer, Autumn, or Winter.");
            //}
            #endregion
        }
    }
}
