namespace SignalRApiForSql.DAL
{
    public enum ECity
    {
        Berlin = 1,
        İstanbul = 2,
        Ankara = 3,
        London = 4,
        İzmir = 5
    }

    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}