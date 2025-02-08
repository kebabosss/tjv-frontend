namespace BlazorFrontend.DTO;

public class ReviewDTO
{
    public long reviewId{ get; set; }
    public String reviewText{ get; set; }
    public int rating{ get; set; }
    public long movieId{ get; set; }

    public ReviewDTO()
    {
    }

    public ReviewDTO(long reviewId, string reviewText, int rating, long movieId)
    {
        this.reviewId = reviewId;
        this.reviewText = reviewText;
        this.rating = rating;
        this.movieId = movieId;
    }
}