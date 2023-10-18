namespace Zon_Coffee.Database.Models.Repositories
{
    public class HolidayRepository
    {
        private readonly List<Holiday> _holidays = new List<Holiday>();
        
        public HolidayRepository()
        {
            _holidays.Add(new Holiday(1, "2", "3"));
        }

        public List<Holiday> GetAll()
        {
            return _holidays;
        }
    }
}
