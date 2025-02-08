namespace BlazorFrontend.DTO;

public class DirectorDTO
{
        public long id{ get; set; }
        public List<long> moviesDirected { get; set; } = new();
        public String name{ get; set; }
        public int yearOfBirth{ get; set; }

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