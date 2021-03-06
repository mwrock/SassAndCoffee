﻿namespace SassAndCoffee.Core {
    using SassAndCoffee.Core.Pooling;

    public class JavaScriptCompilerProxy : ProxyBase<IJavaScriptCompiler>, IJavaScriptCompiler {

        public JavaScriptCompilerProxy() { }

        public JavaScriptCompilerProxy(IJavaScriptCompiler compiler)
            : base(compiler) { }

        public string Compile(string source) {
            return WrappedItem.Compile(source);
        }
    }
}

