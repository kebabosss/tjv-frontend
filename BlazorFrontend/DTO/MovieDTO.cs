namespace BlazorFrontend.DTO;

public class MovieDTO
{
    public long id { get; set; }
    public String name{ get; set; }
    public int releaseYear{ get; set; }

    public List<long> directors { get; set; } = new();
    public List<long> reviews { get; set; } = new();

    public MovieDTO()
    {
    }

    public MovieDTO(long id, string name, int releaseYear, List<long> directors, List<long> reviews)
    {
        this.id = id;
        this.name = name;
        this.releaseYear = releaseYear;
        this.directors = directors;
        this.reviews = reviews;
    }
}