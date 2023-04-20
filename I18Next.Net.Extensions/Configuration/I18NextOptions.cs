using System.Collections.Generic;

namespace I18Next.Net.Extensions.Configuration;

public class I18NextOptions
{
    public string DefaultLanguage { get; set; } = "en-US";

    public string DefaultNamespace { get; set; } = "translation";

    public bool DetectLanguageOnEachTranslation { get; set; }

    public string DefaultFileFormat { get; set; } = ".json";

    public IList<string> FallbackLanguages { get; set; } = new List<string>();
}
