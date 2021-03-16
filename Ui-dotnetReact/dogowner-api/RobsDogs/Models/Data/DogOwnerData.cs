namespace RobsDogs.Models.Data
{
    public class DogOwnerData
    {
        public long Id { get; set; }
        public string OwnerName { get; set; }
        public string DogNames { get; set; }

        // public DogOwnerData(string ownerName, string dogNames)
        // {
        //     OwnerName = ownerName;
        //     DogNames = dogNames;
        // }
        //
        // public DogOwnerData(long id, string ownerName, string dogNames)
        // {
        //     Id = id;
        //     OwnerName = ownerName;
        //     DogNames = dogNames;
        // }
    }
}