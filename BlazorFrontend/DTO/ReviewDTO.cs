namespace BlazorFrontend.DTO;

public class ReviewDTO
{
    long reviewId;
    String reviewText;
    int rating;
    long movieId;

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