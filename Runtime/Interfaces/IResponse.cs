namespace OpenAI
{
    public interface IResponse
    {
        ApiError Error { get; set; }
        public string Warning { get; set; }
    }

    public interface IResponseWithBinaryContent : IResponse
    {
        byte[] BinaryContent { get; set; }
    }
}
