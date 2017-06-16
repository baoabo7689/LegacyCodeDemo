using System;

namespace Chapter25.ReplaceGlobalReferenceWithGetter_1
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
}

namespace Chapter25.ReplaceGlobalReferenceWithGetter_2
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

        protected virtual DateTime GetMinDate() => minDate;

        protected virtual DateTime GetMaxDate() => maxDate;
    }
}

namespace Chapter25.ReplaceGlobalReferenceWithGetter_3
{
    public class AnnouncementService
    {
        DateTime minDate = new DateTime(1, 1, 2000);
        DateTime maxDate = new DateTime(1, 1, 2020);

        public void Announce(string message)
        {
            var currentDate = DateTime.Now;

            if (GetMinDate() <= currentDate && GetMaxDate() <= maxDate)
            {
                Console.WriteLine(message);
            }
        }

        protected virtual DateTime GetMinDate() => minDate;

        protected virtual DateTime GetMaxDate() => maxDate;
    }
}

namespace Chapter25.ReplaceGlobalReferenceWithGetter_4
{
    public class AnnouncementService
    {
        DateTime minDate = new DateTime(1, 1, 2000);
        DateTime maxDate = new DateTime(1, 1, 2020);

        public void Announce(string message)
        {
            var currentDate = DateTime.Now;

            if (GetMinDate() <= currentDate && GetMaxDate() <= maxDate)
            {
                Console.WriteLine(message);
            }
        }

        protected virtual DateTime GetMinDate() => minDate;

        protected virtual DateTime GetMaxDate() => maxDate;
    }

    public class AnnouncementServiceMock : AnnouncementService
    {
        protected override DateTime GetMinDate() => new DateTime(1, 1, 2000);

        protected override DateTime GetMaxDate() => new DateTime(1, 1, 2020);
    }

    public class AnnouncementServiceTests
    {
        public void Announce_XXX_XXX()
        {
            // Arrange
            var announcementService = new AnnouncementServiceMock();

            // Act
            announcementService.Announce("SomeMessage");

            // ...
        }
    }
}
