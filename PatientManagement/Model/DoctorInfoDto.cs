namespace PatientManagement.Model
{
    public class DoctorInfoDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Mobile { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string Gender { get; set; }
        public string RegistrationNo { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
