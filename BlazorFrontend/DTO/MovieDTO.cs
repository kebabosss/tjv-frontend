namespace BlazorFrontend.DTO;

public class MovieDTO
{
    public long id;
    public String name;
    public int releaseYear;

    public List<long> directors;
    public List<long> reviews;

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