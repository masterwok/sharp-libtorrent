using CppSharp;
using CppSharp.AST;

namespace SharpLibTorrent
{
    public class SharpLibTorrent : ILibrary
    {
        public void Preprocess(Driver driver, ASTContext ctx)
        {
            throw new System.NotImplementedException();
        }

        public void Postprocess(Driver driver, ASTContext ctx)
        {
            throw new System.NotImplementedException();
        }

        public void Setup(Driver driver)
        {
            throw new System.NotImplementedException();
        }

        public void SetupPasses(Driver driver)
        {
            throw new System.NotImplementedException();
        }

        public static void GenerateBindings() => ConsoleDriver.Run(new SharpLibTorrent());
    }
}