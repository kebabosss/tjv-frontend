namespace BlazorFrontend.DTO;

public class DirectorDTO
{
        public long id;
        public List<long> moviesDirected;
        public String name;
        public int yearOfBirth;

        public DirectorDTO()
        {
        }

        public DirectorDTO(long id, List<long> moviesDirected, string name, int yearOfBirth)
        {
                this.id = id;
                this.moviesDirected = moviesDirected;
                this.name = name;
                this.yearOfBirth = yearOfBirth;
        }
        
}