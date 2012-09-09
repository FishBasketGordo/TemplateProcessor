namespace TemplateProcessor.Client.Interfaces
{
    public interface ITemplateProcessor
    {
        string TemplateDirectory { get; set; }

        string OutputDirectory { get; set; }
    }
}