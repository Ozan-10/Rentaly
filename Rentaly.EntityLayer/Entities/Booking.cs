namespace Rentaly.EntityLayer.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }

        public DateTime PickUpDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int CarId { get; set; }

        public bool IsApproved { get; set; }
        public string PickUpLocation { get; set; }
        public string DropOffLocation { get; set; }

        public string CarName { get; set; }
        public decimal TotalPrice { get; set; }
    }
}