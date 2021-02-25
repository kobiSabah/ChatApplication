namespace ChatApplication.Core
{
    /// <summary>
    /// The API representation response 
    /// </summary>
    public class ApiResponse<T>
    {
        /// <summary>
        /// Error message if occur
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Indicate if the request succeeded
        /// </summary>
        public bool Succeeded => string.IsNullOrEmpty(ErrorMessage);

        /// <summary>
        /// The response data context
        /// </summary>
        public T Context { get; set; }
    }
}
