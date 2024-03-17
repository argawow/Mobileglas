namespace Infrastructure
{
    public class ErrorList
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
    }
    
    public class ErrorResponse
    {
        public string Field { get; set; }
        public string Code { get; set; }
        public IDictionary<string, string> Parameters { get; set; }
        public List<ErrorList> List { get; set; } = null;

        public static ErrorResponse Create(string field, string code, Dictionary<string, string> parameters, List<ErrorList> list = null)
        {
            return new ErrorResponse
            {
                Field = field,
                Code = code,
                Parameters = parameters,
                List = list
            };
        }
    }
}