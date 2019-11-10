using System;
using System.IO;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace SharpLibTorrent
{
    public class SharpLibTorrent : ILibrary
    {
        private static readonly string PathProjectRoot = Path.GetFullPath(Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory
            , @"../../"
        ));

        private static readonly string PathLibTorrentRoot = Path.Combine(PathProjectRoot, "Lib/libtorrent/");
        private static readonly string PathLibTorrentInclude = Path.Combine(PathLibTorrentRoot, "include/libtorrent");


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
            options.OutputDir = Path.Combine(Environment.CurrentDirectory, "output");
            options.Verbose = true;
            options.UseHeaderDirectories = true;

            var module = options.AddModule("SharpLibTorrent");

            module.LibraryName = "SharpLibTorrent";
            module.OutputNamespace = "SharpLibTorrent";

            module.IncludeDirs.Add(PathLibTorrentInclude);


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