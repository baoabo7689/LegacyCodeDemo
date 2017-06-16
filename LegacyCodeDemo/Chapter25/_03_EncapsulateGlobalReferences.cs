using System;

namespace Chapter25.EncapsulateGlobalReferences_1
{
    public class AnnouncementService
    {
        DateTime minDate = new DateTime(1, 1, 2000);
        DateTime maxDate = new DateTime(1, 1, 2020);

        public void Announce(string message)
        {
            var currentDate = DateTime.Now;

            if (minDate <= currentDate && currentDate <= maxDate)
            {
                Console.WriteLine(message);
            }
        }
    }

    public class AnnouncementServiceTests
    {
        public void Announce_XXX_XXX()
        {
            // Arrange
            var announcementService = new AnnouncementService();
            //minDate = new DateTime(1, 1, 2000);
            //maxDate = new DateTime(1, 1, 2020);

            // Act
            announcementService.Announce("SomeMessage");

            // ...
        }
    }
}

namespace Chapter25.EncapsulateGlobalReferences_2_3
{
    public class AnnouncementTimeRange
    {
        public readonly DateTime MinDate = new DateTime(1, 1, 2000);

        public readonly DateTime MaxDate = new DateTime(1, 1, 2020);
    }

    public class AnnouncementService
    {
        DateTime minDate = new DateTime(1, 1, 2000);
        DateTime maxDate = new DateTime(1, 1, 2020);

        public void Announce(string message)
        {
            var currentDate = DateTime.Now;

            if (minDate <= currentDate && currentDate <= maxDate)
            {
                Console.WriteLine(message);
            }
        }
    }
}

//namespace Chapter25.EncapsulateGlobalReferences_4
//{
//    public static class AnnouncementTimeRange
//    {
//        public static readonly DateTime MinDate = new DateTime(1, 1, 2000);

//        public static readonly DateTime MaxDate = new DateTime(1, 1, 2020);
//    }

//    public class AnnouncementService
//    {
//        //DateTime minDate = new DateTime(1, 1, 2000);
//        //DateTime maxDate = new DateTime(1, 1, 2020);

//        public void Announce(string message)
//        {
//            var currentDate = DateTime.Now;

//            if (minDate <= currentDate && currentDate <= maxDate)
//            {
//                Console.WriteLine(message);
//            }
//        }
//    }
//}

//namespace Chapter25.EncapsulateGlobalReferences_5_6
//{
//    public class AnnouncementTimeRange
//    {
//        public readonly DateTime MinDate = new DateTime(1, 1, 2000);

//        public readonly DateTime MaxDate = new DateTime(1, 1, 2020);
//    }

//    public class AnnouncementService
//    {
//        AnnouncementTimeRange timeRange = new AnnouncementTimeRange();

//        public void Announce(string message)
//        {
//            var currentDate = DateTime.Now;

//            if (minDate <= currentDate && currentDate <= maxDate)
//            {
//                Console.WriteLine(message);
//            }
//        }
//    }
//}

namespace Chapter25.EncapsulateGlobalReferences_7
{
    public class AnnouncementTimeRange
    {
        public readonly DateTime MinDate = new DateTime(1, 1, 2000);

        public readonly DateTime MaxDate = new DateTime(1, 1, 2020);
    }

    public class AnnouncementService
    {
        AnnouncementTimeRange timeRange = new AnnouncementTimeRange();

        public void Announce(string message)
        {
            var currentDate = DateTime.Now;

            if (timeRange.MinDate <= currentDate && currentDate <= timeRange.MaxDate)
            {
                Console.WriteLine(message);
            }
        }
    }
}

