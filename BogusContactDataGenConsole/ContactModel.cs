using System.Data.SqlTypes;
using System.Text.Encodings.Web;

namespace BogusContactDataGenConsole
{
    public record ContactModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? NickName { get; set; }
        public string? Title { get; set; }
        public DateOnly? Birthday { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public string? Website { get; set; }
        public string? Notes { get; set; }
        public string? Picture { get; set; }

        public int IsFavorite { get; set; }
        public int IsActive { get; set; }

    }
}
