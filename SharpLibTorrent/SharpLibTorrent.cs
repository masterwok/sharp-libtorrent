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
//            module.IncludeDirs.Add("C:\Sample\include");
//            module.Headers.Add("Sample.h");
//            module.LibraryDirs.Add("C:\Sample\lib");
//            module.Libraries.Add("Sample.lib");
        }

        public void SetupPasses(Driver driver)
        {
        }
        
        public static void GenerateBindings() => ConsoleDriver.Run(new SharpLibTorrent());
    }
}