﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OwinUrlRewriter.Tests.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OwinUrlRewriter.Tests.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Rewrite&gt;
        /// &lt;rules&gt;
        ///                &lt;rule name=&quot;Rule1&quot; stopProcessing=&quot;true&quot;&gt;
        ///                    &lt;match url=&quot;capture&quot; ignoreCase=&quot;false&quot; /&gt;
        ///                    &lt;action type=&quot;Rewrite&quot; url=&quot;rewriteUrl&quot; /&gt;
        ///                &lt;/rule&gt;
        ///            &lt;/rules&gt;
        ///&lt;/Rewrite&gt;.
        /// </summary>
        internal static string RuleRewriteSimple_IgnoreCase {
            get {
                return ResourceManager.GetString("RuleRewriteSimple_IgnoreCase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Rewrite&gt;
        ///	&lt;rules&gt;
        ///		&lt;rule name=&quot;Rule1&quot;&gt;
        ///			&lt;match url=&quot;capture&quot; /&gt;
        ///			&lt;action type=&quot;Rewrite&quot; url=&quot;rewriteUrl&quot; /&gt;
        ///        &lt;/rule&gt;
        ///    &lt;/rules&gt;
        ///&lt;/Rewrite&gt;
        ///
        ///.
        /// </summary>
        internal static string RuleRewriteSimple01 {
            get {
                return ResourceManager.GetString("RuleRewriteSimple01", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to   &lt;Rewrite&gt;
        ///            &lt;rules&gt;
        ///                &lt;rule name=&quot;Rule1&quot; stopProcessing=&quot;true&quot;&gt;
        ///                    &lt;match url=&quot;capture&quot; ignoreCase=&quot;false&quot; /&gt;
        ///                    &lt;action type=&quot;Rewrite&quot; url=&quot;rewriteUrl&quot; appendQueryString=&quot;false&quot; /&gt;
        ///                &lt;/rule&gt;
        ///            &lt;/rules&gt;
        ///        &lt;/Rewrite&gt;.
        /// </summary>
        internal static string RuleRewriteSimple03 {
            get {
                return ResourceManager.GetString("RuleRewriteSimple03", resourceCulture);
            }
        }
    }
}
