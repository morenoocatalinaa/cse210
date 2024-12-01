public class Address
{
    private string street;
    private string city;
    private string country;

    public Address(string street, string city, string country)
    {
        this.street = street;
        this.city = city;
        this.country = country;
    }

    public string Street => street;
    public string City => city;
    public string Country => country;

    public override string ToString() => $"{street}, {city}, {country}";
}