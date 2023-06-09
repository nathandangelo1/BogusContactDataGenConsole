using Bogus;

namespace BogusContactDataGenConsole
{
    public class DataGenerator
    {
        System.ComponentModel.DateOnlyConverter DateOnlyConverter { get; set; }

        Faker<ContactModel> faker;

        public DataGenerator()
        {
            Randomizer.Seed = new Random(123);

            faker = new Faker<ContactModel>()
                .RuleFor(u => u.Id, f => f.Random.Int(1, 10000))
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.MiddleName, f => f.Name.FirstName().OrNull(f, .7f))
                .RuleFor(u => u.LastName, f => f.Name.LastName().OrNull(f, .1f))
                .RuleFor(u => u.NickName, f => f.Lorem.Word().OrNull(f, .8f))
                .RuleFor(u => u.Title, f => f.PickRandom<Title>().ToString().OrNull(f, .5f))
                .RuleFor(u => u.Birthday, f => f.Date.PastDateOnly().OrNull(f, .7f))
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName).OrNull(f, .5f))
                .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber().OrNull(f, .1f))
                .RuleFor(u => u.Street, f => f.Address.StreetAddress().OrNull(f, .4f))
                .RuleFor(u => u.City, f => f.Address.City().OrNull(f, .4f))
                .RuleFor(u => u.State, f => f.Address.State().OrNull(f, .4f))
                .RuleFor(u => u.ZipCode, f => f.Address.ZipCode().OrNull(f, .4f))
                .RuleFor(u => u.Country, f => f.Address.Country().OrNull(f, .8f))
                .RuleFor(u => u.Website, f => f.Internet.Url().OrNull(f, .50f))
                .RuleFor(u => u.Notes, f => f.Lorem.Sentence().OrNull(f, .85f))
                .RuleFor(u => u.Picture, f => f.Image.PicsumUrl().OrNull(f, .5f))
                .RuleFor(u => u.IsFavorite, f => 0)
                .RuleFor(u => u.IsActive, f => 1);
        }
        public ContactModel GenerateContact()
        {
            return faker.Generate();
        }

        public IEnumerable<ContactModel> GenerateContacts()
        {
            return faker.GenerateForever();
        }

        
    }
}
