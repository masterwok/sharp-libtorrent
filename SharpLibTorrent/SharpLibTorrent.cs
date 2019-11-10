using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace SharpLibTorrent
{
    public class SharpLibTorrent : ILibrary
    {
        public void Preprocess(Driver driver, ASTContext ctx)
        {
        }

        public void Postprocess(Driver driver, ASTContext ctx)
        {
        }

        public void Setup(Driver driver)
        {
            var options = driver.Options;

            options.GeneratorKind = GeneratorKind.CSharp;

            var module = options.AddModule("SharpLibTorrent");

            const string pathRootInclude = "~/Lib/libtorrent";

            module.IncludeDirs.Add($"{pathRootInclude}");
            module.IncludeDirs.Add($"{pathRootInclude}/extensions");
            module.IncludeDirs.Add($"{pathRootInclude}/kademlia");
        }

        public void SetupPasses(Driver driver)
        {
        }

        public static void GenerateBindings() => ConsoleDriver.Run(new SharpLibTorrent());
    }
}