using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using ICSharpCode.TextEditor.Document;


namespace RedisViewer.Services
{
    public class AppSyntaxModeProvider : ISyntaxModeFileProvider
    {
        public ICollection<SyntaxMode> SyntaxModes { get; }

        public AppSyntaxModeProvider()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourcePath = $"{assembly.GetName().Name}.Resources.SyntaxModes.xml";
            var syntaxModeStream = assembly.GetManifestResourceStream(resourcePath);
            SyntaxModes = syntaxModeStream == null ? new List<SyntaxMode>() : SyntaxMode.GetSyntaxModes(syntaxModeStream);
        }

        public XmlTextReader GetSyntaxModeFile(SyntaxMode syntaxMode)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourcePath = $"{assembly.GetName().Name}.Resources.{syntaxMode.FileName}";
            var stream = assembly.GetManifestResourceStream(resourcePath);
            return stream == null ? null : new XmlTextReader(stream);
        }

        public void UpdateSyntaxModeList()
        {
            // Our resources don't change during runtime
        }
    }
}