using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;

namespace BlueWombat.BusinessLogic.Xml
{
    public class EntityBuilder
    {
        //public void foo()
        //{
        //    var foo = new PhraseEntityExtensionRuntime();
        //    var bar = foo.TransformText();
        //    var baz = new CSharpCodeProvider();
        //    using (var memStream = new MemoryStream())
        //    {
        //        //Encoding.UTF8.GetBytes(bar).CopyTo(memStream.GetBuffer(), 0L);
        //        //using (var reader = new StreamReader(memStream))
        //        //{
        //        //    var compileUnit = baz.Parse(reader);
        //        //    var reults = baz.CompileAssemblyFromDom(new CompilerParameters()
        //        //    {
        //        //        GenerateInMemory = true,
        //        //        OutputAssembly = "BlueWombat.STU.BusinessLogice.Dynamic.dll"
        //        //    }, compileUnit);
        //        //    AppDomain.CurrentDomain.Load(reults.CompiledAssembly.GetName());
        //        //}

        //        var reader = new StringReader(bar);
        //        var compileUnit = baz.Parse(reader);
        //        var results = baz.CompileAssemblyFromDom(new CompilerParameters()
        //        {
        //            GenerateInMemory = true,
        //            OutputAssembly = "BlueWombat.STU.BusinessLogice.Dynamic.dll"
        //        }, compileUnit);
        //        AppDomain.CurrentDomain.Load(results.CompiledAssembly.GetName());
        //    }
        //}
        //public static void Compile(IEnumerable<string> propertyNames)
        //{
        //    var compileUnit = new CodeCompileUnit();
        //    var @namespace = new CodeNamespace("BlueWombat.BusinessLogic.Xml");
        //    compileUnit.Namespaces.Add(@namespace);
        //    var @class = new CodeTypeDeclaration("PhraseEntity");
        //    @class.IsClass = true;
        //    @class.IsPartial = true;
        //    foreach (var propertyName in propertyNames)
        //    {
        //        var snippetText = $"[Language(Name=\"{}\")]";
        //        var snippet = new CodeSnippetExpression();

        //        //@class.Members.Add(new CodeMemberProperty
        //        //{
        //        //    HasGet = true,
        //        //    HasSet = true,
        //        //    Type = new CodeTypeReference(typeof(string)),
        //        //    Name = $@"{propertyName.Replace("@", "")}",
        //        //    Attributes = MemberAttributes.Public | MemberAttributes.Final
        //        //});
        //    }

        //    @namespace.Types.Add(@class);
        //    var provider = new CSharpCodeProvider();
        //    var results = provider.CompileAssemblyFromDom(new CompilerParameters
        //    {
        //        GenerateInMemory = true,
        //        OutputAssembly = "BlueWombat.STU.BusinessLogic.Dynamic.dll"
        //    });
        //    AppDomain.CurrentDomain.Load(results.CompiledAssembly.GetName());
        //}
        public static void Compile()
        {
            var codeSnippetText = new PhraseEntityExtensionRuntime().TransformText();
            var codeSnippet = new CodeSnippetCompileUnit(codeSnippetText);
            var @namespace = new CodeNamespace("BlueWombat.BusinessLogic.Xml");
            @namespace.Imports.Add(new CodeNamespaceImport("System.Xml.Serialization"));
            @namespace.Imports.Add(new CodeNamespaceImport("BlueWombat.BusinessLogic.Xml"));
            codeSnippet.Namespaces.Add(@namespace);
            codeSnippet.ReferencedAssemblies.Add("System.Xml.dll");
            codeSnippet.ReferencedAssemblies.Add("BlueWombat.STU.BusinessLogic.dll");
            var provider = new CSharpCodeProvider();
            var results = provider.CompileAssemblyFromDom(new CompilerParameters
            {
                GenerateInMemory = true,
                OutputAssembly = "BlueWombat.STU.BusinessLogic.Dynamic.dll"
            }, codeSnippet);
            //AppDomain.CurrentDomain.Load(results.CompiledAssembly.GetName());
        }
    }
}
